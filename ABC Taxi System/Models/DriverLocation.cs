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
    
    public partial class DriverLocation
    {
        public string Driver { get; set; }
        public string StreetNo { get; set; }
        public string Route { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string ZipCode { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    
        public virtual User User { get; set; }
    }
}
