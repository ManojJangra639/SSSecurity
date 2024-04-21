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
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
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
        [DisplayName("Nearest Post Location")]
        public string NearestPostLocation { get; set; }
        [Required]
        [DisplayName("AdhaarCard Number")]
        public string AdhaarCardNumber { get; set; }
        [Required]
        [DisplayName("Pan Card Number")]
        public string PanCardNumber { get; set; }
        [Required]
        [DisplayName("Permanent Address")]
        public string PermanentAddress { get; set; }
        [Required]
        [DisplayName("Pin Code")]
        public string PinCode { get; set; }
        public string CurrentAddress { get; set; }
        public string PinCode2 { get; set; }
    }
}
