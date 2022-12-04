using CQRSDesignPattern.UI.CQRS.Results.StudentResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDesignPattern.UI.CQRS.Queries.StudentQueries
{
    public class GetAllStudentQuery:IRequest<List<GetAllStudentQueryResult>>
    {
    }
}
