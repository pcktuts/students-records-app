using System;
namespace StudentRecords
{
    public class Menu
    {
        public int SelectedMenu;
        public void DisplayMenu()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Choose a menu item {1..5}");
            Console.WriteLine("1.Add Details");
            Console.WriteLine("2.Print student Details");
            Console.WriteLine("3.Edit student Details");
            Console.WriteLine("4.Detele Student Detail");
            Console.WriteLine("5.Exit");
            SelectedMenu = Convert.ToInt32(Console.ReadLine());
        }
    }
}
