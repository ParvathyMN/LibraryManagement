//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book_Details
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book_Details()
        {
            this.Order_Details = new HashSet<Order_Details>();
        }
    
        public int BookId { get; set; }
        public int UserId { get; set; }
        public string Book_Title { get; set; }
        public string Book_Author { get; set; }
        public string Book_Edition { get; set; }
        public string Book_ISBN { get; set; }
        public System.DateTime Book_AvailDate { get; set; }
        public decimal Book_Amount { get; set; }
        public int Booked { get; set; }
    
        public virtual User_Details User_Details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Details> Order_Details { get; set; }
    }
}
