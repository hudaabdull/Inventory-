using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace invFM.ViewModels
{
    public class AdminViewModel
    {

        /// <summary> 
        /// Employee view model from employee model and used by employee controller 
        /// </summary> 

        [Display(Name = "Admin ID")]
        public int Id { get; set; }


        //[Required] 
        //[StringLength(256)] 
        //public string UserName { get; set; } 


        [Required]
        [Display(Name = "First Name")]
        public string AdminName { get; set; }

        //[Required] 
        //[StringLength(15)] 
        //public string Phone { get; set; } 



        [Display(Name = "Phone Number")]
        public string Phone { get; set; }


        [Required] 
         [EmailAddress] 
         [Display(Name = "Email")] 
         public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }











    } 
 } 

    
