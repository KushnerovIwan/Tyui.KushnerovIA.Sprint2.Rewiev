using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyui.KushnerovIA.Sprint2.TaskRewiev.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res = false;
            if ((y<=(x*x) && y<=(2-x) && y>=0 && x>=0)||(y<=(x*x) && y >= (2 - x)))
                {
                res = true;
                }
            return res;        
        }
    }
}
