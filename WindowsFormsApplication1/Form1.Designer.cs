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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grid1 = new WindowsFormsApplication1.Grid();
            this.redButton1 = new WindowsFormsApplication1.RedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Режимы игры";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(261, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // grid1
            // 
            this.grid1.CellSize = 50;
            this.grid1.CellWidth = 4F;
            this.grid1.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))))};
            this.grid1.ColsCount = 5;
            this.grid1.DisplayMode = WindowsFormsApplication1.Grid.GridDisplayMode.Colors;
            this.grid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grid1.LineColor = System.Drawing.Color.Red;
            this.grid1.Location = new System.Drawing.Point(92, 80);
            this.grid1.Name = "grid1";
            this.grid1.RowsCount = 5;
            this.grid1.Size = new System.Drawing.Size(267, 263);
            this.grid1.TabIndex = 6;
            this.grid1.Text = "grid1";
            this.grid1.CellClick += new WindowsFormsApplication1.Grid.CellHandler(this.grid1_CellClick);
            this.grid1.Click += new System.EventHandler(this.grid1_Click);
            // 
            // redButton1
            // 
            this.redButton1.BackColor = System.Drawing.Color.Red;
            this.redButton1.Crossed = false;
            this.redButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.redButton1.Location = new System.Drawing.Point(119, 358);
            this.redButton1.Name = "redButton1";
            this.redButton1.Size = new System.Drawing.Size(204, 72);
            this.redButton1.TabIndex = 3;
            this.redButton1.Text = "RANDOM";
            this.redButton1.UseVisualStyleBackColor = false;
            this.redButton1.Click += new System.EventHandler(this.redButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 452);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.redButton1);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RedButton redButton1;
        private Grid grid1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

