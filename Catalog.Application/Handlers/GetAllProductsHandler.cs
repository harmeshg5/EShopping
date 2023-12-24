using Catalog.Application.Mappers;
using Catalog.Application.Queries;
using Catalog.Application.Responses;
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.Handlers
{
    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, IList<ProductResponse>>
    {
        private readonly IProductRepository productRepository;

        public GetAllProductsHandler(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }
        public async Task<IList<ProductResponse>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var productList = await productRepository.GetAllProducts();
            var productResponseList = ProductMapper.Mapper.Map<IList<ProductResponse>>(productList);

            return productResponseList;
        }
    }
}
