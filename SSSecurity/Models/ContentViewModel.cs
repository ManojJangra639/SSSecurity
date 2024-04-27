using System.ComponentModel;

namespace SSSecurity.Models
{
    public class ContentViewModel
    {
        [DisplayName("Passport Size Photo")]
        public IFormFile Photo { get; set; }
        [DisplayName("Aadhar Card")]
        public IFormFile AadharCard { get; set; }
        [DisplayName("Pan Card")]
        public IFormFile PanCard { get; set; }
        [DisplayName("Highest Qualification")]
        public IFormFile Doc1 { get; set; }
        [DisplayName("Signature/Thumb Impression")]
        public IFormFile Doc2 { get; set; }
    }
}
