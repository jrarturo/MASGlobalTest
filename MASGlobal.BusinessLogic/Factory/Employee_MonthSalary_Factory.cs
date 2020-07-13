using MASGlobal.Entities.DTOs;

namespace MASGlobal.BusinessLogic.Factory
{
    class Employee_MonthlySalary_Factory : EmployeeDTOFactory
    {
        private double _monthlySalary;

        public Employee_MonthlySalary_Factory(double monthlySalary)
        {
            _monthlySalary = monthlySalary;
        }

        public override EmployeeDTO GetEmployeeDTO()
        {
            EmployeeDTO employeeDTO = new EmployeeDTO();
            employeeDTO.Salary = CalculateSalary();
            return employeeDTO;
        }

        internal double CalculateSalary()
        {
            return _monthlySalary * 12;
        }
    }
}
