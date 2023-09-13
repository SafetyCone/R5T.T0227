using System;

using R5T.T0178;


namespace R5T.T0227
{
    /// <summary>
    /// <inheritdoc cref="IDotnetRuntimeDirectoryPath" path="/summary"/>
    /// <para>
    /// The .NET runtime directory is the default runtime directory.
    /// </para>
    /// </summary>
    /// <remarks>
    /// For a general runtime directory, use <see cref="N001.IRuntimeDirectoryPath"/>
    /// </remarks>
    [StrongTypeMarker]
    public interface IRuntimeDirectoryPath : IStrongTypeMarker,
        IDotnetRuntimeDirectoryPath
    {
    }
}