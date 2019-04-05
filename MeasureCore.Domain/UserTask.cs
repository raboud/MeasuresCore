using System;
using System.Collections.Generic;

namespace RandREng.MeasuresCore.Domain
{
    public partial class UserTask
    {
        public int Id { get; set; }
        public Nullable<int> JobId { get; set; }
        public System.DateTime DueDate { get; set; }
        public int UserTaskTypeId { get; set; }
        public WhoDidIt Added { get; set; }
        public WhoDidIt Completed { get; set; }
        public WhoDidIt Assinged { get; set; }

        public Nullable<int> OrderId { get; set; }
    
        public Order Order { get; set; }
        public UserTaskType UserTaskType { get; set; }
    }
}
