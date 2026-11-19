using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class ZombieType
    {
        public int Id { get; set; }
        [Display(Name = "TypeName")]
        [StringLength(25, MinimumLength = 5)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        public string TypeName { get; set; }

        [Range(2, 5, ErrorMessage = "RangeValidation")]
        [Display(Name = "Point")]
        public int Point { get; set; }

        [ValidateNever]
        [Display(Name = "Zombies")]
        public virtual List<Zombie>? Zombies { get; set; }
    }
}
