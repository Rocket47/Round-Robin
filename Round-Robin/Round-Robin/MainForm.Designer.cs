﻿namespace Round_Robin
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listViewEmployees = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewTasksWorker = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Employees = new System.Windows.Forms.Label();
            this.tasks_one_worker = new System.Windows.Forms.Label();
            this.process_work = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewEmployees
            // 
            this.listViewEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewEmployees.FullRowSelect = true;
            this.listViewEmployees.GridLines = true;
            this.listViewEmployees.HideSelection = false;
            this.listViewEmployees.Location = new System.Drawing.Point(25, 52);
            this.listViewEmployees.MultiSelect = false;
            this.listViewEmployees.Name = "listViewEmployees";
            this.listViewEmployees.Size = new System.Drawing.Size(318, 336);
            this.listViewEmployees.TabIndex = 0;
            this.listViewEmployees.UseCompatibleStateImageBehavior = false;
            this.listViewEmployees.View = System.Windows.Forms.View.Details;
            this.listViewEmployees.SelectedIndexChanged += new System.EventHandler(this.listViewEmployees_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Performance";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Task";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Complexity";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 80;
            // 
            // listViewTasksWorker
            // 
            this.listViewTasksWorker.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.listViewTasksWorker.FullRowSelect = true;
            this.listViewTasksWorker.GridLines = true;
            this.listViewTasksWorker.HideSelection = false;
            this.listViewTasksWorker.Location = new System.Drawing.Point(394, 52);
            this.listViewTasksWorker.Name = "listViewTasksWorker";
            this.listViewTasksWorker.Size = new System.Drawing.Size(318, 336);
            this.listViewTasksWorker.TabIndex = 1;
            this.listViewTasksWorker.UseCompatibleStateImageBehavior = false;
            this.listViewTasksWorker.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tasks";
            this.columnHeader5.Width = 160;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Complexity";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 160;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(765, 52);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(318, 336);
            this.listView3.TabIndex = 2;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Name of worker";
            this.columnHeader7.Width = 110;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Task";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 110;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Simulation cicle";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 110;
            // 
            // Employees
            // 
            this.Employees.AutoSize = true;
            this.Employees.Location = new System.Drawing.Point(152, 21);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(58, 13);
            this.Employees.TabIndex = 3;
            this.Employees.Text = "Employees";
            // 
            // tasks_one_worker
            // 
            this.tasks_one_worker.AutoSize = true;
            this.tasks_one_worker.Location = new System.Drawing.Point(517, 21);
            this.tasks_one_worker.Name = "tasks_one_worker";
            this.tasks_one_worker.Size = new System.Drawing.Size(83, 13);
            this.tasks_one_worker.TabIndex = 4;
            this.tasks_one_worker.Text = "Tasks of worker";
            // 
            // process_work
            // 
            this.process_work.AutoSize = true;
            this.process_work.Location = new System.Drawing.Point(891, 21);
            this.process_work.Name = "process_work";
            this.process_work.Size = new System.Drawing.Size(83, 13);
            this.process_work.TabIndex = 5;
            this.process_work.Text = "Process of work";
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(520, 469);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 23);
            this.buttonPause.TabIndex = 6;
            this.buttonPause.Text = "PAUSE";
            this.buttonPause.UseVisualStyleBackColor = true;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(601, 469);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 7;
            this.buttonNew.Text = "NEW";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(439, 469);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonSettings.TabIndex = 8;
            this.buttonSettings.Text = "SETTINGS";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLabel.Location = new System.Drawing.Point(545, 417);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(30, 18);
            this.timerLabel.TabIndex = 9;
            this.timerLabel.Text = "00";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 524);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.process_work);
            this.Controls.Add(this.tasks_one_worker);
            this.Controls.Add(this.Employees);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listViewTasksWorker);
            this.Controls.Add(this.listViewEmployees);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Round-Robin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewEmployees;
        private System.Windows.Forms.ListView listViewTasksWorker;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Label Employees;
        private System.Windows.Forms.Label tasks_one_worker;
        private System.Windows.Forms.Label process_work;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerLabel;
    }
}
