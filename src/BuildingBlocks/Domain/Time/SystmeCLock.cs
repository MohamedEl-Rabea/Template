using System;

namespace CompanyName.ProjectName.BuilidingBlocks.Domain.Time
{
    public class SystmeCLock : ISystmeCLock
    {
        public DateTime Now => CLock.Now;
    }
}
