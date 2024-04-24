using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerAppDomain
{
    public class Size
    {
        public string SizeId {  get; set; }
        public int PriceDifference { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
