using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepatrmentAndEmployeeLibrary
{
    public class DepatrmentAndEmployee
    {
        public DepatrmentAndEmployee()
        {
            EmployeeInfoList = new List<EmployeeInfo>();
            DepartmentInfoList = new List<DepartmentInfo>();
        }

        public class EmployeeInfo
        {
            public long Id { get; set; }
            public long DepartmentId { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Email { get; set; }
            public long PhoneNumber { get; set; }
            public DateTime HasBeenWorkSince { get; set; }
        }
        public List<EmployeeInfo> EmployeeInfoList;
        public class DepartmentInfo
        {
            public long Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
            public long PhoneNumber { get; set; }
            public DateTime DateOfCreationDepartment { get; set; }
        }
        public List<DepartmentInfo> DepartmentInfoList;
    }
}
