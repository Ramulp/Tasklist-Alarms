
namespace Tasklist_Alarms.Classes
{
    partial class ControlAlarmTask
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox_TaskActive = new System.Windows.Forms.CheckBox();
            this.txtBox_TaskTitle = new System.Windows.Forms.TextBox();
            this.txtBox_TaskDescription = new System.Windows.Forms.TextBox();
            this.datePicker_Task = new System.Windows.Forms.DateTimePicker();
            this.timePicker_Task = new System.Windows.Forms.DateTimePicker();
            this.buttonOptions_Task = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox_TaskActive
            // 
            this.checkBox_TaskActive.AutoSize = true;
            this.checkBox_TaskActive.Location = new System.Drawing.Point(8, 7);
            this.checkBox_TaskActive.Name = "checkBox_TaskActive";
            this.checkBox_TaskActive.Size = new System.Drawing.Size(15, 14);
            this.checkBox_TaskActive.TabIndex = 0;
            this.checkBox_TaskActive.UseVisualStyleBackColor = true;
            // 
            // txtBox_TaskTitle
            // 
            this.txtBox_TaskTitle.Location = new System.Drawing.Point(30, 4);
            this.txtBox_TaskTitle.Name = "txtBox_TaskTitle";
            this.txtBox_TaskTitle.Size = new System.Drawing.Size(405, 20);
            this.txtBox_TaskTitle.TabIndex = 1;
            // 
            // txtBox_TaskDescription
            // 
            this.txtBox_TaskDescription.Location = new System.Drawing.Point(8, 31);
            this.txtBox_TaskDescription.Multiline = true;
            this.txtBox_TaskDescription.Name = "txtBox_TaskDescription";
            this.txtBox_TaskDescription.Size = new System.Drawing.Size(427, 56);
            this.txtBox_TaskDescription.TabIndex = 2;
            // 
            // datePicker_Task
            // 
            this.datePicker_Task.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker_Task.Location = new System.Drawing.Point(441, 4);
            this.datePicker_Task.Name = "datePicker_Task";
            this.datePicker_Task.Size = new System.Drawing.Size(82, 20);
            this.datePicker_Task.TabIndex = 3;
            // 
            // timePicker_Task
            // 
            this.timePicker_Task.CustomFormat = "HH:mm";
            this.timePicker_Task.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker_Task.Location = new System.Drawing.Point(524, 4);
            this.timePicker_Task.Name = "timePicker_Task";
            this.timePicker_Task.ShowUpDown = true;
            this.timePicker_Task.Size = new System.Drawing.Size(52, 20);
            this.timePicker_Task.TabIndex = 4;
            // 
            // buttonOptions_Task
            // 
            this.buttonOptions_Task.Location = new System.Drawing.Point(441, 30);
            this.buttonOptions_Task.Name = "buttonOptions_Task";
            this.buttonOptions_Task.Size = new System.Drawing.Size(134, 56);
            this.buttonOptions_Task.TabIndex = 5;
            this.buttonOptions_Task.Text = "Options";
            this.buttonOptions_Task.UseVisualStyleBackColor = true;
            this.buttonOptions_Task.Click += new System.EventHandler(this.buttonOptions_Task_Click);
            // 
            // ControlAlarmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonOptions_Task);
            this.Controls.Add(this.timePicker_Task);
            this.Controls.Add(this.datePicker_Task);
            this.Controls.Add(this.txtBox_TaskDescription);
            this.Controls.Add(this.txtBox_TaskTitle);
            this.Controls.Add(this.checkBox_TaskActive);
            this.Name = "ControlAlarmTask";
            this.Size = new System.Drawing.Size(579, 91);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_TaskActive;
        private System.Windows.Forms.TextBox txtBox_TaskTitle;
        private System.Windows.Forms.TextBox txtBox_TaskDescription;
        private System.Windows.Forms.DateTimePicker datePicker_Task;
        private System.Windows.Forms.DateTimePicker timePicker_Task;
        private System.Windows.Forms.Button buttonOptions_Task;
    }
}
