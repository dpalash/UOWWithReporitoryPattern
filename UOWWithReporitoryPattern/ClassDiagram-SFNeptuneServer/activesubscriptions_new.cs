//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UOWWithReporitoryPattern.ClassDiagram_SFNeptuneServer
{
    using System;
    using System.Collections.Generic;
    
    public partial class activesubscriptions_new
    {
        public long C_Id { get; set; }
        public int C_CustomerId { get; set; }
        public string C_ShipName { get; set; }
        public string C_NauProdID { get; set; }
        public int C_IssuerID { get; set; }
        public string C_Type { get; set; }
        public string C_ChartNumber { get; set; }
        public System.DateTime C_Added { get; set; }
        public Nullable<System.DateTime> C_Removed { get; set; }
        public string C_Description { get; set; }
        public Nullable<int> C_ShipEd { get; set; }
        public Nullable<int> C_CurrentEd { get; set; }
        public Nullable<System.DateTime> C_Sent { get; set; }
        public Nullable<int> C_Antall { get; set; }
        public Nullable<int> C_SubStatus { get; set; }
        public Nullable<int> C_eNTMSubCode { get; set; }
        public Nullable<System.DateTime> C_CustNotifiedAdded { get; set; }
        public Nullable<System.DateTime> C_CustNotifiedRemoved { get; set; }
        public string C_UniqueVBValue { get; set; }
        public Nullable<System.DateTime> C_EditionDate { get; set; }
        public string C_VBEditionDate { get; set; }
        public string Discriminator { get; set; }
    }
}
