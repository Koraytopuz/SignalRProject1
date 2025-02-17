using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public string TProcutNamePriceByMaxPrice()
        {
           return _productDal.ProcutNamePriceByMaxPrice();
        }

        public string TProcutNamePriceByMinPrice()
        {
            return _productDal.ProcutNamePriceByMinPrice();
        }

        public void TAdd(Product entity)
        {
            _productDal.add(entity);
        }

        public void TDelete(Product entity)
        {
            _productDal.delete(entity);
        }

        public Product TGetByID(int id)
        {
            return _productDal.GetByID(id);
        }

        public List<Product> TGetListAll()
        {
            return _productDal.GetListAll();
        }

        public List<Product> TGetProductsWithCategories()
        {
            return _productDal.GetProductsWithCategories();
        }

        public int TProductCount()
        {
            return _productDal.ProductCount();
        }

        public int TProductCountByCategoryNameDrink()
        {
            return _productDal.ProductCountByCategoryNameDrink();
        }

        public int TProductCountByCategoryNameHamburger()
        {
            return _productDal.ProductCountByCategoryNameHamburger();
        }

        public decimal TProductPriceAvg()
        {
           return _productDal.ProductPriceAvg();
        }

        public void TUpdate(Product entity)
        {
            _productDal.update(entity);
        }

        public decimal TProductAvgPriceByHamburger()
        {
           return _productDal.ProductAvgPriceByHamburger();    
        }
    }
}
