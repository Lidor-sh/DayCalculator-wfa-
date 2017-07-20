namespace DayCalculatorWFA
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
            this.Day = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Month = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Day
            // 
            this.Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Day.Location = new System.Drawing.Point(189, 52);
            this.Day.MaxLength = 2;
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(70, 38);
            this.Day.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(229, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(184, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Day";
            // 
            // Month
            // 
            this.Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Month.Location = new System.Drawing.Point(277, 52);
            this.Month.MaxLength = 2;
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(70, 38);
            this.Month.TabIndex = 3;
            // 
            // Year
            // 
            this.Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Year.Location = new System.Drawing.Point(376, 52);
            this.Year.MaxLength = 4;
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(70, 38);
            this.Year.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(318, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 76);
            this.label3.TabIndex = 5;
            this.label3.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(272, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(376, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Year";
            // 
            // Result
            // 
            this.Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Result.Location = new System.Drawing.Point(252, 121);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(126, 46);
            this.Result.TabIndex = 8;
            this.Result.Text = "label6";
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Check
            // 
            this.Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check.Location = new System.Drawing.Point(260, 181);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(110, 46);
            this.Check.TabIndex = 9;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 261);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Day);
            this.Name = "Form1";
            this.Text = "Day Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Day;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Month;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Check;
    }
}

