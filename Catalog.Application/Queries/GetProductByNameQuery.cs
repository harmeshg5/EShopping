using Catalog.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Queries
{
    public class GetProductByNameQuery : IRequest<IList<ProductResponse>>
    {
        public readonly string name;

        public GetProductByNameQuery(string _name)
        {
            name = _name;
        }
    }
}
