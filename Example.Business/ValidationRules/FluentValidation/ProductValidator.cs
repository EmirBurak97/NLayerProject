using Example.Entities.Concrete;
//using FluentValidation; Validator library
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Business.ValidationRules.FluentValidation
{
    public class ProductValidator//:AbstractValidator<Product> FluentValidator method
    {
        public ProductValidator()
        {

            //ValidatorRules
            //RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün ismi boş olamaz.");
            //RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Ürün kategorisi boş olamaz.");
            //RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Ürün fiyatı boş olamaz.");
            //RuleFor(p => p.UnitsInStock).NotEmpty().WithMessage("Ürün stoğu boş olamaz.");

            //RuleFor(p => p.UnitPrice).GreaterThan(0);
            //RuleFor(p => p.UnitPrice).GreaterThan(15).When(p => p.CategoryId != 8);
        }
    }
}
