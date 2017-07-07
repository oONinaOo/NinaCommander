using System;

namespace NinaCommanderv2._0
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toDrag = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.corners = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DiagnosticPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.updateDrives = new System.Windows.Forms.Timer(this.components);
            this.LeftDrives = new System.Windows.Forms.Panel();
            this.LeftPath = new ZBobb.AlphaBlendTextBox();
            this.LeftContentPanel = new System.Windows.Forms.Panel();
            this.systemtimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.RightContentPanel = new System.Windows.Forms.Panel();
            this.RightPath = new ZBobb.AlphaBlendTextBox();
            this.RightDrives = new System.Windows.Forms.Panel();
            this.filewatcher = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.toDrag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.DiagnosticPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // drag
            // 
            this.drag.Fixed = true;
            this.drag.Horizontal = true;
            this.drag.TargetControl = this.toDrag;
            this.drag.Vertical = true;
            // 
            // toDrag
            // 
            this.toDrag.BackColor = System.Drawing.Color.Transparent;
            this.toDrag.Location = new System.Drawing.Point(0, -13);
            this.toDrag.Name = "toDrag";
            this.toDrag.Size = new System.Drawing.Size(1108, 50);
            this.toDrag.TabIndex = 0;
            this.toDrag.TabStop = false;
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.Image = global::NinaCommanderv2._0.Properties.Resources.down;
            this.minimize.Location = new System.Drawing.Point(1111, 4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(34, 36);
            this.minimize.TabIndex = 1;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            this.minimize.MouseEnter += new System.EventHandler(this.minimize_MouseEnter);
            this.minimize.MouseLeave += new System.EventHandler(this.minimize_MouseLeave);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Image = global::NinaCommanderv2._0.Properties.Resources.exit;
            this.exit.Location = new System.Drawing.Point(1151, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(36, 37);
            this.exit.TabIndex = 2;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            // 
            // corners
            // 
            this.corners.ElipseRadius = 20;
            this.corners.TargetControl = this;
            // 
            // DiagnosticPanel
            // 
            this.DiagnosticPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.DiagnosticPanel.Controls.Add(this.pictureBox2);
            this.DiagnosticPanel.Location = new System.Drawing.Point(0, 519);
            this.DiagnosticPanel.Name = "DiagnosticPanel";
            this.DiagnosticPanel.Size = new System.Drawing.Size(1200, 100);
            this.DiagnosticPanel.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::NinaCommanderv2._0.Properties.Resources.diagnostics1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 35);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::NinaCommanderv2._0.Properties.Resources.title;
            this.pictureBox1.Location = new System.Drawing.Point(373, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 38);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LeftDrives
            // 
            this.LeftDrives.BackColor = System.Drawing.Color.Transparent;
            this.LeftDrives.Location = new System.Drawing.Point(46, 60);
            this.LeftDrives.Name = "LeftDrives";
            this.LeftDrives.Size = new System.Drawing.Size(491, 30);
            this.LeftDrives.TabIndex = 6;
            // 
            // LeftPath
            // 
            this.LeftPath.BackAlpha = 10;
            this.LeftPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LeftPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LeftPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LeftPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LeftPath.Location = new System.Drawing.Point(46, 478);
            this.LeftPath.Name = "LeftPath";
            this.LeftPath.Size = new System.Drawing.Size(491, 19);
            this.LeftPath.TabIndex = 13;
            this.LeftPath.Text = "C:\\";
            this.LeftPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LeftPath_KeyPress);
            // 
            // LeftContentPanel
            // 
            this.LeftContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.LeftContentPanel.Location = new System.Drawing.Point(32, 109);
            this.LeftContentPanel.Name = "LeftContentPanel";
            this.LeftContentPanel.Size = new System.Drawing.Size(523, 351);
            this.LeftContentPanel.TabIndex = 14;
            // 
            // systemtimer
            // 
            this.systemtimer.Interval = 1000;
            this.systemtimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(346, 628);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "F3 Search || F4 Rename || F5 Copy || F6 Move to || F7 New directory || F8 Compres" +
    "s ";
            // 
            // RightContentPanel
            // 
            this.RightContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.RightContentPanel.Location = new System.Drawing.Point(643, 109);
            this.RightContentPanel.Name = "RightContentPanel";
            this.RightContentPanel.Size = new System.Drawing.Size(523, 351);
            this.RightContentPanel.TabIndex = 15;
            // 
            // RightPath
            // 
            this.RightPath.BackAlpha = 10;
            this.RightPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RightPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RightPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RightPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RightPath.Location = new System.Drawing.Point(659, 478);
            this.RightPath.Name = "RightPath";
            this.RightPath.Size = new System.Drawing.Size(491, 19);
            this.RightPath.TabIndex = 16;
            this.RightPath.Text = "C:\\";
            // 
            // RightDrives
            // 
            this.RightDrives.BackColor = System.Drawing.Color.Transparent;
            this.RightDrives.Location = new System.Drawing.Point(659, 60);
            this.RightDrives.Name = "RightDrives";
            this.RightDrives.Size = new System.Drawing.Size(491, 30);
            this.RightDrives.TabIndex = 7;
            // 
            // filewatcher
            // 
            this.filewatcher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.filewatcher_DoWork);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::NinaCommanderv2._0.Properties.Resources.basebg;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.RightDrives);
            this.Controls.Add(this.RightPath);
            this.Controls.Add(this.RightContentPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LeftContentPanel);
            this.Controls.Add(this.LeftPath);
            this.Controls.Add(this.LeftDrives);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DiagnosticPanel);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.toDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.toDrag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.DiagnosticPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void timer1_Tick(object sender, EventArgs e, Content list)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl drag;
        private System.Windows.Forms.PictureBox toDrag;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox exit;
        private Bunifu.Framework.UI.BunifuElipse corners;
        private System.Windows.Forms.Panel DiagnosticPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer updateDrives;
        private System.Windows.Forms.Panel LeftDrives;
        private ZBobb.AlphaBlendTextBox LeftPath;
        private System.Windows.Forms.Panel LeftContentPanel;
        private System.Windows.Forms.Timer systemtimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel RightDrives;
        private ZBobb.AlphaBlendTextBox RightPath;
        private System.Windows.Forms.Panel RightContentPanel;
        public System.ComponentModel.BackgroundWorker filewatcher;
    }
}

