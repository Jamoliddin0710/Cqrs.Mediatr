using MediatR;

namespace CqrsMediatr.Commands
{
	public class UpdateBookCommand : IRequest
	{
		public int Id { get; set; }
		public string? Name { get; set; }
	}
}
