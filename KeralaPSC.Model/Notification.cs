//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KeralaPSC.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Notification
    {
        public int NotificationID { get; set; }
        public int ExamID { get; set; }
        public System.DateTime NotificationDate { get; set; }
        public string Designation { get; set; }
        public string Qualification { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public byte[] EntityRowVersion { get; set; }
    
        public virtual Exam Exam { get; set; }
    }
}