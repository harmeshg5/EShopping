using Catalog.Application.Mappers;
using Catalog.Application.Queries;
using Catalog.Application.Responses;
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.Handlers
{
    public class GetProductByBrandHandler : IRequestHandler<GetProductByBrandQuery, IList<ProductResponse>>
    {
        private readonly IProductRepository productRepository;

        public GetProductByBrandHandler(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }
        public async Task<IList<ProductResponse>> Handle(GetProductByBrandQuery request, CancellationToken cancellationToken)
        {
            var product = await productRepository.GetProductByBrand(request.brandName);
            var productResponseList = ProductMapper.Mapper.Map<IList<ProductResponse>>(product);

            return productResponseList;
        }
    }
}
