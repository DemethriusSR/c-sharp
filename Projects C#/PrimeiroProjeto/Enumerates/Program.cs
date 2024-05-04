using Enumerates.Entities;
using Enumerates.Entities.Enums;

using System;
/* Utilizando Enum para mostrar status */
namespace Enumerates
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Order order = new Order
                {
                    Id = 1080,
                    Moment = DateTime.Now,
                    Status = OrderStatus.PendingPayment
                };

                Console.WriteLine(order);

                string txt = OrderStatus.PendingPayment.ToString();

                Console.WriteLine(txt);

                OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
                Console.WriteLine(os);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}