﻿using Catalog.Application.Mappers;
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
    public class GetProductByNameQueryHandler : IRequestHandler<GetProductByNameQuery, IList<ProductResponse>>
    {
        private readonly IProductRepository productRepository;

        public GetProductByNameQueryHandler(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }
        public async Task<IList<ProductResponse>> Handle(GetProductByNameQuery request, CancellationToken cancellationToken)
        {
            var product = await productRepository.GetProductByName(request.name);
            var productResponseList = ProductMapper.Mapper.Map<IList<ProductResponse>>(product);

            return productResponseList;
        }
    }
}
