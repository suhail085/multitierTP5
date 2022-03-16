using System;
using System.Collections.Generic;
using CommanLayer.Models;
using DataAccessLayer;

namespace BussinessLayer
{
    public class BLEmployeesBussiness
    {
        private EmployeeDataAccessDb employeeData;
        public BLEmployeesBussiness()
        {
            employeeData = new EmployeeDataAccessDb();
        }
            public List<Employess> GetEmployees()
        {
            return employeeData.GetEmployees();
        }

    } 
    
}
