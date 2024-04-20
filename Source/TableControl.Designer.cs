namespace BD_6.Forms
{
    partial class TableControl
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
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.grbAddOrFilter = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnNextEntry = new System.Windows.Forms.Button();
            this.btnPreviousEntry = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.contentsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.grbAddOrFilter.SuspendLayout();
            this.contentsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(4, 4);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.RowTemplate.Height = 24;
            this.dgvTable.Size = new System.Drawing.Size(733, 494);
            this.dgvTable.TabIndex = 0;
            // 
            // grbAddOrFilter
            // 
            this.grbAddOrFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grbAddOrFilter.Controls.Add(this.btnAddRecord);
            this.grbAddOrFilter.Controls.Add(this.btnSearch);
            this.grbAddOrFilter.Location = new System.Drawing.Point(4, 3);
            this.grbAddOrFilter.Name = "grbAddOrFilter";
            this.grbAddOrFilter.Size = new System.Drawing.Size(274, 71);
            this.grbAddOrFilter.TabIndex = 30;
            this.grbAddOrFilter.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(145, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 29);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "Искать";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(6, 36);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(123, 29);
            this.btnAddRecord.TabIndex = 30;
            this.btnAddRecord.Text = "Добавить";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btnNextEntry
            // 
            this.btnNextEntry.Location = new System.Drawing.Point(148, 91);
            this.btnNextEntry.Name = "btnNextEntry";
            this.btnNextEntry.Size = new System.Drawing.Size(129, 29);
            this.btnNextEntry.TabIndex = 28;
            this.btnNextEntry.Text = "-->";
            this.btnNextEntry.UseVisualStyleBackColor = true;
            // 
            // btnPreviousEntry
            // 
            this.btnPreviousEntry.AutoSize = true;
            this.btnPreviousEntry.Enabled = false;
            this.btnPreviousEntry.Location = new System.Drawing.Point(4, 91);
            this.btnPreviousEntry.Name = "btnPreviousEntry";
            this.btnPreviousEntry.Size = new System.Drawing.Size(129, 29);
            this.btnPreviousEntry.TabIndex = 27;
            this.btnPreviousEntry.Text = "<--";
            this.btnPreviousEntry.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(2, 462);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(276, 29);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Удалить выбранную запись";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // contentsPanel
            // 
            this.contentsPanel.AutoSize = true;
            this.contentsPanel.Controls.Add(this.btnDelete);
            this.contentsPanel.Controls.Add(this.btnPreviousEntry);
            this.contentsPanel.Controls.Add(this.btnNextEntry);
            this.contentsPanel.Controls.Add(this.grbAddOrFilter);
            this.contentsPanel.Location = new System.Drawing.Point(743, 4);
            this.contentsPanel.Name = "contentsPanel";
            this.contentsPanel.Size = new System.Drawing.Size(281, 494);
            this.contentsPanel.TabIndex = 32;
            // 
            // TableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentsPanel);
            this.Controls.Add(this.dgvTable);
            this.Name = "TableControl";
            this.Size = new System.Drawing.Size(1032, 501);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.grbAddOrFilter.ResumeLayout(false);
            this.contentsPanel.ResumeLayout(false);
            this.contentsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.GroupBox grbAddOrFilter;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNextEntry;
        private System.Windows.Forms.Button btnPreviousEntry;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel contentsPanel;
    }
}
