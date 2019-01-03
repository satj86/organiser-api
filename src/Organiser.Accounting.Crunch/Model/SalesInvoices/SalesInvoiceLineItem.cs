namespace Organiser.Accounting.Crunch.Model.SalesInvoices
{
    public class SalesInvoiceLineItem
    {
        public string lineItemDescription { get; set; }
        public double quantity { get; set; }
        public double rate { get; set; }
        public LineItemAmount lineItemAmount { get; set; }
        public string vatType { get; set; }
    }
}
