using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class ArithProgression : ISeries
    {
        protected int _start;  //старт прогрессии
        protected int _n=1;    //текущий член прогрессии
        protected int _step;   //шаг(знаменатель) прогрессии

        public int Step
        {
            get
            {
                return _step;
            }

            set
            {
                _step = value;
            }
        }

        public virtual int GetN(int n)
        {
            return _start + (n -1) * _step;
        }

        public int GetNext()
        {
            _n++;
            return GetN(_n);
        }

        public void Reset()
        {
            _n = 1;
        }

        public void SetStart(int x)
        {
            _start = x;
        }
        public ArithProgression(int start, int step)
        {
            _start = start;
            _step = step;
            
        }
    }

    class GeomProgression : ArithProgression
        
    {
        public GeomProgression(int start, int step)
            :base (start, step)
        {}

        public override int GetN(int n)
        {
            return _start * (int)Math.Pow(_step, n - 1);
        }

    }

}
