namespace Organiser.Accounting.Crunch.Model.SalesInvoices
{
    public class SalesInvoice
    {
        public int salesInvoiceId { get; set; }
        public string resourceUrl { get; set; }
        public string currency { get; set; }
        public SalesInvoiceLineItems salesInvoiceLineItems { get; set; }
        public ClientPayments clientPayments { get; set; }
        public SalesInvoiceDetails salesInvoiceDetails { get; set; }
        public string note { get; set; }
    }
}
