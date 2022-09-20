using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantMVCApplication.Models;

namespace RestaurantMVCApplication.Repositories
{
    public class PaymentTypeRepository
    {
        private readonly Model1 restaurantDBEntities;
        public PaymentTypeRepository()
        {
            restaurantDBEntities = new Model1();
        }

        public IEnumerable<SelectListItem> GetAllPaymentType()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (
                                    from obj in restaurantDBEntities.PaymentTypes
                                    select new SelectListItem
                                    {
                                        Text = obj.PaymentTypeName,
                                        Value = obj.PaymentTypeId.ToString(),
                                        Selected = true
                                    }
                                ).ToList();

            return objSelectListItems;
        }
    }
}