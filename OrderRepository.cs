using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantMVCApplication.Models;
using RestaurantMVCApplication.ViewModel;

namespace RestaurantMVCApplication.Repositories
{
    public class OrderRepository
    {
        private readonly Model1 restaurantDBEntities;
        public OrderRepository()
        {
            restaurantDBEntities = new Model1();
        }

        public bool AddOrder(OrderViewModel orderViewModel)
        {
            try
            {
                Order objOrder = new Order()
                {
                    CustomerId = orderViewModel.CustomerId,
                    FinalTotal = orderViewModel.FinalTotal,
                    OrderDate = orderViewModel.OrderDate,
                    OrderNumber = String.Format("{0:ddmmyyyyhhmmss}", DateTime.Now),
                    PaymentTypeId = orderViewModel.PaymentTypeId,
                };
                restaurantDBEntities.Orders.Add(objOrder);
                restaurantDBEntities.SaveChanges();

                foreach (var item in orderViewModel.listOrderDetailViewModel)
                {
                    var objOrderDetails = new OrderDetail()
                    {
                        Discount = item.Discount,
                        ItemId = item.ItemId,
                        Quantity = item.Quantity,
                        OrderId = objOrder.OrderId,
                        Total = item.Total,
                        UnitPrice = item.UnitPrice
                    };
                    restaurantDBEntities.OrderDetails.Add(objOrderDetails);
                    restaurantDBEntities.SaveChanges();

                    Transaction objTransaction = new Transaction()
                    {
                        ItemId = item.ItemId,
                        Quantity = (-1) * item.Quantity,
                        TranactionDate = orderViewModel.OrderDate,
                        TypeId = 2
                    };
                    restaurantDBEntities.Transactions.Add(objTransaction);
                    restaurantDBEntities.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}