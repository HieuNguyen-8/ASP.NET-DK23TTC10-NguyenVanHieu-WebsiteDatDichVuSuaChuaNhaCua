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
    
    public partial class admin
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string avatar { get; set; }
        public Nullable<int> role { get; set; }
        public byte[] created_at { get; set; }
    }
}
