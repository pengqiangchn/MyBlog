using AutoMapper;
using Microsoft.AspNetCore.Builder;

namespace Infrastructure.Crosscutting.Adapter
{
    public static class TypeAdapterFactory
    {
        #region Members

        static ITypeAdapterFactory _currentTypeAdapterFactory = null;
        static IMapper _mapper = null;

        #endregion

        #region Public Static Methods
        public static void SetTypeAdapterFactory(this IApplicationBuilder applicationBuilder, ITypeAdapterFactory adapterFactory, IMapper mapper)
        {
            _currentTypeAdapterFactory = adapterFactory;
            _mapper = mapper;
        }

        ///// <summary>
        ///// Set the current type adapter factory
        ///// </summary>
        ///// <param name="adapterFactory">The adapter factory to set</param>
        //public static void SetCurrent(ITypeAdapterFactory adapterFactory)
        //{
        //}

        /// <summary>
        /// Create a new type adapter from currect factory
        /// </summary>
        /// <returns>Created type adapter</returns>
        public static ITypeAdapter CreateAdapter()
        {
            return _currentTypeAdapterFactory.Create(_mapper);
        }
        #endregion
    }
}
