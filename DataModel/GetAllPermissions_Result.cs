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
    
    public partial class GetAllPermissions_Result
    {
        public long Id { get; set; }
        public long RoleId { get; set; }
        public int EntityId { get; set; }
        public bool Create { get; set; }
        public bool Read { get; set; }
        public bool Update { get; set; }
        public bool Remove { get; set; }
        public bool Enabled { get; set; }
        public System.DateTime Created { get; set; }
        public long CreatedBy { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public long ModifiedBy { get; set; }
    }
}
