using System;

namespace CompanyName.ProjectName.BuilidingBlocks.Domain.Time
{
    public static class CLock
    {
        public static DateTime Now => DateTime.Now;
        public static DateTime NowUTC => DateTime.UtcNow;
    }
}
