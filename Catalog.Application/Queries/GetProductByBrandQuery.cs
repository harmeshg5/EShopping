using Catalog.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Queries
{
    public class GetProductByBrandQuery :IRequest<IList<ProductResponse>>
    {
        public readonly string brandName;

        public GetProductByBrandQuery(string _brandName)
        {
            this.brandName = _brandName;
        }
    }
}
