using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Timetable_Map
{
    class Module_Timetable
    {
        string moduleName;
        List<string> Monday = new List<string>();
        List<string> Tuesday = new List<string>();
        List<string> Wednesday = new List<string>();
        List<string> Thursday = new List<string>();
        List<string> Friday = new List<string>();

        public Module_Timetable(string mName, List<string> mDay, List<string> tDay, List<string> wDay, List<string> thDay, List<string> fDay)
        {
            moduleName = mName;
            for(int i = 0; i < mDay.Count; i++)
            {
                Monday.Add(mDay[i]);
                Tuesday.Add(tDay[i]);
                Wednesday.Add(wDay[i]);
                Thursday.Add(thDay[i]);
                Friday.Add(fDay[i]);
            }
        }
    }
}
