using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class InvoiceItem : BaseEntity
    {
        public int PriceINvoiceItem { get; set; }
        public int INvoiceId { get; set; }
        public Invoice Invoice { get; set; }
    }
}
