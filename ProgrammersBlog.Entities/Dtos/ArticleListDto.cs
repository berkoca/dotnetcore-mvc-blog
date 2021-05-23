using System.Collections;
using System.Collections.Generic;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Entities.Abstract;
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;

namespace ProgrammersBlog.Entities.Dtos
{
    public class ArticleListDto : DtoGetBase
    {
        public IList<Article> Articles { get; set; }
    }
}