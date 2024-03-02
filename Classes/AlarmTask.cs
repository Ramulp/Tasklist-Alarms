using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Tasklist_Alarms.Classes
{
    public class AlarmTask
    {
        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public DateTime TaskAlarmTime { get => taskAlarmTime; set => taskAlarmTime = value; }
        public bool TaskActive { get => taskActive; set => taskActive = value; }
        internal ControlAlarmTask CPanel { get => cPanel; set => cPanel = value; }


        //EL ID NO ESTA FUNCIONANDO COM OQUIERO POR QUE DENUVO SON PUTAS INSTANCIAS
        int id;
        //EL ID NO ESTA FUNCIONANDO COM OQUIERO POR QUE DENUVO SON PUTAS INSTANCIAS

        string title;
        string description;
        DateTime taskAlarmTime;
        ControlAlarmTask cPanel;


        bool taskActive;

        public AlarmTask(string title, string description, DateTime taskAlarmTime, int id, bool taskActive = false)
        {

            this.id = id;

            this.Title = title;
            this.Description = description;
            this.TaskAlarmTime = taskAlarmTime;


            TaskActive = taskActive;
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
