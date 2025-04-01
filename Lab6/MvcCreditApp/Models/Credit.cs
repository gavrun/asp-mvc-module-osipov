using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcCreditApp.Models
{
    public class Credit
    {
        public virtual int CreditId { get; set; }

        [DisplayName("Credit type")]
        [Required]
        public virtual string Head { get; set; }

        [Required]
        public virtual int Period { get; set; }

        [DisplayName("Amount")]
        [Required]
        public virtual int Sum { get; set; }

        [DisplayName("Interest rate")]
        [Required]
        public virtual int Procent { get; set; }

    }
}
