namespace WindowsFormsApp1
{
    partial class CircleForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.TextBox();
            this.y = new System.Windows.Forms.TextBox();
            this.r = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.draw = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Center Point ( x , y) :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Raduis Value : ";
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(283, 47);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(80, 20);
            this.x.TabIndex = 2;
            this.x.TextChanged += new System.EventHandler(this.x_TextChanged);
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(383, 47);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(82, 20);
            this.y.TabIndex = 3;
            // 
            // r
            // 
            this.r.Location = new System.Drawing.Point(283, 90);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(182, 20);
            this.r.TabIndex = 4;
            this.r.TextChanged += new System.EventHandler(this.r_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(52, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 348);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // draw
            // 
            this.draw.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.draw.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draw.Location = new System.Drawing.Point(308, 526);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(103, 35);
            this.draw.TabIndex = 6;
            this.draw.Text = "Draw";
            this.draw.UseVisualStyleBackColor = false;
            this.draw.Click += new System.EventHandler(this.button1_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clear.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(120, 526);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(111, 35);
            this.clear.TabIndex = 7;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(551, 620);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.r);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "CircleForm";
            this.Text = "Circle Drawing";
            this.Load += new System.EventHandler(this.CircleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.TextBox y;
        private System.Windows.Forms.TextBox r;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Button clear;
    }
}

