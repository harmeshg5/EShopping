﻿using AutoMapper;
using Catalog.Application.Mappers;
using Catalog.Application.Queries;
using Catalog.Application.Responses;
using Catalog.Core.Entities;
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.Handlers
{
    public class GetAllBrandsHandler : IRequestHandler<GetAllBrandsQuery, IList<BrandResponse>>
    {
        private readonly IBrandRepository brandRepository;

        public GetAllBrandsHandler(IBrandRepository _brandRepository)
        {
            brandRepository = _brandRepository;
        }

        public async Task<IList<BrandResponse>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
        {
            var brandList = await brandRepository.GetAllBrands();
            var brandResponseList = ProductMapper.Mapper.Map<IList<ProductBrand>, IList<BrandResponse>>(brandList.ToList());
            return brandResponseList;
        }
    }
}
