using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Config
{
    public interface ISettings
    {
        void Configure();
    }

    public class Settings : ISettings 
    {
        public void Configure()
        {

        }

    }
}
