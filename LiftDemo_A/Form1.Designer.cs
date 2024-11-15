namespace LiftDemo_A
{
	partial class Form1
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
            this.liftTimerUp = new System.Windows.Forms.Timer(this.components);
            this.doorTimer = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.liftTimerDown = new System.Windows.Forms.Timer(this.components);
            this.doorRight_1 = new System.Windows.Forms.PictureBox();
            this.doorLeft_1 = new System.Windows.Forms.PictureBox();
            this.doorRight_G = new System.Windows.Forms.PictureBox();
            this.doorLeft_G = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_G = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.liftPanel = new System.Windows.Forms.PictureBox();
            this.mainElevator = new System.Windows.Forms.PictureBox();
            this.indicator = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRight_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeft_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRight_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeft_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainElevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // liftTimerUp
            // 
            this.liftTimerUp.Interval = 50;
            this.liftTimerUp.Tick += new System.EventHandler(this.liftTimerUp_Tick);
            // 
            // doorTimer
            // 
            this.doorTimer.Tick += new System.EventHandler(this.door_Timer_Tick);
            // 
            // dataGridViewLogs
            // 
            this.dataGridViewLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLogs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogs.Location = new System.Drawing.Point(927, 224);
            this.dataGridViewLogs.Name = "dataGridViewLogs";
            this.dataGridViewLogs.RowHeadersWidth = 51;
            this.dataGridViewLogs.RowTemplate.Height = 24;
            this.dataGridViewLogs.Size = new System.Drawing.Size(413, 372);
            this.dataGridViewLogs.TabIndex = 10;
            this.dataGridViewLogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLogs_CellContentClick);
            // 
            // liftTimerDown
            // 
            this.liftTimerDown.Interval = 50;
            this.liftTimerDown.Tick += new System.EventHandler(this.liftTimerDown_Tick);
            // 
            // doorRight_1
            // 
            this.doorRight_1.BackgroundImage = global::LiftDemo_A.Properties.Resources.liftdoor15;
            this.doorRight_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorRight_1.Location = new System.Drawing.Point(173, 0);
            this.doorRight_1.Name = "doorRight_1";
            this.doorRight_1.Size = new System.Drawing.Size(81, 202);
            this.doorRight_1.TabIndex = 9;
            this.doorRight_1.TabStop = false;
            // 
            // doorLeft_1
            // 
            this.doorLeft_1.BackgroundImage = global::LiftDemo_A.Properties.Resources.liftdoor14;
            this.doorLeft_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorLeft_1.Location = new System.Drawing.Point(95, 0);
            this.doorLeft_1.Name = "doorLeft_1";
            this.doorLeft_1.Size = new System.Drawing.Size(83, 202);
            this.doorLeft_1.TabIndex = 8;
            this.doorLeft_1.TabStop = false;
            // 
            // doorRight_G
            // 
            this.doorRight_G.BackgroundImage = global::LiftDemo_A.Properties.Resources.liftdoor12;
            this.doorRight_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorRight_G.Location = new System.Drawing.Point(175, 391);
            this.doorRight_G.Name = "doorRight_G";
            this.doorRight_G.Size = new System.Drawing.Size(81, 213);
            this.doorRight_G.TabIndex = 7;
            this.doorRight_G.TabStop = false;
            // 
            // doorLeft_G
            // 
            this.doorLeft_G.BackgroundImage = global::LiftDemo_A.Properties.Resources.liftdoor13;
            this.doorLeft_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorLeft_G.Location = new System.Drawing.Point(94, 391);
            this.doorLeft_G.Name = "doorLeft_G";
            this.doorLeft_G.Size = new System.Drawing.Size(83, 213);
            this.doorLeft_G.TabIndex = 6;
            this.doorLeft_G.TabStop = false;
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = global::LiftDemo_A.Properties.Resources.closedoorsbutton11;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Close.Location = new System.Drawing.Point(855, 470);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(55, 53);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.BackgroundImage = global::LiftDemo_A.Properties.Resources.opendoorbutton11;
            this.btn_Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Open.Location = new System.Drawing.Point(751, 471);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(55, 53);
            this.btn_Open.TabIndex = 4;
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_G
            // 
            this.btn_G.BackgroundImage = global::LiftDemo_A.Properties.Resources.letter_g6;
            this.btn_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_G.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_G.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_G.Location = new System.Drawing.Point(802, 397);
            this.btn_G.Name = "btn_G";
            this.btn_G.Size = new System.Drawing.Size(55, 53);
            this.btn_G.TabIndex = 3;
            this.btn_G.UseVisualStyleBackColor = true;
            this.btn_G.Click += new System.EventHandler(this.btn_G_click);
            // 
            // btn_1
            // 
            this.btn_1.BackgroundImage = global::LiftDemo_A.Properties.Resources.number_11;
            this.btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_1.Location = new System.Drawing.Point(802, 320);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(55, 53);
            this.btn_1.TabIndex = 2;
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_click);
            // 
            // liftPanel
            // 
            this.liftPanel.BackgroundImage = global::LiftDemo_A.Properties.Resources.plate2;
            this.liftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.liftPanel.Location = new System.Drawing.Point(731, 224);
            this.liftPanel.Name = "liftPanel";
            this.liftPanel.Size = new System.Drawing.Size(193, 372);
            this.liftPanel.TabIndex = 1;
            this.liftPanel.TabStop = false;
            this.liftPanel.Click += new System.EventHandler(this.liftPanel_Click);
            // 
            // mainElevator
            // 
            this.mainElevator.BackgroundImage = global::LiftDemo_A.Properties.Resources.liftindoor;
            this.mainElevator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainElevator.Location = new System.Drawing.Point(94, 391);
            this.mainElevator.Name = "mainElevator";
            this.mainElevator.Size = new System.Drawing.Size(162, 203);
            this.mainElevator.TabIndex = 0;
            this.mainElevator.TabStop = false;
            // 
            // indicator
            // 
            this.indicator.AccessibleName = "";
            this.indicator.BackColor = System.Drawing.Color.Gainsboro;
            this.indicator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.indicator.Enabled = false;
            this.indicator.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicator.ForeColor = System.Drawing.Color.Lime;
            this.indicator.Location = new System.Drawing.Point(811, 264);
            this.indicator.Multiline = true;
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(36, 40);
            this.indicator.TabIndex = 11;
            this.indicator.Text = "G";
            this.indicator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.indicator.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearBtn.Location = new System.Drawing.Point(927, 175);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(121, 47);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LiftDemo_A.Properties.Resources.plate2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(360, 392);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 205);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::LiftDemo_A.Properties.Resources.direction_north1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(390, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 51);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::LiftDemo_A.Properties.Resources.direction_south1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(389, 519);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 53);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LiftDemo_A.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1341, 599);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.indicator);
            this.Controls.Add(this.dataGridViewLogs);
            this.Controls.Add(this.doorRight_1);
            this.Controls.Add(this.doorLeft_1);
            this.Controls.Add(this.doorRight_G);
            this.Controls.Add(this.doorLeft_G);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.btn_G);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.liftPanel);
            this.Controls.Add(this.mainElevator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRight_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeft_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRight_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeft_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainElevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox mainElevator;
		private System.Windows.Forms.PictureBox liftPanel;
		private System.Windows.Forms.Button btn_1;
		private System.Windows.Forms.Button btn_G;
		private System.Windows.Forms.Button btn_Open;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.Timer liftTimerUp;
		private System.Windows.Forms.PictureBox doorLeft_G;
		private System.Windows.Forms.PictureBox doorRight_G;
		private System.Windows.Forms.PictureBox doorRight_1;
		private System.Windows.Forms.PictureBox doorLeft_1;
		private System.Windows.Forms.Timer doorTimer;
		private System.Windows.Forms.DataGridView dataGridViewLogs;
		private System.Windows.Forms.Timer liftTimerDown;
        private System.Windows.Forms.TextBox indicator;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

