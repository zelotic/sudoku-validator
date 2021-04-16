using Application.Interfaces;
using Domain;
using Service.Interfaces;
using System;

namespace Application.Services
{
    public class InputService : IInputService
    {
        private readonly IBoardService _boardService;
        private Board _board;

        public InputService(IValidationService validationService, IBoardService boardService)
        {
            _boardService = boardService;
        }

        public void ProcessInput()
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo();

            cki = Console.ReadKey();

            switch (cki.Key)
            {
                case ConsoleKey.Enter:
                    _board = _boardService.ReadBoard();
                    break;
                case ConsoleKey.X:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
