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
    
    public partial class Meeting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Meeting()
        {
            this.MemberMeetings = new HashSet<MemberMeeting>();
        }
    
        public int Meetingid { get; set; }
        public string Agenda { get; set; }
        public System.DateTime date { get; set; }
        public Nullable<int> CPDpoints { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MemberMeeting> MemberMeetings { get; set; }
    }
}
