//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogWebsite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BlogTable
    {
        public int Blogid { get; set; }
        public int Userid { get; set; }
        public string Titile { get; set; }
        public string Description { get; set; }
        public string Impagepath { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual BlogTable BlogTable1 { get; set; }
        public virtual BlogTable BlogTable2 { get; set; }
    }
}