using System.ComponentModel.Design;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Tic_tac_toe
{
    internal class Program
    {
       static string[,] board =
            { {"1", "2", "3" }
            , {"4", "5", "6" },
              {"7", "8", "9" }
            };
        static int mark = 0;
        static string input, input2;
        static bool error1 = false;
        static bool error2 = false;    
        static bool notAllowedField = false;
        static bool notAllowedField2 = false;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("    " + " | " + "   " + " | " + "   " + "  " + "\n" +
                  "  " + board[0, 0] + "  " + "| " + " " + board[0, 1] + "  " + "|" + "  " + board[0, 2] + " " + " " + " " + "\n"
                  + "_____" + "|" + "_____" + "|" + "_____" + "" + "\n" +
                  "    " + " | " + "   " + " | " + "   " + "  " + "\n" +
                  "  " + board[1, 0] + "  " + "| " + " " + board[1, 1] + "  " + "|" + "  " + board[1, 2] + " " + " " + " " + "\n"
                  + "_____" + "|" + "_____" + "|" + "_____" + "" + "\n" +
                  "    " + " | " + "   " + " | " + "   " + "  " + "\n" +
                  "  " + board[2, 0] + "  " + "| " + " " + board[2, 1] + "  " + "|" + "  " + board[2, 2] + " " + " " + " " + "\n"
                  + "     " + "|" + "     " + "|" + "" + "\n");

                Console.Write("Giocatore 1 Scegli la casella: ");
                input = Console.ReadLine();

                if (CheckField(input) == true)
                {
                    do
                    {
                        Console.Write("Casella occupata o valore non valido. Inserire un altro valore: ");
                        input = Console.ReadLine();
                    }
                    while (CheckField(input) == true);
                    SostituisciP1(input);                
                }
                else if (CheckField(input) == false)
                {
                    SostituisciP1(input);
                }
               
                
                Checker(board);
                if(Checker(board) == true) 
                {
                    Console.Clear();
                    Console.WriteLine("    " + " | " + "   " + " | " + "   " + "  " + "\n" +
                 "  " + board[0, 0] + "  " + "| " + " " + board[0, 1] + "  " + "|" + "  " + board[0, 2] + " " + " " + " " + "\n"
                 + "_____" + "|" + "_____" + "|" + "_____" + "" + "\n" +
                 "    " + " | " + "   " + " | " + "   " + "  " + "\n" +
                 "  " + board[1, 0] + "  " + "| " + " " + board[1, 1] + "  " + "|" + "  " + board[1, 2] + " " + " " + " " + "\n"
                 + "_____" + "|" + "_____" + "|" + "_____" + "" + "\n" +
                 "    " + " | " + "   " + " | " + "   " + "  " + "\n" +
                 "  " + board[2, 0] + "  " + "| " + " " + board[2, 1] + "  " + "|" + "  " + board[2, 2] + " " + " " + " " + "\n"
                 + "     " + "|" + "     " + "|" + "" + "\n");
                    Console.WriteLine("Giocatore 1 ha Vinto!"); break; }
               
                Console.Clear();
                Console.WriteLine("    " + " | " + "   " + " | " + "   " + "  " + "\n" +
                 "  " + board[0, 0] + "  " + "| " + " " + board[0, 1] + "  " + "|" + "  " + board[0, 2] + " " + " " + " " + "\n"
                 + "_____" + "|" + "_____" + "|" + "_____" + "" + "\n" +
                 "    " + " | " + "   " + " | " + "   " + "  " + "\n" +
                 "  " + board[1, 0] + "  " + "| " + " " + board[1, 1] + "  " + "|" + "  " + board[1, 2] + " " + " " + " " + "\n"
                 + "_____" + "|" + "_____" + "|" + "_____" + "" + "\n" +
                 "    " + " | " + "   " + " | " + "   " + "  " + "\n" +
                 "  " + board[2, 0] + "  " + "| " + " " + board[2, 1] + "  " + "|" + "  " + board[2, 2] + " " + " " + " " + "\n"
                 + "     " + "|" + "     " + "|" + "" + "\n");

                Console.Write("Giocatore 2 Scegli la casella: ");
                input2 = Console.ReadLine();
                if (CheckField(input2) == true)
                {
                    do
                    {
                        Console.Write("Casella occupata. Inserire un altro valore: ");
                        input2 = Console.ReadLine();
                    }
                    while (CheckField(input2) == true);
                    SostituisciP2(input2);
                }
                else if (CheckField(input2) == false)
                {
                    SostituisciP2(input2);
                }
                Checker(board);
                if (Checker(board) == true)
                {
                    Console.Clear();
                    Console.WriteLine("    " + " | " + "   " + " | " + "   " + "  " + "\n" +
                 "  " + board[0, 0] + "  " + "| " + " " + board[0, 1] + "  " + "|" + "  " + board[0, 2] + " " + " " + " " + "\n"
                 + "_____" + "|" + "_____" + "|" + "_____" + "" + "\n" +
                 "    " + " | " + "   " + " | " + "   " + "  " + "\n" +
                 "  " + board[1, 0] + "  " + "| " + " " + board[1, 1] + "  " + "|" + "  " + board[1, 2] + " " + " " + " " + "\n"
                 + "_____" + "|" + "_____" + "|" + "_____" + "" + "\n" +
                 "    " + " | " + "   " + " | " + "   " + "  " + "\n" +
                 "  " + board[2, 0] + "  " + "| " + " " + board[2, 1] + "  " + "|" + "  " + board[2, 2] + " " + " " + " " + "\n"
                 + "     " + "|" + "     " + "|" + "" + "\n");
                    Console.WriteLine("Giocatore 2 ha Vinto!"); break; }
                Console.Clear();
                Console.WriteLine("    " + " | " + "   " + " | " + "   " + "  " + "\n" +
                 "  " + board[0, 0] + "  " + "| " + " " + board[0, 1] + "  " + "|" + "  " + board[0, 2] + " " + " " + " " + "\n"
                 + "_____" + "|" + "_____" + "|" + "_____" + "" + "\n" +
                 "    " + " | " + "   " + " | " + "   " + "  " + "\n" +
                 "  " + board[1, 0] + "  " + "| " + " " + board[1, 1] + "  " + "|" + "  " + board[1, 2] + " " + " " + " " + "\n"
                 + "_____" + "|" + "_____" + "|" + "_____" + "" + "\n" +
                 "    " + " | " + "   " + " | " + "   " + "  " + "\n" +
                 "  " + board[2, 0] + "  " + "| " + " " + board[2, 1] + "  " + "|" + "  " + board[2, 2] + " " + " " + " " + "\n"
                 + "     " + "|" + "     " + "|" + "" + "\n");

            } while (Checker(board) == false);
         
          
            Console.ReadLine();
        }
        public static bool Checker(string[,] board)
        {
            // TODO
            for (int i = 0; i < 3; i++)
            {
                // check rows and columns
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return true;
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return true;
            }
            // check diagonals
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return true;
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return true;
            return false;
        }
        public static void SostituisciP1(string input)
        {
            if (int.TryParse(input, out mark) && mark > 0 && mark <= 9)
            {
               
                switch (input)
                   {
                    case "1":                      
                         board[0, 0] = "X";                     
                         break;

                    case "2":                  
                            board[0, 1] = "X";
                        break;
                    case "3":                 
                            board[0, 2] = "X";
                        break;
                    case "4":
                            board[1, 0] = "X";
                        break;
                    case "5":
                            board[1, 1] = "X";
                        break;
                    case "6":
                            board[1, 2] = "X";
                        break;
                    case "7":
                            board[2, 0] = "X";
                        break;
                    case "8":
                            board[2, 1] = "X";
                        break;
                    case "9":
                            board[2, 2] = "X";
                        break;
                }
                
            }
            else if (!int.TryParse(input, out mark) || mark <= 0 || mark > 9)
            {
                error1 = true;
                while (error1 == true)
                {
                    Console.Write("Giocatore 1 Inserire un valore valido: ");
                    input = Console.ReadLine();
                    if(int.TryParse(input, out mark) && mark > 0 && mark <= 9) 
                    {
                        switch (input)
                        {
                            case "1":
                                board[0, 0] = "X";
                                break;
                            case "2":
                                board[0, 1] = "X";
                                break;
                            case "3":
                                board[0, 2] = "X";
                                break;
                            case "4":
                                board[1, 0] = "X";
                                break;
                            case "5":
                                board[1, 1] = "X";
                                break;
                            case "6":
                                board[1, 2] = "X";
                                break;
                            case "7":
                                board[2, 0] = "X";
                                break;
                            case "8":
                                board[2, 1] = "X";
                                break;
                            case "9":
                                board[2, 2] = "X";
                                break;
                        }
                        break; 
                    }
                }
            }
        }
        public static void SostituisciP2(string input2)
        {
            if (int.TryParse(input2, out mark) && mark > 0 && mark <= 9)
            {
                switch (input2)
                {
                    case "1":
                        board[0, 0] = "O";
                        break;
                    case "2":
                        board[0, 1] = "O";
                        break;
                    case "3":
                        board[0, 2] = "O";
                        break;
                    case "4":
                        board[1, 0] = "O";
                        break;
                    case "5":
                        board[1, 1] = "O";
                        break;
                    case "6":
                        board[1, 2] = "O";
                        break;
                    case "7":
                        board[2, 0] = "O";
                        break;
                    case "8":
                        board[2, 1] = "O";
                        break;
                    case "9":
                        board[2, 2] = "O";
                        break;
                }
            }
            else if (!int.TryParse(input2, out mark) || mark <= 0 || mark > 9)
            {
                error2 = true;
                while (error2 == true)
                {
                    Console.Write("Giocatore 2 Inserire un valore valido: ");
                    input2 = Console.ReadLine();
                    if (int.TryParse(input2, out mark) && mark > 0 && mark <= 9) 
                    {
                        switch (input2)
                        {
                            case "1":
                                board[0, 0] = "O";
                                break;
                            case "2":
                                board[0, 1] = "O";
                                break;
                            case "3":
                                board[0, 2] = "O";
                                break;
                            case "4":
                                board[1, 0] = "O";
                                break;
                            case "5":
                                board[1, 1] = "O";
                                break;
                            case "6":
                                board[1, 2] = "O";
                                break;
                            case "7":
                                board[2, 0] = "O";
                                break;
                            case "8":
                                board[2, 1] = "O";
                                break;
                            case "9":
                                board[2, 2] = "O";
                                break;
                        }
                        break; 
                    }
                }
            }
        }
        public static bool CheckField(string input)
        {
                if (board[0, 0] != "1" && input == "1" || (!int.TryParse(input, out mark) || mark <= 0 || mark > 9))
                {
                    notAllowedField = true;               
                }
                else if (board[0, 1] != "2" && input == "2" || (!int.TryParse(input, out mark) || mark <= 0 || mark > 9))
                {
                    notAllowedField = true;
                }
                else if (board[0, 2] != "3" && input == "3" || (!int.TryParse(input, out mark) || mark <= 0 || mark > 9))
                {
                    notAllowedField = true;
                }
                else if (board[1, 0] != "4" && input == "4" || (!int.TryParse(input, out mark) || mark <= 0 || mark > 9))
                {
                    notAllowedField = true;
                }
                else if (board[1, 1] != "5" && input == "5" || (!int.TryParse(input, out mark) || mark <= 0 || mark > 9))
                {
                    notAllowedField = true;
                }
                else if (board[1, 2] != "6" && input == "6" || (!int.TryParse(input, out mark) || mark <= 0 || mark > 9))
                {
                    notAllowedField = true;
                }
                else if (board[2, 0] != "7" && input == "7" || (!int.TryParse(input, out mark) || mark <= 0 || mark > 9))
                {
                    notAllowedField = true;
                }
                else if (board[2, 1] != "8" && input == "8" || (!int.TryParse(input, out mark) || mark <= 0 || mark > 9))
                {
                    notAllowedField = true;
                }
                else if (board[2, 2] != "9" && input == "9" || (!int.TryParse(input, out mark) || mark <= 0 || mark > 9))
                {
                    notAllowedField = true;
                }
                else if (int.TryParse(input, out mark) && mark > 0 && mark <= 9)
                {
                    notAllowedField = false;          
                }
            return notAllowedField;
        }
      
    }
}