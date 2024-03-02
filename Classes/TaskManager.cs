using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasklist_Alarms.Classes
{
    public class TaskManager
    {
        Panel AlarmTaskPanel;

        public static List<AlarmTask> SetIds(List<AlarmTask> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Id = i + 1;
            }
            return list.OrderBy(o => o.Id).ToList();
        }
    }
}
