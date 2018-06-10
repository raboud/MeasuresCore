using System;

namespace RandREng.MeasuresCore.Domain
{
    [Flags]
    public enum Status : int
    {
        Completed = 2,
        Scheduled = 1,
        Paid = 4,
        Billed = 8,
        Cancelled = 16,
        Sold = 32,
        Calculated = 64
    }
}
