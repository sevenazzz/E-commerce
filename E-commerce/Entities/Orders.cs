using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.Entities
{
    public class Orders
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Total { get; set; }
        public Clients Client { get; set; }

    }
}
