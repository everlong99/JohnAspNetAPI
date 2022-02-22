using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteJoaoLib.Model;

namespace TesteJoaoLib.DAL
{
    public interface IBlogRepository: IBaseRepository<Blog>
    {

    }


    public class BlogRepository: BaseRepository<Blog>, IBlogRepository
    {
        public BlogRepository(TesteJoaoContext context) : base(context)
        {
        }
    }
}
