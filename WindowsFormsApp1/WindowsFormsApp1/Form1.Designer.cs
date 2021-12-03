
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
            this.yearPicker = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.csvpathBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.yearPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // yearPicker
            // 
            this.yearPicker.Location = new System.Drawing.Point(60, 16);
            this.yearPicker.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.yearPicker.Name = "yearPicker";
            this.yearPicker.Size = new System.Drawing.Size(80, 20);
            this.yearPicker.TabIndex = 0;
            this.yearPicker.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Záróév";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Népesség fájl";
            // 
            // csvpathBox
            // 
            this.csvpathBox.Location = new System.Drawing.Point(313, 15);
            this.csvpathBox.Name = "csvpathBox";
            this.csvpathBox.Size = new System.Drawing.Size(268, 20);
            this.csvpathBox.TabIndex = 3;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(600, 13);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(91, 23);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(697, 13);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(91, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 57);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 381);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.csvpathBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearPicker);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.yearPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown yearPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox csvpathBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

