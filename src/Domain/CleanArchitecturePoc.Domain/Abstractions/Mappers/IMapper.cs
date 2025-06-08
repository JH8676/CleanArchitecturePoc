namespace CleanArchitecturePoc.Domain.Abstractions.Mappers;

public interface IMapper<TModel, TDto>
    where TModel : class
    where TDto : class
{
    TDto MapToDto(TModel model);
    
    TModel MapToModel(TDto dto);
}