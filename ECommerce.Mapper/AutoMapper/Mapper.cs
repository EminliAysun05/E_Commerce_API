
using AutoMapper;

namespace ECommerce.Mapper.AutoMapper;

public class Mapper : Application.Repositories.Interfaces.AutoMapper.IMapper
{
	public static List<TypePair> typePairs = new();
	private IMapper MapperContainer;



	public TDestination Map<TDestination, TSource>(TSource source, string? ignore = null)
	{
		Config<TDestination, TSource>(5, ignore);
		return MapperContainer.Map<TSource, TDestination>(source);

	}

	public IList<TDestination> Map<TDestination, TSource>(IList<TSource> source, string? ignore = null)
	{
		Config<TDestination, TSource>(5, ignore);
		return MapperContainer.Map<IList<TSource>, IList<TDestination>>(source);
	}

	public TDestination Map<TDestination>(object source, string? ignore = null)
	{
		Config<TDestination, object>(5, ignore);
		return MapperContainer.Map<TDestination>(source);
	}

	public IList<TDestination> Map<TDestination>(IList<object> source, string? ignore = null)
	{
		Config<TDestination, object>(5, ignore);
		return MapperContainer.Map<IList<object>, IList<TDestination>>(source);
	}

	protected void Config<TDestination, TSource>(int depth = 5, string? ignore = null)
	{
		var typePair = new TypePair(typeof(TDestination), typeof(TSource));
		if (typePairs.Any(a => a.DestinationType == typePair.DestinationType && a.SourceType == typePair.SourceType && ignore is not null))

			typePairs.Add(typePair);

		var config = new MapperConfiguration(cfg =>
		{
			foreach (var item in typePairs)
			{
				if (ignore is not null)
					cfg.CreateMap(item.SourceType, item.DestinationType).MaxDepth(depth).ForMember(ignore, opt => opt.Ignore());
				else
					cfg.CreateMap(item.SourceType, item.DestinationType).MaxDepth(depth).ReverseMap();
			}
		});
		MapperContainer = config.CreateMapper();

	}
}
