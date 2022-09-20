﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantMVCApplication.Models;

namespace RestaurantMVCApplication.Repositories
{
    public class ItemRepository
    {
        private readonly Model1 restaurantDBEntities;
        public ItemRepository()
        {
            restaurantDBEntities = new Model1();
        }

        public IEnumerable<SelectListItem> GetAllItems()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (
                                    from obj in restaurantDBEntities.Items
                                    select new SelectListItem
                                    {
                                        Text = obj.ItemName,
                                        Value = obj.ItemId.ToString(),
                                        Selected = true
                                    }
                                ).ToList();

            return objSelectListItems;
        }
    }
}