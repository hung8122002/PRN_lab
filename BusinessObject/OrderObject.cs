using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class OrderObject
    {
        public int OrderId { get; set; }

        public int MemberId { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? RequireDare { get; set; }

        public DateTime? ShippingDate { get; set; }

        public decimal? Freight { get; set; }
    }
}
