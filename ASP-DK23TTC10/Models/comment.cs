//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP_DK23TTC10.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class comment
    {
        public int id { get; set; }
        public int id_users { get; set; }
        public string invoice_code { get; set; }
        public Nullable<int> options { get; set; }
        public string content { get; set; }
        public string image { get; set; }
    
        public virtual user user { get; set; }
    }
}
