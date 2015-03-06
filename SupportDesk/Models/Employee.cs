//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SupportDesk.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public Employee()
        {
            this.Equipments = new HashSet<Equipment>();
            this.SupportGroups = new HashSet<SupportGroup>();
            this.Tasks = new HashSet<Task>();
            this.Tasks1 = new HashSet<Task>();
            this.SupportGroups1 = new HashSet<SupportGroup>();
        }
    
        public long ID { get; set; }
        public string F_Name { get; set; }
        public string L_Name { get; set; }
        public Nullable<long> Phone { get; set; }
        public string Office { get; set; }
        public Nullable<long> Department_ID { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual ICollection<Equipment> Equipments { get; set; }
        public virtual ICollection<SupportGroup> SupportGroups { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        public virtual ICollection<Task> Tasks1 { get; set; }
        public virtual ICollection<SupportGroup> SupportGroups1 { get; set; }
    }
}
