namespace Organiser.Accounting.Crunch.Model.SalesInvoices
{
    public class LineItemAmount
    {
        public double netAmount { get; set; }
        public double grossAmount { get; set; }
        public double vatAmount { get; set; }
        public double vatRate { get; set; }
    }
}
