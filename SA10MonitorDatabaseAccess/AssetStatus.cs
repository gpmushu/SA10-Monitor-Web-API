//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA10MonitorDatabaseAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class AssetStatus
    {
        public string assetID { get; set; }
        public System.DateTime dateTime { get; set; }
        public Nullable<bool> onlineStatus { get; set; }
        public Nullable<decimal> netSpeed { get; set; }
        public Nullable<decimal> netQuality { get; set; }
        public Nullable<bool> dfStatus { get; set; }
        public Nullable<bool> cmStatus { get; set; }
        public Nullable<bool> gkStatus { get; set; }
        public Nullable<bool> regkeyStatus { get; set; }
    }
}
