<<<<<<< Updated upstream
=======
<<<<<<< Updated upstream
=======
using System;

class Program
{
    static char[,] board = new char[3, 3]; // Игровое поле 3x3
    static char currentPlayer = 'X'; // Текущий игрок

    static void Main(string[] args)
    {
        InitializeBoard(); // Инициализация игрового поля
        PlayGame();        // Начало игры
    }

    // Инициализация пустого игрового поля
    static void InitializeBoard() 
    {
        for (int i = 0; i < 3; i++) 
        {
            for (int j = 0; j < 3; j++) 
            {
                board[i, j] = ' '; // Все клетки изначально пустые
            }
        }
    }

    // Функция печати игрового поля
    static void PrintBoard() 
    {
        for (int i = 0; i < 3; i++) 
        {
            for (int j = 0; j < 3; j++) 
            {
                Console.Write(board[i, j]);
                if (j < 2) Console.Write(" | ");
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine("--|---|--");
        }
    }

    static void PlayGame() 
    {
        bool gameOver = false;

        while (!gameOver) 
        {
            PrintBoard(); // Вывод игрового поля
            int row, col;
            bool validMove = false;

            // Проверка корректного ввода (Inputcorrectness)
            while (!validMove) 
            {
                Console.WriteLine($"Ход игрока {currentPlayer}. Введите строку и столбец (0, 1 или 2) через Enter:");
                row = int.Parse(Console.ReadLine());
                col = int.Parse(Console.ReadLine());

                if (IsValidMove(row, col)) 
                {
                    board[row, col] = currentPlayer; // Игрок может сделать ход только в пустую клетку
                    validMove = true;
                } 

                // Проверка на победу (Win)
                if (CheckWin()) 
                {
                    PrintBoard();
                    Console.WriteLine($"Игрок {currentPlayer} победил!");
                    gameOver = true;
                }

                // Проверка на ничью (Draw)
                else if (CheckDraw()) 
                {
                    PrintBoard();
                    Console.WriteLine("Ничья!");
                    gameOver = true;
                }

                else 
                    {
                        // Логика смены игрока (Rules)
                        currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
                    }

                else 
                {
                    Console.WriteLine("Некорректный ход. Попробуйте снова.");
                }
            }  
        }
    }
}
>>>>>>> Stashed changes
>>>>>>> Stashed changes
