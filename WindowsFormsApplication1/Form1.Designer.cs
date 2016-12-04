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
            this.redButton1 = new WindowsFormsApplication1.RedButton();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.CellSize = 30;
            this.grid1.ColsCount = 3;
            this.grid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grid1.LineColor = System.Drawing.Color.Red;
            this.grid1.Location = new System.Drawing.Point(12, 58);
            this.grid1.Name = "grid1";
            this.grid1.RowsCount = 5;
            this.grid1.Size = new System.Drawing.Size(363, 245);
            this.grid1.TabIndex = 6;
            this.grid1.Text = "grid1";
            // 
            // redButton1
            // 
            this.redButton1.BackColor = System.Drawing.Color.Red;
            this.redButton1.Crossed = false;
            this.redButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.redButton1.Location = new System.Drawing.Point(32, 309);
            this.redButton1.Name = "redButton1";
            this.redButton1.Size = new System.Drawing.Size(343, 82);
            this.redButton1.TabIndex = 3;
            this.redButton1.Text = "RANDOM";
            this.redButton1.UseVisualStyleBackColor = false;
            this.redButton1.Click += new System.EventHandler(this.redButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 400);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.redButton1);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private RedButton redButton1;
        private Grid grid1;
    }
}

