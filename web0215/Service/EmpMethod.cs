using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web0215.Models;

namespace web0215.Service
{
    public class EmpMethod
    {
        /// <summary>
        /// 取得員工列表
        /// </summary>
        /// <returns>List of employees</returns>
        public List<EmployeeModel> GetEmployeeModels()
        {
            List < EmployeeModel > employeeModels= new List < EmployeeModel >();
            employeeModels.Add(new EmployeeModel() { EmpNo = "FG4466", Name = "CLH1", Ext = 1234 });
            employeeModels.Add(new EmployeeModel() { EmpNo = "FG4467", Name = "CLH2", Ext = 1234 });
            employeeModels.Add(new EmployeeModel() { EmpNo = "FG4468", Name = "CLH3", Ext = 1234 });
            employeeModels.Add(new EmployeeModel() { EmpNo = "FG4469", Name = "CLH4", Ext = 1234 });

            return employeeModels;
        }
    }
}