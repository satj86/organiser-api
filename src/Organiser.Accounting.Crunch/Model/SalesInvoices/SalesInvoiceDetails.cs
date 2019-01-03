using System;

namespace Organiser.Accounting.Crunch.Model.SalesInvoices
{
    public class SalesInvoiceDetails
    {
        public Client client { get; set; }
        public string clientReference { get; set; }
        public string issuedDate { get; set; }
        public int paymentTermsDays { get; set; }
        public string state { get; set; }
        public bool emailReminderToCustomer { get; set; }
        public DateTime lastModifiedDate { get; set; }
        public string issueDateType { get; set; }
        public string purchaseOrder { get; set; }
        public string dueDate { get; set; }
        public string invoiceNumber { get; set; }
        public string settledDate { get; set; }
    }
}
