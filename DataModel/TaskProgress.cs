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
    
    public partial class TaskProgress
    {
        public long Id { get; set; }
        public long TaskId { get; set; }
        public int Progress { get; set; }
        public string Comment { get; set; }
        public System.DateTime Dated { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<long> CreatedBy { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Task Task { get; set; }
    }
}
