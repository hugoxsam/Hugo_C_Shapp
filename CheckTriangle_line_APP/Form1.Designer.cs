
namespace CheckTriangle_line_APP
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1_Width = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1_High = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1_length = new System.Windows.Forms.NumericUpDown();
            this.ChkButton_1 = new System.Windows.Forms.Button();
            this.label_Answers = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_High)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_length)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDown1_Width);
            this.panel1.Controls.Add(this.numericUpDown1_High);
            this.panel1.Controls.Add(this.numericUpDown1_length);
            this.panel1.Location = new System.Drawing.Point(36, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 142);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "邊長C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "邊長B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "邊長A";
            // 
            // numericUpDown1_Width
            // 
            this.numericUpDown1_Width.Location = new System.Drawing.Point(94, 104);
            this.numericUpDown1_Width.Name = "numericUpDown1_Width";
            this.numericUpDown1_Width.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1_Width.TabIndex = 0;
            // 
            // numericUpDown1_High
            // 
            this.numericUpDown1_High.Location = new System.Drawing.Point(94, 64);
            this.numericUpDown1_High.Name = "numericUpDown1_High";
            this.numericUpDown1_High.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1_High.TabIndex = 0;
            // 
            // numericUpDown1_length
            // 
            this.numericUpDown1_length.Location = new System.Drawing.Point(94, 23);
            this.numericUpDown1_length.Name = "numericUpDown1_length";
            this.numericUpDown1_length.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1_length.TabIndex = 0;
            this.numericUpDown1_length.Tag = "長";
            // 
            // ChkButton_1
            // 
            this.ChkButton_1.Location = new System.Drawing.Point(279, 64);
            this.ChkButton_1.Name = "ChkButton_1";
            this.ChkButton_1.Size = new System.Drawing.Size(97, 40);
            this.ChkButton_1.TabIndex = 1;
            this.ChkButton_1.Text = "ChkButton";
            this.ChkButton_1.UseVisualStyleBackColor = true;
            this.ChkButton_1.Click += new System.EventHandler(this.ChkButton_1_Click);
            // 
            // label_Answers
            // 
            this.label_Answers.AutoSize = true;
            this.label_Answers.BackColor = System.Drawing.Color.Yellow;
            this.label_Answers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Answers.ForeColor = System.Drawing.Color.Maroon;
            this.label_Answers.Location = new System.Drawing.Point(145, 179);
            this.label_Answers.Name = "label_Answers";
            this.label_Answers.Size = new System.Drawing.Size(110, 24);
            this.label_Answers.TabIndex = 2;
            this.label_Answers.Text = "三角形類型";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 272);
            this.Controls.Add(this.label_Answers);
            this.Controls.Add(this.ChkButton_1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_High)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_length)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1_Width;
        private System.Windows.Forms.NumericUpDown numericUpDown1_High;
        private System.Windows.Forms.NumericUpDown numericUpDown1_length;
        private System.Windows.Forms.Button ChkButton_1;
        private System.Windows.Forms.Label label_Answers;
    }
}

