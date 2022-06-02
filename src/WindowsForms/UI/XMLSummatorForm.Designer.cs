namespace Metcom.XMLSummator.WindowsForms.UI
{
    partial class XMLSummatorForm
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtFileNameFirst = new System.Windows.Forms.TextBox();
            this.txtFileNameSecond = new System.Windows.Forms.TextBox();
            this.labFileFirst = new System.Windows.Forms.Label();
            this.labFileSecond = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(112, 98);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(128, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Создать файл";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // txtFileNameFirst
            // 
            this.txtFileNameFirst.Location = new System.Drawing.Point(12, 72);
            this.txtFileNameFirst.Name = "txtFileNameFirst";
            this.txtFileNameFirst.Size = new System.Drawing.Size(228, 20);
            this.txtFileNameFirst.TabIndex = 1;
            // 
            // txtFileNameSecond
            // 
            this.txtFileNameSecond.Location = new System.Drawing.Point(12, 27);
            this.txtFileNameSecond.Name = "txtFileNameSecond";
            this.txtFileNameSecond.Size = new System.Drawing.Size(228, 20);
            this.txtFileNameSecond.TabIndex = 2;
            // 
            // labFileFirst
            // 
            this.labFileFirst.AutoSize = true;
            this.labFileFirst.Location = new System.Drawing.Point(12, 9);
            this.labFileFirst.Name = "labFileFirst";
            this.labFileFirst.Size = new System.Drawing.Size(136, 15);
            this.labFileFirst.TabIndex = 3;
            this.labFileFirst.Text = "Путь к первому файлу";
            // 
            // labFileSecond
            // 
            this.labFileSecond.AutoSize = true;
            this.labFileSecond.Location = new System.Drawing.Point(12, 54);
            this.labFileSecond.Name = "labFileSecond";
            this.labFileSecond.Size = new System.Drawing.Size(136, 15);
            this.labFileSecond.TabIndex = 4;
            this.labFileSecond.Text = "Путь к второму файлу";
            // 
            // XMLSummatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 134);
            this.Controls.Add(this.labFileSecond);
            this.Controls.Add(this.labFileFirst);
            this.Controls.Add(this.txtFileNameSecond);
            this.Controls.Add(this.txtFileNameFirst);
            this.Controls.Add(this.btnCreate);
            this.Name = "XMLSummatorForm";
            this.Text = "Сложение XML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtFileNameFirst;
        private System.Windows.Forms.TextBox txtFileNameSecond;
        private System.Windows.Forms.Label labFileFirst;
        private System.Windows.Forms.Label labFileSecond;
    }
}

