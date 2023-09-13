using System;


namespace R5T.T0227.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToDotnetRuntimeDirectoryPath(string)"/>
        public static IDotnetRuntimeDirectoryPath ToDotnetRuntimeDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToDotnetRuntimeDirectoryPath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToRuntimeDirectoryPath(string)"/>
        public static IRuntimeDirectoryPath ToRuntimeDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToRuntimeDirectoryPath(value);
        }
    }
}
