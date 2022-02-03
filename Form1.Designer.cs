
namespace Sample_Rate_Converter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonBaseSR_44_1 = new System.Windows.Forms.RadioButton();
            this.radioButtonBaseSR_88_2 = new System.Windows.Forms.RadioButton();
            this.radioButtonBaseSR_176_4 = new System.Windows.Forms.RadioButton();
            this.radioButtonBaseSR_48 = new System.Windows.Forms.RadioButton();
            this.radioButtonBaseSR_96 = new System.Windows.Forms.RadioButton();
            this.baseSR_192 = new System.Windows.Forms.RadioButton();
            this.radioButtonIncrease = new System.Windows.Forms.RadioButton();
            this.radioButtonDecrease = new System.Windows.Forms.RadioButton();
            this.segmentSamplesLong = new System.Windows.Forms.TextBox();
            this.segmentSamplesShort = new System.Windows.Forms.TextBox();
            this.labelSegmentLong = new System.Windows.Forms.Label();
            this.labelSegmentShort = new System.Windows.Forms.Label();
            this.labelResampleValue = new System.Windows.Forms.Label();
            this.resampleValueOutput = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonBaseSR_44_1
            // 
            this.radioButtonBaseSR_44_1.AutoSize = true;
            this.radioButtonBaseSR_44_1.Location = new System.Drawing.Point(15, 19);
            this.radioButtonBaseSR_44_1.Name = "radioButtonBaseSR_44_1";
            this.radioButtonBaseSR_44_1.Size = new System.Drawing.Size(52, 19);
            this.radioButtonBaseSR_44_1.TabIndex = 0;
            this.radioButtonBaseSR_44_1.Text = "44.1k";
            this.radioButtonBaseSR_44_1.UseVisualStyleBackColor = true;
            // 
            // radioButtonBaseSR_88_2
            // 
            this.radioButtonBaseSR_88_2.AutoSize = true;
            this.radioButtonBaseSR_88_2.Location = new System.Drawing.Point(15, 45);
            this.radioButtonBaseSR_88_2.Name = "radioButtonBaseSR_88_2";
            this.radioButtonBaseSR_88_2.Size = new System.Drawing.Size(52, 19);
            this.radioButtonBaseSR_88_2.TabIndex = 1;
            this.radioButtonBaseSR_88_2.Text = "88.2k";
            this.radioButtonBaseSR_88_2.UseVisualStyleBackColor = true;
            // 
            // radioButtonBaseSR_176_4
            // 
            this.radioButtonBaseSR_176_4.AutoSize = true;
            this.radioButtonBaseSR_176_4.Location = new System.Drawing.Point(15, 71);
            this.radioButtonBaseSR_176_4.Name = "radioButtonBaseSR_176_4";
            this.radioButtonBaseSR_176_4.Size = new System.Drawing.Size(58, 19);
            this.radioButtonBaseSR_176_4.TabIndex = 2;
            this.radioButtonBaseSR_176_4.Text = "176.4k";
            this.radioButtonBaseSR_176_4.UseVisualStyleBackColor = true;
            // 
            // radioButtonBaseSR_48
            // 
            this.radioButtonBaseSR_48.AutoSize = true;
            this.radioButtonBaseSR_48.Checked = true;
            this.radioButtonBaseSR_48.Location = new System.Drawing.Point(130, 19);
            this.radioButtonBaseSR_48.Name = "radioButtonBaseSR_48";
            this.radioButtonBaseSR_48.Size = new System.Drawing.Size(43, 19);
            this.radioButtonBaseSR_48.TabIndex = 3;
            this.radioButtonBaseSR_48.TabStop = true;
            this.radioButtonBaseSR_48.Text = "48k";
            this.radioButtonBaseSR_48.UseVisualStyleBackColor = true;
            // 
            // radioButtonBaseSR_96
            // 
            this.radioButtonBaseSR_96.AutoSize = true;
            this.radioButtonBaseSR_96.Location = new System.Drawing.Point(130, 45);
            this.radioButtonBaseSR_96.Name = "radioButtonBaseSR_96";
            this.radioButtonBaseSR_96.Size = new System.Drawing.Size(43, 19);
            this.radioButtonBaseSR_96.TabIndex = 4;
            this.radioButtonBaseSR_96.Text = "96k";
            this.radioButtonBaseSR_96.UseVisualStyleBackColor = true;
            // 
            // baseSR_192
            // 
            this.baseSR_192.AutoSize = true;
            this.baseSR_192.Location = new System.Drawing.Point(130, 71);
            this.baseSR_192.Name = "baseSR_192";
            this.baseSR_192.Size = new System.Drawing.Size(49, 19);
            this.baseSR_192.TabIndex = 5;
            this.baseSR_192.Text = "192k";
            this.baseSR_192.UseVisualStyleBackColor = true;
            // 
            // radioButtonIncrease
            // 
            this.radioButtonIncrease.AutoSize = true;
            this.radioButtonIncrease.Checked = true;
            this.radioButtonIncrease.Location = new System.Drawing.Point(15, 18);
            this.radioButtonIncrease.Name = "radioButtonIncrease";
            this.radioButtonIncrease.Size = new System.Drawing.Size(68, 19);
            this.radioButtonIncrease.TabIndex = 8;
            this.radioButtonIncrease.TabStop = true;
            this.radioButtonIncrease.Text = "Increase";
            this.radioButtonIncrease.UseVisualStyleBackColor = true;
            // 
            // radioButtonDecrease
            // 
            this.radioButtonDecrease.AutoSize = true;
            this.radioButtonDecrease.Location = new System.Drawing.Point(130, 18);
            this.radioButtonDecrease.Name = "radioButtonDecrease";
            this.radioButtonDecrease.Size = new System.Drawing.Size(72, 19);
            this.radioButtonDecrease.TabIndex = 9;
            this.radioButtonDecrease.Text = "Decrease";
            this.radioButtonDecrease.UseVisualStyleBackColor = true;
            // 
            // segmentSamplesLong
            // 
            this.segmentSamplesLong.Location = new System.Drawing.Point(125, 29);
            this.segmentSamplesLong.Name = "segmentSamplesLong";
            this.segmentSamplesLong.Size = new System.Drawing.Size(100, 23);
            this.segmentSamplesLong.TabIndex = 11;
            this.segmentSamplesLong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // segmentSamplesShort
            // 
            this.segmentSamplesShort.Location = new System.Drawing.Point(125, 58);
            this.segmentSamplesShort.Name = "segmentSamplesShort";
            this.segmentSamplesShort.Size = new System.Drawing.Size(100, 23);
            this.segmentSamplesShort.TabIndex = 12;
            this.segmentSamplesShort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSegmentLong
            // 
            this.labelSegmentLong.AutoSize = true;
            this.labelSegmentLong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSegmentLong.Location = new System.Drawing.Point(11, 32);
            this.labelSegmentLong.Name = "labelSegmentLong";
            this.labelSegmentLong.Size = new System.Drawing.Size(87, 15);
            this.labelSegmentLong.TabIndex = 13;
            this.labelSegmentLong.Text = "Long Segment:";
            // 
            // labelSegmentShort
            // 
            this.labelSegmentShort.AutoSize = true;
            this.labelSegmentShort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSegmentShort.Location = new System.Drawing.Point(11, 61);
            this.labelSegmentShort.Name = "labelSegmentShort";
            this.labelSegmentShort.Size = new System.Drawing.Size(88, 15);
            this.labelSegmentShort.TabIndex = 14;
            this.labelSegmentShort.Text = "Short Segment:";
            // 
            // labelResampleValue
            // 
            this.labelResampleValue.AutoSize = true;
            this.labelResampleValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelResampleValue.Location = new System.Drawing.Point(24, 315);
            this.labelResampleValue.Name = "labelResampleValue";
            this.labelResampleValue.Size = new System.Drawing.Size(97, 15);
            this.labelResampleValue.TabIndex = 15;
            this.labelResampleValue.Text = "Resample Value:";
            // 
            // resampleValueOutput
            // 
            this.resampleValueOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resampleValueOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resampleValueOutput.ForeColor = System.Drawing.Color.Blue;
            this.resampleValueOutput.Location = new System.Drawing.Point(134, 311);
            this.resampleValueOutput.Name = "resampleValueOutput";
            this.resampleValueOutput.Size = new System.Drawing.Size(100, 23);
            this.resampleValueOutput.TabIndex = 16;
            this.resampleValueOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(22, 352);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(100, 30);
            this.calculate.TabIndex = 17;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(137, 352);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(100, 30);
            this.clear.TabIndex = 18;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.baseSR_192);
            this.groupBox1.Controls.Add(this.radioButtonBaseSR_96);
            this.groupBox1.Controls.Add(this.radioButtonBaseSR_48);
            this.groupBox1.Controls.Add(this.radioButtonBaseSR_176_4);
            this.groupBox1.Controls.Add(this.radioButtonBaseSR_88_2);
            this.groupBox1.Controls.Add(this.radioButtonBaseSR_44_1);
            this.groupBox1.Location = new System.Drawing.Point(9, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select base sample rate:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonDecrease);
            this.groupBox2.Controls.Add(this.radioButtonIncrease);
            this.groupBox2.Location = new System.Drawing.Point(9, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 50);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select duration increase or decrease:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelSegmentShort);
            this.groupBox3.Controls.Add(this.labelSegmentLong);
            this.groupBox3.Controls.Add(this.segmentSamplesShort);
            this.groupBox3.Controls.Add(this.segmentSamplesLong);
            this.groupBox3.Location = new System.Drawing.Point(9, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 100);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enter segment sample counts:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(259, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 401);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.resampleValueOutput);
            this.Controls.Add(this.labelResampleValue);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(275, 440);
            this.MinimumSize = new System.Drawing.Size(275, 440);
            this.Name = "Form1";
            this.Text = "SR Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonBaseSR_44_1;
        private System.Windows.Forms.RadioButton radioButtonBaseSR_88_2;
        private System.Windows.Forms.RadioButton radioButtonBaseSR_176_4;
        private System.Windows.Forms.RadioButton radioButtonBaseSR_48;
        private System.Windows.Forms.RadioButton radioButtonBaseSR_96;
        private System.Windows.Forms.RadioButton baseSR_192;
        private System.Windows.Forms.RadioButton radioButtonIncrease;
        private System.Windows.Forms.RadioButton radioButtonDecrease;
        private System.Windows.Forms.TextBox segmentSamplesLong;
        private System.Windows.Forms.TextBox segmentSamplesShort;
        private System.Windows.Forms.Label labelSegmentLong;
        private System.Windows.Forms.Label labelSegmentShort;
        private System.Windows.Forms.Label labelResampleValue;
        private System.Windows.Forms.Label resampleValueOutput;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

