//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_S07_CoursesStudentDetailt
    {
        public System.Guid ScsId { get; set; }
        public Nullable<System.Guid> StudetId { get; set; }
        public Nullable<System.Guid> CJId { get; set; }
        public string Description { get; set; }
    
        public virtual tbl_S07_CoursesJournal tbl_S07_CoursesJournal { get; set; }
        public virtual tbl_S07_Student tbl_S07_Student { get; set; }
    }
}