namespace Timer
{
    partial class TimeNow
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
            this.lbTimeNow = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbTimeNow
            // 
            this.lbTimeNow.AutoSize = true;
            this.lbTimeNow.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbTimeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeNow.Location = new System.Drawing.Point(82, 29);
            this.lbTimeNow.Name = "lbTimeNow";
            this.lbTimeNow.Size = new System.Drawing.Size(292, 73);
            this.lbTimeNow.TabIndex = 4;
            this.lbTimeNow.Text = "00:00:00";
            this.lbTimeNow.Click += new System.EventHandler(this.lbChronologie_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // TimeNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(476, 133);
            this.Controls.Add(this.lbTimeNow);
            this.Name = "TimeNow";
            this.Text = "TimeNow";
            this.Load += new System.EventHandler(this.TimeNow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTimeNow;
        private System.Windows.Forms.Timer timer2;
    }
}