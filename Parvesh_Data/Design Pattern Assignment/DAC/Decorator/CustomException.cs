using System;
using System.Collections.Generic;
using System.Text;

namespace DAC.Decorator
{
    public class NoEventException : Exception
    {
        public override string Message
        {
            get
            {
                return "There is empty event list";
            }
        }
    }

    public class NoPblicEvent : Exception
    {
        public override string Message
        {
            get
            {
                return "No public event";
            }
        }
    }
}
