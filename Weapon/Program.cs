using System;
using Weapon.models;


namespace Weapon
{
    class Program
    {
        static void Main(string[] args)
        {
            int MagazineCapacity = -1;
            int NumberOfBulletsRemaining = -1;
            float DischargeSecond = -1;
            int FireMode = -1;
            bool input = true;
            while (input)
            {
                Helper.WriteConsole(ConsoleColor.Magenta, "MagazineCapacity:");
                input = !int.TryParse(Console.ReadLine(), out MagazineCapacity);
                if (input || MagazineCapacity < 0)
                {
                   Helper.WriteConsole(ConsoleColor.Red,"Please enter correctly");
                    input = true;
                }
            }
            input = true;
            while (input)
            {
                Helper.WriteConsole(ConsoleColor.Magenta, "NumberOfBulletsRemaining:");
                input = !int.TryParse(Console.ReadLine(), out NumberOfBulletsRemaining);
                if (input || NumberOfBulletsRemaining < 0 || NumberOfBulletsRemaining > MagazineCapacity)
                {
                    RightChoise(ref input);
                }
            }
            input = true;
            while (input)
            {
                Helper.WriteConsole(ConsoleColor.Magenta, "DischargeSecond:");
                input = !float.TryParse(Console.ReadLine(), out DischargeSecond);
                if (input || DischargeSecond < 0)
                {
                    RightChoise(ref input);
                }
            }
            input = true;
            string FireModeName = " ";
            while (input)
            {
                Helper.WriteConsole(ConsoleColor.Magenta, "Choose fire mode:  \n1) Single  \n2) Auto");
                input = !int.TryParse(Console.ReadLine(), out FireMode);
                if (input || FireMode < 1 || FireMode > 2)
                    RightChoise(ref input);
                else
                {
                    if (FireMode == 1)
                        FireModeName = "Single";
                    else
                        FireModeName = "Automatic";
                }
            }
            Console.Clear();
            Weapons ak47 = new Weapons(MagazineCapacity, NumberOfBulletsRemaining, DischargeSecond, FireModeName);


            int Choise;
            string choise;
            do
            {
                Helper.WriteConsole(ConsoleColor.Yellow, "Choise option");
                Helper.WriteConsole(ConsoleColor.Yellow, "0)Information");
                Helper.WriteConsole(ConsoleColor.Yellow, "1)Shoot");
                Helper.WriteConsole(ConsoleColor.Yellow, "2)Fire");
                Helper.WriteConsole(ConsoleColor.Yellow, "3)GetRemainBulletCount");
                Helper.WriteConsole(ConsoleColor.Yellow, "4)Reload");
                Helper.WriteConsole(ConsoleColor.Yellow, "5)ChangeFireMode");
                Helper.WriteConsole(ConsoleColor.Yellow, "6)Stop");
                Helper.WriteConsole(ConsoleColor.Yellow, "7)Update");


                while (!int.TryParse(Console.ReadLine(), out Choise))
                {
                    Helper.WriteConsole(ConsoleColor.Cyan,"Select correct option number:");

                }
                Console.Clear();

                switch (Choise)
                {
                    case 0:
                        ak47.GetInfo();
                        break;
                    case 1:
                        ak47.Shoot();
                        break;
                    case 2:
                        ak47.Fire();
                        break;
                    case 3:
                        Console.WriteLine(ak47.GetRemainBulletCount());
                        break;
                    case 4:
                        ak47.Reload();

                        break;
                    case 5:
                        ak47.ChangeFireMode();
                        Helper.WriteConsole(ConsoleColor.Green,"Changed:" + ak47.FireMode);
                        break;
                    case 6:
                        break;
                    case 7:
                       Helper.WriteConsole(ConsoleColor.Cyan,"T:Change MagazineCapaci");
                        Helper.WriteConsole(ConsoleColor.Cyan,"S:Change NumberOfBulletsRemaining");
                        Helper.WriteConsole(ConsoleColor.Cyan,"D:Change DischargeSecond");
                        char Choice = ' ';
                        while (Choice != 'T' && Choice != 'S' && Choice != 'D')
                        {
                            Helper.WriteConsole(ConsoleColor.Red,"Please Input Correctly:");

                            while (!char.TryParse(Console.ReadLine(), out Choice))
                            {
                                Helper.WriteConsole(ConsoleColor.Red,"Select Correctly:");
                               
                            }
                        }
                        int Choise1;
                        switch (Choice)
                        {
                            case 'T':
                                Helper.WriteConsole(ConsoleColor.Yellow,"Add new Change:");
                                while (!int.TryParse(Console.ReadLine(),out Choise1))
                                {
                                    Helper.WriteConsole(ConsoleColor.Red, "Please Input Correctly:");
                                }
                                ak47.MagazineCapacity = Choise1;
                                Helper.WriteConsole(ConsoleColor.Green, "Changed");
                                if (ak47.NumberOfBulletsRemaining > ak47.MagazineCapacity)
                                    ak47.NumberOfBulletsRemaining = ak47.MagazineCapacity;
                                break;
                            case 'S':
                                Helper.WriteConsole(ConsoleColor.Yellow, "Add new Change:");
                                while (!int.TryParse(Console.ReadLine(), out Choise1))
                                {
                                    Helper.WriteConsole(ConsoleColor.Red, "Please Input Correctly:");
                                }
                                ak47.NumberOfBulletsRemaining = Choise1;
                                Helper.WriteConsole(ConsoleColor.Green, "Changed");
                                break;
                            case 'D':
                                float Choise2;
                                Helper.WriteConsole(ConsoleColor.Yellow, "Add new Change:");
                                while (!float.TryParse(Console.ReadLine(), out Choise2))
                                {
                                    Helper.WriteConsole(ConsoleColor.Red, "Please Input Correctly:");
                                }
                                ak47.DischargeSecond = Choise2;
                                Helper.WriteConsole(ConsoleColor.Green, "Changed");
                                break;
                            default:
                                break;
                        }
                        break;

                    default:
                        Helper.WriteConsole(ConsoleColor.Red, "Select Correctly:");
                        break;
                }
               Helper.WriteConsole(ConsoleColor.Cyan,"If you want to Continue? press:Y if you want to quit-press:N");
                do
                {
                    Helper.WriteConsole(ConsoleColor.Red, "Please Input Correctly:");
                    choise = Console.ReadLine().ToUpper();
                } while (choise != "Y" && choise != "N");

                Console.Clear();

            } while (choise == "Y");

           

        }
        public static void RightChoise(ref bool input)
        {
            Helper.WriteConsole(ConsoleColor.Red, "Select Correctly:");
            input = true;
        }

    }
}
