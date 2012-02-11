namespace TrelloNet
{
	public class Paging
	{
		public Paging(int limit, int page)
		{
			Limit = limit;
			Page = page;
		}

		public int Limit { get; private set; }
		public int Page { get; private set; }

		public bool IsDefault
		{
			get { return Limit == 50 && Page == 1; }
		}
	}
}