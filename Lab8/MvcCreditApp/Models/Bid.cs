using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcCreditApp.Models
{
    public class Bid
    {
        public virtual int BidId { get; set; }

        [DisplayNameAttribute("Name")]
        [Required]
        public virtual string Name { get; set; }

        [DisplayName("Credit type")]
        [Required]
        public virtual string CreditHead { get; set; }

        [DisplayName("Request Date")]
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public virtual DateTime bidDate { get; set; }
    }
}
