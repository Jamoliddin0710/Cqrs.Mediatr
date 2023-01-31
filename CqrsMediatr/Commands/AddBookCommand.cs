using MediatR;

namespace CqrsMediatr.Commands
{
	public class AddBookCommand : IRequest
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
}
