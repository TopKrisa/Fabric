using System.Text.RegularExpressions;
using Fabric.DAL.Abstractions.Repository;

namespace Fabric.BL.Services.Implementations;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
}