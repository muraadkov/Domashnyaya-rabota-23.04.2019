using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork_23._04._2019
{
    public class InitProducts
    {
        public void AddProductsToDB()
        {
            using(var context = new ShopContext()) {
                Products product = new Products()
                {
                    Name = "Пельмени",
                    Price = 1000
                };
                Products product2 = new Products()
                {
                    Name = "Хлеб",
                    Price = 500,
                };
                Products product3 = new Products()
                {
                    Name = "Кетчуп",
                    Price = 200
                };
                context.Products.AddRange(new List<Products> { product, product2, product3 });
            }

        }
      
    }
}
