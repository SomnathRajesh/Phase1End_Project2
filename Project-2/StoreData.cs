using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public class StoreData
    {
        readonly string path1 = "C:\\Users\\Somnath.Pratik\\Desktop\\India123\\TeacherData.txt";
        public void Save()
        {
            Console.WriteLine("Enter the details of the teacher:");
            Console.WriteLine("ID: ");
            string id = Console.ReadLine();
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Class and Section: ");
            string cas = Console.ReadLine();
            StreamWriter sw = File.AppendText(path1);
            sw.WriteLine(id + "," + name + "," + cas);
            sw.Close();

        }
    }
}
