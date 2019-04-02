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

        public bool AddEmployee(long department_id, string name, string surname, string email, long phone_number)
        {
            Reader();
            try
            {
                long id;
                if (EmployeeInfoList.Count == 0)
                {
                    id = 100000000;
                }
                else
                {
                    id = EmployeeInfoList[EmployeeInfoList.Count - 1].Id + 1;
                }
                DateTime has_been_work_since = DateTime.Today;
                EmployeeInfoList.Add(new EmployeeInfo
                {
                    Id = id,
                    DepartmentId = department_id,
                    Name = name,
                    Surname = surname,
                    Email = email,
                    PhoneNumber = phone_number,
                    HasBeenWorkSince = has_been_work_since
                });
                Writer();
                return true;
            }
            catch
            {
                Writer();
                return false;
            }
        }
        public bool DeleteEmployee(long id)
        {
            Reader();
            foreach (EmployeeInfo employee in EmployeeInfoList)
            {
                if (employee.Id == id)
                {
                    EmployeeInfoList.Remove(employee);
                    Writer();
                    return true;
                }
            }
            Writer();
            return false;
        }
        public bool DeleteEmployee(string name, string surname)
        {
            Reader();
            foreach (EmployeeInfo employee in EmployeeInfoList)
            {
                if (employee.Name == name && employee.Surname == surname)
                {
                    EmployeeInfoList.Remove(employee);
                    Writer();
                    return true;
                }
            }
            Writer();
            return false;
        }
        private bool DeleteByDepartmentIdEmployee(long id)
        {

            for (int i = 0; i < EmployeeInfoList.Count; i++)
            {
                if (EmployeeInfoList[i].DepartmentId == id)
                {
                    EmployeeInfoList.Remove(EmployeeInfoList[i]);
                    i--; ;
                }
            }
            return true;
        }
        public bool ClearEmployee()
        {
            Reader();
            EmployeeInfoList.Clear();
            Writer();
            return true;
        }
        public string GetInfoEmployee()
        {
            Reader();

            string info = "EmployeeInfoList\n\n";
            foreach (EmployeeInfo employee in EmployeeInfoList)
            {
                info += "Id: " + employee.Id + "\n";
                info += "Name: " + employee.Name + "\n";
                info += "Surname: " + employee.Surname + "\n";
                //info += "DepartmentName: " + GetNameDepartment(employee.DepartmentId) + "\n";
                info += "DepartmentId: " + employee.DepartmentId + "\n";
                info += "Email: " + employee.Email + "\n";
                info += "PhoneNumber: " + employee.PhoneNumber + "\n";
                info += "HasBeenWorkSince: " + employee.HasBeenWorkSince + "\n";
                info += "\n";
            }
            return info;
        }
        public bool ChangeNameEmployee(long id, string name)
        {
            Reader();
            foreach (EmployeeInfo employee in EmployeeInfoList)
            {
                if (employee.Id == id)
                {
                    employee.Name = name;
                    Writer();
                    return true;
                }
            }
            Writer();
            return false;
        }
        public bool ChangeSurnameEmployee(long id, string surname)
        {
            Reader();
            foreach (EmployeeInfo employee in EmployeeInfoList)
            {
                if (employee.Id == id)
                {
                    employee.Surname = surname;
                    Writer();
                    return true;
                }
            }
            Writer();
            return false;
        }
        public bool ChangeEmailEmployee(long id, string email)
        {
            Reader();
            foreach (EmployeeInfo employee in EmployeeInfoList)
            {
                if (employee.Id == id)
                {
                    employee.Email = email;
                    Writer();
                    return true;
                }
            }
            Writer();
            return false;
        }
        public bool ChangePhoneNumberEmployee(long id, long phonenumber)
        {
            Reader();
            foreach (EmployeeInfo employee in EmployeeInfoList)
            {
                if (employee.Id == id)
                {
                    employee.PhoneNumber = phonenumber;
                    Writer();
                    return true;
                }
            }
            Writer();
            return false;
        }
        public bool ChangeDepartmenIdEmployee(long id, long departmenId)
        {
            Reader();
            foreach (EmployeeInfo employee in EmployeeInfoList)
            {
                if (employee.Id == id)
                {
                    employee.DepartmentId = departmenId;
                    Writer();
                    return true;
                }
            }
            Writer();
            return false;
        }
        public bool ChangeNameEmployee(string surname, string name, string newname)
        {
            Reader();
            foreach (EmployeeInfo employee in EmployeeInfoList)
            {
                if (employee.Surname == surname && employee.Name == name)
                {
                    employee.Name = newname;
                    Writer();
                    return true;
                }
            }
            Writer();
            return false;
        }
        public bool ChangeSurnameEmployee(string surname, string name, string newsurname)
        {
            Reader();
            foreach (EmployeeInfo employee in EmployeeInfoList)
            {
                if (employee.Surname == surname && employee.Name == name)
                {
                    employee.Surname = newsurname;
                    Writer();
                    return true;
                }
            }
            Writer();
            return false;
        }
        public bool ChangeEmailEmployee(string surname, string name, string email)
        {
            Reader();
            foreach (EmployeeInfo employee in EmployeeInfoList)
            {
                if (employee.Surname == surname && employee.Name == name)
                {
                    employee.Email = email;
                    Writer();
                    return true;
                }
            }
            Writer();
            return false;
        }
        public bool ChangePhoneNumberEmployee(string surname, string name, long phonenumber)
        {
            Reader();
            foreach (EmployeeInfo employee in EmployeeInfoList)
            {
                if (employee.Surname == surname && employee.Name == name)
                {
                    employee.PhoneNumber = phonenumber;
                    Writer();
                    return true;
                }
            }
            Writer();
            return false;
        }
        public bool ChangeDepartmenIdEmployee(string surname, string name, long departmenId)
        {
            Reader();
            foreach (EmployeeInfo employee in EmployeeInfoList)
            {
                if (employee.Surname == surname && employee.Name == name)
                {
                    employee.DepartmentId = departmenId;
                    Writer();
                    return true;
                }
            }
            Writer();
            return false;
        }

       

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
