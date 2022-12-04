using CQRSDesignPattern.UI.CQRS.Results.StudentResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDesignPattern.UI.CQRS.Queries.StudentQueries
{
    public class GetStudentByIDQuery:IRequest<GetStudentByIDQueryResult>
    {
        public GetStudentByIDQuery(int id)
        {
            Id=id;
        }

        public int Id { get; set; }
    }
}
