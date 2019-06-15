using System;

namespace EasyCloud.Time
{
    public class TimeProvider : ITimeProvider
    {
        public DateTime GetTime() => DateTime.Now;
    }
}
