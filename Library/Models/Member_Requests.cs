//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member_Requests
    {
        public int request_id { get; set; }
        public int member_id { get; set; }
        public string ISBN { get; set; }
        public System.DateTime date_requested { get; set; }
        public Nullable<System.DateTime> date_located { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Member Member { get; set; }
    }
}
