using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership {
    internal class Employees {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime Birthday { get; set; }
        public string PassportNumber { get; set; }
        public string PassportOtherData { get; set; }
        public string ResidenceAddress { get; set; }
        public string ResidentialAddress { get; set; }
        public bool DriversLicense { get; set; }
        public string CategoryDriversLicense { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public string Specialization { get; set; }
    }
}
