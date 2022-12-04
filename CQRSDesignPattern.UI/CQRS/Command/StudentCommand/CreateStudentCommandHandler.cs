using CQRSDesignPattern.UI.DAL.Concrete;
using CQRSDesignPattern.UI.DAL.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSDesignPattern.UI.CQRS.Command.StudentCommand
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand>
    {
        private readonly Context _context;

        public CreateStudentCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            await _context.Students.AddAsync(new Student
            {
                Name = request.Name,
                Surname = request.Surname,
                Status = true

            });
            await _context.SaveChangesAsync();
            return Unit.Value;

        }
    }
}
