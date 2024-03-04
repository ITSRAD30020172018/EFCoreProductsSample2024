using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductModel
{
    public class ProductRepository : IProduct<Product>, IDisposable
    {
        ProductDBContext context = new ProductDBContext();

        public ProductRepository(ProductDBContext context)
        {
            this.context = context;
        }

        public void Add(Product entity)
        {
            context.Products.Add(entity);
            context.SaveChanges();
        }

        public void AddRange(IEnumerable<Product> entities)
        {
            context.AddRange(entities);
        }

        public IEnumerable<Product> Find(Expression<Func<Product, bool>> predicate)
        {
            return context.Products.Find(predicate) as IEnumerable<Product>;
        }

        public Product Get(int id)
        {
            return context.Products.Find(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return context.Products.Include("ProductSupplier").ToList();
        }

        public void Remove(Product entity)
        {
            context.Products.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Product> entities)
        {
            context.Products.RemoveRange(entities);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public async Task<Supplier> SupplierProduct(int productId)
        {

            if(context.Products.Find(productId) != null)
                return context.Products
                              .FirstOrDefaultAsync(p => p.ID == productId)
                              .Result.ProductSupplier;
            return null;
            //return context.Suppliers
            //    .Include(s => s.SupplierProducts)
            //    .Where(s => s.SupplierID == sp.SupplierID).FirstOrDefault();
        }

        public async Task<Product> ProductWithSupplier(int productId)
        {
            return await context.Products
                .Include(s => s.ProductSupplier)
                .FirstOrDefaultAsync(P => P.ID == productId);
        }

        public async Task<IEnumerable<Supplier>> GetSupplierList()
        {
            return await context.Suppliers
                .Include( sp => sp.SupplierProducts).ToListAsync();
        }

        public async Task<Product> Put(Product Entity)
        {
            context.Entry<Product>(Entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await context.SaveChangesAsync();
            return Entity;
        }
    }
}
