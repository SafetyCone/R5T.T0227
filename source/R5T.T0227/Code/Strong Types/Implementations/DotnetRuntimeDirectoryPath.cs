using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0227
{
    /// <inheritdoc cref="IDotnetRuntimeDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class DotnetRuntimeDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IDotnetRuntimeDirectoryPath
    {
        public DotnetRuntimeDirectoryPath(string value)
            : base(value)
        {
        }
    }
}