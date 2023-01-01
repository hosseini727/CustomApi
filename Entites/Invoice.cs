using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Invoice : BaseEntity
    {
        public int Price { get; set; }//ss
        public int NetPrice { get; set; }
        public ICollection<InvoiceItem> InvoiceItem { get; set; }
    }
}
