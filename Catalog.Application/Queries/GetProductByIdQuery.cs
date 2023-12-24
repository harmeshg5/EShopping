using Catalog.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Queries
{
    public class GetProductByIdQuery :IRequest<ProductResponse>
    {
        public readonly string id;

        public GetProductByIdQuery(string _id)
        {
            id = _id;
        }
    }
}
