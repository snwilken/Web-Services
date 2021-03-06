//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eventual.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.EventRegistrations = new HashSet<EventRegistration>();
            this.SavedEvents = new HashSet<SavedEvent>();
        }
    
        public int UserID { get; set; }
        public string UserEmail { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public Nullable<System.DateTime> UserStartDate { get; set; }
        public Nullable<System.DateTime> UserBirthDate { get; set; }
        public Nullable<System.DateTime> UserEndDate { get; set; }
        public string UserPhoneNumber { get; set; }
        public Nullable<int> UserRoleID { get; set; }
        public string UserHashedPassword { get; set; }
        public string UserImageURL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventRegistration> EventRegistrations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SavedEvent> SavedEvents { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
