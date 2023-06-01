using Example.Business.Abstract;
using Example.Business.ValidationRules.FluentValidation;
using Example.DataAccess.Abstract;
using Example.DataAccess.Concrete;
using Example.DataAccess.Concrete.EntityFramework;
using Example.Entities.Concrete;
//using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {

            //Validator codes
            //ProductValidator productValidator = new ProductValidator();
            //var result= productValidator.Validate(product);
            //if (result.Errors.Count>0)
            //{
            //    throw new ValidationException(result.Errors);
            //}
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p=>p.CategoryId==categoryId);
        }

        public List<Product> GetProductsByName(string productName)
        {
            return _productDal.GetAll(p=>p.ProductName.Contains(productName));
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
