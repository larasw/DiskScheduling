namespace DSTry
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
            this.radioFCFS = new System.Windows.Forms.RadioButton();
            this.radioSTF = new System.Windows.Forms.RadioButton();
            this.radioElevator = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.arrayBox = new System.Windows.Forms.RichTextBox();
            this.killBox = new System.Windows.Forms.TextBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // radioFCFS
            // 
            this.radioFCFS.AutoSize = true;
            this.radioFCFS.Location = new System.Drawing.Point(18, 21);
            this.radioFCFS.Name = "radioFCFS";
            this.radioFCFS.Size = new System.Drawing.Size(63, 21);
            this.radioFCFS.TabIndex = 2;
            this.radioFCFS.TabStop = true;
            this.radioFCFS.Text = "FCFS";
            this.radioFCFS.UseVisualStyleBackColor = true;
            this.radioFCFS.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioSTF
            // 
            this.radioSTF.AutoSize = true;
            this.radioSTF.Location = new System.Drawing.Point(18, 48);
            this.radioSTF.Name = "radioSTF";
            this.radioSTF.Size = new System.Drawing.Size(55, 21);
            this.radioSTF.TabIndex = 3;
            this.radioSTF.TabStop = true;
            this.radioSTF.Text = "STF";
            this.radioSTF.UseVisualStyleBackColor = true;
            this.radioSTF.CheckedChanged += new System.EventHandler(this.radioSTF_CheckedChanged);
            // 
            // radioElevator
            // 
            this.radioElevator.AutoSize = true;
            this.radioElevator.Location = new System.Drawing.Point(18, 75);
            this.radioElevator.Name = "radioElevator";
            this.radioElevator.Size = new System.Drawing.Size(81, 21);
            this.radioElevator.TabIndex = 4;
            this.radioElevator.TabStop = true;
            this.radioElevator.Text = "Elevator";
            this.radioElevator.UseVisualStyleBackColor = true;
            this.radioElevator.CheckedChanged += new System.EventHandler(this.radioElevator_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioElevator);
            this.groupBox1.Controls.Add(this.radioFCFS);
            this.groupBox1.Controls.Add(this.radioSTF);
            this.groupBox1.Location = new System.Drawing.Point(256, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 119);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(256, 174);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(146, 37);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(256, 238);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(146, 39);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // arrayBox
            // 
            this.arrayBox.Location = new System.Drawing.Point(132, 59);
            this.arrayBox.Name = "arrayBox";
            this.arrayBox.Size = new System.Drawing.Size(100, 218);
            this.arrayBox.TabIndex = 8;
            this.arrayBox.Text = "";
            // 
            // killBox
            // 
            this.killBox.Location = new System.Drawing.Point(132, 31);
            this.killBox.Name = "killBox";
            this.killBox.Size = new System.Drawing.Size(100, 22);
            this.killBox.TabIndex = 9;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(36, 26);
            this.trackBar.Maximum = 100;
            this.trackBar.Name = "trackBar";
            this.trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar.Size = new System.Drawing.Size(56, 261);
            this.trackBar.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 314);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.killBox);
            this.Controls.Add(this.arrayBox);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioFCFS;
        private System.Windows.Forms.RadioButton radioSTF;
        private System.Windows.Forms.RadioButton radioElevator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox arrayBox;
        private System.Windows.Forms.TextBox killBox;
        private System.Windows.Forms.TrackBar trackBar;
    }
}

