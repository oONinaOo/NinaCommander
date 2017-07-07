namespace NinaCommanderv2._0
{
    partial class Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete));
            this.corner = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.exit = new System.Windows.Forms.PictureBox();
            this.bg = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.beSure = new System.Windows.Forms.TextBox();
            this.yes = new System.Windows.Forms.PictureBox();
            this.no = new System.Windows.Forms.PictureBox();
            this.yesText = new System.Windows.Forms.Label();
            this.noText = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no)).BeginInit();
            this.SuspendLayout();
            // 
            // corner
            // 
            this.corner.ElipseRadius = 20;
            this.corner.TargetControl = this;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.exit.Image = global::NinaCommanderv2._0.Properties.Resources.exit_dialog;
            this.exit.Location = new System.Drawing.Point(417, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(32, 27);
            this.exit.TabIndex = 1;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            // 
            // bg
            // 
            this.bg.Image = ((System.Drawing.Image)(resources.GetObject("bg.Image")));
            this.bg.Location = new System.Drawing.Point(-1, -1);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(466, 181);
            this.bg.TabIndex = 0;
            this.bg.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(465, 180);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 75;
            this.lineShape1.Y1 = 0;
            this.lineShape1.Y2 = 23;
            // 
            // beSure
            // 
            this.beSure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.beSure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.beSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.beSure.ForeColor = System.Drawing.Color.White;
            this.beSure.Location = new System.Drawing.Point(33, 68);
            this.beSure.Multiline = true;
            this.beSure.Name = "beSure";
            this.beSure.ReadOnly = true;
            this.beSure.Size = new System.Drawing.Size(393, 62);
            this.beSure.TabIndex = 4;
            // 
            // yes
            // 
            this.yes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.yes.Image = global::NinaCommanderv2._0.Properties.Resources.ok;
            this.yes.Location = new System.Drawing.Point(62, 140);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(32, 32);
            this.yes.TabIndex = 5;
            this.yes.TabStop = false;
            this.yes.MouseEnter += new System.EventHandler(this.yes_MouseEnter);
            this.yes.MouseLeave += new System.EventHandler(this.yes_MouseLeave);
            // 
            // no
            // 
            this.no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.no.Image = global::NinaCommanderv2._0.Properties.Resources.exit_dialog;
            this.no.Location = new System.Drawing.Point(360, 140);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(32, 32);
            this.no.TabIndex = 6;
            this.no.TabStop = false;
            this.no.Click += new System.EventHandler(this.no_Click);
            this.no.MouseEnter += new System.EventHandler(this.no_MouseEnter);
            this.no.MouseLeave += new System.EventHandler(this.no_MouseLeave);
            // 
            // yesText
            // 
            this.yesText.AutoSize = true;
            this.yesText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.yesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yesText.ForeColor = System.Drawing.Color.DarkGray;
            this.yesText.Location = new System.Drawing.Point(100, 147);
            this.yesText.Name = "yesText";
            this.yesText.Size = new System.Drawing.Size(36, 13);
            this.yesText.TabIndex = 7;
            this.yesText.Text = "(Yes)";
            // 
            // noText
            // 
            this.noText.AutoSize = true;
            this.noText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.noText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noText.ForeColor = System.Drawing.Color.DarkGray;
            this.noText.Location = new System.Drawing.Point(319, 147);
            this.noText.Name = "noText";
            this.noText.Size = new System.Drawing.Size(35, 13);
            this.noText.TabIndex = 8;
            this.noText.Text = "(No!)";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(200, 11);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(62, 20);
            this.title.TabIndex = 9;
            this.title.Text = "Delete";
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 180);
            this.Controls.Add(this.title);
            this.Controls.Add(this.noText);
            this.Controls.Add(this.yesText);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.beSure);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.bg);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErrorForm";
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bg;
        private System.Windows.Forms.PictureBox exit;
        private Bunifu.Framework.UI.BunifuElipse corner;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox beSure;
        private System.Windows.Forms.Label yesText;
        private System.Windows.Forms.PictureBox no;
        private System.Windows.Forms.PictureBox yes;
        private System.Windows.Forms.Label noText;
        private System.Windows.Forms.Label title;
    }
}