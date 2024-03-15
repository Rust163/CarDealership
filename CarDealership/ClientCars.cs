using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership {
    internal class ClientCars {
        public int Id { get; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public string VinNumber { get; set; }
        public float Mileage {  get; set; }
        public string NumberSTS { get; set;}
    }
}
