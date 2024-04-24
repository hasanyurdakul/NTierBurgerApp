using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BurgerAppDomain
{
    public class OrderDetail
    {  
        public int OrderId{ get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product{ get; set; }
        public int Amount { get; set; }
        public int TotalPrice { get; set; }
        public string SizeID { get; set; }
        public Size Size { get; set; }
        public int SauceId { get; set; }
        public ICollection<Sauce> Sauce { get; set; }    
    }
}
