//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class TeamProject
    {
        public long Id { get; set; }
        public long TeamId { get; set; }
        public long ProjectId { get; set; }
    
        public virtual Project Project { get; set; }
        public virtual Team Team { get; set; }
    }
}
