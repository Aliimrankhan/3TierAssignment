using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Contracts
{
    public interface IGenericRepository<TModel> where TModel : class
    {
        Task<List<TModel>> GetAll();
    }
}
