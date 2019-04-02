using DepatrmentAndEmployeeLibrary;
using System;

namespace Menu
{
    public class Menu
    {
        void print()
        {
            Console.Clear();
            Console.WriteLine("Enter 1 to add employee ");
            Console.WriteLine("Enter 2 to add department ");
            Console.WriteLine("Enter 3 to delete exactly employee ");
            Console.WriteLine("Enter 4 to delete exactly department ");
            Console.WriteLine("Enter 5 to delete all employees ");
            Console.WriteLine("Enter 6 to delete all departments ");
            //

            //
            Console.WriteLine("Enter 7 to edit employee ");
            Console.WriteLine("Enter 8 to edit department ");
            Console.WriteLine("Enter 9 to print all employee ");
            Console.WriteLine("Enter 10 to print all department ");
            Console.WriteLine("Enter 11 to exit ");

        }
        public Menu()
        {
            int choice = 0;
            while (choice != 11)
            {
                print();
                bool res = true;

                while (res)
                {
                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice > 0 && choice < 12)
                        {
                            res = false;
                        }
                        else
                        {
                            Console.WriteLine("Input error try again");

                            Console.ReadLine();
                            Console.Clear();
                            print();
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                        Console.Clear();
                        print();
                    }

                }

                if (choice == 1)
                {
                    Console.Clear();
                    DepatrmentAndEmployee DAE = new DepatrmentAndEmployee();

                    string name = "";
                    while (name == "")
                    {
                        Console.WriteLine("Enter name : ");
                        name = Console.ReadLine();
                    }

                    string surname = "";
                    while (surname == "")
                    {
                        Console.WriteLine("Enter surname : ");
                        surname = Console.ReadLine();
                    }


                    string email = "";
                    while (email == "")
                    {
                        Console.WriteLine("Enter email : ");
                        email = Console.ReadLine();
                    }



                    res = true;

                    long id = 0;
                    long phone_number = 0;
                    bool check_is_id_true = true;
                    bool go_back_to_menu = false;

                    DAE.Reader();


                    while (check_is_id_true)
                    {
                        try
                        {

                            Console.WriteLine("Enter departament id : ");
                            id = Convert.ToInt64(Console.ReadLine());

                            for (int i = 0; i < DAE.DepartmentInfoList.Count; i++)
                            {

                                if (DAE.DepartmentInfoList[i].Id == id)
                                {
                                    check_is_id_true = false;
                                }

                            }
                            if (check_is_id_true == true)
                            {
                                Console.WriteLine("Not such departament with this id ");
                                Console.WriteLine("Enter 1 if you want to exit to main menu or try to enter id one more time ");
                                int h = 0;
                                try
                                {
                                    h = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                if (h == 1)
                                {
                                    check_is_id_true = false;
                                    go_back_to_menu = true;
                                }
                            }


                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                    }
                    if (!go_back_to_menu)
                    {
                        while (res)
                        {
                            try
                            {
                                Console.WriteLine("Enter phone number : ");
                                phone_number = Convert.ToInt64(Console.ReadLine());
                                res = false;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }

                        DAE.Writer();
                        if (DAE.AddEmployee(id, name, surname, email, phone_number) == true)
                        {
                            Console.WriteLine("employee add successfully");
                        }
                        else
                        {
                            Console.WriteLine("Error when added employee");
                        }
                        Console.ReadLine();
                    }


                }
                else if (choice == 2)
                {
                    Console.Clear();
                    DepatrmentAndEmployee DAE = new DepatrmentAndEmployee();

                    string name = "";
                    while (name == "")
                    {
                        Console.WriteLine("Enter name : ");
                        name = Console.ReadLine();
                    }

                    string email = "";
                    while (email == "")
                    {
                        Console.WriteLine("Enter email : ");
                        email = Console.ReadLine();
                    }

                    string adress = "";
                    while (adress == "")
                    {
                        Console.WriteLine("Enter adress : ");
                        adress = Console.ReadLine();
                    }

                    long phone_number = 0;
                    res = true;
                    while (res)
                    {
                        try
                        {
                            Console.WriteLine("Enter phone number : ");
                            phone_number = Convert.ToInt64(Console.ReadLine());
                            res = false;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }


                    if (DAE.AddDepartment(name, email, adress, phone_number) == true)
                    {
                        Console.WriteLine("department add successfully");
                    }
                    else
                    {
                        Console.WriteLine("Error when added department");
                    }
                    Console.ReadLine();
                }
                else if (choice == 3)
                {
                    Console.Clear();
                    DepatrmentAndEmployee DAE = new DepatrmentAndEmployee();



                    int choice_delete = 0;
                    res = true;
                    while (res)
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Enter 1 if you want to find employee by id ");
                            Console.WriteLine("Enter 2 if you want to find employee by name and surname ");
                            Console.WriteLine("Enter 3 if you want go back to main menu ");
                            choice_delete = Convert.ToInt32(Console.ReadLine());
                            if (choice_delete > 0 && choice_delete < 4)
                            {
                                res = false;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }

                    if (choice_delete == 1)
                    {
                        long id = 0;
                        res = true;
                        while (res)
                        {
                            try
                            {
                                Console.WriteLine("Enter id : ");
                                id = Convert.ToInt64(Console.ReadLine());
                                res = false;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }


                        if (DAE.DeleteEmployee(id) == true)
                        {
                            Console.WriteLine("employee delete successfully");
                        }
                        else
                        {
                            Console.WriteLine("we couldnt find employee with such id");
                        }

                    }
                    else if (choice_delete == 2)
                    {
                        string name;
                        Console.WriteLine("Enter name : ");
                        name = Console.ReadLine();
                        string surname;
                        Console.WriteLine("Enter surname : ");
                        surname = Console.ReadLine();
                        if (DAE.DeleteEmployee(name, surname) == true)
                        {
                            Console.WriteLine("employee delete successfully");
                        }
                        else
                        {
                            Console.WriteLine("we couldnt find employee with such name and surname");
                        }
                    }
                    else if (choice_delete == 3)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Error try again ");
                    }
                    Console.ReadLine();

                }
                else if (choice == 4)
                {
                    Console.Clear();
                    DepatrmentAndEmployee DAE = new DepatrmentAndEmployee();

                    int choice_delete = 0;
                    res = true;
                    while (res)
                    {
                        try
                        {
                            Console.Clear();

                            Console.WriteLine("ALL EMPLOYEE OF THAT DEPARTMENT WILL DELETE TOO!!!!!");
                            Console.WriteLine("Enter 1 if you want to find departament by id ");
                            Console.WriteLine("Enter 2 if you want to find departament by name ");
                            Console.WriteLine("Enter 3 if you want go back to main menu ");
                            choice_delete = Convert.ToInt32(Console.ReadLine());
                            if (choice_delete > 0 && choice_delete < 4)
                            {
                                res = false;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    if (choice_delete == 1)
                    {
                        long id = 0;
                        res = true;
                        while (res)
                        {
                            try
                            {
                                Console.WriteLine("Enter id : ");
                                id = Convert.ToInt64(Console.ReadLine());
                                res = false;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        if (DAE.DeleteDepartment(id) == true)
                        {
                            Console.WriteLine("departmanet delete successfully");
                        }
                        else
                        {
                            Console.WriteLine("we couldnt find department with such id ");
                        }

                    }
                    else if (choice_delete == 2)
                    {
                        string name;
                        Console.WriteLine("Enter name : ");
                        name = Console.ReadLine();
                        if (DAE.DeleteDepartment(name) == true)
                        {
                            Console.WriteLine("departmanet delete successfully");
                        }
                        else
                        {
                            Console.WriteLine("we couldnt find department with such name ");
                        }
                    }
                    else if (choice_delete == 3)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Error try again ");
                    }
                    Console.ReadLine();
                }
                else if (choice == 5)
                {
                    Console.Clear();
                    DepatrmentAndEmployee DAE = new DepatrmentAndEmployee();

                    if (DAE.ClearEmployee() == true)
                    {
                        Console.WriteLine("successfully delete all employee ");
                    }
                    else
                    {
                        Console.WriteLine("Error when deleting all employees");
                    }
                    Console.ReadLine();
                }
                else if (choice == 6)
                {
                    Console.Clear();
                    DepatrmentAndEmployee DAE = new DepatrmentAndEmployee();

                    Console.WriteLine("ALL EMPLOYEE WILL DELETE TOO!!!!!");
                    if (DAE.ClearDepartment() == true)
                    {
                        Console.WriteLine("successfully delete all departaments ");
                    }
                    else
                    {
                        Console.WriteLine("Error when deleting all departaments");
                    }
                    Console.ReadLine();
                }


                else if (choice == 7)
                {
                    Console.Clear();
                    DepatrmentAndEmployee DAE = new DepatrmentAndEmployee();


                    int choice_change = 0;
                    res = true;
                    while (res)
                    {
                        try
                        {
                            Console.Clear();

                            Console.WriteLine("Enter 1 if you want change departament id of employee");
                            Console.WriteLine("Enter 2 if you want change email of employee");
                            Console.WriteLine("Enter 3 if you want change name of employee");
                            Console.WriteLine("Enter 4 if you want change surname of employee");
                            Console.WriteLine("Enter 5 if you want change phone number of employee");
                            Console.WriteLine("Enter 6 if you want go back to main menu");
                            choice_change = Convert.ToInt32(Console.ReadLine());
                            if (choice_change > 0 && choice_change < 7)
                            {
                                res = false;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }


                    if (choice_change == 1)
                    {



                        int choice_change1 = 0;
                        res = true;
                        while (res)
                        {
                            try
                            {
                                Console.Clear();
                                Console.WriteLine("Enter 1 if you want to find employee by id ");
                                Console.WriteLine("Enter 2 if you want to find employee by name and surname ");
                                Console.WriteLine("Enter 3 if you want go back to main menu ");
                                choice_change1 = Convert.ToInt32(Console.ReadLine());
                                if (choice_change1 > 0 && choice_change1 < 4)
                                {
                                    res = false;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }



                        if (choice_change1 == 1)
                        {
                            res = true;
                            long id = 0;
                            while (res)
                            {
                                try
                                {
                                    Console.WriteLine("Enter id ");

                                    id = Convert.ToInt64(Console.ReadLine());
                                    res = false;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }

                            }

                            res = true;
                            long did = 0;
                            while (res)
                            {
                                try
                                {
                                    Console.WriteLine("Enter new departament id ");

                                    did = Convert.ToInt64(Console.ReadLine());
                                    res = false;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }

                            }



                            if (DAE.ChangeDepartmenIdEmployee(id, did) == true)
                            {
                                Console.WriteLine("change successfull");
                            }
                            else
                            {
                                Console.WriteLine("Error when change departament id");
                            }
                        }
                        else if (choice_change1 == 2)
                        {
                            string name = "";
                            while (name == "")
                            {
                                Console.WriteLine("Enter name : ");
                                name = Console.ReadLine();
                            }

                            string surname = "";
                            while (surname == "")
                            {
                                Console.WriteLine("Enter surname : ");
                                surname = Console.ReadLine();
                            }
                            Console.WriteLine("Enter new  departament id ");
                            res = true;
                            long did = 0;
                            while (res)
                            {
                                try
                                {
                                    Console.WriteLine("Enter new departament id ");

                                    did = Convert.ToInt64(Console.ReadLine());
                                    res = false;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }

                            }
                            if (DAE.ChangeDepartmenIdEmployee(name, surname, did) == true)
                            {
                                Console.WriteLine("change successfull");
                            }
                            else
                            {
                                Console.WriteLine("Error when change departament id");
                            }
                        }
                        else if (choice_change1 == 3)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }

                    }
                    else if (choice_change == 2)
                    {
                        int choice_change1 = 0;
                        res = true;
                        while (res)
                        {
                            try
                            {
                                Console.Clear();
                                Console.WriteLine("Enter 1 if you want to find employee by id ");
                                Console.WriteLine("Enter 2 if you want to find employee by name and surname ");
                                Console.WriteLine("Enter 3 if you want go back to main menu ");
                                choice_change1 = Convert.ToInt32(Console.ReadLine());
                                if (choice_change1 > 0 && choice_change1 < 4)
                                {
                                    res = false;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        if (choice_change1 == 1)
                        {
                            res = true;
                            long id = 0;
                            while (res)
                            {
                                try
                                {
                                    Console.WriteLine("Enter id ");

                                    id = Convert.ToInt64(Console.ReadLine());
                                    res = false;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }

                            }
                            Console.WriteLine("Enter new email ");
                            string email = "";
                            while (email == "")
                            {
                                Console.WriteLine("Enter new email ");
                                email = Console.ReadLine();
                            }

                            if (DAE.ChangeEmailEmployee(id, email) == true)
                            {
                                Console.WriteLine("change successfull");
                            }
                            else
                            {
                                Console.WriteLine("Error when change email");
                            }
                        }
                        else if (choice_change1 == 2)
                        {
                            string name = "";
                            while (name == "")
                            {
                                Console.WriteLine("Enter name : ");
                                name = Console.ReadLine();
                            }

                            string surname = "";
                            {
                                Console.WriteLine("Enter surname : ");
                                surname = Console.ReadLine();
                            }
                            string email = "";
                            while (email == "")
                            {
                                Console.WriteLine("Enter new email ");

                                email = (Console.ReadLine());
                            }

                            if (DAE.ChangeEmailEmployee(name, surname, email) == true)
                            {
                                Console.WriteLine("change successfull");
                            }
                            else
                            {
                                Console.WriteLine("Error when change email");
                            }
                        }
                        else if (choice_change1 == 3)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                    else if (choice_change == 3)
                    {
                        int choice_change1 = 0;
                        res = true;
                        while (res)
                        {
                            try
                            {
                                Console.Clear();
                                Console.WriteLine("Enter 1 if you want to find employee by id ");
                                Console.WriteLine("Enter 2 if you want to find employee by name and surname ");
                                Console.WriteLine("Enter 3 if you want go back to main menu ");
                                choice_change1 = Convert.ToInt32(Console.ReadLine());
                                if (choice_change1 > 0 && choice_change1 < 4)
                                {
                                    res = false;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        if (choice_change1 == 1)
                        {
                            res = true;
                            long id = 0;
                            while (res)
                            {
                                try
                                {
                                    Console.WriteLine("Enter id ");

                                    id = Convert.ToInt64(Console.ReadLine());
                                    res = false;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }

                            }

                            string name = "";
                            while (name == "")
                            {
                                Console.WriteLine("Enter new name ");
                                name = (Console.ReadLine());
                            }

                            if (DAE.ChangeNameEmployee(id, name) == true)
                            {
                                Console.WriteLine("change successfull");
                            }
                            else
                            {
                                Console.WriteLine("Error when change name");
                            }
                        }
                        else if (choice_change1 == 2)
                        {
                            string name = "";
                            while (name == "")
                            {
                                Console.WriteLine("Enter name : ");
                                name = Console.ReadLine();
                            }

                            string surname = "";
                            {
                                Console.WriteLine("Enter surname : ");
                                surname = Console.ReadLine();
                            }
                            string newname = "";
                            while (newname == "")
                            {
                                Console.WriteLine("Enter new name : ");
                                newname = Console.ReadLine();
                            }
                            if (DAE.ChangeNameEmployee(name, surname, newname) == true)
                            {
                                Console.WriteLine("change successfull");
                            }
                            else
                            {
                                Console.WriteLine("Error when change name");
                            }
                        }
                        else if (choice_change1 == 3)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                    else if (choice_change == 4)
                    {
                        int choice_change1 = 0;
                        res = true;
                        while (res)
                        {
                            try
                            {
                                Console.Clear();
                                Console.WriteLine("Enter 1 if you want to find employee by id ");
                                Console.WriteLine("Enter 2 if you want to find employee by name and surname ");
                                Console.WriteLine("Enter 3 if you want go back to main menu ");
                                choice_change1 = Convert.ToInt32(Console.ReadLine());
                                if (choice_change1 > 0 && choice_change1 < 4)
                                {
                                    res = false;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        if (choice_change1 == 1)
                        {
                            res = true;
                            long id = 0;
                            while (res)
                            {
                                try
                                {
                                    Console.WriteLine("Enter id ");

                                    id = Convert.ToInt64(Console.ReadLine());
                                    res = false;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }

                            }

                            string surname = "";
                            while (surname == "")
                            {
                                Console.WriteLine("Enter new surname ");
                                surname = (Console.ReadLine());
                            }

                            if (DAE.ChangeSurnameEmployee(id, surname) == true)
                            {
                                Console.WriteLine("change successfull");
                            }
                            else
                            {
                                Console.WriteLine("Error when change surname");
                            }
                        }
                        else if (choice_change1 == 2)
                        {
                            string name = "";
                            while (name == "")
                            {
                                Console.WriteLine("Enter name : ");
                                name = Console.ReadLine();
                            }

                            string surname = "";
                            {
                                Console.WriteLine("Enter surname : ");
                                surname = Console.ReadLine();
                            }
                            string newsurname = "";
                            {
                                Console.WriteLine("Enter new surname : ");
                                newsurname = Console.ReadLine();
                            }
                            if (DAE.ChangeSurnameEmployee(name, surname, newsurname) == true)
                            {
                                Console.WriteLine("change successfull");
                            }
                            else
                            {
                                Console.WriteLine("Error when change name");
                            }
                        }
                        else if (choice_change1 == 3)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                    else if (choice_change == 5)
                    {
                        int choice_change1 = 0;
                        res = true;
                        while (res)
                        {
                            try
                            {
                                Console.Clear();
                                Console.WriteLine("Enter 1 if you want to find employee by id ");
                                Console.WriteLine("Enter 2 if you want to find employee by name and surname ");
                                Console.WriteLine("Enter 3 if you want go back to main menu ");
                                choice_change1 = Convert.ToInt32(Console.ReadLine());
                                if (choice_change1 > 0 && choice_change1 < 4)
                                {
                                    res = false;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        if (choice_change1 == 1)
                        {
                            res = true;
                            long id = 0;
                            while (res)
                            {
                                try
                                {
                                    Console.WriteLine("Enter id ");

                                    id = Convert.ToInt64(Console.ReadLine());
                                    res = false;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }

                            }
                            res = true;
                            long phone_number = 0;
                            while (res)
                            {
                                try
                                {
                                    Console.WriteLine("Enter new phone number ");

                                    phone_number = Convert.ToInt64((Console.ReadLine()));
                                    res = false;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }

                            if (DAE.ChangePhoneNumberEmployee(id, phone_number) == true)
                            {
                                Console.WriteLine("change successfull");
                            }
                            else
                            {
                                Console.WriteLine("Error when change surname");
                            }
                        }
                        else if (choice_change1 == 2)
                        {
                            string name = "";
                            while (name == "")
                            {
                                Console.WriteLine("Enter name : ");
                                name = Console.ReadLine();
                            }

                            string surname = "";
                            {
                                Console.WriteLine("Enter surname : ");
                                surname = Console.ReadLine();
                            }
                            res = true;
                            long phone_number = 0;
                            while (res)
                            {
                                try
                                {
                                    Console.WriteLine("Enter new phone number ");

                                    phone_number = Convert.ToInt64((Console.ReadLine()));
                                    res = false;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }
                            if (DAE.ChangePhoneNumberEmployee(name, surname, phone_number) == true)
                            {
                                Console.WriteLine("change successfull");
                            }
                            else
                            {
                                Console.WriteLine("Error when change name");
                            }
                        }
                        else if (choice_change1 == 3)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                    else if (choice_change == 6)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    Console.ReadLine();

                }
                else if (choice == 8)
                {
                    Console.Clear();
                    DepatrmentAndEmployee DAE = new DepatrmentAndEmployee();

                    int choice_change = 0;
                    res = true;
                    while (res)
                    {
                        try
                        {
                            Console.Clear();

                            Console.WriteLine("Enter 1 if you want change adress of departament");
                            Console.WriteLine("Enter 2 if you want change email of departament");
                            Console.WriteLine("Enter 3 if you want change name of departament");
                            Console.WriteLine("Enter 4 if you want change phone number of departament");
                            Console.WriteLine("Enter 5 if you want go back to main menu ");
                            choice_change = Convert.ToInt32(Console.ReadLine());
                            if (choice_change > 0 && choice_change < 7)
                            {
                                res = false;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    if (choice_change == 1)
                    {

                        int choice_change1 = 0;
                        res = true;
                        while (res)
                        {
                            try
                            {
                                Console.Clear();
                                Console.WriteLine("Enter 1 if you want to find departament by id ");
                                Console.WriteLine("Enter 2 if you want to find departament by name  ");
                                Console.WriteLine("Enter 3 id you want go back to main menu ");
                                choice_change1 = Convert.ToInt32(Console.ReadLine());
                                if (choice_change1 > 0 && choice_change1 < 4)
                                {
                                    res = false;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        if (choice_change1 == 1)
                        {
                            long id = 0;
                            res = true;
                            while (res)
                            {
                                try
                                {
                                    Console.WriteLine("Enter id ");

                                    id = Convert.ToInt64(Console.ReadLine());
                                    res = false;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }


                            string adress = "";
                            while (adress == "")
                            {
                                Console.WriteLine("Enter new adress ");
                                adress = (Console.ReadLine());
                            }

                            if (DAE.ChangeAddressDepartment(id, adress) == true)
                            {
                                Console.WriteLine("change successfull");
                            }
                            else
                            {
                                Console.WriteLine("Error when change departament adress");
                            }
                        }
                        else if (choice_change1 == 2)
                        {
                            string name = "";
                            while (name == "")
                            {
                                Console.WriteLine("Enter name : ");
                                name = Console.ReadLine();

                            }

                            string adress = "";
                            while (adress == "")
                            {
                                Console.WriteLine("Enter new adress ");
                                adress = (Console.ReadLine());
                            }
                            if (DAE.ChangeAddressDepartment(name, adress) == true)
                            {
                                Console.WriteLine("change successfull");
                            }
                            else
                            {
                                Console.WriteLine("Error when change departament adress");
                            }
                        }
                        else if (choice_change1 == 3)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                    else if (choice_change == 2)
                    {
                        int choice_change1 = 0;
                        res = true;
                        while (res)
                        {
                            try
                            {
                                Console.Clear();
                                Console.WriteLine("Enter 1 if you want to find departament by id ");
                                Console.WriteLine("Enter 2 if you want to find departament by name  ");
                                Console.WriteLine("Enter 3 id you want go back to main menu ");
                                choice_change1 = Convert.ToInt32(Console.ReadLine());
                                if (choice_change1 > 0 && choice_change1 < 4)
                                {
                                    res = false;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        if (choice_change1 == 1)
                        {
                            long id = 0;
                            res = true;
                            while (res)
                            {
                                try
                                {
                                    Console.WriteLine("Enter id ");

                                    id = Convert.ToInt64(Console.ReadLine());
                                    res = false;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }

                            string email = "";
                            while (email == "")
                            {
                                Console.WriteLine("Enter new email ");
                                email = (Console.ReadLine());
                            }

                            if (DAE.ChangeEmailDepartment(id, email) == true)
                            {
                                Console.WriteLine("change successfull");
                            }
                            else
                            {
                                Console.WriteLine("Error when change departament email");
                            }
                        }
                        else if (choice_change1 == 2)
                        {
                            string name = "";
                            while (name == "")
                            {
                                Console.WriteLine("Enter name : ");
                                name = Console.ReadLine();

                            }

                            string email = "";
                            while (email == "")
                            {
                                Console.WriteLine("Enter new email ");
                                email = (Console.ReadLine());
                            }
                            if (DAE.ChangeEmailDepartment(name, email) == true)
                            {
                                Console.WriteLine("change successfull");
                            }
                            else
                            {
                                Console.WriteLine("Error when change departament email");
                            }
                        }
                        else if (choice_change1 == 3)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                    else if (choice_change == 3)
                    {
                        int choice_change1 = 0;
                        res = true;
                        while (res)
                        {
                            try
                            {
                                Console.Clear();
                                Console.WriteLine("Enter 1 if you want to find departament by id ");
                                Console.WriteLine("Enter 2 if you want to find departament by name  ");
                                Console.WriteLine("Enter 3 id you want go back to main menu ");
                                choice_change1 = Convert.ToInt32(Console.ReadLine());
                                if (choice_change1 > 0 && choice_change1 < 4)
                                {
                                    res = false;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        if (choice_change1 == 1)
                        {
                            long id = 0;
                            res = true;
                            while (res)
                            {
                                try
                                {
                                    Console.WriteLine("Enter id ");

                                    id = Convert.ToInt64(Console.ReadLine());
                                    res = false;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }

                            string name = "";
                            while (name == "")
                            {
                                Console.WriteLine("Enter new name ");
                                name = (Console.ReadLine());
                            }

                            if (DAE.ChangeNameDepartment(id, name) == true)
                            {
                                Console.WriteLine("change successfull");
                            }
                            else
                            {
                                Console.WriteLine("Error when change departament name");
                            }
                        }
                        else if (choice_change1 == 2)
                        {
                            string name = "";
                            while (name == "")
                            {
                                Console.WriteLine("Enter name : ");
                                name = Console.ReadLine();

                            }

                            string newname = "";
                            while (newname == "")
                            {
                                Console.WriteLine("Enter new name ");
                                newname = (Console.ReadLine());
                            }
                            if (DAE.ChangeNameDepartment(name, newname) == true)
                            {
                                Console.WriteLine("change successfull");
                            }
                            else
                            {
                                Console.WriteLine("Error when change departament name");
                            }
                        }
                        else if (choice_change1 == 3)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                    else if (choice_change == 4)
                    {
                        int choice_change1 = 0;
                        res = true;
                        while (res)
                        {
                            try
                            {
                                Console.Clear();
                                Console.WriteLine("Enter 1 if you want to find departament by id ");
                                Console.WriteLine("Enter 2 if you want to find departament by name  ");
                                Console.WriteLine("Enter 3 id you want go back to main menu ");
                                choice_change1 = Convert.ToInt32(Console.ReadLine());
                                if (choice_change1 > 0 && choice_change1 < 4)
                                {
                                    res = false;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        if (choice_change1 == 1)
                        {
                            long id = 0;
                            res = true;
                            while (res)
                            {
                                try
                                {
                                    Console.WriteLine("Enter id ");

                                    id = Convert.ToInt64(Console.ReadLine());
                                    res = false;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }
                            res = true;
                            long phone_number = 0;
                            while (res)
                            {
                                try
                                {
                                    Console.WriteLine("Enter new phone number ");

                                    phone_number = Convert.ToInt64(Console.ReadLine());
                                    res = false;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }

                            if (DAE.ChangePhoneNumberDepartment(id, phone_number) == true)
                            {
                                Console.WriteLine("change successfull");
                            }
                            else
                            {
                                Console.WriteLine("Error when change departament  phone number");
                            }
                        }
                        else if (choice_change1 == 2)
                        {
                            string name = "";
                            while (name == "")
                            {
                                Console.WriteLine("Enter name : ");
                                name = Console.ReadLine();

                            }

                            res = true;
                            long phone_number = 0;
                            while (res)
                            {
                                try
                                {
                                    Console.WriteLine("Enter new phone number ");

                                    phone_number = Convert.ToInt64(Console.ReadLine());
                                    res = false;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }
                            if (DAE.ChangePhoneNumberDepartment(name, phone_number) == true)
                            {
                                Console.WriteLine("change successfull");
                            }
                            else
                            {
                                Console.WriteLine("Error when change departament phone number");
                            }
                        }
                        else if (choice_change1 == 3)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                    else if (choice_change == 5)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    Console.ReadLine();

                }
                else if (choice == 9)
                {
                    Console.Clear();
                    DepatrmentAndEmployee DAE = new DepatrmentAndEmployee();

                    Console.WriteLine(DAE.GetInfoEmployee());
                    Console.ReadLine();
                }
                else if (choice == 10)
                {
                    Console.Clear();
                    DepatrmentAndEmployee DAE = new DepatrmentAndEmployee();

                    Console.WriteLine(DAE.GetInfoDepartment());
                    Console.ReadLine();
                }
                else if (choice == 11)
                {
                    Console.Clear();

                }


            }
        }
    }
    
}
