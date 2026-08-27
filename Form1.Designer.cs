namespace Timer
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopWatchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timerNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stopWatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbChronologie = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnMark = new System.Windows.Forms.Button();
            this.btnRestat = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderMark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDuring = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MyName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopWatchToolStripMenuItem1,
            this.timerNowToolStripMenuItem,
            this.timerToolStripMenuItem1});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            this.optionToolStripMenuItem.Click += new System.EventHandler(this.optionToolStripMenuItem_Click);
            // 
            // stopWatchToolStripMenuItem1
            // 
            this.stopWatchToolStripMenuItem1.Name = "stopWatchToolStripMenuItem1";
            this.stopWatchToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.stopWatchToolStripMenuItem1.Text = "Stop Watch";
            this.stopWatchToolStripMenuItem1.Click += new System.EventHandler(this.stopWatchToolStripMenuItem1_Click);
            // 
            // timerNowToolStripMenuItem
            // 
            this.timerNowToolStripMenuItem.Name = "timerNowToolStripMenuItem";
            this.timerNowToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.timerNowToolStripMenuItem.Text = "Timer Now";
            this.timerNowToolStripMenuItem.Click += new System.EventHandler(this.timerNowToolStripMenuItem_Click);
            // 
            // timerToolStripMenuItem1
            // 
            this.timerToolStripMenuItem1.Name = "timerToolStripMenuItem1";
            this.timerToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.timerToolStripMenuItem1.Text = "Timer";
            this.timerToolStripMenuItem1.Click += new System.EventHandler(this.timerToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopWatchToolStripMenuItem,
            this.timeNowToolStripMenuItem,
            this.timerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 70);
            // 
            // stopWatchToolStripMenuItem
            // 
            this.stopWatchToolStripMenuItem.Name = "stopWatchToolStripMenuItem";
            this.stopWatchToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.stopWatchToolStripMenuItem.Text = "Stop Watch";
            // 
            // timeNowToolStripMenuItem
            // 
            this.timeNowToolStripMenuItem.Name = "timeNowToolStripMenuItem";
            this.timeNowToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.timeNowToolStripMenuItem.Text = "Time Now";
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.timerToolStripMenuItem.Text = "Timer";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbChronologie
            // 
            this.lbChronologie.AutoSize = true;
            this.lbChronologie.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbChronologie.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChronologie.Location = new System.Drawing.Point(38, 71);
            this.lbChronologie.Name = "lbChronologie";
            this.lbChronologie.Size = new System.Drawing.Size(292, 73);
            this.lbChronologie.TabIndex = 3;
            this.lbChronologie.Text = "00:00:00";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(51, 183);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(91, 36);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnMark
            // 
            this.btnMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMark.Location = new System.Drawing.Point(148, 183);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(91, 36);
            this.btnMark.TabIndex = 5;
            this.btnMark.Text = "Mark";
            this.btnMark.UseVisualStyleBackColor = true;
            this.btnMark.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRestat
            // 
            this.btnRestat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestat.Location = new System.Drawing.Point(245, 183);
            this.btnRestat.Name = "btnRestat";
            this.btnRestat.Size = new System.Drawing.Size(91, 36);
            this.btnRestat.TabIndex = 6;
            this.btnRestat.Text = "Restart";
            this.btnRestat.UseVisualStyleBackColor = true;
            this.btnRestat.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMark,
            this.columnHeaderTime,
            this.columnHeaderDuring});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(342, 71);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(446, 275);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_2);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeaderMark
            // 
            this.columnHeaderMark.Text = "Mark";
            this.columnHeaderMark.Width = 77;
            // 
            // columnHeaderTime
            // 
            this.columnHeaderTime.Text = "Time";
            this.columnHeaderTime.Width = 173;
            // 
            // columnHeaderDuring
            // 
            this.columnHeaderDuring.Text = "During";
            this.columnHeaderDuring.Width = 280;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "delete.png");
            this.imageList1.Images.SetKeyName(1, "eye.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Timer.Properties.Resources.delete;
            this.pictureBox1.Location = new System.Drawing.Point(160, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MyName
            // 
            this.MyName.AutoSize = true;
            this.MyName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MyName.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MyName.Location = new System.Drawing.Point(603, 36);
            this.MyName.Name = "MyName";
            this.MyName.Size = new System.Drawing.Size(185, 15);
            this.MyName.TabIndex = 36;
            this.MyName.Text = "By : Djibril Bocar Sall";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(289, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 39);
            this.label1.TabIndex = 37;
            this.label1.Text = "Timer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MyName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnRestat);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbChronologie);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stopWatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbChronologie;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.Button btnRestat;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderMark;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
        private System.Windows.Forms.ColumnHeader columnHeaderDuring;
        private System.Windows.Forms.ToolStripMenuItem stopWatchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem timerNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MyName;
        private System.Windows.Forms.Label label1;
    }
}

