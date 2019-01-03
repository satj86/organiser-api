using System.Collections.Generic;

namespace Organiser.Accounting.Crunch.Model.SalesInvoices
{
    public class SalesCollection
    {
        public int count { get; set; }
        public List<SalesInvoice> salesInvoice { get; set; }
    }
}
