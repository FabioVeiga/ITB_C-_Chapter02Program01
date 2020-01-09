namespace Chapter02Program01
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDisplayOutput = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 7);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(422, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(93, 33);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(422, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(93, 59);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(118, 20);
            this.txtCity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "City:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(298, 57);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(65, 20);
            this.txtState.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(217, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "State:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(450, 57);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(65, 20);
            this.txtZip.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(369, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Zip:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnDisplayOutput
            // 
            this.btnDisplayOutput.Location = new System.Drawing.Point(12, 84);
            this.btnDisplayOutput.Name = "btnDisplayOutput";
            this.btnDisplayOutput.Size = new System.Drawing.Size(104, 36);
            this.btnDisplayOutput.TabIndex = 10;
            this.btnDisplayOutput.Text = "Display";
            this.btnDisplayOutput.UseVisualStyleBackColor = true;
            this.btnDisplayOutput.Click += new System.EventHandler(this.BtnDisplayOutput_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(411, 84);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(104, 36);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(12, 126);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(503, 175);
            this.txtDisplay.TabIndex = 12;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 313);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.btnDisplayOutput);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mailing Label Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDisplayOutput;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox txtDisplay;
    }
}