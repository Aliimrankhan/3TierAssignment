using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services.Contract
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllStudents();
        void Insert(Student model);
        Task<Student> Update(Student model);
    }
}
