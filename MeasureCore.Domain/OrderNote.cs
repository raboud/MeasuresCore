using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class OrderNote
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int NoteTypeId { get; set; }
        public int SpokeWithId { get; set; }
        public string ContactName { get; set; }
        public System.DateTime DateTimeEntered { get; set; }
        public string NoteText { get; set; }
        public Nullable<int> EnteredById { get; set; }
        public bool CustomerToCallBack { get; set; }
        public bool Scheduled { get; set; }
        public bool UnScheduled { get; set; }
        public Nullable<bool> ScheduledAM { get; set; }
        public Nullable<System.DateTime> ScheduledDate { get; set; }
        public bool Deleted { get; set; }
        public bool SentViaXML { get; set; }
        public Nullable<System.DateTime> DateTimeSent { get; set; }
    
        public Employee EnteredBy { get; set; }
        public NoteType NoteType { get; set; }
        public Order Order { get; set; }
    }
}
