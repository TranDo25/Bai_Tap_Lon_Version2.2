//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Website1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class contacts
    {
        public long id { get; set; }
        public string c_name { get; set; }
        public string c_email { get; set; }
        public string c_title { get; set; }
        public string c_content { get; set; }
        public Nullable<byte> c_status { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    }
}
