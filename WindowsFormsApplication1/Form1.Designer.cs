namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.grid1 = new WindowsFormsApplication1.Grid();
            this.redButton3 = new WindowsFormsApplication1.RedButton();
            this.redButton2 = new WindowsFormsApplication1.RedButton();
            this.redButton1 = new WindowsFormsApplication1.RedButton();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.CellSize = 30;
            this.grid1.ColumnCount = 3;
            this.grid1.LineColor = System.Drawing.Color.Red;
            this.grid1.Location = new System.Drawing.Point(245, 30);
            this.grid1.Name = "grid1";
            this.grid1.RowCount = 5;
            this.grid1.Size = new System.Drawing.Size(171, 158);
            this.grid1.TabIndex = 6;
            this.grid1.Text = "grid1";
            // 
            // redButton3
            // 
            this.redButton3.BackColor = System.Drawing.Color.Red;
            this.redButton3.Crossed = false;
            this.redButton3.Location = new System.Drawing.Point(452, 306);
            this.redButton3.Name = "redButton3";
            this.redButton3.Size = new System.Drawing.Size(75, 75);
            this.redButton3.TabIndex = 5;
            this.redButton3.Text = "redButton3";
            this.redButton3.UseVisualStyleBackColor = false;
            // 
            // redButton2
            // 
            this.redButton2.BackColor = System.Drawing.Color.Red;
            this.redButton2.Crossed = false;
            this.redButton2.Location = new System.Drawing.Point(557, 219);
            this.redButton2.Name = "redButton2";
            this.redButton2.Size = new System.Drawing.Size(75, 75);
            this.redButton2.TabIndex = 4;
            this.redButton2.Text = "redButton2";
            this.redButton2.UseVisualStyleBackColor = false;
            // 
            // redButton1
            // 
            this.redButton1.BackColor = System.Drawing.Color.Red;
            this.redButton1.Crossed = false;
            this.redButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.redButton1.Location = new System.Drawing.Point(298, 261);
            this.redButton1.Name = "redButton1";
            this.redButton1.Size = new System.Drawing.Size(75, 75);
            this.redButton1.TabIndex = 3;
            this.redButton1.Text = "B!";
            this.redButton1.UseVisualStyleBackColor = false;
            this.redButton1.Click += new System.EventHandler(this.redButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 622);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.redButton3);
            this.Controls.Add(this.redButton2);
            this.Controls.Add(this.redButton1);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private RedButton redButton1;
        private RedButton redButton2;
        private RedButton redButton3;
        private Grid grid1;
    }
}

