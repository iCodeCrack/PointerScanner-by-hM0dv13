using PointerScanF_by_hM0dv13.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerScanF_by_hM0dv13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "PointerScanner by hM0dv13";
            ConsoleMenu mainMenu = new ConsoleMenu();
            //mainMenu.Header = headertext;
            mainMenu.addMenuItem(0, "Scan Csh", ScanCsh);
            mainMenu.addMenuItem(1, "Scan Obj", ScanObj);
            mainMenu.addMenuItem(2, "Scan Inventory", ScanInventory);
            mainMenu.addMenuItem(3, "Exit", Exit);
            mainMenu.showMenu();
            Console.ReadKey();
        }
        public static void Exit()
        {
            System.Environment.Exit(0);
        }
        public static void ScanInventory()
        {

        }
        public static void ScanObj()
        {

        }
        public static void ScanCsh()
        {

        }
    }
}
