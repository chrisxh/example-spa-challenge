//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPASampleApp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Field
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Caption { get; set; }
        public string Status { get; set; }
        public string ToolTip { get; set; }
        public System.DateTime LastUpdate { get; set; }
        public int ScreenId { get; set; }
    
        public virtual Screen Screen { get; set; }
    }
}
