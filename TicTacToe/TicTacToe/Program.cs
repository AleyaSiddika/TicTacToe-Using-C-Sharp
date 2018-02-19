using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        private static char player1 = 'X';
        private static char player2 = 'O';
        private static int choice=0;
        private static char[,] boardval = new char[3, 3];
       
       
        static void Main(string[] args)
        {
            int i=0;
            boardval[0, 0] = ' ';
            boardval[0, 1] = ' ';
            boardval[0, 2] = ' ';
            boardval[1, 0] = ' ';
            boardval[1, 1] = ' ';
            boardval[1, 2] = ' ';
            boardval[2, 0] = ' ';
            boardval[2, 1] = ' ';
            boardval[2, 2] = ' ';
            Program.board();
            string move;
            while (i<9)
            {
                if (choice == 0)
                {
                    Console.WriteLine("Please enter player 1 move: ");
                    move = Console.ReadLine();
                    Program.moov(move);
                    Program.board();
                    Program.winner('X');
                    i++;
                    choice++;
                }
                else
                {
                    Console.WriteLine("Please enter player 2 move: ");
                    move = Console.ReadLine();
                    Program.moov(move);
                    Program.board();
                    Program.winner('O');
                    i++;
                    choice--;
                }

            }
           // Program.winner();
            Console.ReadKey();
        }
        public static void winner(char val)
        {

            
            if (boardval[0, 0] == boardval[0, 1] && boardval[0, 0] == boardval[0, 2]) {
                val = boardval[0, 0];
               Console.WriteLine("Winner is {0}",val);
            }

            else if (boardval[1, 0] == boardval[1, 1] && boardval[1, 0] == boardval[1, 2]) {
                val = boardval[1, 0];
               Console.WriteLine("Winner is {0}", val);
            }
            else if (boardval[2, 0] == boardval[2, 1] && boardval[2, 0] == boardval[2, 2]) {
                val = boardval[2, 0];
                Console.WriteLine("Winner is {0}", val);
            }
            else if (boardval[0, 0] == boardval[1, 0] && boardval[0, 0] == boardval[2, 0]) {
                val = boardval[0, 0];
                Console.WriteLine("Winner is {0}", val);
            }
            else if (boardval[0, 1] == boardval[1, 1] && boardval[0, 1] == boardval[2, 1]) {
                val = boardval[0, 1];
               //Console.WriteLine("Winner is {0}", val);
            }
            else if (boardval[0, 2] == boardval[1, 2] && boardval[0, 2] == boardval[2, 2]) {
                val = boardval[0, 2];
                Console.WriteLine("Winner is {0}", val);
            }
            else if (boardval[0, 0] == boardval[1, 1] && boardval[0, 0] == boardval[2, 2]) {
                val = boardval[0, 0];
                Console.WriteLine("Winner is {0}", val);

            }
            else if (boardval[0, 2] == boardval[1, 1] && boardval[0, 2] == boardval[2, 0]) {
                val = boardval[0, 2];
                Console.WriteLine("Winner is {0} ", val);

            }
            else
            {
 
            }

        }
      /*  public static void checkWinner(char check)
        {
            if (check == 'X')
            {
                Program.winner('X');
                Console.WriteLine("Winner is player 1");
            }
            else if(check == 'O')
            {
                Program.winner('X');
                Console.WriteLine("Winner is player 2");
            }

        }*/
        public static void board()
        {
            Console.WriteLine("    A        B         C  ");
            Console.WriteLine("        |        |           ");
             Console.WriteLine(" {0}      |  {1}     |  {2} ", boardval[0, 0], boardval[0, 1], boardval[0, 2]);
             Console.WriteLine("________|________|_______");
             Console.WriteLine("        |        |           ");
             Console.WriteLine(" {0}      |  {1}     |  {2}", boardval[1, 0], boardval[1, 1], boardval[1, 2]);
             Console.WriteLine("________|________|_______");
             Console.WriteLine("        |        |");
             Console.WriteLine(" {0}      |  {1}     |  {2}", boardval[2, 0], boardval[2, 1], boardval[2, 2]);


        }
        public static void moov(String move)
        {
            
             if (move == "A1")
              {
                if (choice == 0 && boardval[0, 0] == ' ')
                {
                    boardval[0, 0] = player1;
                }
                else if(boardval[0, 0] == ' ')
                {
                    boardval[0, 0] = player2;
                    
                }
                else
                {
                    Console.WriteLine("Invalid Attempt");
                }
            }
           else if (move == "A2")
            {
                if (choice == 0 && boardval[1, 0] == ' ')
                {
                    boardval[1, 0] = player1;
                    
                }
                else if(boardval[1, 0] == ' ')
                {
                    boardval[1, 0] = player2;
                }
                else
                {
                    Console.WriteLine("Invalid Attempt");
                }
            }
           else if (move == "A3")
            {
                if (choice == 0 && boardval[2, 0] == ' ')
                {
                    boardval[2, 0] = player1;
                }
                else if(boardval[2, 0] == ' ')
                {
                    boardval[2, 0] = player2;
                }
                else
                {
                    Console.WriteLine("Invalid Attempt");
                }
            }
            else if (move == "B1")
            {
                if (choice == 0 && boardval[0, 1] == ' ')
                {
                    boardval[0, 1] = player1;

                }
                else if (boardval[0, 1] == ' ')
                {
                    boardval[0, 1] = player2;
                }
                else
                {
                    Console.WriteLine("Invalid Attempt");
                }
            }
            else if (move == "B2")
            {
                if (choice == 0 && boardval[1, 1] == ' ')
                {
                    boardval[1, 1] = player1;

                }
                else if ( boardval[1, 1] == ' ')
                {
                    boardval[1, 1] = player2;
                }
                else
                {
                    Console.WriteLine("Invalid Attempt");
                }
            }
            else if (move == "B3")
            {
                if (choice == 0 && boardval[2, 1] == ' ')
                {
                    boardval[2, 1] = player1;

                }
                else if (boardval[2, 1] == ' ')
                {
                    boardval[2, 1] = player2;
                }
                else
                {
                    Console.WriteLine("Invalid Attempt");
                }
            }
            else if (move == "C1")
            {
                if (choice == 0 && boardval[0, 2] == ' ')
                {
                    boardval[0, 2] = player1;

                }
                else if (boardval[0, 2] == ' ')
                {
                    boardval[0, 2] = player2;
                }
                else
                {
                    Console.WriteLine("Invalid Attempt");
                }
            }
            else if (move == "C2")
            {
                if (choice == 0 && boardval[1, 2] == ' ')
                {
                    boardval[1, 2] = player1;

                }
                else if (boardval[1, 2] == ' ')
                {
                    boardval[1, 2] = player2;
                }
                else
                {
                    Console.WriteLine("Invalid Attempt");
                }
            }
            else if (move == "C3")
            {
                if (choice == 0 && boardval[2, 2] == ' ')
                {
                    boardval[2, 2] = player1;

                }
                else if (boardval[2, 2] == ' ')
                {
                    boardval[2, 2] = player2;
                }
                else
                {
                    Console.WriteLine("Invalid Attempt");
                }
            }
        }

    }  
 


    }


