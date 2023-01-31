using MediatR;

namespace CqrsMediatr.Queries
{
	public class GetBookByIdQuery : IRequest
	{
		public int Id { get; set; }
	}
}
