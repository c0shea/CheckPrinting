using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CheckPrinting
{
    public partial class Main : Form
    {
        private decimal _amount;

        public Main()
        {
            InitializeComponent();

            Application.ThreadException += (sender, args) =>
            {
                EnableControls(this);
                SetErrorStatus(args.Exception.Message);
            };
            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                EnableControls(this);
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
            errorProvider.Clear();
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
            DisableControls(this);
            EnableControls(lblStatus);
            EnableControls(tabControl);

            if (!ValidatePrint())
            {
                EnableControls(this);
                return;
            }

            SetStatus("Connecting to printer...");
            using (var printer = new Printer(txtLogicalName.Text))
            {
                SetStatus("Please insert check into printer.");
                printer.InsertCheck();
                SetStatus("Printing...");
                printer.PrintCheck(datePicker.Value, txtPayToTheOrderOf.Text, _amount, txtMemo.Text);
                SetStatus("Please remove check from printer.");
                printer.RemoveCheck();
            }

            EnableControls(this);
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

            if (!decimal.TryParse(txtAmount.Text, out _amount))
            {
                errorProvider.SetError(txtAmount, "The amount must be a decimal number, e.g. 123.45");
                isValid = false;
            }

            if (!isValid)
            {
                SetErrorStatus("There are form errors that must be resolved before the check can be printed.");
            }

            return isValid;
        }

        private bool ValidateEndorse()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(txtLogicalName.Text))
            {
                errorProvider.SetError(txtLogicalName, "A logical name must be specified in order to endorse the check.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtEndorsement.Text))
            {
                errorProvider.SetError(txtPayToTheOrderOf, "An endorsement must be specified.");
                isValid = false;
            }
            
            if (!isValid)
            {
                SetErrorStatus("There are form errors that must be resolved before the check can be endorsed.");
            }

            return isValid;
        }

        private void btnEndorse_Click(object sender, EventArgs e)
        {
            ResetStatus();
            DisableControls(this);
            EnableControls(lblStatus);
            EnableControls(tabControl);

            if (!ValidateEndorse())
            {
                EnableControls(this);
                return;
            }

            SetStatus("Connecting to printer...");
            using (var printer = new Printer(txtLogicalName.Text))
            {
                SetStatus("Please insert check into printer.");
                printer.InsertCheck();
                SetStatus("Printing...");
                printer.Endorse(txtEndorsement.Lines);
                SetStatus("Please remove check from printer.");
                printer.RemoveCheck();
            }

            EnableControls(this);
            ResetStatus();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            decimal test;
            if (decimal.TryParse(txtAmount.Text, out test))
            {
                errorProvider.SetError(txtAmount, "");
            }
            else
            {
                errorProvider.SetError(txtAmount, "The amount must be a decimal number, e.g. 123.45");
            }
        }

        private void DisableControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                DisableControls(c);
            }

            control.Enabled = false;
        }

        private void EnableControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                EnableControls(c);
            }

            control.Enabled = true;
        }
    }
}
