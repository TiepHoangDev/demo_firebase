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
    
    public partial class tbl_S07_Weekdays
    {
        public tbl_S07_Weekdays()
        {
            this.tbl_S07_Schedulers = new HashSet<tbl_S07_Schedulers>();
        }
    
        public System.Guid WeId { get; set; }
        public string WeName { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<tbl_S07_Schedulers> tbl_S07_Schedulers { get; set; }
    }
}
