using MediatR;

namespace CqrsMediatr.Queries;
public class GetBookByIdHandler
{
	private readonly BookRepositories repositories;

	public GetBookByIdHandler(BookRepositories repositories)
	{
		this.repositories = repositories;
	}

	public async Task<Tuple<int, string>> Handle(GetBookByIdQuery query)
	{
		var k = repositories.Books.FirstOrDefault(q => q.Key == query.Id);
		var tuple = new Tuple<int, string>(k.Key, k.Value);
		return tuple;
	}



}


