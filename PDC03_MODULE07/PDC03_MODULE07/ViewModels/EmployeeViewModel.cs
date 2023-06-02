using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using System.IO;
using PDC03_MODULE07.Models;

using System.Threading.Tasks;
using PDC03_MODULE07.Views;

namespace PDC03_MODULE07.ViewModels
{
    public class EmployeeViewModel
    {
        //Call Database

        private Services.DatabaseContext getContext()
        {
            return new Services.DatabaseContext();
        }

        // Insert Records

        public int InsertEmployee(EmployeeModel obj)
        {
            var _dbContext = getContext();
            _dbContext.Employee.Add(obj);
            int c = _dbContext.SaveChanges();
            return c;
        }

        public async Task<List<EmployeeModel>> GetAllEmployees()
        {
            var _dbContext = getContext();
            var res = await _dbContext.Employee.ToListAsync();
            return res;
        }

        public int DeleteEmployee(EmployeeModel obj)
        {
            var _dbContext = getContext();
            _dbContext.Employee.Remove(obj);
            int c = _dbContext.SaveChanges();
            return c;
        }

        public async Task<int> UpdateEmployee(EmployeeModel obj)
        {
            var _dbContext = getContext();
            _dbContext.Employee.Update(obj);
            int c = await _dbContext.SaveChangesAsync();
            return c;
        }

 

    }
}
