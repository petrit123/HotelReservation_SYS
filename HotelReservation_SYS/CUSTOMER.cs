//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelReservation_SYS
{
    using System;
    using System.Collections.Generic;
    
    public partial class CUSTOMER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUSTOMER()
        {
            this.RESERVATIONS = new HashSet<RESERVATION>();
        }
    
        public int CUST_ID { get; set; }
        public string FORENAME { get; set; }
        public string SURNAME { get; set; }
        public System.DateTime DOB { get; set; }
        public string EMAIL { get; set; }
        public string MOBILE_NO { get; set; }
        public string LOYALTY { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESERVATION> RESERVATIONS { get; set; }
    }
}