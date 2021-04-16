using Application.Interfaces;
using Application.Services;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class ConsoleDisplayService : IDisplayService
    {
        private readonly IInputService _userInputService;
        private readonly IBoardService _boardService;

        public ConsoleDisplayService(IInputService userInputService, IBoardService boardService)
        {
            _userInputService = userInputService;
            _boardService = boardService;
        }

        public void InitializeDisplay()
        {
            PrintLine("Press 'Enter' to check this board's validity or 'X' to exit the application.");

            _userInputService.ProcessInput();

            PrintResults(_boardService.ValidateBoard());
        }

        public void PrintResults(bool result)
        {
            PrintLine("");
            PrintLine("The board is printed above.");
            PrintLine("");
            PrintLine("Board Status: " + (result.Equals(true) ? "VALID" : "INVALID"));
        }

        public void PrintLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
