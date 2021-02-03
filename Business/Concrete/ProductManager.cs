using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
                
        public List<Product> GetAll()
        {

            //iş kodları
            return _productDal.GetAll();    
        }

        public List<Product> GetAllCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }
        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(P => P.UnitPrice <= min && P.UnitPrice <= max);
        }
    }
}
