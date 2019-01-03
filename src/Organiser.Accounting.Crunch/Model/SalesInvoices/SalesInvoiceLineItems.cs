using System.Collections.Generic;

namespace Organiser.Accounting.Crunch.Model.SalesInvoices
{
    public class SalesInvoiceLineItems
    {
        public List<SalesInvoiceLineItem> salesInvoiceLineItem { get; set; }
        public int count { get; set; }
    }
}
