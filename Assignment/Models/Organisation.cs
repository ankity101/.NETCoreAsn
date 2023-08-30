using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models
{
    public class Organisation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage ="Organisation Id Required")]
        public int OrganisationId { get; set; }

        [Required(ErrorMessage ="Organisation Name Is Required")]
        public string OrganisationName { get; set; }
    }
}
