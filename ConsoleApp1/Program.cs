using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Please select language:");
                Console.WriteLine("1)English" + " 2)Polish" + " 3)Azerbaijani");
                string language = Console.ReadLine();
                const string E = "Engish";


                switch (language.ToLower())
                {
                    case "english":
                    case E:
                        Console.WriteLine("Welcome to ATM Fast Cash!");
                        Console.WriteLine("Please, choose any of the options:");
                        Console.WriteLine("1)Withdraw cash" + " 2)Balance" + " 3)Exit");
                        string userchoice = Console.ReadLine();


                        switch (userchoice.ToLower())
                        {
                            case "withdraw cash":


                                Console.WriteLine("Please select amaount!");
                                Console.WriteLine("1)50" + " 2)100" + " 3)200");


                                int withdrawalamount = Convert.ToInt32(Console.ReadLine());

                                switch (withdrawalamount)
                                {
                                    case 50:

                                        Console.WriteLine("Thank you so much!" + " Avaible balance:650 PLN");
                                        break;

                                    case 100:
                                        Console.WriteLine("Thank you so much!" + " Avaible balance:600 PLN");
                                        break;
                                    case 200:
                                        Console.WriteLine("Thank you so much!" + " Avaible balance:500 PLN");
                                        break;

                                    default:

                                        Console.WriteLine("Amount wasn't chosen!" + " Avaible balance:700 PLN");
                                        break;





                                }


                                break;

                            case "balance":

                                Console.WriteLine(" Currently you have 700 PLN in your account");

                                break;

                            case "exit":

                                Console.WriteLine("Thank you so much for choosing us!");
                                break;

                        }
                        break;

                    case "polish":

                        Console.WriteLine("Witamy w ATM Fast Cash!");
                        Console.WriteLine("Wybierz jedną z opcji:");
                        Console.WriteLine("1)Wypłać gotówkę " + " 2)Saldo " + " 3)Wyjdź");

                        string userhoice = Console.ReadLine();


                        switch (userhoice.ToLower())
                        {
                            case "wyplac gotowke":


                                Console.WriteLine("Proszę wybrać kwotę!");
                                Console.WriteLine("1)50" + " 2)100" + " 3)200");


                                int withdrawalamount = Convert.ToInt32(Console.ReadLine());

                                switch (withdrawalamount)
                                {
                                    case 50:

                                        Console.WriteLine("Dziękuję bardzo!" + "Dostępne saldo: 650 PLN");
                                        break;

                                    case 100:
                                        Console.WriteLine("Dziękuję bardzo!" + "Dostępne saldo: 600 PLN");
                                        break;
                                    case 200:
                                        Console.WriteLine("Dziękuję bardzo!" + "Dostępne saldo: 500 PLN");
                                        break;

                                    default:

                                        Console.WriteLine("Kwota nie została wybrana!" + " Dostępne saldo: 700 PLN");
                                        break;





                                }


                                break;

                            case "saldo":

                                Console.WriteLine("Aktualnie masz 700 PLN na swoim koncie.");

                                break;

                            case "wyjdz":

                                Console.WriteLine("Dziękujemy bardzo za wybranie nas!");
                                break;

                        }
                        break;

                    case "azerbaijani":

                        Console.WriteLine("ATM Fast Cash-e xoş gelmisiniz!");



                        Console.WriteLine("Asagidakilardan her hansi birini secin:");
                        Console.WriteLine("1)Pul cixartmaq " + " 2) Balans " + " 3) Cixis");

                        string useroice = Console.ReadLine();


                        switch (useroice.ToLower())
                        {
                            case "pul cixartmaq":


                                Console.WriteLine("Zehmet olmasa meblegi secin!");
                                Console.WriteLine("1)50" + " 2)100" + " 3)200");


                                int withdrawalamount = Convert.ToInt32(Console.ReadLine());

                                switch (withdrawalamount)
                                {
                                    case 50:

                                        Console.WriteLine("Tesekkurler!" + "Hazirdaki balans: 650 PLN");
                                        break;

                                    case 100:
                                        Console.WriteLine("Tesekkurler!" + "Hazirdaki balans: 600 PLN");
                                        break;
                                    case 200:
                                        Console.WriteLine("Tesekkurler!" + "Hazirdaki balans: 500 PLN");
                                        break;

                                    default:

                                        Console.WriteLine("Mebleg duzgun secilmedi!" + " Balans: 700 PLN");
                                        break;





                                }


                                break;

                            case "balans":

                                Console.WriteLine("Hal-hazırda hesabınızda 700 PLN var.");

                                break;

                            case "cixis":

                                Console.WriteLine("Bizi secdiyiniz ucun tesekkur edirik!");
                                break;

                        }
                        break;

                    default:
                        Console.WriteLine("English is chosen as a default language.Welcome to ATM Fast Cash.");
                        Console.WriteLine("Please, choose any of the options:");
                        Console.WriteLine("1)Withdraw cash" + " 2)Balance" + " 3)Exit");
                        string userce = Console.ReadLine();


                        switch (userce.ToLower())
                        {
                            case "withdraw cash":


                                Console.WriteLine("Please select amaount!");
                                Console.WriteLine("1)50" + " 2)100" + " 3)200");


                                int withdrawalamount = Convert.ToInt32(Console.ReadLine());

                                switch (withdrawalamount)
                                {
                                    case 50:

                                        Console.WriteLine("Thank you so much!" + " Avaible balance:650 PLN");
                                        break;

                                    case 100:
                                        Console.WriteLine("Thank you so much!" + " Avaible balance:600 PLN");
                                        break;
                                    case 200:
                                        Console.WriteLine("Thank you so much!" + " Avaible balance:500 PLN");
                                        break;

                                    default:

                                        Console.WriteLine("Amount wasn't chosen!" + " Avaible balance:700 PLN");
                                        break;





                                }


                                break;

                            case "balance":

                                Console.WriteLine(" Currently you have 700 PLN in your account.");

                                break;

                            case "exit":

                                Console.WriteLine("Thank you so much for choosing us!");
                                break;

                        }
                        break;
                }
                Console.WriteLine("");

            }




















        }
    }
}
   
