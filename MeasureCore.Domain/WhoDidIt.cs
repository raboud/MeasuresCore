using Microsoft.EntityFrameworkCore;
using System;

namespace RandREng.MeasuresCore.Domain
{
    [Owned]
    public class WhoDidIt
    {
        public Nullable<int> UserId { get; set; }
        public System.DateTime DateTimeEntered { get; set; }
        public Employee User { get; set; }
    }
}
