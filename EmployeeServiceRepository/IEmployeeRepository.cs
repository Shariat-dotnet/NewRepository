using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeServiceRepository
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeRepository" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeRepository
    {
        [OperationContract]
        List<Employee> GetEmployees();
        [OperationContract]
        Employee GetEmployee(int id);

        [OperationContract]
        Employee CreateEmployees( Employee employee);
        [OperationContract]
        Employee UpdateEmployees(Employee employee);
    }
}
