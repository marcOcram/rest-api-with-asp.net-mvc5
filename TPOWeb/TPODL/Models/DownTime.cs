//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TPO.DL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DownTime
    {
        public int ID { get; set; }
        public int PlantID { get; set; }
        public int LineID { get; set; }
        public int ProductID { get; set; }
        public int WorkOrderID { get; set; }
        public int TypeID { get; set; }
        public int ReasonID { get; set; }
        public int ShiftID { get; set; }
        public Nullable<int> EquipmentID { get; set; }
        public System.DateTime DateOccurred { get; set; }
        public string Comment { get; set; }
        public System.DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual DownTimeEquipment DownTimeEquipment { get; set; }
        public virtual Plant Plant { get; set; }
        public virtual ProdLine ProdLine { get; set; }
        public virtual ProductionShift ProductionShift { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}