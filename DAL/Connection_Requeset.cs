//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Connection_Requeset
    {
        public int Id { get; set; }
        public Nullable<int> FK_UserId { get; set; }
        public Nullable<int> FK_Connction_UserId { get; set; }
        public Nullable<bool> IsApproved { get; set; }
    
        public virtual User_Details User_Details { get; set; }
        public virtual User_Details User_Details1 { get; set; }
    }
}
