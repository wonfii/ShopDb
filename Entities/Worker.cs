using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_ShopDb.Entities
{
    public class Worker
    {
        public int WorkerId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public decimal Salary { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }



        public Position Position { get; set; }
        public int PoditionId { get; set; }

        public Shop Shop { get; set; }
        public int ShopId { get; set; }
    }
}
