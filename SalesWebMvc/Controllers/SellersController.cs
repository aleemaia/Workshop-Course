using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers {
    public class SellersController : Controller {

        private readonly SellerService _sellerService;

        public SellersController(SellerService sellersService) {
            _sellerService = sellersService;
        }
        public IActionResult Index() {
            var list = _sellerService.FindaAll();
            return View(list);
        }
    }
}
