using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class UserTaskType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Nullable<int> Priority { get; set; }
    
        public List<UserTask> UserTasks { get; set; }
    }
}
