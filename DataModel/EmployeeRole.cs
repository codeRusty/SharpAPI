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
    
    public partial class EmployeeRole
    {
        public long Id { get; set; }
        public long EmployeeId { get; set; }
        public long RoleID { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Role Role { get; set; }
    }
}
