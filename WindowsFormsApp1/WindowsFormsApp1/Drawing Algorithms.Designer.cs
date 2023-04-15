namespace WindowsFormsApp1
{
    partial class Drawing_Algorithms
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
            this.Circle = new System.Windows.Forms.Button();
            this.Ellips = new System.Windows.Forms.Button();
            this.DDA = new System.Windows.Forms.Button();
            this.Bresenham = new System.Windows.Forms.Button();
            this.TwoDGeometric = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Circle
            // 
            this.Circle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Circle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Circle.Location = new System.Drawing.Point(68, 145);
            this.Circle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(191, 47);
            this.Circle.TabIndex = 0;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = false;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Ellips
            // 
            this.Ellips.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Ellips.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ellips.Location = new System.Drawing.Point(317, 145);
            this.Ellips.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ellips.Name = "Ellips";
            this.Ellips.Size = new System.Drawing.Size(191, 47);
            this.Ellips.TabIndex = 1;
            this.Ellips.Text = "Ellips";
            this.Ellips.UseVisualStyleBackColor = false;
            this.Ellips.Click += new System.EventHandler(this.Ellips_Click);
            // 
            // DDA
            // 
            this.DDA.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DDA.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DDA.Location = new System.Drawing.Point(68, 42);
            this.DDA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DDA.Name = "DDA";
            this.DDA.Size = new System.Drawing.Size(191, 50);
            this.DDA.TabIndex = 2;
            this.DDA.Text = "DDA";
            this.DDA.UseVisualStyleBackColor = false;
            this.DDA.Click += new System.EventHandler(this.DDA_Click);
            // 
            // Bresenham
            // 
            this.Bresenham.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Bresenham.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bresenham.Location = new System.Drawing.Point(317, 42);
            this.Bresenham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bresenham.Name = "Bresenham";
            this.Bresenham.Size = new System.Drawing.Size(185, 50);
            this.Bresenham.TabIndex = 3;
            this.Bresenham.Text = "Bresenham ";
            this.Bresenham.UseVisualStyleBackColor = false;
            this.Bresenham.Click += new System.EventHandler(this.Bresenham_Click);
            // 
            // TwoDGeometric
            // 
            this.TwoDGeometric.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TwoDGeometric.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoDGeometric.Location = new System.Drawing.Point(165, 252);
            this.TwoDGeometric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TwoDGeometric.Name = "TwoDGeometric";
            this.TwoDGeometric.Size = new System.Drawing.Size(249, 47);
            this.TwoDGeometric.TabIndex = 4;
            this.TwoDGeometric.Text = "2D Geometric";
            this.TwoDGeometric.UseVisualStyleBackColor = false;
            this.TwoDGeometric.Click += new System.EventHandler(this.TwoDGeometric_Click);
            // 
            // Drawing_Algorithms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(571, 482);
            this.Controls.Add(this.TwoDGeometric);
            this.Controls.Add(this.Bresenham);
            this.Controls.Add(this.DDA);
            this.Controls.Add(this.Ellips);
            this.Controls.Add(this.Circle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Drawing_Algorithms";
            this.Text = "Drawing_Algorithms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Ellips;
        private System.Windows.Forms.Button DDA;
        private System.Windows.Forms.Button Bresenham;
        private System.Windows.Forms.Button TwoDGeometric;
    }
}