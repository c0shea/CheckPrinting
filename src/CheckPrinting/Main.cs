using System;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using Microsoft.PointOfService;

namespace CheckPrinting
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            Application.ThreadException += (sender, args) =>
            {
                SetErrorStatus(args.Exception.Message);
            };
            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                SetErrorStatus((args.ExceptionObject as Exception).Message);
            };
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Checks are typically void after 90 days, but we'll allow a bit more leeway
            datePicker.MinDate = DateTime.Now.AddYears(-1);
            datePicker.Value = DateTime.Now;

            ResetStatus();
        }

        private void ResetStatus()
        {
            lblStatus.Text = "Ready.";
            lblStatus.BackColor = Color.AliceBlue;
        }

        private void SetErrorStatus(string errorMessage)
        {
            lblStatus.Text = errorMessage;
            lblStatus.BackColor = Color.LightPink;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ResetStatus();

            if (!ValidatePrint())
            {
                return;
            }
            
            PosPrinter printer;
            try
            {
                printer = GetPrinter(txtLogicalName.Text);
            }
            catch (Exception ex)
            {
                SetErrorStatus(ex.Message);
                return;
            }
            
            printer.BeginInsertion(1 * 60 * 1000); // 1 minute
            printer.EndInsertion();
            
            ClosePrinter(printer);
        }

        private void ClosePrinter(PosPrinter printer)
        {
            printer.DeviceEnabled = false;
            printer.Close();
        }

        private PosPrinter GetPrinter(string logicalName)
        {
            PosExplorer posExplorer;
            DeviceInfo deviceInfo;
            PosPrinter posPrinter;

            try
            {
                posExplorer = new PosExplorer();
                deviceInfo = posExplorer.GetDevice(DeviceType.PosPrinter, "132");
            }
            catch (Exception)
            {
                throw new Exception("Unable to retrieve device information.");
            }

            try
            {
                posPrinter = posExplorer.CreateInstance(deviceInfo) as PosPrinter;
            }
            catch (Exception)
            {
                throw new Exception("Unable to create the device instance.");
            }

            try
            {
                posPrinter.Open();
            }
            catch (Exception)
            {
                throw new Exception("Unable to open the device.");
            }

            try
            {
                posPrinter.Claim(750);
            }
            catch (Exception)
            {
                throw new Exception("Unable to claim the device.");
            }

            try
            {
                posPrinter.DeviceEnabled = true;
            }
            catch (Exception)
            {
                throw new Exception("Unable to enable the device.");
            }

            return posPrinter;
        }

        private bool ValidatePrint()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(txtLogicalName.Text))
            {
                errorProvider.SetError(txtLogicalName, "A logical name must be specified in order to print the check.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPayToTheOrderOf.Text))
            {
                errorProvider.SetError(txtPayToTheOrderOf, "A payee must be specified.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                errorProvider.SetError(txtAmount, "An amount must be specified.");
                isValid = false;
            }

            if (!isValid)
            {
                SetErrorStatus("There are form errors that must be resolved before the check can be printed.");
            }

            return isValid;
        }
    }
}
