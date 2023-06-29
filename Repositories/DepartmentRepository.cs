using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDWS.DbContexts;
using APIDWS.IRepositories;
using APIDWS.Models;

namespace APIDWS.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly DWSDBContext _context;

        public DepartmentRepository(DWSDBContext context)
        {
            this._context = context;
        }

        public async Task<Department> CreateDepartment(Department department)
        {
            department.Code = "DEP" + department.Name;
            _context.Departments.Add(department);
            await _context.SaveChangesAsync();
            return department;
        }

        public async Task<Department> DeleteDepartment(Department department)
        {
            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();
            return department;
        }

        public List<Department> GetAllDepartments()
        {
            return _context.Departments.ToList();
        }

        public Department GetDepartmentById(int id)
        {
            return _context.Departments.FirstOrDefault(department => department.Id == id);
        }

        public Department GetDepartmentByCode(string code)
        {
            return _context.Departments.FirstOrDefault(department => department.Code == code);
        }

        public async Task<Department> UpdateDepartment(Department department)
        {
            _context.Departments.Update(department);
            await _context.SaveChangesAsync();
            return department;
        }

    }
}