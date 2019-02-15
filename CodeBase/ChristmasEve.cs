using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBase
{
    class ChristmasEve
    {
        public bool IsChristmasEve(DateTime UserDate)
        {
            if(UserDate.Day==24 && UserDate.Month==12)
                    return true;
            else
                return false;
        }
    }
}
