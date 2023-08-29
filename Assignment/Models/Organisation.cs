using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models
{
    public class Organisation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
 
        public int OrganisationId { get; set; }
       
        public string OrganisationName { get; set; }
    }
}
