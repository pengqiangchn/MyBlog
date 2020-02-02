using AutoMapper;
using Domain.Seedwork;
using Infrastructure.Crosscutting.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Infrastructure.Crosscutting.NetFramework.Adapter
{
    public class AutomapperTypeAdapterFactory
        : ITypeAdapterFactory
    {
        public List<(Type, Type)> ConvertList { get; } = new List<(Type, Type)>();

        #region Constructor

        /// <summary>
        /// Create a new Automapper type adapter factory
        /// </summary>
        public AutomapperTypeAdapterFactory()
        {
            ////scan all assemblies finding Automapper Profile
            //var profiles = AppDomain.CurrentDomain
            //                        .GetAssemblies()
            //                        .Where(x => x.GetName().FullName.Contains("NLayerApp"))
            //                        .SelectMany(a => a.GetTypes())
            //                        .Where(t => t.GetTypeInfo().BaseType == typeof(Profile));


            //Mapper.Initialize(cfg =>
            //{
            //    foreach (var item in profiles)
            //    {
            //        if (item.FullName != "AutoMapper.SelfProfiler`2" &&
            //            item.FullName != "AutoMapper.MapperConfiguration+NamedProfile")

            //            cfg.AddProfile(Activator.CreateInstance(item) as Profile);
            //    }
            //});

            var assemblys = AppDomain.CurrentDomain.GetAssemblies();

            foreach (var assembly in assemblys)
            {
                var atributes = assembly.GetTypes()
                    .Where(_type => _type.GetCustomAttribute<AutoInject>() != null)
                    .Select(_type =>
                    new
                    {
                        SourceType = _type.GetCustomAttribute<AutoInject>().SourceType,
                        TargetType = _type
                    });

                foreach (var atribute in atributes)
                {
                    ConvertList.Add((atribute.SourceType, atribute.TargetType));
                }
            }
        }

        #endregion

        #region ITypeAdapterFactory Members

        public ITypeAdapter Create(object _mapper)
        {
            return new AutomapperTypeAdapter(_mapper as IMapper);
        }

        #endregion
    }
}
