//------------------------------------------------------------------------------
namespace LibraryMSMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class tblAdmin
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid email address")]
        [DisplayName("Email address")]
        public string AdminEmail { get; set; }
        [Required]
        [DisplayName("Password")]
        public string AdminPass { get; set; }
    }
}
