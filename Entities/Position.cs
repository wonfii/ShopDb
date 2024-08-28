using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_ShopDb.Entities
{
    public class Position
    {
        public int PositionId { get; set; }

        public string Name { get; set; }

        ICollection<Worker> Workers { get; set;}
    }
}
