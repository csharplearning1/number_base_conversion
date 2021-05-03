using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 8;
            string first_base = "";



            Console.WriteLine("\nPlease select an option from the menu");
            Console.WriteLine("\n1: Convert From base 8 to base 2");
            Console.WriteLine("\n2: Convert From base 2 to base 10");
            Console.WriteLine("\n3: Convert From base 10 to base 2");
            Console.WriteLine("\n4: Convert From base 16 to base 10");
            Console.WriteLine("\n5: Convert From base 10 to base 16");
            Console.WriteLine("\n6: Convert From base 2 to base 16");
            Console.WriteLine("\n7: Convert From base 16 to base 2");
            Console.WriteLine("\n0:Exit\n");
            option = int.Parse(Console.ReadLine());
            string ins = "";
            while (option != 0)
            {
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("Please input the value for converting");

                            first_base = Console.ReadLine();


                            for (int i = 0; i < first_base.Length; i++)
                            {
                                int t = int.Parse(first_base[i].ToString());
                                switch (t)
                                {
                                    case 0:
                                        {
                                            ins += "000";


                                            break;
                                        }
                                    case 1:
                                        {

                                            ins += "001";
                                            break;
                                        }
                                    case 2:
                                        {
                                            ins += "010";
                                            break;
                                        }
                                    case 3:
                                        {
                                            ins += "011";
                                            break;
                                        }
                                    case 4:
                                        {
                                            ins += "100";
                                            break;
                                        }
                                    case 5:
                                        {
                                            ins += "101";
                                            break;
                                        }
                                    case 6:
                                        {
                                            ins += "110";
                                            break;
                                        }
                                    case 7:
                                        {
                                            ins += "111";
                                            break;
                                        }


                                }


                            }
                            Console.Write("Convert From base 8 to base 2 = ");
                            Console.WriteLine(ins);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Please input the value for converting");

                            first_base = Console.ReadLine();

                            int result = 0;
                            for (int i = 0; i < first_base.Length; i++)
                            {

                                int t = int.Parse(first_base[i].ToString());


                                int power = 1;

                                for (int j = i; j < first_base.Length - 1; j++)

                                    power *= 2;


                                result += t * power;





                            }
                            Console.Write("Convert From base 2 to base 10 = ");
                            Console.WriteLine(result);


                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Please input the value for converting");

                            first_base = Console.ReadLine();
                            string binary = Convert.ToString(int.Parse(first_base), 2);
                            Console.Write("Convert From base 10 to base 2 =");
                            Console.WriteLine(binary);


                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Please input the value for converting");

                            first_base = Console.ReadLine();

                            int result = 0;
                            for (int i = 0; i < first_base.Length; i++)
                            {

                                int t = int.Parse(first_base[i].ToString(), System.Globalization.NumberStyles.HexNumber);


                                int power = 1;

                                for (int j = i; j < first_base.Length - 1; j++)

                                    power *= 16;


                                result += t * power;





                            }
                            Console.Write("Convert From base 16 to base 10 = ");
                            Console.WriteLine(result);


                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Please input the value for converting");

                            first_base = Console.ReadLine();
                            string binary = Convert.ToString(int.Parse(first_base), 16);
                            Console.Write("Convert From base 10 to base 16 =");
                            Console.WriteLine(binary);


                        }
                        break;

                    case 6:
                        {
                            Console.WriteLine("Please input the value for converting");

                            first_base = Console.ReadLine();



                            int result = 0;
                            for (int i = 0; i < first_base.Length; i++)
                            {

                                int t = int.Parse(first_base[i].ToString());


                                int power = 1;

                                for (int j = i; j < first_base.Length - 1; j++)

                                    power *= 2;


                                result += t * power;





                            }
                            string binary = Convert.ToString(result, 16);
                            Console.Write("Convert From base 2 to base 16 =");
                            Console.WriteLine(binary);



                        }
                        break;

                    case 7:
                        {
                            ins = "";
                            Console.WriteLine("Please input the value for converting");

                            first_base = Console.ReadLine();


                            for (int i = 0; i < first_base.Length; i++)
                            {

                                char t = first_base[i];
                                switch (t)
                                {
                                    case '0':
                                        {
                                            ins += "0000";


                                            break;
                                        }
                                    case '1':
                                        {

                                            ins += "0001";
                                            break;
                                        }
                                    case '2':
                                        {
                                            ins += "0010";
                                            break;
                                        }
                                    case '3':
                                        {
                                            ins += "0011";
                                            break;
                                        }
                                    case '4':
                                        {
                                            ins += "0100";
                                            break;
                                        }
                                    case '5':
                                        {
                                            ins += "0101";
                                            break;
                                        }
                                    case '6':
                                        {
                                            ins += "0110";
                                            break;
                                        }
                                    case '7':
                                        {
                                            ins += "0111";
                                            break;
                                        }
                                    case '8':
                                        {
                                            ins += "1000";
                                            break;
                                        }
                                    case '9':
                                        {
                                            ins += "1001";
                                            break;
                                        }
                                    case 'A':
                                    case 'a':
                                        {
                                            ins += "1010";
                                            break;
                                        }
                                    case 'B':
                                    case 'b':
                                        {
                                            ins += "1011";
                                            break;
                                        }
                                    case 'C':
                                    case 'c':
                                        {
                                            ins += "1100";
                                            break;
                                        }
                                    case 'D':
                                    case 'd':
                                        {
                                            ins += "1101";
                                            break;
                                        }
                                    case 'E':
                                    case 'e':
                                        {
                                            ins += "1110";
                                            break;
                                        }
                                    case 'F':
                                    case 'f':
                                        {
                                            ins += "1111";
                                            break;
                                        }


                                }


                            }
                            Console.Write("Convert From base 16 to base 2 = ");
                            Console.WriteLine(ins);
                            break;
                        }

                }
                Console.WriteLine("\n Please select an optin from the menu.");
                option = int.Parse(Console.ReadLine());
            }


        }
    }

}

