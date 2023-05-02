namespace WindowsFormsApp1
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
            this.EncryptButton = new System.Windows.Forms.Button();
            this.PlainTextField = new System.Windows.Forms.TextBox();
            this.EncryptedTextField = new System.Windows.Forms.TextBox();
            this.HashedTextField = new System.Windows.Forms.TextBox();
            this.StreamedTextField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(12, 38);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptButton.TabIndex = 0;
            this.EncryptButton.Text = "ОК";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // PlainTextField
            // 
            this.PlainTextField.Location = new System.Drawing.Point(12, 12);
            this.PlainTextField.Name = "PlainTextField";
            this.PlainTextField.Size = new System.Drawing.Size(353, 20);
            this.PlainTextField.TabIndex = 1;
            // 
            // EncryptedTextField
            // 
            this.EncryptedTextField.Location = new System.Drawing.Point(12, 82);
            this.EncryptedTextField.Name = "EncryptedTextField";
            this.EncryptedTextField.Size = new System.Drawing.Size(353, 20);
            this.EncryptedTextField.TabIndex = 2;
            // 
            // HashedTextField
            // 
            this.HashedTextField.Location = new System.Drawing.Point(12, 108);
            this.HashedTextField.Name = "HashedTextField";
            this.HashedTextField.Size = new System.Drawing.Size(353, 20);
            this.HashedTextField.TabIndex = 3;
            // 
            // StreamedTextField
            // 
            this.StreamedTextField.Location = new System.Drawing.Point(12, 134);
            this.StreamedTextField.Name = "StreamedTextField";
            this.StreamedTextField.Size = new System.Drawing.Size(353, 20);
            this.StreamedTextField.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введіть текст для шифрування та хешування";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Блоковий алгоритм шифрування CRAB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Алгоритм хешування RIPE-MD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Потоковий шифр Маурера";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StreamedTextField);
            this.Controls.Add(this.HashedTextField);
            this.Controls.Add(this.EncryptedTextField);
            this.Controls.Add(this.PlainTextField);
            this.Controls.Add(this.EncryptButton);
            this.Name = "Form1";
            this.Text = "Лабораторна робота 24";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.TextBox PlainTextField;
        private System.Windows.Forms.TextBox EncryptedTextField;
        private System.Windows.Forms.TextBox HashedTextField;
        private System.Windows.Forms.TextBox StreamedTextField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

