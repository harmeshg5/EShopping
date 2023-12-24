using Catalog.Application.Mappers;
using Catalog.Application.Queries;
using Catalog.Application.Responses;
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.Handlers
{
    public class GetAllTypesHandler : IRequestHandler<GetAllTypesQuery, IList<TypesResponse>>
    {
        private readonly ITypesRepository typesRepository;

        public GetAllTypesHandler(ITypesRepository _typesRepository)
        {
            typesRepository = _typesRepository;
        }

        public async Task<IList<TypesResponse>> Handle(GetAllTypesQuery request, CancellationToken cancellationToken)
        {
            var typesList = await typesRepository.GetAllTypes();

            var typesResponseList = ProductMapper.Mapper.Map<IList<TypesResponse>>(typesList);
            return typesResponseList;
        }
    }
}
