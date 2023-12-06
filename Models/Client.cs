namespace Puppy.Models
{
    public class Client 
    {
        public int ClientID {get;set;}

       // [BindProperty]
        //[StringLength(25, MinimunLength = 2)]
        //[Display(Name = "First Name")]
        //[Required]
        public string? CName {get;set;}

        //[BindProperty]
        //[StringLength(25, MinimunLength = 2)]
        //[Display(Name = "Last Name")]
        //[Required]
        public string? LName {get;set;}

        //[BindProperty]
        //[StringLength(25, MinimunLength = 2)]
        //[Display(Name = "Email")]
        //[Required]
        public string? email {get;set;}

        //[BindProperty]
        //[StringLength(25, MinimunLength = 2)]
        //[Display(Name = "Phone Number")]
        //[Required]
        public int phone {get;set;} 

        public List<Puppy> Puppy {get;set;} = new List<Puppy>();
    } 

}
