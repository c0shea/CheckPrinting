using System;
using System.Drawing;
using System.Windows.Forms;

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
            SetStatus("Ready.");
            lblStatus.BackColor = Color.AliceBlue;
        }

        private void SetErrorStatus(string errorMessage)
        {
            SetStatus(errorMessage);
            lblStatus.BackColor = Color.LightPink;
        }

        private void SetStatus(string message)
        {
            lblStatus.Text = message;
            lblStatus.Refresh();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ResetStatus();

            if (!ValidatePrint())
            {
                return;
            }

            SetStatus("Connecting to printer...");
            using (var printer = new Printer(txtLogicalName.Text))
            {
                SetStatus("Please insert check into printer.");
                printer.InsertCheck();
                SetStatus("Printing...");
                printer.PrintCheck(datePicker.Value, txtPayToTheOrderOf.Text, 123m, txtMemo.Text);
                SetStatus("Please remove check from printer.");
                printer.RemoveCheck();
            }

            ResetStatus();
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
