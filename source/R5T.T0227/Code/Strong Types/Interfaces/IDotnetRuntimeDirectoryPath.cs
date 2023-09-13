using System;

using R5T.T0178;


namespace R5T.T0227
{
    /// <summary>
    /// Strongly-types a string as a .NET runtime directory path.
    /// <para>Example: <inheritdoc cref="Y0000.Documentation.Example_RuntimeDirectoryPath" path="/summary"/></para>
    /// </summary>
    [StrongTypeMarker]
    public interface IDotnetRuntimeDirectoryPath : IStrongTypeMarker,
        N001.IRuntimeDirectoryPath
    {
    }
}