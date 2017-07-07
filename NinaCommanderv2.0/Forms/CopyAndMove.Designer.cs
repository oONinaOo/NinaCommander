namespace NinaCommanderv2._0
{
    partial class CopyAndMove
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
            this.ok = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.originalPath = new ZBobb.AlphaBlendTextBox();
            this.destinationPath = new ZBobb.AlphaBlendTextBox();
            this.progress = new Bunifu.Framework.UI.BunifuProgressBar();
            this.progresstext = new System.Windows.Forms.Label();
            this.bgwork = new System.ComponentModel.BackgroundWorker();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.ok.Image = global::NinaCommanderv2._0.Properties.Resources.ok;
            this.ok.Location = new System.Drawing.Point(427, 144);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(34, 30);
            this.ok.TabIndex = 2;
            this.ok.TabStop = false;
            this.ok.MouseEnter += new System.EventHandler(this.ok_MouseEnter);
            this.ok.MouseLeave += new System.EventHandler(this.ok_MouseLeave);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.exit.Image = global::NinaCommanderv2._0.Properties.Resources.exit_dialog;
            this.exit.Location = new System.Drawing.Point(428, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(29, 27);
            this.exit.TabIndex = 1;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            // 
            // originalPath
            // 
            this.originalPath.BackAlpha = 98;
            this.originalPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.originalPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.originalPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.originalPath.Location = new System.Drawing.Point(32, 63);
            this.originalPath.Name = "originalPath";
            this.originalPath.Size = new System.Drawing.Size(399, 17);
            this.originalPath.TabIndex = 3;
            // 
            // destinationPath
            // 
            this.destinationPath.BackAlpha = 98;
            this.destinationPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.destinationPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.destinationPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.destinationPath.Location = new System.Drawing.Point(32, 107);
            this.destinationPath.Name = "destinationPath";
            this.destinationPath.Size = new System.Drawing.Size(399, 17);
            this.destinationPath.TabIndex = 4;
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.Color.Black;
            this.progress.BorderRadius = 5;
            this.progress.Location = new System.Drawing.Point(21, 156);
            this.progress.MaximumValue = 100;
            this.progress.Name = "progress";
            this.progress.ProgressColor = System.Drawing.Color.Teal;
            this.progress.Size = new System.Drawing.Size(167, 12);
            this.progress.TabIndex = 5;
            this.progress.Value = 0;
            // 
            // progresstext
            // 
            this.progresstext.AutoSize = true;
            this.progresstext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.progresstext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.progresstext.ForeColor = System.Drawing.Color.Black;
            this.progresstext.Location = new System.Drawing.Point(194, 153);
            this.progresstext.Name = "progresstext";
            this.progresstext.Size = new System.Drawing.Size(0, 15);
            this.progresstext.TabIndex = 6;
            // 
            // bgwork
            // 
            this.bgwork.WorkerReportsProgress = true;
            this.bgwork.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwork_ProgressChanged);
            this.bgwork.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwork_RunWorkerCompleted);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(207, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(0, 20);
            this.title.TabIndex = 7;
            // 
            // CopyAndMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NinaCommanderv2._0.Properties.Resources.copy_move;
            this.ClientSize = new System.Drawing.Size(465, 180);
            this.Controls.Add(this.title);
            this.Controls.Add(this.progresstext);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.destinationPath);
            this.Controls.Add(this.originalPath);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CopyAndMove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "copy";
            ((System.ComponentModel.ISupportInitialize)(this.ok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox ok;
        private ZBobb.AlphaBlendTextBox originalPath;
        private ZBobb.AlphaBlendTextBox destinationPath;
        private Bunifu.Framework.UI.BunifuProgressBar progress;
        private System.Windows.Forms.Label progresstext;
        private System.ComponentModel.BackgroundWorker bgwork;
        private System.Windows.Forms.Label title;
    }
}