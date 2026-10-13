namespace plusik
{
    partial class plusik
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.plus = new System.Windows.Forms.Button();
            this.number_box = new System.Windows.Forms.TextBox();
            this.random_number = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.mulptiply = new System.Windows.Forms.Button();
            this.set_a_number = new System.Windows.Forms.Button();
            this.random_number_button = new System.Windows.Forms.Button();
            this.your_number = new System.Windows.Forms.Label();
            this.step = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.Red;
            this.plus.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(12, 12);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(223, 223);
            this.plus.TabIndex = 0;
            this.plus.Text = "+1";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click_1);
            // 
            // number_box
            // 
            this.number_box.Location = new System.Drawing.Point(292, 282);
            this.number_box.Name = "number_box";
            this.number_box.Size = new System.Drawing.Size(223, 22);
            this.number_box.TabIndex = 1;
            this.number_box.Text = "15";
            this.number_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // random_number
            // 
            this.random_number.AutoSize = true;
            this.random_number.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.random_number.Location = new System.Drawing.Point(287, 30);
            this.random_number.Name = "random_number";
            this.random_number.Size = new System.Drawing.Size(209, 27);
            this.random_number.TabIndex = 2;
            this.random_number.Text = "random_number";
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(12, 362);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(223, 76);
            this.reset.TabIndex = 3;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click_1);
            // 
            // mulptiply
            // 
            this.mulptiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mulptiply.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulptiply.Location = new System.Drawing.Point(565, 12);
            this.mulptiply.Name = "mulptiply";
            this.mulptiply.Size = new System.Drawing.Size(223, 223);
            this.mulptiply.TabIndex = 0;
            this.mulptiply.Text = "*2";
            this.mulptiply.UseVisualStyleBackColor = false;
            this.mulptiply.Click += new System.EventHandler(this.mulptiply_Click_1);
            // 
            // set_a_number
            // 
            this.set_a_number.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_a_number.Location = new System.Drawing.Point(565, 362);
            this.set_a_number.Name = "set_a_number";
            this.set_a_number.Size = new System.Drawing.Size(223, 76);
            this.set_a_number.TabIndex = 3;
            this.set_a_number.Text = "set a number";
            this.set_a_number.UseVisualStyleBackColor = true;
            this.set_a_number.Click += new System.EventHandler(this.set_a_number_Click_1);
            // 
            // random_number_button
            // 
            this.random_number_button.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.random_number_button.Location = new System.Drawing.Point(292, 362);
            this.random_number_button.Name = "random_number_button";
            this.random_number_button.Size = new System.Drawing.Size(223, 76);
            this.random_number_button.TabIndex = 3;
            this.random_number_button.Text = "random number button";
            this.random_number_button.UseVisualStyleBackColor = true;
            this.random_number_button.Click += new System.EventHandler(this.random_number_button_Click_1);
            // 
            // your_number
            // 
            this.your_number.AutoSize = true;
            this.your_number.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.your_number.Location = new System.Drawing.Point(287, 110);
            this.your_number.Name = "your_number";
            this.your_number.Size = new System.Drawing.Size(172, 27);
            this.your_number.TabIndex = 2;
            this.your_number.Text = "your number";
            // 
            // step
            // 
            this.step.AutoSize = true;
            this.step.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step.Location = new System.Drawing.Point(287, 208);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(67, 27);
            this.step.TabIndex = 2;
            this.step.Text = "step";
            // 
            // plusik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.random_number_button);
            this.Controls.Add(this.set_a_number);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.step);
            this.Controls.Add(this.your_number);
            this.Controls.Add(this.random_number);
            this.Controls.Add(this.number_box);
            this.Controls.Add(this.mulptiply);
            this.Controls.Add(this.plus);
            this.Name = "plusik";
            this.Text = "plusik";
            this.Load += new System.EventHandler(this.plusik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.TextBox number_box;
        private System.Windows.Forms.Label random_number;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button mulptiply;
        private System.Windows.Forms.Button set_a_number;
        private System.Windows.Forms.Button random_number_button;
        private System.Windows.Forms.Label your_number;
        private System.Windows.Forms.Label step;
    }
}

