﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Custom_Model_Binding.Models;

namespace Custom_Model_Binding.CustomBinders
{
    public class CustomDataBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var request = controllerContext.HttpContext.Request;
            string title = request.Form.Get("title");
            string day = request.Form.Get("day");
            string month = request.Form.Get("month");
            string year = request.Form.Get("year");

            return new CustomModel
            {
                Title = title,
                Date = day + "/" + month + "/" + year
            };
        }
    }
}