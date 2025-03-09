
using AutoMapper;

namespace ECommerce.Mapper.AutoMapper;

public class Mapper : Application.Repositories.Interfaces.AutoMapper.IMapper
{
	private static readonly List<TypePair> typePairs = new();
	private static readonly object lockObject = new();
	private IMapper MapperContainer;

	public Mapper()
	{
		ConfigureMapper();
	}

	public TDestination Map<TDestination, TSource>(TSource source, string? ignore = null)
	{
		EnsureMappingExists<TDestination, TSource>(ignore);
		return MapperContainer.Map<TSource, TDestination>(source);
	}

	public IList<TDestination> Map<TDestination, TSource>(IList<TSource> source, string? ignore = null)
	{
		EnsureMappingExists<TDestination, TSource>(ignore);
		return MapperContainer.Map<IList<TSource>, IList<TDestination>>(source);
	}

	public TDestination Map<TDestination>(object source, string? ignore = null)
	{
		EnsureMappingExists<TDestination, object>(ignore);
		return MapperContainer.Map<TDestination>(source);
	}

	public IList<TDestination> Map<TDestination>(IList<object> source, string? ignore = null)
	{
		EnsureMappingExists<TDestination, object>(ignore);
		return MapperContainer.Map<IList<object>, IList<TDestination>>(source);
	}

	private void EnsureMappingExists<TDestination, TSource>(string? ignore)
	{
		lock (lockObject)
		{
			var typePair = new TypePair(typeof(TDestination), typeof(TSource));
			if (!typePairs.Any(a => a.DestinationType == typePair.DestinationType && a.SourceType == typePair.SourceType))
			{
				typePairs.Add(typePair);
				ConfigureMapper();
			}
		}
	}

	private void ConfigureMapper()
	{
		var config = new MapperConfiguration(cfg =>
		{
			lock (lockObject)
			{
				foreach (var item in typePairs)
				{
					var map = cfg.CreateMap(item.SourceType, item.DestinationType).MaxDepth(5);
					if (!string.IsNullOrEmpty(item.IgnoreProperty))
					{
						map.ForMember(item.IgnoreProperty, opt => opt.Ignore());
					}
					else
					{
						map.ReverseMap();
					}
				}
			}
		});

		MapperContainer = config.CreateMapper();
	}
}

public class TypePair
{
	public Type SourceType { get; }
	public Type DestinationType { get; }
	public string? IgnoreProperty { get; }

	public TypePair(Type destinationType, Type sourceType, string? ignoreProperty = null)
	{
		DestinationType = destinationType;
		SourceType = sourceType;
		IgnoreProperty = ignoreProperty;
	}
}

