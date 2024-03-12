﻿namespace OrdersApp
{
    public class DataStorage
    {
        private static List<Order> _orders;

        public DataStorage()
        {
            _orders = new List<Order>()
            {
                new Order{Id = 1, Name = "HP Elitebook", Description = "Pc number 1 to users", Price = 3300.12 },
                new Order{Id = 2, Name = "HP Probook", Description = "Pc number 2 to users", Price = 4400.00 },
                new Order{Id = 3, Name = "HP NoteBook", Description = "Pc number 3 to users", Price = 2600.24 },
                new Order{Id = 4, Name = "HP Pavilion", Description = "Pc number 4 to users", Price = 6500.00 }
            };
        }

        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            return await Task.FromResult(_orders);
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await Task.FromResult(_orders.Single(o => o.Id == id));
        }
    }
}
