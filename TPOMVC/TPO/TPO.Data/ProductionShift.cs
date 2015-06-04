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
    
    public partial class ProductionShift
    {
        public ProductionShift()
        {
            this.ProdSupervisorOnShifts = new HashSet<ProdSupervisorOnShift>();
            this.ProductionLineSchedules = new HashSet<ProductionLineSchedule>();
            this.ProductionShiftUses = new HashSet<ProductionShiftUse>();
            this.QCKickouts = new HashSet<QCKickout>();
            this.ScrimActions = new HashSet<ScrimAction>();
            this.TPOCProductRolls = new HashSet<TPOCProductRoll>();
            this.TPOReclaimActions = new HashSet<TPOReclaimAction>();
            this.RawMaterialActions = new HashSet<RawMaterialAction>();
            this.TPOLineScraps = new HashSet<TPOLineScrap>();
            this.TPOReworkRolls = new HashSet<TPOReworkRoll>();
            this.ProdComments = new HashSet<ProdComment>();
            this.WorkOrderShiftDatas = new HashSet<WorkOrderShiftData>();
            this.SupervisorOnShifts = new HashSet<SupervisorOnShift>();
            this.TPOReworkActions = new HashSet<TPOReworkAction>();
            this.IMProds = new HashSet<IMProd>();
        }
    
        public int ID { get; set; }
        public int PlantID { get; set; }
        public int TypeID { get; set; }
        public string Code { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public System.TimeSpan EndTime { get; set; }
        public System.DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual Plant Plant { get; set; }
        public virtual ICollection<ProdSupervisorOnShift> ProdSupervisorOnShifts { get; set; }
        public virtual ICollection<ProductionLineSchedule> ProductionLineSchedules { get; set; }
        public virtual ProductionShiftType ProductionShiftType { get; set; }
        public virtual ICollection<ProductionShiftUse> ProductionShiftUses { get; set; }
        public virtual ICollection<QCKickout> QCKickouts { get; set; }
        public virtual ICollection<ScrimAction> ScrimActions { get; set; }
        public virtual ICollection<TPOCProductRoll> TPOCProductRolls { get; set; }
        public virtual ICollection<TPOReclaimAction> TPOReclaimActions { get; set; }
        public virtual ICollection<RawMaterialAction> RawMaterialActions { get; set; }
        public virtual ICollection<TPOLineScrap> TPOLineScraps { get; set; }
        public virtual ICollection<TPOReworkRoll> TPOReworkRolls { get; set; }
        public virtual ICollection<ProdComment> ProdComments { get; set; }
        public virtual ICollection<WorkOrderShiftData> WorkOrderShiftDatas { get; set; }
        public virtual ICollection<SupervisorOnShift> SupervisorOnShifts { get; set; }
        public virtual ICollection<TPOReworkAction> TPOReworkActions { get; set; }
        public virtual ICollection<IMProd> IMProds { get; set; }
    }
}