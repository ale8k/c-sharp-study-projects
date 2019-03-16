using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private DateTime _startDate;
        private DateTime _endDate;
        private bool StartOn;

        public void Start()
        {
            if (StartOn == false)
            {
                _startDate = DateTime.Now;
                StartOn = true;
            } 
            else
            {
                throw new InvalidOperationException("Turn the stop watch off before pressing start again");
            }
        }
        public void Stop()
        {
            StartOn = false;
            _endDate = DateTime.Now;
            Console.WriteLine(_endDate - _startDate);
        }
    }
}
