using EmployeeDetailsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeDetailsDemo.Controllers
{
    public class DepartmentsController : ApiController
    {
        public static List<Department> Department;
        public DepartmentsController()
        {
            Department = new List<Department>() {
                new Department{ ID = 1,
                                DepartmentName = "Computer Science",
                                EmployeeDetails = new List<EmployeeDetails>{
                                                new EmployeeDetails{ Employee_ID = 1, EmployeeName = "Clay Jensen"},
                                                new EmployeeDetails{ Employee_ID = 2, EmployeeName = "Hannah Baker"}
                                                            }
                },
                new Department{ ID = 2,
                                DepartmentName = "Political Science",
                                EmployeeDetails = new List<EmployeeDetails>{
                                                new EmployeeDetails{ Employee_ID = 3, EmployeeName = "Michael"},
                                                new EmployeeDetails{ Employee_ID = 4, EmployeeName = "Sarah"}
                                                            }
                }
            };
        }
        [HttpGet]
        public List<Department> GetAllDepartments()
        {
            return Department;
        }
    }
}
