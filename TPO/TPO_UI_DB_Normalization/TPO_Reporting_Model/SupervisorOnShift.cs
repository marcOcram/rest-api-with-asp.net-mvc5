//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TPO_Reporting_Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SupervisorOnShift
    {
        public int ID { get; set; }
        public int ShiftID { get; set; }
        public int SupervisorUserID { get; set; }
        public System.DateTime ProductionDate { get; set; }
        public System.DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual ProductionShift ProductionShift { get; set; }
        public virtual User User { get; set; }
    }
}
