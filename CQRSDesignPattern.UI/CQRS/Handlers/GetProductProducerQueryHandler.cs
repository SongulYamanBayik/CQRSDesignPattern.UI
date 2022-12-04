using CQRSDesignPattern.UI.CQRS.Queries;
using CQRSDesignPattern.UI.CQRS.Results;
using CQRSDesignPattern.UI.DAL.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDesignPattern.UI.CQRS.Handlers
{
    public class GetProductProducerQueryHandler
    {
        private readonly Context _context;

        public GetProductProducerQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetProductProducerQueryResult> Handle(GetProductProducerQuery query)
        {
            var values = _context.Products.Select(x => new GetProductProducerQueryResult
            {
                ProductID = x.ProductID,
                ProductName = x.ProductName,
                Status = x.Status,
                Storage = x.Storage
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
