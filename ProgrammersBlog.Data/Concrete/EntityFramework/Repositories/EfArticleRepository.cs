using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Contexts
{
    public class EfArticleRepository : EfEntityRepositoryBase<Article>, IArticleRepository
    {
        public EfArticleRepository(DbContext context) : base(context)
        {

        }
    }
}