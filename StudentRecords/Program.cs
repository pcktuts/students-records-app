using System;
using System.Collections.Generic;

namespace StudentRecords
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            var student = new Student();
            var menu = new Menu();           
            menu.DisplayMenu();
            var m = menu.SelectedMenu;
            while (m!= 5)
            {
                if (m == 1)
                {
                    student.AddStudent();
                    
                } else if(m == 2)
                {
                    student.DisplayStudents();
                }
                else if (m == 3)
                {
                    student.UpdateStudent();
                }
                else if (m == 4)
                {
                    student.DeleteStudent();
                }
                menu.DisplayMenu();
                m = menu.SelectedMenu;
            }
            Console.WriteLine("Good bye --->");
            

        }
    }
}
