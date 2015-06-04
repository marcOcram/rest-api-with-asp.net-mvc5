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
    
    public partial class TPOProductStandardCost
    {
        public int ID { get; set; }
        public int PlantID { get; set; }
        public int TPOProductID { get; set; }
        public double StandartCost { get; set; }
        public double StandardWeightPerArea { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public System.DateTime LastModified { get; set; }
    
        public virtual Plant Plant { get; set; }
        public virtual TPOProduct TPOProduct { get; set; }
    }
}