using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantMVCApplication.Models;

namespace RestaurantMVCApplication.Repositories
{
    public class CustomerRepository
    {
        private readonly Model1 restaurantDBEntities;
        public CustomerRepository()
        {
            restaurantDBEntities = new Model1();
        }

        public IEnumerable<SelectListItem> GetAllCustomers()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (
                                    from obj in restaurantDBEntities.Customers
                                    select new SelectListItem
                                    {
                                        Text = obj.CustomerName,
                                       
                                        
                                        Value = obj.CustomerId.ToString(),

                                        Selected = true
                                    }
                                ).ToList();

            return objSelectListItems;
        }
    }
}