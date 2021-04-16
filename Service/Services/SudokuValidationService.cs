using Domain;
using Service.Interfaces;
using System;

namespace Service.Services
{
    public class SudokuValidationService : IValidationService
    {
        public bool ValidateBoard(Board board)
        {
            return ValidateColumns(board) && ValidateRows(board) && ValidateSquares(board);
        }

        public bool ValidateColumns(Board board)
        {
            for (int i = 0; i < 9; i++)
            {                
                for (int n = 0; n < 9; n++)
                {
                    var numbers = new bool[10];

                    int number = GetNumber(board, i, n);

                    if (!ValidateNumber(ref numbers, number))
                        return false;
                }
            }

            return true;
        }

        public bool ValidateRows(Board board)
        {            
            for (int i = 0; i < 9; i++)
            {
                var numbers = new bool[10];

                for (int n = 0; n < 9; n++)
                {
                    int number = GetNumber(board, i, n);

                    if (!ValidateNumber(ref numbers, number))
                        return false;
                }
            }

            return true;
        }

        public bool ValidateSquares(Board board)
        {
            throw new NotImplementedException();
        }

        public int GetNumber(Board board, int row, int column)
        {
            int number = board.Squares[row, column];

            if (string.IsNullOrEmpty(number.ToString()))
                return 0;

            return number;
        }

        public bool ValidateNumber(ref bool[] numbers, int number)
        {
            if (number != 0 && numbers[number] == true)
                return false;

            numbers[number] = true;

            return true;
        }
    }
}
