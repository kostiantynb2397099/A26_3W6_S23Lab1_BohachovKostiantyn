using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class HuntingLog
    {
        [Display(Name = "Title")]
        public int Id { get; set; }
        [StringLength(25, MinimumLength = 5)]
        public string Title { get; set; }
        
        [StringLength(255)]
        [Display(Name = "Description")]
        public string Description { get; set; }
        public DateTime AdventureDate { get; set; }

        [Display(Name = "Zombies")]
        [ValidateNever]
        public virtual List<Zombie> Zombies { get; set; }
    }
}
