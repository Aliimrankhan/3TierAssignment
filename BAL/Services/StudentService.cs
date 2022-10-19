using BAL.Services.Contract;
using DAL.Models;
using DAL.Repos.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services
{
    public class StudentService : IStudentService
    {
        private readonly IGenericRepository<Student> _repository;
        private readonly DAL.Context.DataContext _dbcontext;
        public StudentService(IGenericRepository<Student> repository, DAL.Context.DataContext dbcontext)
        {
            _repository = repository;
        }
        public async Task<List<Student>> GetAllStudents()
        {
            try
            {
                return await _repository.GetAll();
            }
            catch
            {
                throw;
            }
        }

        public void Insert(Student model)
        {
            _dbcontext.Students.Add(model);
        }

        public async Task<Student> Update(Student model)
        {
            _dbcontext.Students.Update(model);
            await _dbcontext.SaveChangesAsync();
            return await _dbcontext.Students.FirstOrDefaultAsync(x => x.Id == model.Id);
        }
    }
}
