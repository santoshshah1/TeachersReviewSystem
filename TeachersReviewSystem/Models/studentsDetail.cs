//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeachersReviewSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class studentsDetail
    {
        public int studentDetailID { get; set; }
        public int appeared { get; set; }
        public Nullable<int> succeeded { get; set; }
    
        public virtual subjects subjects { get; set; }
    }
}
