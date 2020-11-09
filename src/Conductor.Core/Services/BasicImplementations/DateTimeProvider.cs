using System;
using Conductor.Core.Dependencies;

namespace Conductor.Core.Services.BasicImplementations
{
    public class BasicDateTimeProvider : IDateTimeProvider
    {
        public DateTime GetCurrentDateTime() => DateTime.Now;
    }
}