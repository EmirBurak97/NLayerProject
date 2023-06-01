using Example.DataAccess.Abstract;
using Example.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Example.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {


        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }


        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    ProductId=1,
                    ProductName="Vegan Burger",
                    CategoryId=1,
                    UnitPrice=50,
                    UnitsInStock=15,
                }
            };
            return products;
        }


        void IEntityRepository<Product>.Add(Product entity)
        {
            throw new NotImplementedException();
        }

        void IEntityRepository<Product>.Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        void IEntityRepository<Product>.Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
