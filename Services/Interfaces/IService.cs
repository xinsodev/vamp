using System.Collections.Generic;
using VAMP.Services.Enums;

namespace VAMP.Services.Interfaces
{
    public interface IService
    {
        Status Status { get; }

        List<string> Versions { get; }

        bool IsAvailable { get; }

        string Key { get; }
    }
}