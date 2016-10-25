namespace ShutDown
{
    partial class Main
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.doActionButton = new System.Windows.Forms.Button();
            this.shutdown = new System.Windows.Forms.RadioButton();
            this.shutdownWithQuickStartup = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hibernate = new System.Windows.Forms.RadioButton();
            this.restartAndBoot = new System.Windows.Forms.RadioButton();
            this.logOff = new System.Windows.Forms.RadioButton();
            this.restart = new System.Windows.Forms.RadioButton();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.minutesTextBox = new System.Windows.Forms.TextBox();
            this.secondsTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.Label();
            this.abortButton = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(246, 294);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(186, 23);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "ShoutDawn by BocBoc";
            // 
            // doActionButton
            // 
            this.doActionButton.Location = new System.Drawing.Point(247, 231);
            this.doActionButton.Name = "doActionButton";
            this.doActionButton.Size = new System.Drawing.Size(75, 23);
            this.doActionButton.TabIndex = 2;
            this.doActionButton.Text = "Execute action";
            this.doActionButton.UseVisualStyleBackColor = true;
            this.doActionButton.Click += new System.EventHandler(this.doActionButton_Click);
            // 
            // shutdown
            // 
            this.shutdown.AutoSize = true;
            this.shutdown.Location = new System.Drawing.Point(3, 26);
            this.shutdown.Name = "shutdown";
            this.shutdown.Size = new System.Drawing.Size(73, 17);
            this.shutdown.TabIndex = 3;
            this.shutdown.TabStop = true;
            this.shutdown.Text = "Shutdown";
            this.shutdown.UseVisualStyleBackColor = true;
            // 
            // shutdownWithQuickStartup
            // 
            this.shutdownWithQuickStartup.AutoSize = true;
            this.shutdownWithQuickStartup.Location = new System.Drawing.Point(3, 3);
            this.shutdownWithQuickStartup.Name = "shutdownWithQuickStartup";
            this.shutdownWithQuickStartup.Size = new System.Drawing.Size(145, 17);
            this.shutdownWithQuickStartup.TabIndex = 4;
            this.shutdownWithQuickStartup.TabStop = true;
            this.shutdownWithQuickStartup.Text = "Shutdown W/Quick Start";
            this.shutdownWithQuickStartup.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.shutdownWithQuickStartup);
            this.flowLayoutPanel1.Controls.Add(this.shutdown);
            this.flowLayoutPanel1.Controls.Add(this.hibernate);
            this.flowLayoutPanel1.Controls.Add(this.restartAndBoot);
            this.flowLayoutPanel1.Controls.Add(this.logOff);
            this.flowLayoutPanel1.Controls.Add(this.restart);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(75, 156);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(150, 148);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // hibernate
            // 
            this.hibernate.AutoSize = true;
            this.hibernate.Location = new System.Drawing.Point(3, 49);
            this.hibernate.Name = "hibernate";
            this.hibernate.Size = new System.Drawing.Size(71, 17);
            this.hibernate.TabIndex = 7;
            this.hibernate.TabStop = true;
            this.hibernate.Text = "Hibernate";
            this.hibernate.UseVisualStyleBackColor = true;
            // 
            // restartAndBoot
            // 
            this.restartAndBoot.AutoSize = true;
            this.restartAndBoot.Location = new System.Drawing.Point(3, 72);
            this.restartAndBoot.Name = "restartAndBoot";
            this.restartAndBoot.Size = new System.Drawing.Size(134, 17);
            this.restartAndBoot.TabIndex = 8;
            this.restartAndBoot.TabStop = true;
            this.restartAndBoot.Text = "Restart and Open Boot";
            this.restartAndBoot.UseVisualStyleBackColor = true;
            // 
            // logOff
            // 
            this.logOff.AutoSize = true;
            this.logOff.Location = new System.Drawing.Point(3, 95);
            this.logOff.Name = "logOff";
            this.logOff.Size = new System.Drawing.Size(102, 17);
            this.logOff.TabIndex = 6;
            this.logOff.TabStop = true;
            this.logOff.Text = "Log Off              ";
            this.logOff.UseVisualStyleBackColor = true;
            // 
            // restart
            // 
            this.restart.AutoSize = true;
            this.restart.Location = new System.Drawing.Point(3, 118);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(59, 17);
            this.restart.TabIndex = 5;
            this.restart.TabStop = true;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = true;
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(247, 159);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(55, 20);
            this.hoursTextBox.TabIndex = 6;
            this.hoursTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // minutesTextBox
            // 
            this.minutesTextBox.Location = new System.Drawing.Point(247, 183);
            this.minutesTextBox.Name = "minutesTextBox";
            this.minutesTextBox.Size = new System.Drawing.Size(55, 20);
            this.minutesTextBox.TabIndex = 7;
            this.minutesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.Location = new System.Drawing.Point(247, 205);
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.Size = new System.Drawing.Size(55, 20);
            this.secondsTextBox.TabIndex = 8;
            this.secondsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(309, 165);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(13, 13);
            this.label.TabIndex = 9;
            this.label.Text = "h";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "s";
            // 
            // statusBar
            // 
            this.statusBar.AutoSize = true;
            this.statusBar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.statusBar.Location = new System.Drawing.Point(117, 43);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(0, 27);
            this.statusBar.TabIndex = 10;
            // 
            // abortButton
            // 
            this.abortButton.Location = new System.Drawing.Point(246, 260);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(75, 23);
            this.abortButton.TabIndex = 11;
            this.abortButton.Text = "Cancel";
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.errorMessage.Location = new System.Drawing.Point(114, 307);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 13);
            this.errorMessage.TabIndex = 12;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 326);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.secondsTextBox);
            this.Controls.Add(this.minutesTextBox);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.doActionButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "Main";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button doActionButton;
        private System.Windows.Forms.RadioButton shutdown;
        private System.Windows.Forms.RadioButton shutdownWithQuickStartup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton restart;
        private System.Windows.Forms.RadioButton logOff;
        private System.Windows.Forms.RadioButton hibernate;
        private System.Windows.Forms.RadioButton restartAndBoot;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.TextBox minutesTextBox;
        private System.Windows.Forms.TextBox secondsTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label statusBar;
        private System.Windows.Forms.Button abortButton;
        private System.Windows.Forms.Label errorMessage;
    }
}

