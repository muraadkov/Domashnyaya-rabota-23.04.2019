using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork_23._04._2019
{
    public class BuyProductsShop
    {
        Products products = new Products();
        public void BuyProducts(User user, ShoppingBasket shoppingBasket)
        {
            int i = 1;
            using (var context = new ShopContext())
            {
                Console.WriteLine("Наш магазин: ");
                foreach(var s in context.Products.ToList())
                {
                    Console.WriteLine($"{i++}.{s.Name}    -    {s.Price}");
                }
                Console.WriteLine("Что вы хотите взять?");
                string buyProduct = Console.ReadLine();
                var result = context.Products.ToList().Where(x => x.Name == buyProduct);

                Console.WriteLine("В каком количестве?");
                int countOfBuyProduct = int.Parse(Console.ReadLine());
                shoppingBasket.Count = countOfBuyProduct;
                foreach (var s in result)
                {
                    shoppingBasket.Name = s.Name;
                    shoppingBasket.Price = s.Price * countOfBuyProduct;
                }
                context.ShoppingBaskets.Add(shoppingBasket);
                user.ShoppingBasket = shoppingBasket;
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
