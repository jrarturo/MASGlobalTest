using MASGlobal.BusinessLogic;
using MASGlobal.Entities.DTOs;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MASGlobalTest.Controllers.Api
{
    [Route("api/Employees")]
    [EnableCors(origins: "http://localhost:51694", headers: "*", methods: "*")]
    public class EmployeeController: ApiController
    {
        public IEnumerable<EmployeeDTO> Get()
        {
            EmployeeBL employeeBL = new EmployeeBL();
            IEnumerable<EmployeeDTO> employees = employeeBL.GetEmployees();
            return employees;
        }
        public EmployeeDTO Get(int id)
        {
            EmployeeBL employeeBL = new EmployeeBL();
            var employee = employeeBL.GetEmployeeById(id);
            return employee;
        }
    }
}