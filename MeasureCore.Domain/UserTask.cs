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
        public int AddedById { get; set; }
        public System.DateTime AddedDate { get; set; }
        public Nullable<int> AssignedToId { get; set; }
        public Nullable<int> CompletedById { get; set; }
        public Nullable<System.DateTime> CompletedDate { get; set; }
        public Nullable<int> OrderId { get; set; }
    
        public Employee AssignedTo { get; set; }
        public Employee CompletedBy { get; set; }
        public Employee AddedBy { get; set; }
        public Order Order { get; set; }
        public UserTaskType UserTaskType { get; set; }
    }
}
