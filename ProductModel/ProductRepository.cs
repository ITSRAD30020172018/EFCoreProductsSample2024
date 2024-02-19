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
            return context.Products;
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
    }
}
