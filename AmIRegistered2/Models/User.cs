using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AmIRegistered2.Models
{
    public class User
    {
        [Required]
        [MaxLength(32)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(32)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(128)]
        public string Address { get; set; }
        [Required]
        [Display(Name="Telephone No.")]
        public string PhoneNo { get; set; }
        [Required]
        [Display(Name="National Insurance Number")]
        [RegularExpression(@"[a-zA-Z]{2}\d{6}[a-zA-Z]{1}", ErrorMessage = "Your National Insurance No. should have the formt AA000000A")]
        public string NINO { get; set; }
    }
}