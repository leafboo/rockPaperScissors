namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCPUChoice = new System.Windows.Forms.Label();
            this.lblPlayerChoice = new System.Windows.Forms.Label();
            this.PLAYER_PIC = new System.Windows.Forms.PictureBox();
            this.CPU_PIC = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblComputerResult = new System.Windows.Forms.Label();
            this.lblPlayerResult = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PLAYER_PIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_PIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(592, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 42);
            this.button3.TabIndex = 2;
            this.button3.Tag = "S";
            this.button3.Text = "Scissors";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.MakeChoiceEvent);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(323, 376);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 42);
            this.button4.TabIndex = 3;
            this.button4.Tag = "P";
            this.button4.Text = "Paper";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.MakeChoiceEvent);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(64, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 42);
            this.button1.TabIndex = 4;
            this.button1.Tag = "R";
            this.button1.Text = "Rock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MakeChoiceEvent);
            // 
            // lblCPUChoice
            // 
            this.lblCPUChoice.AutoSize = true;
            this.lblCPUChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUChoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCPUChoice.Location = new System.Drawing.Point(520, 81);
            this.lblCPUChoice.Name = "lblCPUChoice";
            this.lblCPUChoice.Size = new System.Drawing.Size(100, 15);
            this.lblCPUChoice.TabIndex = 7;
            this.lblCPUChoice.Text = "Computer choice";
            // 
            // lblPlayerChoice
            // 
            this.lblPlayerChoice.AutoSize = true;
            this.lblPlayerChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerChoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayerChoice.Location = new System.Drawing.Point(228, 81);
            this.lblPlayerChoice.Name = "lblPlayerChoice";
            this.lblPlayerChoice.Size = new System.Drawing.Size(80, 15);
            this.lblPlayerChoice.TabIndex = 8;
            this.lblPlayerChoice.Text = "Player choice";
            // 
            // PLAYER_PIC
            // 
            this.PLAYER_PIC.BackColor = System.Drawing.Color.Black;
            this.PLAYER_PIC.Location = new System.Drawing.Point(208, 147);
            this.PLAYER_PIC.Name = "PLAYER_PIC";
            this.PLAYER_PIC.Size = new System.Drawing.Size(100, 100);
            this.PLAYER_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PLAYER_PIC.TabIndex = 6;
            this.PLAYER_PIC.TabStop = false;
            this.PLAYER_PIC.Click += new System.EventHandler(this.PLAYER_PIC_Click);
            // 
            // CPU_PIC
            // 
            this.CPU_PIC.BackColor = System.Drawing.Color.Black;
            this.CPU_PIC.Location = new System.Drawing.Point(532, 147);
            this.CPU_PIC.Name = "CPU_PIC";
            this.CPU_PIC.Size = new System.Drawing.Size(100, 100);
            this.CPU_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CPU_PIC.TabIndex = 5;
            this.CPU_PIC.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-41, -32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(847, 493);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblComputerResult
            // 
            this.lblComputerResult.AutoSize = true;
            this.lblComputerResult.Location = new System.Drawing.Point(550, 266);
            this.lblComputerResult.Name = "lblComputerResult";
            this.lblComputerResult.Size = new System.Drawing.Size(86, 13);
            this.lblComputerResult.TabIndex = 10;
            this.lblComputerResult.Text = "Computer Score:";
            // 
            // lblPlayerResult
            // 
            this.lblPlayerResult.AutoSize = true;
            this.lblPlayerResult.Location = new System.Drawing.Point(222, 266);
            this.lblPlayerResult.Name = "lblPlayerResult";
            this.lblPlayerResult.Size = new System.Drawing.Size(70, 13);
            this.lblPlayerResult.TabIndex = 11;
            this.lblPlayerResult.Text = "Player Score:";
            // 
            // lblDraw
            // 
            this.lblDraw.AutoSize = true;
            this.lblDraw.Location = new System.Drawing.Point(383, 201);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(0, 13);
            this.lblDraw.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDraw);
            this.Controls.Add(this.lblPlayerResult);
            this.Controls.Add(this.lblComputerResult);
            this.Controls.Add(this.lblPlayerChoice);
            this.Controls.Add(this.lblCPUChoice);
            this.Controls.Add(this.PLAYER_PIC);
            this.Controls.Add(this.CPU_PIC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.MakeChoiceEvent);
            ((System.ComponentModel.ISupportInitialize)(this.PLAYER_PIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_PIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PLAYER_PIC;
        private System.Windows.Forms.Label lblCPUChoice;
        private System.Windows.Forms.Label lblPlayerChoice;
        private System.Windows.Forms.PictureBox CPU_PIC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblComputerResult;
        private System.Windows.Forms.Label lblPlayerResult;
        private System.Windows.Forms.Label lblDraw;
    }
}

