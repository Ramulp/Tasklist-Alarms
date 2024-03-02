using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tasklist_Alarms.Classes;
using Tasklist_Alarms.JSONParse;

namespace Tasklist_Alarms
{
    public partial class MainForm : Form
    {
        ControlTaskList TaskListPanel = new ControlTaskList();

        public MainForm()
        {
            InitializeComponent();

            Controls.Add(TaskListPanel);
        }




        private void button_CreateTask_Click(object sender, EventArgs e)
        {
            //Open "create a new task" window

            AlarmTask newTask = new AlarmTask("Nueva Tarea", "DEscripcion", DateTime.Now.AddHours(1), DateTime.Now.Millisecond, true);

            TaskListPanel.CreateTaskInList(newTask);
        }

        private void button_HideInactive_Click(object sender, EventArgs e)
        {
            //falta reordenar las tasks

            button_HideInactive.Text = TaskListPanel.ToggleInactive();
        }

        private void timer_1Minute_Tick(object sender, EventArgs e)
        {
            TaskListPanel.CheckAlarms();
        }
    }
}
