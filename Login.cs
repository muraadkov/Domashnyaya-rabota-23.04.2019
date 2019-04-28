using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork_23._04._2019
{
    public class Login
    {
        public void UserLogin(User user)
        {
            Registration registration = new Registration();
            using(var context = new ShopContext())
            {
                Console.WriteLine("Введите логин: ");
                string login = Console.ReadLine();
                Console.WriteLine("Введите пароль: ");
                string password = registration.ReadPassword();
                foreach(var s in context.Users.ToList()) {
                if(s.UserName == login & s.Password == password)
                    {
                        Console.WriteLine("Добро пожаловать в наш магазин!");
                        Console.WriteLine("Ваша корзина: ");
                        Console.WriteLine(s.ShoppingBasket.Name);
                    }
                }
            }
        }
    }
}
