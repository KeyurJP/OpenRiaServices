//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbContextModels.AdventureWorks
{
    using System;
    using System.Collections.Generic;
    
    public partial class Department
    {
        public Department()
        {
            this.EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();
        }
    
        public short DepartmentID { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
    }
}
