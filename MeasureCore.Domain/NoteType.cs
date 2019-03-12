using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class NoteType
    {
        public int Id { get; set; }
        public string NoteTypeDescription { get; set; }
        public bool ShowInList { get; set; }
        public bool ShowEmployees { get; set; }
        public bool ShowSpokeWith { get; set; }
        public bool RequireSpokeWith { get; set; }
        public bool EnableSchedulingInfo { get; set; }
        public bool CanSendToExpeditor { get; set; }
        public bool ShowStoreManagement { get; set; }
        public bool PermissionRequiredToSelect { get; set; }
        public Nullable<byte> DisplayOrder { get; set; }
    
        public List<OrderNote> PONotes { get; set; }
    }
}
