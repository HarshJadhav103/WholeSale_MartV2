using Mart.DataAccess.Repository.IRepository;
using Mart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mart.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(x=>x.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.ProductNumber = obj.ProductNumber;
                objFromDb.ProductNumber = obj.ProductNumber;
                objFromDb.OriginalPrice = obj.OriginalPrice;
                objFromDb.Price = obj.Price;
                objFromDb.Price25 = obj.Price25;
                objFromDb.Description = obj.Description;
                objFromDb.Price10 = obj.Price10;
                objFromDb.CategoryId = obj.CategoryId;
                objFromDb.VedorName = obj.VedorName;
                if(obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
