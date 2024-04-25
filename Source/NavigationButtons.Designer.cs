namespace BD_6
{
    partial class NavigationButtons
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPreviousEntry = new System.Windows.Forms.Button();
            this.btnNextEntry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPreviousEntry
            // 
            this.btnPreviousEntry.AutoSize = true;
            this.btnPreviousEntry.Enabled = false;
            this.btnPreviousEntry.Location = new System.Drawing.Point(0, 4);
            this.btnPreviousEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPreviousEntry.Name = "btnPreviousEntry";
            this.btnPreviousEntry.Size = new System.Drawing.Size(84, 30);
            this.btnPreviousEntry.TabIndex = 29;
            this.btnPreviousEntry.Text = "<--";
            this.btnPreviousEntry.UseVisualStyleBackColor = true;
            this.btnPreviousEntry.Click += new System.EventHandler(this.btnPreviousEntry_Click);
            // 
            // btnNextEntry
            // 
            this.btnNextEntry.AutoSize = true;
            this.btnNextEntry.Location = new System.Drawing.Point(92, 3);
            this.btnNextEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNextEntry.Name = "btnNextEntry";
            this.btnNextEntry.Size = new System.Drawing.Size(78, 32);
            this.btnNextEntry.TabIndex = 30;
            this.btnNextEntry.Text = "-->";
            this.btnNextEntry.UseVisualStyleBackColor = true;
            this.btnNextEntry.Click += new System.EventHandler(this.btnNextEntry_Click);
            // 
            // NavigationButtons
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnPreviousEntry);
            this.Controls.Add(this.btnNextEntry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NavigationButtons";
            this.Size = new System.Drawing.Size(174, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPreviousEntry;
        private System.Windows.Forms.Button btnNextEntry;
    }
}
