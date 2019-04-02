using System;
using System.Collections.Generic;
using System.IO;
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



        public void Writer()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("Info.dat", FileMode.Create)))
            {
                foreach (EmployeeInfo employee in EmployeeInfoList)
                {

                    writer.Write(1);
                    writer.Write(employee.Id);
                    writer.Write(employee.DepartmentId);
                    writer.Write(employee.Name);
                    writer.Write(employee.Surname);
                    writer.Write(employee.Email);
                    writer.Write(employee.PhoneNumber);
                    writer.Write(Convert.ToString(employee.HasBeenWorkSince.Date));
                }
                EmployeeInfoList.Clear();
                foreach (DepartmentInfo department in DepartmentInfoList)
                {

                    writer.Write(2);
                    writer.Write(department.Id);
                    writer.Write(department.Name);
                    writer.Write(department.Email);
                    writer.Write(department.Address);
                    writer.Write(department.PhoneNumber);
                    writer.Write(Convert.ToString(department.DateOfCreationDepartment.Date));
                }
                DepartmentInfoList.Clear();
            }
        }
        public void Reader()
        {
            using (BinaryReader reader = new BinaryReader(File.Open("Info.dat", FileMode.OpenOrCreate)))
            {
                while (reader.PeekChar() > -1)
                {
                    int type = reader.ReadInt32();
                    if (type != 1 && type != 2)
                    {
                        return;
                    }


                    if (type == 1)
                    {

                        EmployeeInfoList.Add(new EmployeeInfo
                        {
                            Id = reader.ReadInt64(),
                            DepartmentId = reader.ReadInt64(),
                            Name = reader.ReadString(),
                            Surname = reader.ReadString(),
                            Email = reader.ReadString(),
                            PhoneNumber = reader.ReadInt64(),
                            HasBeenWorkSince = Convert.ToDateTime(reader.ReadString())
                        });
                    }
                    if (type == 2)
                    {

                        DepartmentInfoList.Add(new DepartmentInfo
                        {
                            Id = reader.ReadInt64(),
                            Name = reader.ReadString(),
                            Email = reader.ReadString(),
                            Address = reader.ReadString(),
                            PhoneNumber = reader.ReadInt64(),
                            DateOfCreationDepartment = Convert.ToDateTime(reader.ReadString())
                        });
                    }

                }
            }
        }
    }
}
