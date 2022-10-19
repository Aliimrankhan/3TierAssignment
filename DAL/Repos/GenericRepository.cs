using DAL.Context;
using DAL.Repos.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : class
    {

        private readonly DataContext _dbcontext;
        public GenericRepository(DataContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<TModel>> GetAll()
        {
            try
            {
                return await _dbcontext.Set<TModel>().ToListAsync();
            }
            catch
            {
                throw;
            }
        }

      
    }
}
