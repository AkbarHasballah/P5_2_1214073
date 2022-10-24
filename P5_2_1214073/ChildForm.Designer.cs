namespace P5_2_1214073
{
    partial class ChildForm
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
            this.outputlabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.OutputgroupBox = new System.Windows.Forms.GroupBox();
            this.DateOption = new System.Windows.Forms.RadioButton();
            this.TimeOption = new System.Windows.Forms.RadioButton();
            this.OutputgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // outputlabel
            // 
            this.outputlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputlabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.outputlabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputlabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.outputlabel.Location = new System.Drawing.Point(0, 0);
            this.outputlabel.Name = "outputlabel";
            this.outputlabel.Size = new System.Drawing.Size(293, 32);
            this.outputlabel.TabIndex = 0;
            this.outputlabel.Text = "label2";
            this.outputlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outputlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Location = new System.Drawing.Point(181, 78);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(37, 78);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayButton.TabIndex = 2;
            this.DisplayButton.Text = "&Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // OutputgroupBox
            // 
            this.OutputgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputgroupBox.Controls.Add(this.TimeOption);
            this.OutputgroupBox.Controls.Add(this.DateOption);
            this.OutputgroupBox.Location = new System.Drawing.Point(46, 152);
            this.OutputgroupBox.Name = "OutputgroupBox";
            this.OutputgroupBox.Size = new System.Drawing.Size(200, 104);
            this.OutputgroupBox.TabIndex = 4;
            this.OutputgroupBox.TabStop = false;
            this.OutputgroupBox.Text = "Choose Output";
            this.OutputgroupBox.Enter += new System.EventHandler(this.OutputgroupBox_Enter);
            // 
            // DateOption
            // 
            this.DateOption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateOption.Location = new System.Drawing.Point(26, 19);
            this.DateOption.Name = "DateOption";
            this.DateOption.Size = new System.Drawing.Size(128, 64);
            this.DateOption.TabIndex = 0;
            this.DateOption.TabStop = true;
            this.DateOption.Text = "Display Current D&ate";
            this.DateOption.UseVisualStyleBackColor = true;
            this.DateOption.CheckedChanged += new System.EventHandler(this.DateOption_CheckedChanged);
            // 
            // TimeOption
            // 
            this.TimeOption.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TimeOption.Location = new System.Drawing.Point(26, 74);
            this.TimeOption.Name = "TimeOption";
            this.TimeOption.Size = new System.Drawing.Size(128, 24);
            this.TimeOption.TabIndex = 1;
            this.TimeOption.TabStop = true;
            this.TimeOption.Text = "Display Current & Time";
            this.TimeOption.UseVisualStyleBackColor = true;
            this.TimeOption.CheckedChanged += new System.EventHandler(this.TimeOption_CheckedChanged);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 280);
            this.Controls.Add(this.OutputgroupBox);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.outputlabel);
            this.Controls.Add(this.label1);
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.Load += new System.EventHandler(this.ChildForm_Load);
            this.OutputgroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputlabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.GroupBox OutputgroupBox;
        private System.Windows.Forms.RadioButton TimeOption;
        private System.Windows.Forms.RadioButton DateOption;
    }
}