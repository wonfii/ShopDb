using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_ShopDb.Entities
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }


        public Country Country { get; set; }
        public int CountryId { get; set; }

        ICollection<Shop> ShopsInCity { get; set;}
    }
}
