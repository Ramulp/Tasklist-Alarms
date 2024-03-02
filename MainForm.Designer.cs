
namespace Tasklist_Alarms
{
    partial class MainForm
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_CreateTask = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button_HideInactive = new System.Windows.Forms.Button();
            this.timer_1Minute = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_CreateTask
            // 
            this.button_CreateTask.Location = new System.Drawing.Point(168, 17);
            this.button_CreateTask.Name = "button_CreateTask";
            this.button_CreateTask.Size = new System.Drawing.Size(101, 21);
            this.button_CreateTask.TabIndex = 4;
            this.button_CreateTask.Text = "Create Task";
            this.button_CreateTask.UseVisualStyleBackColor = true;
            this.button_CreateTask.Click += new System.EventHandler(this.button_CreateTask_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Location = new System.Drawing.Point(168, 417);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(816, 90);
            this.panel4.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(413, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(0, 0);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(406, 20);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "Titulo";
            // 
            // button_HideInactive
            // 
            this.button_HideInactive.Location = new System.Drawing.Point(276, 17);
            this.button_HideInactive.Name = "button_HideInactive";
            this.button_HideInactive.Size = new System.Drawing.Size(111, 23);
            this.button_HideInactive.TabIndex = 5;
            this.button_HideInactive.Text = "Hide Inactive Tasks";
            this.button_HideInactive.UseVisualStyleBackColor = true;
            this.button_HideInactive.Click += new System.EventHandler(this.button_HideInactive_Click);
            // 
            // timer_1Minute
            // 
            this.timer_1Minute.Enabled = true;
            this.timer_1Minute.Interval = 60000;
            this.timer_1Minute.Tick += new System.EventHandler(this.timer_1Minute_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 450);
            this.Controls.Add(this.button_HideInactive);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button_CreateTask);
            this.Name = "MainForm";
            this.Text = "Tasklist Alarms";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button_CreateTask;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_HideInactive;
        private System.Windows.Forms.Timer timer_1Minute;
    }
}

