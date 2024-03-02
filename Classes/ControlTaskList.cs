using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tasklist_Alarms.JSONParse;

namespace Tasklist_Alarms.Classes
{
    public partial class ControlTaskList : UserControl
    {
        const int TASK_LIST_MARGIN = 0; //No te olvides que esto incluye top y bottom

        List<AlarmTask> Tasks = new List<AlarmTask>();
        List<ControlAlarmTask> tasksInList = new List<ControlAlarmTask>();

        bool toggleInactiveShown = false;

        public ControlTaskList()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.Location = new Point(168, 44);
            CreateAllSavedTasks();
        }

        #region On Startup Functions
        /// <summary>
        /// Reads the saved backup and instantiates all the saved tasks
        /// </summary>
        private void CreateAllSavedTasks()
        {
            Tasks = TaskManager.SetIds(JSON_Parser.ReadBackup());
            InstantiateTasksList();
        }

        /// <summary>
        /// Create all tasks saved in the backup
        /// </summary>
        private void InstantiateTasksList()
        {
            for (int i = 0; i < Tasks.Count; i++)
            {
                AlarmTask t = Tasks[i]; //No se puede usar REF con una lista

                ControlAlarmTask panel = new ControlAlarmTask(ref t);
                //panel.Location = new Point(0,0);
                panel.Location = new Point(0, (panel.Size.Height + TASK_LIST_MARGIN) * i);

                panel.BackColor = (i % 2 == 0) ? Color.LightGray : Color.DarkGray;

                this.Controls.Add(panel);
                tasksInList.Add(panel);

                Tasks[i] = t;
            }
        } 
        #endregion

        /// <summary>
        /// Creates the Control window in the Task list, with the AlarmTask sent
        /// </summary>
        /// <param name="taskToCreate">The task to create and add to the list</param>
        public void CreateTaskInList(AlarmTask taskToCreate)
        {
            ControlAlarmTask panel = new ControlAlarmTask(ref taskToCreate);
            //panel.Location = new Point(0,0);
            int YPos = (panel.Size.Height + TASK_LIST_MARGIN) * (Tasks.Count) - this.VerticalScroll.Value;
            panel.Location = new Point(0, YPos);

            panel.BackColor = (Tasks.Count % 2 == 0) ? Color.LightGray : Color.DarkGray;

            this.Controls.Add(panel);
            tasksInList.Add(panel);

            JSON_Parser.SaveToJSON(taskToCreate);
        }

        public string ToggleInactive()
        {
            string result = string.Empty;

            if (toggleInactiveShown == true)
            {
                //Hide inactive
                result = "Show Inactive Tasks";

                for (int i = 0; i < tasksInList.Count; i++)
                {
                    if (Tasks[i].TaskActive == false)
                        tasksInList[i].Hide();
                }
            }
            else
            {
                //Show inactive
                result = "Hide Inactive Tasks";

                for (int i = 0; i < tasksInList.Count; i++)
                {
                    if (Tasks[i].TaskActive == false)
                        tasksInList[i].Show();
                }
            }
            toggleInactiveShown = !toggleInactiveShown;

            return result;
        }


        /// <summary>
        /// This method is called every 60 Seconds, to check all active tasks, if they need to be triggered.
        /// </summary>
        public void CheckAlarms()
        {
            foreach (AlarmTask alarm in Tasks)
            {
                if (!alarm.TaskActive)
                    continue;

                if (alarm.TaskAlarmTime <= DateTime.Now)
                {

                }
            }
        }
    }
}
