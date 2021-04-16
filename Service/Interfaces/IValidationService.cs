using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IValidationService
    {
        int GetNumber(Board board, int row, int column);
        bool ValidateRows(Board board);
        bool ValidateColumns(Board board);
        bool ValidateNumber(ref bool[] numbers, int number);
        bool ValidateSquares(Board board);
        bool ValidateBoard(Board board);
    }
}
