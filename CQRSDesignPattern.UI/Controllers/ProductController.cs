using CQRSDesignPattern.UI.CQRS.Handlers;
using CQRSDesignPattern.UI.CQRS.Queries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDesignPattern.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductProducerQueryHandler _getProductProducerQueryHandler;

        public ProductController(GetProductProducerQueryHandler getProductProducerQueryHandler)
        {
            _getProductProducerQueryHandler = getProductProducerQueryHandler;
        }

        public IActionResult Index()
        {
            var value = _getProductProducerQueryHandler.Handle(new GetProductProducerQuery());
            return View(value);
        }
    }
}
