using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork_23._04._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login();
            Registration registration = new Registration();
            User user = new User();
            ShoppingBasket shoppingBasket = new ShoppingBasket();
            InitProducts initProducts = new InitProducts();
            BuyProductsShop buyProducts = new BuyProductsShop();

            using(var context = new ShopContext())
            {
                initProducts.AddProductsToDB();
                Console.WriteLine("1 - Вход" + 
                    "\n2 - Регистрация");
                if(int.TryParse(Console.ReadLine(), out int result))
                {
                    switch (result)
                    {
                        case 1:
                            login.UserLogin(user);


                            break;
                        case 2:
                            registration.RegistrationUser(user);
                            registration.SendSms(user);
                            buyProducts.BuyProducts(user, shoppingBasket);
                            context.SaveChanges();
                            break;
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
