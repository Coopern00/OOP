using System;
using System.Collections.Generic;
using System.Text;

namespace Stopwatch
{
    class Stopwatch
    {
        private DateTime _startwatch;
        private TimeSpan _duration;
        private bool _pressedStart;

        public void Start()
        {
            if (_pressedStart)
            {
                throw new InvalidOperationException("You cannot start it again until you press stop");
            }
            else
            {
                _startwatch = DateTime.Now;
                _pressedStart = true;
            }
        }

        public void Stop()
        {
            _duration = DateTime.Now - _startwatch;
            _pressedStart = false;
            Console.WriteLine("The duration of the time is : {0}", _duration);
            // this is for resetting the duration variable to make it ready for another session
            _duration = TimeSpan.Zero;
        }
    }
}
