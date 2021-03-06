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
    
    public partial class ScrimRoll
    {
        public ScrimRoll()
        {
            this.ScrimActions = new HashSet<ScrimAction>();
            this.TPOCurrentScrims = new HashSet<TPOCurrentScrim>();
            this.TPOCurrentScrims1 = new HashSet<TPOCurrentScrim>();
            this.TPOCurrentScrims2 = new HashSet<TPOCurrentScrim>();
            this.TPOBatches = new HashSet<TPOBatch>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public Nullable<int> TypeID { get; set; }
        public int PlantID { get; set; }
        public Nullable<int> LotNumber { get; set; }
        public Nullable<int> WovenLotNumber { get; set; }
        public int WeightUoMID { get; set; }
        public int LengthUoMID { get; set; }
        public Nullable<System.DateTime> WovenDate { get; set; }
        public System.DateTime DateReceived { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public double TareWeight { get; set; }
        public double ReceivedLength { get; set; }
        public double ReceivedWeight { get; set; }
        public double ReceivedTareWeight { get; set; }
        public double LengthUsed { get; set; }
        public double WeightUsed { get; set; }
        public System.DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual Plant Plant { get; set; }
        public virtual ICollection<ScrimAction> ScrimActions { get; set; }
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
        public virtual ScrimType ScrimType { get; set; }
        public virtual UnitOfMeasure UnitOfMeasure1 { get; set; }
        public virtual ICollection<TPOCurrentScrim> TPOCurrentScrims { get; set; }
        public virtual ICollection<TPOCurrentScrim> TPOCurrentScrims1 { get; set; }
        public virtual ICollection<TPOCurrentScrim> TPOCurrentScrims2 { get; set; }
        public virtual ICollection<TPOBatch> TPOBatches { get; set; }
    }
}
