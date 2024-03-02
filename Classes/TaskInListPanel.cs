//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Tasklist_Alarms.Classes
//{
//    class TaskInListPanel : Panel
//    {
//        private AlarmTask alarmTask;
//        CheckBox checkBox_TaskActive;
//        TextBox txtBox_TaskTitle;
//        DateTimePicker datePicker_Task;
//        DateTimePicker timePicker_Task;
//        TextBox txtBox_TaskDescription;


//        public TaskInListPanel(AlarmTask alarmTask)
//        {
//            this.alarmTask = alarmTask;
//            CreateControls(alarmTask);
            

//            //Cambiar el color del fondo a un gris si está desactivado, pero que se pueda editar aun.

//        }

//        private void CreateControls(AlarmTask alarmTask)
//        {

//            checkBox_TaskActive = new CheckBox();
//            //checkBox_TaskActive.Name = "checkBox_TaskActive_" + alarmTask.Id.ToString();
//            checkBox_TaskActive.Name = "checkBox_TaskActive";
//            checkBox_TaskActive.Location = new System.Drawing.Point(8, 7);
//            checkBox_TaskActive.Size = new System.Drawing.Size(15, 14);
//            checkBox_TaskActive.Checked = alarmTask.TaskActive;

//            checkBox_TaskActive.TabIndex = 0;


//            this.Controls.Add(checkBox_TaskActive);

//            txtBox_TaskTitle = new TextBox();
//            //txtBox_TaskTitle.Name = "txtBox_TaskTitle_" + alarmTask.Id.ToString();
//            txtBox_TaskTitle.Name = "txtBox_TaskTitle";
//            txtBox_TaskTitle.Location = new System.Drawing.Point(29, 4);
//            txtBox_TaskTitle.Size = new System.Drawing.Size(406, 20);
//            txtBox_TaskTitle.Text = alarmTask.Title;

//            txtBox_TaskTitle.TabIndex = 1;

//            this.Controls.Add(txtBox_TaskTitle);


//            datePicker_Task = new DateTimePicker();
//            //datePicker_Task.Name = "datePicker_Task_" + alarmTask.Id.ToString();
//            datePicker_Task.Name = "datePicker_Task";
//            datePicker_Task.Location = new System.Drawing.Point(441, 4);
//            datePicker_Task.Size = new System.Drawing.Size(82, 20);
//            datePicker_Task.Text = alarmTask.TaskAlarmTime.ToString("dd/MM/yyyy");
//            datePicker_Task.Format = DateTimePickerFormat.Short;

//            datePicker_Task.TabIndex = 2;

//            this.Controls.Add(datePicker_Task);


//            timePicker_Task = new DateTimePicker();
//            //timePicker_Task.Name = "timePicker_Task_" + alarmTask.Id.ToString();
//            timePicker_Task.Name = "timePicker_Task";
//            timePicker_Task.Location = new System.Drawing.Point(524, 4);
//            timePicker_Task.Size = new System.Drawing.Size(52, 20);
//            timePicker_Task.Text = alarmTask.TaskAlarmTime.ToString("HH:mm");
//            timePicker_Task.Format = DateTimePickerFormat.Custom;
//            timePicker_Task.CustomFormat = "HH:mm";
//            timePicker_Task.ShowUpDown = true;

//            timePicker_Task.TabIndex = 3;

//            this.Controls.Add(timePicker_Task);


//            txtBox_TaskDescription = new TextBox();
//            //txtBox_TaskDescription.Name = "txtBox_TaskDescription_" + alarmTask.Id.ToString();
//            txtBox_TaskDescription.Name = "txtBox_TaskDescription";
//            txtBox_TaskDescription.Location = new System.Drawing.Point(8, 31);
//            txtBox_TaskDescription.Size = new System.Drawing.Size(427, 56);
//            txtBox_TaskDescription.Text = alarmTask.Description;
//            txtBox_TaskDescription.Multiline = true;

//            txtBox_TaskDescription.TabIndex = 4;

//            this.Controls.Add(txtBox_TaskDescription);

//        }
//    }
//}
