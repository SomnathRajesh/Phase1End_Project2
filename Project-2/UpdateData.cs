using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
   public class UpdateData
    {
        readonly string path1 = "C:\\Users\\Somnath.Pratik\\Desktop\\India123\\TeacherData.txt";
        public void Update()
        {
            Console.WriteLine("Enter the ID of the Teacher whose data you want to update");
            string i_d = Console.ReadLine();
            Console.WriteLine("Select the field you want to update");
            Console.WriteLine("1. Name\n2. Class and Section");
            int f = int.Parse(Console.ReadLine());
            string s = "";
            switch (f)
            {
                case 1:
                    Console.WriteLine("Enter the new name");
                    string name = Console.ReadLine();
                    using (StreamReader sr_n = File.OpenText(path1))
                    {
                        string line_n = sr_n.ReadLine();
                        while (line_n != null)
                        {
                            string[] d = line_n.Split(',');
                            if (d[0] == i_d)
                            {
                                s += d[0] + "," + name + "," + d[2] + "\n";
                            }
                            else
                            {
                                s += line_n + "\n";
                            }
                            line_n = sr_n.ReadLine();
                        }
                        sr_n.Close();
                    }

                    using (StreamWriter sw_n = File.CreateText(path1))
                    {
                        sw_n.Write(s);
                        sw_n.Close();
                    }

                    break;
                case 2:
                    Console.WriteLine("Enter the new class and section");
                    string cas = Console.ReadLine();
                    using (StreamReader sr_c = File.OpenText(path1))
                    {
                        string line_c = sr_c.ReadLine();
                        while (line_c != null)
                        {
                            string[] d = line_c.Split(',');
                            if (d[0] == i_d)
                            {
                                s += d[0] + "," + d[1] + "," + cas + "\n";
                            }
                            else
                            {
                                s += line_c + "\n";
                            }
                            line_c = sr_c.ReadLine();
                        }
                        sr_c.Close();
                    }

                    using (StreamWriter sw_c = File.CreateText(path1))
                    {
                        sw_c.Write(s);
                        sw_c.Close();
                    }

                    break;
            }


        }
    }
}
