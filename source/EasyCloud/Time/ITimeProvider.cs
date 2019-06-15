using System;

namespace EasyCloud.Time
{
    public interface ITimeProvider
    {
        DateTime GetTime();
    }
}
