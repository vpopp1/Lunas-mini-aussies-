using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Puppy.Models 
{
    public class Puppy
    {
        public int PuppyID {get;set;}

       // [BindProperty]
       // [StringLength(25, MinimunLength = 2)]
        //[Display(Name = "Puppy's Name")]
        //[Required]
        public string? Name {get;set;}

       
        //[BindProperty]
       // [Display(Name = "Height(in)")]
        //[Required]
        public double Height {get;set;}

        //[BindProperty]
       // [Display(Name = "Weight(lb)")]
       // [Required]
        public double Weight {get;set;}

        //[BindProperty]
        //[StringLength(6)]
       // [Display(Name = "Gender")]
        //[Required]
        public string? Gender {get;set;}

       // [BindProperty]
       // [StringLength(100, MinimunLength = 2)]
      //  [Display(Name = "Characteristics")]
      //  [Required]
        public string? Temp {get;set;}

        //[BindProperty]
       // [StringLength(25, MinimunLength = 2)]
       // [Display(Name = "Mother's Name")]
       // [Required]

        public string? mom{get;set;}

       // [BindProperty]
       // [StringLength(25, MinimunLength = 2)]
      //  [Display(Name = "Father's Name")]
       // [Required]
        public string? dad {get;set;}

        public Client? Client {get;set;} 
    }
}