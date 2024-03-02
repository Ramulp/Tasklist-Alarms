using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasklist_Alarms.Classes
{
    public partial class ControlAlarmTask : UserControl
    {
        private AlarmTask alarmTask;


        //CheckBox checkBox_TaskActive;
        //TextBox txtBox_TaskTitle;
        //DateTimePicker datePicker_Task;
        //DateTimePicker timePicker_Task;
        //TextBox txtBox_TaskDescription;

        public ControlAlarmTask()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Este constructor recibe la referencia de la alarma para asociar el panel con la alarma.
        /// </summary>
        /// <param name="alarmTask">La alarma asociada al panel. Se referencia para poder asociar el panel dentro de la alarma</param>
        public ControlAlarmTask(ref AlarmTask alarmTask)
        {
            InitializeComponent();
            this.alarmTask = alarmTask;
            AssignValuesToFields();

            this.Load += (sender, e) =>
            {
                // Set focus to the TextBox control
                txtBox_TaskTitle.Focus();
            };
            alarmTask.CPanel = this;
        }

        private void AssignValuesToFields()
        {
            checkBox_TaskActive.Checked = alarmTask.TaskActive;
            txtBox_TaskTitle.Text = alarmTask.Title;
            datePicker_Task.Text = alarmTask.TaskAlarmTime.ToString("dd/MM/yyyy");
            timePicker_Task.Text = alarmTask.TaskAlarmTime.ToString("HH:mm");
            txtBox_TaskDescription.Text = alarmTask.Description;
        }

        public void UpdateValues()
        {
            AssignValuesToFields();
        }

        private void buttonOptions_Task_Click(object sender, EventArgs e)
        {
            //Abrí el form de opciones del task este.

            //ToastContent content = new ToastContent()
            //{
            //    Visual = new ToastVisual()
            //    {
            //        BindingGeneric = new ToastBindingGeneric()
            //        {
            //            Children =
            //            {
            //                new AdaptiveText()
            //                {
            //                    Text = "Notification Title"
            //                },
            //                new AdaptiveText()
            //                {
            //                    Text = "Notification Body"
            //                }
            //            }
            //        }
            //    }
            //};

            //// Show the toast
            //new ToastNotification(content.GetXml()).Show();
            NotifyIcon notifyIcon1 = new NotifyIcon
            {
                Visible = true,
                Icon = SystemIcons.Information,
                BalloonTipTitle = "Título de la notificación",
                BalloonTipText = "Texto de la notificación"
            };
            notifyIcon1.ShowBalloonTip(3000); // 3000 milisegundos = 3 segundos
        }
    }
}
