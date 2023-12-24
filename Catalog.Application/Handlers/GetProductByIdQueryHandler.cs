using Catalog.Application.Mappers;
using Catalog.Application.Queries;
using Catalog.Application.Responses;
using Catalog.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Handlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductResponse>
    {
        private readonly IProductRepository productRepository;

        public GetProductByIdQueryHandler(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }
        public async Task<ProductResponse> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await productRepository.GetProduct(request.id);
            var productResponse = ProductMapper.Mapper.Map<ProductResponse>(product);
            return productResponse;
        }
    }
}
