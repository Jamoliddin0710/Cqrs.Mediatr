using MediatR;

namespace CqrsMediatr.Queries
{
	public class GetAllBooksQuery : IRequest<Dictionary<int, string>>
	{

	}
}
