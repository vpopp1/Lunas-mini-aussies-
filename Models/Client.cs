using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Lunas_mini_aussies.Models
{
    public class Client 
    {
        public int ClientID {get;set;}

        //[BindProperty]
        [StringLength(25)]
        [Display(Name = "First Name")]
        [Required]
        public string? CName {get;set;}

        //[BindProperty]
        [StringLength(25)]
        [Display(Name = "Last Name")]
        [Required]
        public string? LName {get;set;}

        //[BindProperty]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Display(Name = "Email")]
        [Required]
        public string? email {get;set;}

        //[BindProperty]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]
        [Display(Name = "Phone Number")]
        public string? phone {get;set;} 

        public List<Puppy> Puppys {get;set;} = new List<Puppy>();
    } 

}
