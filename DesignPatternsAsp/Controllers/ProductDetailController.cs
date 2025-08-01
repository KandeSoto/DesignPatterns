﻿using Microsoft.AspNetCore.Mvc;
using Tools.Earn;

namespace DesignPatternsAsp.Controllers
{     
    public class ProductDetailController : Controller
    {
        private readonly EarnFactory _localEarnFactory;
        private readonly ForeignEarnFactory _foreignEarnFactory;

        public ProductDetailController(LocalEarnFactory localEarnFactory, ForeignEarnFactory foreignEarnFactory)
        {
            _localEarnFactory = localEarnFactory;
            _foreignEarnFactory = foreignEarnFactory;
        }

        public IActionResult Index(decimal total)
        {
            //products
            var localEarn = _localEarnFactory.GetEarn();
            var foreignEarn = _foreignEarnFactory.GetEarn();

            //total
            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeign = total + foreignEarn.Earn(total);

            return View();
        }
    }
}
