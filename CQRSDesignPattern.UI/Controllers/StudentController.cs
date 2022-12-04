using CQRSDesignPattern.UI.CQRS.Command.StudentCommand;
using CQRSDesignPattern.UI.CQRS.Queries.StudentQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDesignPattern.UI.Controllers
{
    public class StudentController : Controller
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllStudentQuery());
            return View(values);
        }

        public async Task<IActionResult> GetStudent(int id)
        {
            var values = await _mediator.Send(new GetStudentByIDQuery(id));
            return View(values);
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddStudent(CreateStudentCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
    }
}
