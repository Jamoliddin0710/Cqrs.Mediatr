using MediatR;

namespace CqrsMediatr.Queries
{
	public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, Dictionary<int, string>>
	{
		private readonly IMediator mediator;
		private readonly BookRepositories repositories;
		public GetAllBooksQueryHandler(IMediator mediator, BookRepositories repositories)
		{
			this.mediator = mediator;
			this.repositories = repositories;
		}

		public async Task<Dictionary<int, string>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
		{
			return repositories.Books;
		}
	}
}
