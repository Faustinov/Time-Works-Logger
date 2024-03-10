using System;
using System.IO;

namespace WinForms
{
    internal class TimeTeller
    {
        private readonly DateTime _time;
        public TimeTeller(DateTime time)
        {
            _time = time;
        }

        private bool doesDirectoryExist() => Directory.Exists($"DataJson\\{_time}.json");
        public void DataExtraction()
        {
            if (doesDirectoryExist())

            
        }
    }
}
