namespace TrackResults.View
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.eventComboBox = new System.Windows.Forms.ComboBox();
            this.lblSelectEvent = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.timeTextBox);
            this.panel1.Controls.Add(this.eventNameTextBox);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblEventName);
            this.panel1.Location = new System.Drawing.Point(114, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 180);
            this.panel1.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(112, 145);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(152, 81);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(118, 23);
            this.timeTextBox.TabIndex = 4;
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Location = new System.Drawing.Point(152, 18);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(118, 23);
            this.eventNameTextBox.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(55, 84);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 15);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(17, 21);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(75, 15);
            this.lblEventName.TabIndex = 1;
            this.lblEventName.Text = "Event Name";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(404, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // eventComboBox
            // 
            this.eventComboBox.FormattingEnabled = true;
            this.eventComboBox.Location = new System.Drawing.Point(519, 56);
            this.eventComboBox.Name = "eventComboBox";
            this.eventComboBox.Size = new System.Drawing.Size(121, 23);
            this.eventComboBox.TabIndex = 2;
            this.eventComboBox.SelectedIndexChanged += new System.EventHandler(this.eventComboBox_SelectedIndexChanged);
            // 
            // lblSelectEvent
            // 
            this.lblSelectEvent.AutoSize = true;
            this.lblSelectEvent.Location = new System.Drawing.Point(519, 26);
            this.lblSelectEvent.Name = "lblSelectEvent";
            this.lblSelectEvent.Size = new System.Drawing.Size(67, 15);
            this.lblSelectEvent.TabIndex = 3;
            this.lblSelectEvent.Text = "Select Event";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSelectEvent);
            this.Controls.Add(this.eventComboBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Track Meet Results";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox eventComboBox;
        private System.Windows.Forms.Label lblSelectEvent;
    }
}
