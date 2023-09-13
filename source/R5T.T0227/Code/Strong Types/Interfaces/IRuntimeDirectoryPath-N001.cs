using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0227.N001
{
    /// <summary>
    /// Strongly-types a string as a runtime directory path.
    /// Note: no assumption is made about whether this is a .NET runtime directory path,
    /// as lots of things can have runtime directories, and the .NET runtime is just one.
    /// </summary>
    [StrongTypeMarker]
    public interface IRuntimeDirectoryPath : IStrongTypeMarker,
        IDirectoryPath
    {
    }
}