//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAIMC_MemberManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class QRGeneration
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int SAIMC_Nr { get; set; }
        public byte[] MemberQRCode { get; set; }
    }
}
