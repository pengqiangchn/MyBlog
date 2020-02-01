using AutoMapper;
using Infrastructure.Crosscutting.Adapter;

namespace Infrastructure.Crosscutting.NetFramework.Adapter
{

    /// <summary>
    /// Automapper type adapter implementation
    /// </summary>
    public class AutomapperTypeAdapter
        : ITypeAdapter
    {
        private readonly IMapper _mapper;

        public AutomapperTypeAdapter(IMapper mapper)
        {
            _mapper = mapper;
        }

        #region ITypeAdapter Members

        public TTarget Adapt<TSource, TTarget>(TSource source)
            where TSource : class
            where TTarget : class, new()
        {
            return _mapper.Map<TSource, TTarget>(source);
        }

        public TTarget Adapt<TTarget>(object source) where TTarget : class, new()
        {
            return _mapper.Map<TTarget>(source);
        }

        #endregion
    }
}
