//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eventual.DAL
{
    using System;
    
    public partial class spGetAllPastRegisteredEventsForSpecificUser_Result
    {
        public int EventID { get; set; }
        public string EventTitle { get; set; }
        public System.DateTime EventStartTime { get; set; }
        public System.DateTime EventEndTime { get; set; }
        public decimal EventPrice { get; set; }
        public string EventImageURL { get; set; }
        public string LocationStreet1 { get; set; }
        public string LocationCity { get; set; }
        public string StateAbbreviation { get; set; }
        public int UserID { get; set; }
    }
}