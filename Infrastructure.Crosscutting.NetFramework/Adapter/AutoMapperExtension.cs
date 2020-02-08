using AutoMapper;
using AutoMapper.Configuration;
using Infrastructure.Crosscutting.Adapter;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Infrastructure.Crosscutting.NetFramework.Adapter
{
    public static class AutoMapperExtension
    {
        public static IServiceCollection AddAutoMapper(this IServiceCollection service)
        {
            service.TryAddSingleton<MapperConfigurationExpression>();
            service.TryAddSingleton(serviceProvider =>
            {
                var mapperConfigurationExpression = serviceProvider.GetRequiredService<MapperConfigurationExpression>();
                var factory = serviceProvider.GetRequiredService<ITypeAdapterFactory>();

                //mapperConfigurationExpression.CreateMap(cfg =>
                //{
                //});types


                //foreach (var (sourceType, targetType) in factory.ConvertList)
                //{
                //    mapperConfigurationExpression.CreateMap(sourceType, targetType);
                //}

                //var instance = new MapperConfiguration(mapperConfigurationExpression);

                //instance.AssertConfigurationIsValid();

                var instance = new MapperConfiguration(cfg =>
                {
                    foreach (var (sourceType, targetType) in factory.ConvertList)
                    {
                        cfg.CreateMap(sourceType, targetType);
                    }
                });

                instance.AssertConfigurationIsValid();

                return instance;
            });
            service.TryAddSingleton(serviceProvider =>
            {
                var mapperConfiguration = serviceProvider.GetRequiredService<MapperConfiguration>();

                return mapperConfiguration.CreateMapper();
            });

            return service;
        }
    }
}
