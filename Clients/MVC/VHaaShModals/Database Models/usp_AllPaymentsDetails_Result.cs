//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VHaaSh.API.Modals.Database_Models
{
    using System;
    
    public partial class usp_AllPaymentsDetails_Result
    {
        public int ID { get; set; }
        public string ReceiverName { get; set; }
        public int PaidAmount { get; set; }
        public int MemberID { get; set; }
        public int MembershipID { get; set; }
        public int PaymentModeID { get; set; }
    }
}