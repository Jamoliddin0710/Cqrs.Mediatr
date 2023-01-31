using MediatR;

namespace CqrsMediatr.Commands;
public class AddBookCommandHandler : IRequestHandler<AddBookCommand>
{
	private readonly BookRepositories repositories;
	private readonly IMediator mediatr;
	public AddBookCommandHandler(BookRepositories repositories, IMediator mediatr)
	{
		this.repositories = repositories;
		this.mediatr = mediatr;
	}

	public Task<Unit> Handle(AddBookCommand request, CancellationToken cancellationToken)
	{
		repositories.Books.Add(request.Id, request.Name);
		return Unit.Task;
	}
}

