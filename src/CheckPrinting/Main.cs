using System;
using System.Windows.Forms;

namespace CheckPrinting
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            datePicker.Value = DateTime.Now;
            // Checks are typically void after 90 days, but we'll allow a bit more leeway
            datePicker.MinDate = DateTime.Now.AddYears(-1);
        }
    }
}
