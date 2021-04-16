using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IDisplayService
    {
        void InitializeDisplay();
        void PrintLine(string line);
        void PrintResults(bool result);
    }
}
