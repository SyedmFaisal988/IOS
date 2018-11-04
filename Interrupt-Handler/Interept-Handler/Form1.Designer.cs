namespace Interept_Handler
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Exe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SoftInt = new System.Windows.Forms.Button();
            this.HardInt = new System.Windows.Forms.Button();
            this.ProcessCompletionTime = new System.Windows.Forms.Timer(this.components);
            this.softIntTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.exeTime = new System.Windows.Forms.Button();
            this.readyQueBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-1, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "No of Process";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(132, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Exe
            // 
            this.Exe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Exe.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Exe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exe.Location = new System.Drawing.Point(3, 200);
            this.Exe.Name = "Exe";
            this.Exe.Size = new System.Drawing.Size(93, 36);
            this.Exe.TabIndex = 12;
            this.Exe.Text = "Run";
            this.Exe.UseVisualStyleBackColor = true;
            this.Exe.Click += new System.EventHandler(this.Exe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Process Execution";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(347, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Interrupt-Status";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(496, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(190, 26);
            this.textBox3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(345, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Interrupt Process";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(496, 69);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(190, 26);
            this.textBox4.TabIndex = 7;
            // 
            // SoftInt
            // 
            this.SoftInt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SoftInt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SoftInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftInt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SoftInt.Location = new System.Drawing.Point(336, 200);
            this.SoftInt.Name = "SoftInt";
            this.SoftInt.Size = new System.Drawing.Size(166, 36);
            this.SoftInt.TabIndex = 6;
            this.SoftInt.Text = "Software Interept";
            this.SoftInt.UseVisualStyleBackColor = true;
            this.SoftInt.Click += new System.EventHandler(this.SoftInt_Click);
            // 
            // HardInt
            // 
            this.HardInt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.HardInt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.HardInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardInt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HardInt.Location = new System.Drawing.Point(505, 200);
            this.HardInt.Name = "HardInt";
            this.HardInt.Size = new System.Drawing.Size(184, 36);
            this.HardInt.TabIndex = 5;
            this.HardInt.Text = "Hardware Interept";
            this.HardInt.UseVisualStyleBackColor = true;
            this.HardInt.Click += new System.EventHandler(this.HardInt_Click);
            // 
            // ProcessCompletionTime
            // 
            this.ProcessCompletionTime.Interval = 500;
            this.ProcessCompletionTime.Tick += new System.EventHandler(this.ProcessCompletionTime_Tick);
            // 
            // softIntTimer
            // 
            this.softIntTimer.Interval = 1500;
            this.softIntTimer.Tick += new System.EventHandler(this.softIntTimer_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(229, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(132, 73);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(193, 26);
            this.textBox5.TabIndex = 2;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(-1, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quantum Size";
            // 
            // exeTime
            // 
            this.exeTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.exeTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exeTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exeTime.Location = new System.Drawing.Point(99, 200);
            this.exeTime.Name = "exeTime";
            this.exeTime.Size = new System.Drawing.Size(126, 36);
            this.exeTime.TabIndex = 0;
            this.exeTime.Text = "Exe Time";
            this.exeTime.UseVisualStyleBackColor = true;
            this.exeTime.Click += new System.EventHandler(this.exeTime_Click);
            // 
            // readyQueBox
            // 
            this.readyQueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyQueBox.Location = new System.Drawing.Point(132, 120);
            this.readyQueBox.Name = "readyQueBox";
            this.readyQueBox.Size = new System.Drawing.Size(554, 26);
            this.readyQueBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(-1, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ready Queue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(701, 247);
            this.Controls.Add(this.readyQueBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.exeTime);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HardInt);
            this.Controls.Add(this.SoftInt);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exe);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Interrupt-Handler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Exe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button SoftInt;
        private System.Windows.Forms.Button HardInt;
        private System.Windows.Forms.Timer ProcessCompletionTime;
        private System.Windows.Forms.Timer softIntTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button exeTime;
        private System.Windows.Forms.TextBox readyQueBox;
        private System.Windows.Forms.Label label6;
    }
}

