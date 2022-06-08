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
            this.txtFileNameSecond = new System.Windows.Forms.TextBox();
            this.txtFileNameFirst = new System.Windows.Forms.TextBox();
            this.labFileFirst = new System.Windows.Forms.Label();
            this.labFileSecond = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultFileName = new System.Windows.Forms.TextBox();
            this.btnFileDialog = new System.Windows.Forms.Button();
            this.btnFileDialog2 = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.labStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(398, 156);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(131, 35);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Создать файл";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // txtFileNameSecond
            // 
            this.txtFileNameSecond.Location = new System.Drawing.Point(12, 68);
            this.txtFileNameSecond.Name = "txtFileNameSecond";
            this.txtFileNameSecond.Size = new System.Drawing.Size(431, 20);
            this.txtFileNameSecond.TabIndex = 6;
            // 
            // txtFileNameFirst
            // 
            this.txtFileNameFirst.Location = new System.Drawing.Point(12, 27);
            this.txtFileNameFirst.Name = "txtFileNameFirst";
            this.txtFileNameFirst.Size = new System.Drawing.Size(431, 20);
            this.txtFileNameFirst.TabIndex = 5;
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
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Путь нового файла";
            // 
            // txtResultFileName
            // 
            this.txtResultFileName.Location = new System.Drawing.Point(12, 109);
            this.txtResultFileName.Name = "txtResultFileName";
            this.txtResultFileName.Size = new System.Drawing.Size(431, 20);
            this.txtResultFileName.TabIndex = 7;
            // 
            // btnFileDialog
            // 
            this.btnFileDialog.Location = new System.Drawing.Point(454, 21);
            this.btnFileDialog.Name = "btnFileDialog";
            this.btnFileDialog.Size = new System.Drawing.Size(75, 31);
            this.btnFileDialog.TabIndex = 1;
            this.btnFileDialog.Text = "Обзор";
            this.btnFileDialog.UseVisualStyleBackColor = true;
            // 
            // btnFileDialog2
            // 
            this.btnFileDialog2.Location = new System.Drawing.Point(454, 62);
            this.btnFileDialog2.Name = "btnFileDialog2";
            this.btnFileDialog2.Size = new System.Drawing.Size(75, 30);
            this.btnFileDialog2.TabIndex = 2;
            this.btnFileDialog2.Text = "Обзор";
            this.btnFileDialog2.UseVisualStyleBackColor = true;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(454, 103);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 30);
            this.btnSaveFile.TabIndex = 3;
            this.btnSaveFile.Text = "Обзор";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(12, 132);
            this.labStatus.MaximumSize = new System.Drawing.Size(250, 0);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(41, 15);
            this.labStatus.TabIndex = 10;
            this.labStatus.Text = "label2";
            this.labStatus.Visible = false;
            // 
            // XMLSummatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 203);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnFileDialog2);
            this.Controls.Add(this.btnFileDialog);
            this.Controls.Add(this.txtResultFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labFileSecond);
            this.Controls.Add(this.labFileFirst);
            this.Controls.Add(this.txtFileNameFirst);
            this.Controls.Add(this.txtFileNameSecond);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "XMLSummatorForm";
            this.ShowIcon = false;
            this.Text = "Сложение XML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtFileNameSecond;
        private System.Windows.Forms.TextBox txtFileNameFirst;
        private System.Windows.Forms.Label labFileFirst;
        private System.Windows.Forms.Label labFileSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResultFileName;
        private System.Windows.Forms.Button btnFileDialog;
        private System.Windows.Forms.Button btnFileDialog2;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Label labStatus;
    }
}

