using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDesignPattern.UI.CQRS.Command.StudentCommand
{
    public class CreateStudentCommand:IRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Status { get; set; }

    }
}
