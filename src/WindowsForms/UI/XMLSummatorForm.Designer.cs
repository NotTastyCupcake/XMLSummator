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
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultFileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(300, 102);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(131, 35);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Создать файл";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // txtFileNameFirst
            // 
            this.txtFileNameFirst.Location = new System.Drawing.Point(12, 68);
            this.txtFileNameFirst.Name = "txtFileNameFirst";
            this.txtFileNameFirst.Size = new System.Drawing.Size(419, 20);
            this.txtFileNameFirst.TabIndex = 1;
            // 
            // txtFileNameSecond
            // 
            this.txtFileNameSecond.Location = new System.Drawing.Point(12, 27);
            this.txtFileNameSecond.Name = "txtFileNameSecond";
            this.txtFileNameSecond.Size = new System.Drawing.Size(419, 20);
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
            this.labFileSecond.Location = new System.Drawing.Point(12, 50);
            this.labFileSecond.Name = "labFileSecond";
            this.labFileSecond.Size = new System.Drawing.Size(136, 15);
            this.labFileSecond.TabIndex = 4;
            this.labFileSecond.Text = "Путь к второму файлу";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название нового файла";
            // 
            // txtResultFileName
            // 
            this.txtResultFileName.Location = new System.Drawing.Point(12, 109);
            this.txtResultFileName.Name = "txtResultFileName";
            this.txtResultFileName.Size = new System.Drawing.Size(282, 20);
            this.txtResultFileName.TabIndex = 6;
            // 
            // XMLSummatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 149);
            this.Controls.Add(this.txtResultFileName);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResultFileName;
    }
}

