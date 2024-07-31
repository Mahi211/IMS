using IMS.CoreBusiness;
using IMS.UseCases.Inventories.Interfaces;
using IMS.UseCases.PluginInterfaces;
using IMS.UseCases.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Inventories
{
    public class DeleteProductUseCase : IDeleteProductUseCase
    {
        private readonly IProductRepository _ProductRepository;

        public DeleteProductUseCase(IProductRepository ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }
        public async Task ExecuteAsync(int ProductId)
        {
            await _ProductRepository.DeleteProductByIdAsync(ProductId);
        }
    }
}
