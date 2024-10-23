namespace CodeLockdown2 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.gameLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 656);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.StartGame);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 638);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(103)))), ((int)(((byte)(128)))));
            this.labelStatus.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(103)))), ((int)(((byte)(128)))));
            this.labelStatus.Location = new System.Drawing.Point(100, 493);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(77, 90);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "6";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameLabel
            // 
            this.gameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(103)))), ((int)(((byte)(128)))));
            this.gameLabel.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(103)))), ((int)(((byte)(128)))));
            this.gameLabel.Location = new System.Drawing.Point(160, 381);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(476, 40);
            this.gameLabel.TabIndex = 4;
            this.gameLabel.Text = "\"Current Password: \" + currend;";
            this.gameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // passwordInput
            // 
            this.passwordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(103)))), ((int)(((byte)(128)))));
            this.passwordInput.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.passwordInput.Location = new System.Drawing.Point(230, 306);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(336, 45);
            this.passwordInput.TabIndex = 5;
            this.passwordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordInput_KeyDown);
            // 
            // stateLabel
            // 
            this.stateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(103)))), ((int)(((byte)(128)))));
            this.stateLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.ForeColor = System.Drawing.Color.Snow;
            this.stateLabel.Location = new System.Drawing.Point(12, 226);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(776, 45);
            this.stateLabel.TabIndex = 6;
            this.stateLabel.Text = "               Press Start to Play!                              ";
            this.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 720);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.gameLabel);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label stateLabel;
    }
}

