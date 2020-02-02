using System;
using System.Collections.Generic;

namespace Infrastructure.Crosscutting.Adapter
{
    /// <summary>
    /// Base contract for adapter factory
    /// </summary>
    public interface ITypeAdapterFactory
    {
        List<(Type, Type)> ConvertList { get; }

        /// <summary>
        /// Create a type adater
        /// </summary>
        /// <returns>The created ITypeAdapter</returns>
        ITypeAdapter Create(object param);
    }
}
