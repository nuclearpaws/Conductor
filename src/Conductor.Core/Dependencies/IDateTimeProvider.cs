using System;

namespace Conductor.Core.Dependencies
{
    public interface IDateTimeProvider
    {
        DateTime GetCurrentDateTime();
    }
}