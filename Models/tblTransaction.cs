namespace LibraryMSMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTransaction
    {
        public int TranId { get; set; }
        public Nullable<int> BookId { get; set; }
        public string BookTitle { get; set; }
        public string BookISBN { get; set; }
        public string TranStatus { get; set; }
        public string TranDate { get; set; }
        public Nullable<int> UserId { get; set; }
        public string UserName { get; set; }
    }
}
