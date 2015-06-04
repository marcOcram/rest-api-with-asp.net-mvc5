//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TPO.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class WorkOrderShiftDataFormulation
    {
        public int ID { get; set; }
        public int LineID { get; set; }
        public System.DateTime ProductionDate { get; set; }
        public string ProductionShift { get; set; }
        public Nullable<int> WorkOrderID { get; set; }
        public string Extruder { get; set; }
        public int Feeder { get; set; }
        public int RawMaterialID { get; set; }
        public string RawMaterialCode { get; set; }
        public double QuantityUsed { get; set; }
        public int PlantID { get; set; }
        public System.DateTime EnteredDate { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual Plant Plant { get; set; }
        public virtual ProdLine ProdLine { get; set; }
        public virtual RawMaterial RawMaterial { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}