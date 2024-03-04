using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductModel
{
    public interface IProduct<T> : IRepository<T> where T : Product
    {
        Task<Supplier> SupplierProduct(int productId);

        Task<Product> ProductWithSupplier(int productId);

        Task<IEnumerable<Supplier>> GetSupplierList();
        // Might want to implement specific Product functionality Later
    }
}
