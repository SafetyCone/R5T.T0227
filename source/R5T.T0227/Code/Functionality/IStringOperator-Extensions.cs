using System;

using R5T.T0132;


namespace R5T.T0227.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IDotnetRuntimeDirectoryPath"/>
        public IDotnetRuntimeDirectoryPath ToDotnetRuntimeDirectoryPath(string value)
        {
            var output = new DotnetRuntimeDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="IRuntimeDirectoryPath"/>
        public IRuntimeDirectoryPath ToRuntimeDirectoryPath(string value)
        {
            var output = new RuntimeDirectoryPath(value);
            return output;
        }
    }
}
