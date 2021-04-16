using Service.Interfaces;
using Domain;
using System;
using System.IO;

namespace Service.Services
{
    public class BoardService : IBoardService
    {
        private readonly Board _board = new Board();
        private readonly IValidationService _validationService;

        public BoardService(Board board, IValidationService validationService)
        {
            _board = board;
            _validationService = validationService;
        }     

        public Board ReadBoard()
        {
            Console.Clear();

            try
            {
                using StreamReader streamReader = new StreamReader("InvalidBoard.txt");
                string line;
                int row = 0;

                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);

                    for (int i = 0; i < 9; i++)
                    {
                        string[] numbers = line.Split(',');
                        _board.Squares[row, i] = Convert.ToInt32(numbers[i]);
                    }

                    row++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("");
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(ex.Message);
            }

            return _board;
        }

        public bool ValidateBoard()
        {
           return _validationService.ValidateBoard(_board);
        }
    }
}
