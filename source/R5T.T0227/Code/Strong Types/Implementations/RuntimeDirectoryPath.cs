using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0227
{
    /// <inheritdoc cref="IRuntimeDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class RuntimeDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IRuntimeDirectoryPath
    {
        public RuntimeDirectoryPath(string value)
            : base(value)
        {
        }
    }
}