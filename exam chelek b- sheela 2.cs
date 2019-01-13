using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_chelek_b_sheela2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] board = { { 0, 0, 0 }, { 1, 0, 1 }, {1 ,1, 1 } };
            WinXO(board);
            int[,] board1 = { { 1, 1, 1 }, { 0, 1, 0 }, { 1, 0, 0 } };
            WinXO(board1);
            int[,] board2 = { { 0, 1 },{ 0, 1 } };
            WinXO(board2);
            int[,] board3 = { { 0, 1, 2 }, { 0, 1, 0 }, { 1, 1, 1 } };
            WinXO(board3);
            int[,] board4 = { { 0, 0, 0 }, { 1, 0, 1 }, { 1,0, 1 } };
            WinXO(board4);
            int[,] board5 = { { 0, 0, 1 }, { 1, 1, 0 }, { 0, 1, 0 } };
            WinXO(board5);
            switch (WinXO(board5))
            {
                case -1:
                    Console.WriteLine("Matrix size is illegal");
                    break;
                case -2:
                    Console.WriteLine("The values are not matching to the game");
                    break;
                case -3:
                    Console.WriteLine("both of the players won!!");
                    break;
                case 2:
                    Console.WriteLine("O won!!!");
                    break;
                case 1:
                    Console.WriteLine("X won!!!");
                    break;
                case 0:
                    Console.WriteLine("no one won");
                    break;
            }

        }

        private static int WinXO(int[,] board)
        {
            if (board.GetLength(0) != 3 || board.GetLength(1) != 3)
            {
                
                return -1;

            }
            else
            {

                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        if (board[i, j] == 1 || board[i, j] == 0)
                        {
                            continue;
                        }
                        else
                        {
                           
                            return -2;
                        }
                    }

                }
                int sum1 = 0;
                int sum2 = 0;
                if (shura(board, 0) == 0)
                {
                    sum1 = sum1+1;
                }
               else if (shura(board, 0) == 1)
                {
                    sum2 = sum2+1;
                }
                if (shura(board, 1) == 0)
                {
                    sum1 = sum1+1;
                }
                else if (shura(board, 1) == 1)
                {
                    sum2 = sum2+1;
                }
                if (shura(board, 2) == 0)
                {
                    sum1 = sum1+1;
                }
                else if (shura(board, 2) == 1)
                {
                    sum2 = sum2+1;
                }

                if (toor(board, 0) == 0)
                {
                    sum1 = sum1+1;
                }
                else if (toor(board, 0) == 1)
                {
                    sum2 = sum2+1;
                }
                if (toor(board, 1) == 0)
                {
                    sum1 = sum1+1;
                }
                else if (toor(board, 1) == 1)
                {
                    sum2 = sum2+1;
                }
                if (toor(board, 2) == 0)
                {
                    sum1 = sum1+1;
                }
                else if (toor(board, 2) == 1)
                {
                    sum2 = sum2+1;
                }

                if (sum1 >0 && sum2 >0)
                {
                    
                    return -3;
                }
                else if (sum1 > 0)
                {
                   
                    return 2;
                }
                else if (sum2 > 0)
                {
                    
                    return 1;
                }
                else if (board[0, 0] == board[1, 1] && board[2, 2] == board[1, 1] && board[1, 1] == 0)
                {
                   
                    return 2;
                }
                else if (board[0, 0] == board[1, 1] && board[2, 2] == board[1, 1] && board[1, 1] == 1)
                {
                    
                    return 1;
                }
                else if (board[0, 2] == board[1, 1] && board[2, 0] == board[1, 1] && board[1, 1] == 0)
                {
                   
                    return 2;
                }
                else if (board[0, 2] == board[1, 1] && board[2, 0] == board[1, 1] && board[1, 1] == 1)
                {
                   
                    return 1;
                }
                else
                {
                    
                    return 0;
                }
            }
        }

        private static int shura(int[,] board,int x)
        {
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < 3; i++)
            {
                if (board[x, i] == 0)
                {
                    sum1 = sum1+1;
                }
                else
                {
                    sum2 = sum2+1;
                }
            }
            if (sum1 == 3)
            {
                return 0;
            }
            else if (sum2 == 3)
            {
                return 1;

            }
            else
            {
                return -1;
            }
        }

        private static int toor(int[,] board, int y)
        {
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < 3; i++)
            {
                if (board[i, y] == 0)
                {
                    sum1 = sum1+1;
                }
                else
                {
                    sum2 = sum2+1;
                }
            }
            if (sum1 == 3)
            {
                return 0;
            }
            else if (sum2 == 3)
            {
                return 1;

            }
            else
            {
                return -1;
            }
        }
    }
}
