using MediatR;

namespace CqrsMediatr.Commands
{
	public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand>
	{
		private readonly IMediator mediator;
		private  BookRepositories repositories;

		public UpdateBookCommandHandler(BookRepositories repositories, IMediator mediator)
		{
			this.mediator = mediator;
			this.repositories = repositories;
		}

		public async Task<Unit> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
		{
			var book =  repositories.Books.FirstOrDefault(b => b.Key == request.Id);

			return Unit.Value;
		}
	}
}
