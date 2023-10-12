using FProject.DataAccess.Data;
using FProject.DataAccess.Repository.IRepository;
using FProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FProject.DataAccess.Repository
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
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Title = obj.Title;
                objFromDb.Description = obj.Description;
                objFromDb.Price = obj.Price;
                objFromDb.Price10 = obj.Price10;
                objFromDb.Price25 = obj.Price25;
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.Artist = obj.Artist;
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.Color = obj.Color;
                objFromDb.CategoryId = obj.CategoryId;
            }
        }

    }
}
