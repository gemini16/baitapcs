using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamGiacSao
{
    
    class Program
    {
        static int Main()
        {
            int row; //so hang can ve
            int i, j; //i= so lan lap, j= vi tri
            Console.Write("Nhap so hang:");
            row = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao cac so:");
            Console.WriteLine("1: Tam giac can trai nguoc");
            Console.WriteLine("2: Tam giac can trai xuoi");
            Console.WriteLine("3: Tam giac can phai nguoc");
            Console.WriteLine("4: Tam giac can phai xuoi");
            Console.WriteLine("5: Tam giac can giua nguoc");
            Console.WriteLine("6: Tam giac can giua xuoi");            
            int so;
            so = int.Parse(Console.ReadLine());
            switch (so)
            {
                case 1:
                    Console.WriteLine("Tam giac can trai nguoc\n");
                    for (i = 1; i <= row; i++)
                    {
                        for (j = row; j > i; j--)
                            Console.Write("* ");
                        Console.Write("\n");
                    }
                break;
                case 2:
                    Console.WriteLine("Tam giac can trai xuoi\n");
                    for (i = 1; i <= row; i++)
                    {
                        for (j = 0; j < i; j++)
                            Console.Write("* ");
                        Console.Write("\n");
                    }
                break;
                case 3:
                    Console.WriteLine("Tam giac can phai nguoc\n");
                    for (i = 0; i <= row; i++)
                    {
                        for (j = 0; j < i; j++)
                            Console.Write("  ");
                        for (j = row; j > i; j--)
                            Console.Write("* ");
                        Console.Write("\n");
                    }
                    break;
                case 4:
                    Console.WriteLine("Tam giac can phai xuoi\n");
                    for (i = 0; i <= row; i++)
                    {
                        for (j = row; j > i; j--)
                            Console.Write("  ");
                        for (j = 0; j < i; j++)
                            Console.Write("* ");
                        Console.Write("\n");
                    }
                    break;
                case 5:
                    Console.WriteLine("Tam giac can giua nguoc\n");
                    for (i = 0; i <= row; i++)
                    {
                        for (j = 0; j < i; j++)
                            Console.Write(" ");
                        for (j = row; j > i; j--)
                            Console.Write("* ");
                        Console.Write("\n");
                    }
                    break;
                case 6:
                    Console.WriteLine("Tam giac can giua xuoi\n");
                    for (i = 0; i <= row; i++)
                    {
                        for (j = row; j > i; j--)
                            Console.Write(" ");
                        for (j = 0; j < i; j++)
                            Console.Write("* ");
                        Console.Write("\n");
                    }
                    break;
                default:
                    Console.WriteLine("Ban khong chi duoc chon so trong khoang 1-6");
                    break;
            }
                Console.ReadLine();
            return 0;
        }
    }
}
