using Refrigerator.Contracts.Repository;
using Refrigerator.Domain.Entities;

namespace Refrigerator.Repository;

public class ProductRepository : RepositoryBase<Product>, IProductRepository
{
    public ProductRepository(RepositoryContext context) : base(context)
    {
    }
}