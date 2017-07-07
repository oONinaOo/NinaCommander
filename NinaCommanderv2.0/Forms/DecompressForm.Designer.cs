namespace NinaCommanderv2._0
{
    partial class DecompressForm
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
            this.exit = new System.Windows.Forms.PictureBox();
            this.getPath = new ZBobb.AlphaBlendTextBox();
            this.ok = new System.Windows.Forms.PictureBox();
            this.decompressingBG = new System.ComponentModel.BackgroundWorker();
            this.title = new System.Windows.Forms.Label();
            this.progress = new Bunifu.Framework.UI.BunifuProgressBar();
            this.progresstext = new System.Windows.Forms.Label();
            this.afterText = new System.Windows.Forms.Label();
            this.after = new System.Windows.Forms.Label();
            this.pw = new System.Windows.Forms.TextBox();
            this.pwText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ok)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.exit.Image = global::NinaCommanderv2._0.Properties.Resources.exit_dialog;
            this.exit.Location = new System.Drawing.Point(428, 8);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(29, 27);
            this.exit.TabIndex = 2;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            // 
            // getPath
            // 
            this.getPath.BackAlpha = 90;
            this.getPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.getPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.getPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.getPath.ForeColor = System.Drawing.Color.Black;
            this.getPath.Location = new System.Drawing.Point(32, 62);
            this.getPath.Name = "getPath";
            this.getPath.Size = new System.Drawing.Size(403, 19);
            this.getPath.TabIndex = 3;
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.ok.Image = global::NinaCommanderv2._0.Properties.Resources.ok;
            this.ok.Location = new System.Drawing.Point(425, 145);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(34, 30);
            this.ok.TabIndex = 4;
            this.ok.TabStop = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            this.ok.MouseEnter += new System.EventHandler(this.ok_MouseEnter);
            this.ok.MouseLeave += new System.EventHandler(this.ok_MouseLeave);
            // 
            // decompressingBG
            // 
            this.decompressingBG.WorkerReportsProgress = true;
            this.decompressingBG.WorkerSupportsCancellation = true;
            this.decompressingBG.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.compressingBG_ProgressChanged);
            this.decompressingBG.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.compressingBG_RunWorkerCompleted);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(181, 11);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(109, 20);
            this.title.TabIndex = 8;
            this.title.Text = "Decompress";
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.Color.Black;
            this.progress.BorderRadius = 5;
            this.progress.Location = new System.Drawing.Point(48, 156);
            this.progress.MaximumValue = 100;
            this.progress.Name = "progress";
            this.progress.ProgressColor = System.Drawing.Color.Teal;
            this.progress.Size = new System.Drawing.Size(167, 12);
            this.progress.TabIndex = 9;
            this.progress.Value = 0;
            // 
            // progresstext
            // 
            this.progresstext.AutoSize = true;
            this.progresstext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.progresstext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.progresstext.ForeColor = System.Drawing.Color.Black;
            this.progresstext.Location = new System.Drawing.Point(222, 153);
            this.progresstext.Name = "progresstext";
            this.progresstext.Size = new System.Drawing.Size(0, 15);
            this.progresstext.TabIndex = 10;
            // 
            // afterText
            // 
            this.afterText.AutoSize = true;
            this.afterText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.afterText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.afterText.Location = new System.Drawing.Point(29, 98);
            this.afterText.Name = "afterText";
            this.afterText.Size = new System.Drawing.Size(109, 13);
            this.afterText.TabIndex = 12;
            this.afterText.Text = "After decompression: ";
            // 
            // after
            // 
            this.after.AutoSize = true;
            this.after.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.after.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.after.Location = new System.Drawing.Point(144, 98);
            this.after.Name = "after";
            this.after.Size = new System.Drawing.Size(0, 13);
            this.after.TabIndex = 13;
            // 
            // pw
            // 
            this.pw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.pw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pw.ForeColor = System.Drawing.Color.DarkGray;
            this.pw.Location = new System.Drawing.Point(143, 117);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(249, 11);
            this.pw.TabIndex = 16;
            this.pw.Text = "provide password...";
            this.pw.Enter += new System.EventHandler(this.pw_Enter);
            // 
            // pwText
            // 
            this.pwText.AutoSize = true;
            this.pwText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.pwText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.pwText.Location = new System.Drawing.Point(29, 116);
            this.pwText.Name = "pwText";
            this.pwText.Size = new System.Drawing.Size(56, 13);
            this.pwText.TabIndex = 15;
            this.pwText.Text = "Password:";
            // 
            // DecompressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NinaCommanderv2._0.Properties.Resources.compress;
            this.ClientSize = new System.Drawing.Size(465, 180);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.pwText);
            this.Controls.Add(this.after);
            this.Controls.Add(this.afterText);
            this.Controls.Add(this.progresstext);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.title);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.getPath);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DecompressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompressForm";
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exit;
        private ZBobb.AlphaBlendTextBox getPath;
        private System.Windows.Forms.PictureBox ok;
        private System.ComponentModel.BackgroundWorker decompressingBG;
        private System.Windows.Forms.Label title;
        private Bunifu.Framework.UI.BunifuProgressBar progress;
        private System.Windows.Forms.Label progresstext;
        private System.Windows.Forms.Label afterText;
        private System.Windows.Forms.Label after;
        private System.Windows.Forms.TextBox pw;
        private System.Windows.Forms.Label pwText;
    }
}