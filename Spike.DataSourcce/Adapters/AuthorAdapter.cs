
namespace Spike.DataSource.Adapters
{
    using Base;
    using Entities;

    public class AuthorAdapter : AdapterBase
    {
        public AuthorAdapter(DataContext context = null) : base(context) {}

        public AuthorEntity AddAuthor(AuthorEntity author)
        {
            return AddEntity(Context.Authors, author);
        }

        
    }
}
