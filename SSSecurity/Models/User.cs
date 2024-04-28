using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using System.Reflection.Emit;

namespace SSSecurity.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Full Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Mother Name")]
        public string LastName { get; set; }
        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        [Required]
        [DisplayName("Post Name")]
        public string PostName { get; set; }
        [Required]
        [DisplayName("Location First")]
        public string NearestPostLocation1 { get; set; }
        [DisplayName("Location Second")]
        public string NearestPostLocation2 { get; set; }
        [DisplayName("Location Third")]
        public string NearestPostLocation3 { get; set; }
        [Required]
        [DisplayName("AdhaarCard Number")]
        public string AdhaarCardNumber { get; set; }
        [Required]
        [DisplayName("Pan Card Number")]
        public string PanCardNumber { get; set; }
        [Required]
        [DisplayName("Village")]
        public string Village { get; set; }
        [DisplayName("PostOffice")]
        public string PostOffice { get; set; }
        [DisplayName("District")]
        public string District { get; set; }
        [DisplayName("State")]
        public string State { get; set; }
        [DisplayName("Pin Code")]
        public string PinCode { get; set; }
        [DisplayName("Ex-Serviceman")]
        public bool ExServiceman { get; set; }
        public string Village2 { get; set; }
        [DisplayName("PostOffice")]
        public string PostOffice2 { get; set; }
        [DisplayName("District")]
        public string District2 { get; set; }
        [DisplayName("State")]
        public string State2 { get; set; }
        [DisplayName("Pin Code")]
        public string PinCode2 { get; set; }
    }
}
