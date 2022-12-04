using CQRSDesignPattern.UI.CQRS.Queries.StudentQueries;
using CQRSDesignPattern.UI.CQRS.Results.StudentResult;
using CQRSDesignPattern.UI.DAL.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSDesignPattern.UI.CQRS.Handlers.StudentHandlers
{
    public class GetStudentByIDQueryHandler : IRequestHandler<GetStudentByIDQuery, GetStudentByIDQueryResult>
    {
        private readonly Context _context;

        public GetStudentByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetStudentByIDQueryResult> Handle(GetStudentByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Students.FindAsync(request.Id);
            return new GetStudentByIDQueryResult
            {
                StudentID = values.StudentID,
                Surname = values.Surname,
                Name = values.Name,
                Mail = values.Mail
            };
        }
    }
}
