using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStand.Domain.Entities
{
    //Markalar
    public class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public List<Cars> Cars { get; set; }
    }
}
