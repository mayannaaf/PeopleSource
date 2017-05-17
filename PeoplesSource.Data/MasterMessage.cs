//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PeoplesSource.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class MasterMessage
    {
        public MasterMessage()
        {
            this.EbayMessages = new HashSet<EbayMessage>();
            this.MessageTags = new HashSet<MessageTag>();
        }
    
        public decimal MasterMessageid { get; set; }
        public int Sellerid { get; set; }
        public string MessageSubject { get; set; }
        public Nullable<System.DateTime> MessageRecieveDate { get; set; }
        public decimal MessageSenderid { get; set; }
        public Nullable<System.DateTime> MessageExpiryDate { get; set; }
        public decimal MessageItemid { get; set; }
        public string Sender { get; set; }
        public string MessageType { get; set; }
        public bool Type { get; set; }
        public string Status { get; set; }
        public bool IsRead { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
        public string Note { get; set; }
        public string DetailTags { get; set; }
    
        public virtual ICollection<EbayMessage> EbayMessages { get; set; }
        public virtual Seller Seller { get; set; }
        public virtual ICollection<MessageTag> MessageTags { get; set; }
    }
}