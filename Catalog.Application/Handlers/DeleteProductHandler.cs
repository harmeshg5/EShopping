using Catalog.Application.Commands; 
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.Handlers
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductByIdCommand, bool>

    {
        private readonly IProductRepository productRepository;

        public DeleteProductHandler(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }

        public async Task<bool> Handle(DeleteProductByIdCommand request, CancellationToken cancellationToken)
        {
            return await productRepository.DeleteProduct(request.id);
        }
    }
}
