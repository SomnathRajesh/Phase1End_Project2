using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public class RetrieveData
    {
        readonly string path = "C:\\Users\\Somnath.Pratik\\Desktop\\India123\\TeacherData.txt";
        public void FetchData()
        {
            if (File.Exists(path))
            {
                Console.WriteLine("Do you want to retrieve the data by 1.Id or 2.Name or 3.Retrieve Info of all Teachers");
                int o = int.Parse(Console.ReadLine());
                switch (o)
                {
                    case 1:
                        Console.WriteLine("Enter the ID of the teacher");
                        string id = Console.ReadLine();
                        StreamReader sr = File.OpenText(path);
                        string line = sr.ReadLine();
                        while (line != null)
                        {
                            string[] data = line.Split(',');
                            if (data[0] == id)
                            {
                                Console.WriteLine(line);
                            }
                            line = sr.ReadLine();
                        }
                        sr.Close();
                        break;
                    case 2:
                        Console.WriteLine("Enter the Name of the teacher");
                        string name = Console.ReadLine();
                        StreamReader sr_n = File.OpenText(path);
                        string line_n = sr_n.ReadLine();
                        while (line_n != null)
                        {
                            string[] data = line_n.Split(',');
                            if (data[1] == name)
                            {
                                Console.WriteLine(line_n);
                            }
                            line_n = sr_n.ReadLine();
                        }
                        sr_n.Close();
                        break;
                    case 3:
                        StreamReader sr_a = File.OpenText(path);
                        string line_a = sr_a.ReadLine();
                        while (line_a != null)
                        {
                            Console.WriteLine(line_a);
                            line_a = sr_a.ReadLine();
                        }
                        sr_a.Close();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }
            else
            {
                Console.WriteLine("The file doesn't exist");
            }
        }
    }
}
