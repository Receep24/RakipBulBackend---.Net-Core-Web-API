namespace Business.Utilities.Mapping.Interface;

public interface IMapperHelper
{
    TDestination Map<TDestination>(object? source);
}