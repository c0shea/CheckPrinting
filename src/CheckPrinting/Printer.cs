using System;
using System.Text;
using Microsoft.PointOfService;

namespace CheckPrinting
{
    public class Printer : IDisposable
    {
        private PosPrinter PosPrinter { get; set; }
        private string Esc => (char) 27 + "|";
        private string LeftAlign => Esc + "lA";

        public Printer(string logicalName)
        {
            var explorer = new PosExplorer();
            PosPrinter = explorer.CreateInstance(explorer.GetDevice(DeviceType.PosPrinter, logicalName)) as PosPrinter;

            if (PosPrinter == null)
            {
                throw new InvalidOperationException($"No OPOS printer with the logical name {logicalName} was found.");
            }

            PosPrinter.Open();
            PosPrinter.Claim(700);
            PosPrinter.DeviceEnabled = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                PosPrinter.DeviceEnabled = false;
                PosPrinter.Release();
                PosPrinter.Close();
                PosPrinter = null;
            }
        }

        public void InsertCheck()
        {
            PosPrinter.BeginInsertion(1 * 60 * 1000); // 1 minute
            PosPrinter.EndInsertion();
        }

        public void RemoveCheck()
        {
            PosPrinter.BeginRemoval(1 * 60 * 1000); // 1 minute
            PosPrinter.EndRemoval();
        }

        public void PrintCheck(DateTime date, string payee, decimal amount, string memo)
        {
            var data = LeftAlign + FeedLines(10);
            data += Spaces(43) + $"{date,-10:MM/dd/yyyy}" + Spaces(7) + "\n";
            data += FeedLines(2);

            data += Spaces(2) + $"{payee,-40}" + Spaces(6) + $"{$"*{amount:0.00}*",-10}" + Spaces(1) + "\n\n";

            data += $"{"*" + NumberToWords.Convert(amount) + "*",-60}\n";
            data += FeedLines(4);

            data += $"{memo,-24}";

            PosPrinter.RotatePrint(PrinterStation.Slip, PrintRotation.Left90);
            PosPrinter.PrintNormal(PrinterStation.Slip, data);
            PosPrinter.RotatePrint(PrinterStation.Slip, PrintRotation.Normal);
            PosPrinter.PrintNormal(PrinterStation.Slip, "");
        }

        private string Spaces(int numberOfSpaces)
        {
            return new string(' ', numberOfSpaces);
        }

        private string FeedLines(int numberOfLinesToFeed)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < numberOfLinesToFeed; i++)
            {
                // For whatever reason, the text isn't actually shifted down lines
                // if only a carriage return + line feed are printed. There has to be
                // another character, like a space, printed.
                sb.AppendLine(" ");
            }

            return sb.ToString();
        }
    }
}
