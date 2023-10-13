using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Ash_Zhax
{
    interface IMove
    {
        void Start();
        void Stop();
        public int Power { get; }
        public int Weight { get; }
    }
}
