using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStand.Domain.Entities
{ 
    //Arabalar
    public class Cars
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public int Km { get; set; }
        public string Transmission { get; set; } //Vites Türü
        public byte Seat { get; set; }  //Oturma Yeri
        public byte Luggage { get; set; } //Bagaj
        public string Fuel { get; set; }
        public string BigImageUrl { get; set; }
    }
}
