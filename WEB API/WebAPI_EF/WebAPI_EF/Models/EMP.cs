//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI_EF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMP
    {
        public int empno { get; set; }
        public string ename { get; set; }
        public string job { get; set; }
        public Nullable<int> mgr_id { get; set; }
        public Nullable<System.DateTime> hiredate { get; set; }
        public Nullable<decimal> sal { get; set; }
        public Nullable<decimal> comm { get; set; }
        public Nullable<int> deptno { get; set; }
    
        public virtual DEPT DEPT { get; set; }
    }
}
