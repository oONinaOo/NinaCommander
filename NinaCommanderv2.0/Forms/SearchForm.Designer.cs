namespace NinaCommanderv2._0
{
    partial class SearchForm
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
            this.title = new System.Windows.Forms.Label();
            this.searchDir = new ZBobb.AlphaBlendTextBox();
            this.ok = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.pattern = new ZBobb.AlphaBlendTextBox();
            this.result = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(206, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(66, 20);
            this.title.TabIndex = 10;
            this.title.Text = "Search";
            // 
            // searchDir
            // 
            this.searchDir.BackAlpha = 98;
            this.searchDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchDir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchDir.Location = new System.Drawing.Point(33, 63);
            this.searchDir.Name = "searchDir";
            this.searchDir.Size = new System.Drawing.Size(399, 17);
            this.searchDir.TabIndex = 11;
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.ok.Image = global::NinaCommanderv2._0.Properties.Resources.ok;
            this.ok.Location = new System.Drawing.Point(421, 140);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(32, 32);
            this.ok.TabIndex = 12;
            this.ok.TabStop = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            this.ok.MouseEnter += new System.EventHandler(this.ok_MouseEnter);
            this.ok.MouseLeave += new System.EventHandler(this.ok_MouseLeave);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.exit.Image = global::NinaCommanderv2._0.Properties.Resources.exit_dialog;
            this.exit.Location = new System.Drawing.Point(421, 8);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(32, 27);
            this.exit.TabIndex = 13;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            // 
            // pattern
            // 
            this.pattern.BackAlpha = 98;
            this.pattern.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pattern.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pattern.Location = new System.Drawing.Point(33, 108);
            this.pattern.Name = "pattern";
            this.pattern.Size = new System.Drawing.Size(399, 17);
            this.pattern.TabIndex = 14;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.ForeColor = System.Drawing.Color.White;
            this.result.FormattingEnabled = true;
            this.result.Location = new System.Drawing.Point(12, 180);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(441, 221);
            this.result.TabIndex = 15;
            this.result.SelectedIndexChanged += new System.EventHandler(this.result_SelectedIndexChanged);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NinaCommanderv2._0.Properties.Resources.search;
            this.ClientSize = new System.Drawing.Size(465, 420);
            this.Controls.Add(this.result);
            this.Controls.Add(this.pattern);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.searchDir);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.ok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private ZBobb.AlphaBlendTextBox searchDir;
        private System.Windows.Forms.PictureBox ok;
        private System.Windows.Forms.PictureBox exit;
        private ZBobb.AlphaBlendTextBox pattern;
        private System.Windows.Forms.ListBox result;
    }
}