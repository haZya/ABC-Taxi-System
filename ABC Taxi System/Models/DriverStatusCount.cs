//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABC_Taxi_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DriverStatusCount
    {
        public int Id { get; set; }
        public string Driver { get; set; }
        public int OnlineCount { get; set; }
        public int OfflineCount { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual DriverAvailability DriverAvailability { get; set; }
    }
}