using CqrsMediatr.Commands;
using CqrsMediatr.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CqrsMediatr.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BooksController : ControllerBase
	{
		private readonly IMediator _mediator;

		public BooksController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpPost]
		public async Task AddBook(int Id, string value)
		{
			var book = new AddBookCommand()
			{
				Id = Id,
				Name = value,
			};

			await _mediator.Send(book);
		}

		[HttpGet]
		public async Task<Dictionary<int, string>> GetAllBook()
		{
			var query = new GetAllBooksQuery();
			var data = await _mediator.Send(query);
			return data;
		}

		[HttpGet("getbyId")]
		public async Task UpdateTask(int Id, string value)
		{
			var query = new UpdateBookCommand()
			{
				Id = Id,
				Name = value,
			};
			await _mediator.Send(query);
		}
	}
}
