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
    
    public partial class TPOFormulation
    {
        public TPOFormulation()
        {
            this.TPOFormulationLineProducts = new HashSet<TPOFormulationLineProduct>();
            this.TPOFormulationRawMaterials = new HashSet<TPOFormulationRawMaterial>();
            this.TPOBatches = new HashSet<TPOBatch>();
        }
    
        public int ID { get; set; }
        public string Description { get; set; }
        public int PlantID { get; set; }
        public System.DateTime LastModified { get; set; }
        public int Extruders { get; set; }
    
        public virtual Plant Plant { get; set; }
        public virtual ICollection<TPOFormulationLineProduct> TPOFormulationLineProducts { get; set; }
        public virtual ICollection<TPOFormulationRawMaterial> TPOFormulationRawMaterials { get; set; }
        public virtual ICollection<TPOBatch> TPOBatches { get; set; }
    }
}