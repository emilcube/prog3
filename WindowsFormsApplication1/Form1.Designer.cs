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
            this.userControl13 = new WindowsFormsApplication1.UserControl1();
            this.userControl12 = new WindowsFormsApplication1.UserControl1();
            this.userControl11 = new WindowsFormsApplication1.UserControl1();
            this.SuspendLayout();
            // 
            // userControl13
            // 
            this.userControl13.BCD = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.userControl13.Location = new System.Drawing.Point(41, 219);
            this.userControl13.Name = "userControl13";
            this.userControl13.Size = new System.Drawing.Size(210, 147);
            this.userControl13.TabIndex = 2;
            // 
            // userControl12
            // 
            this.userControl12.BCD = System.Drawing.Color.Empty;
            this.userControl12.Location = new System.Drawing.Point(220, 83);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(233, 143);
            this.userControl12.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.BCD = System.Drawing.Color.Empty;
            this.userControl11.Location = new System.Drawing.Point(12, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(199, 147);
            this.userControl11.TabIndex = 0;
            this.userControl11.ButtonClicked += new System.EventHandler(this.userControl11_ButtonClicked);
            this.userControl11.Load += new System.EventHandler(this.MYEVENTHANDLER);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 409);
            this.Controls.Add(this.userControl13);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private UserControl1 userControl12;
        private UserControl1 userControl13;
    }
}

