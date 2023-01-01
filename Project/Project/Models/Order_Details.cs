//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    public partial class Order_Details
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order_Details()
        {
            this.Payments = new HashSet<Payment>();
            this.Trackings = new HashSet<Tracking>();
        }
    
        public int Order_ID { get; set; }
        public Nullable<int> Order_Valuation { get; set; }
        public Nullable<int> Quantity { get; set; }
        [Range(0.10, 200)]
        public Nullable<double> OrderWeight { get; set; }
        [Required]
        public string Order_Source { get; set; }
        [Required]
        public string Order_Destination { get; set; }
        [Required(ErrorMessage = "Address is Mandatory")]
        [MinLength(12, ErrorMessage = "Min 12 character Required")]
        public string Source_Description { get; set; }
        [Required(ErrorMessage = "Address is Mandatory")]
        [MinLength(12, ErrorMessage = "Min 12 character Required")]
        public string Dest_Description { get; set; }
        public Nullable<double> Total_Price { get; set; }
        public Nullable<System.DateTime> Order_Time { get; set; }
        public Nullable<int> User_ids { get; set; }
        public Nullable<int> Ship_ID { get; set; }
    
        public virtual Shipment Shipment { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tracking> Trackings { get; set; }
    }
}
