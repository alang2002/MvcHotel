using System.ComponentModel.DataAnnotations;

namespace MvcHotel.Models
{
    public class Guest
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [Display(Name = "First Name")]
        public string FName { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [Display(Name = "Last Name")]
        public string LName { get; set; }
        public int PhoneNum { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set;}

        public int CreditCardNum { get; set; }
    }
}
