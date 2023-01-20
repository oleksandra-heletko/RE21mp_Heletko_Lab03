namespace Heletko_Lab3
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
            this.components = new System.ComponentModel.Container();
            this.cDecLabel = new System.Windows.Forms.Label();
            this.keyDecLabel = new System.Windows.Forms.Label();
            this.pDecTextBox = new System.Windows.Forms.TextBox();
            this.keyDecTextBox = new System.Windows.Forms.TextBox();
            this.cDecTextBox = new System.Windows.Forms.TextBox();
            this.pDecLabel = new System.Windows.Forms.Label();
            this.cEncLabel = new System.Windows.Forms.Label();
            this.keyEncLabel = new System.Windows.Forms.Label();
            this.cEncTextBox = new System.Windows.Forms.TextBox();
            this.keyEncTextBox = new System.Windows.Forms.TextBox();
            this.pEncTextBox = new System.Windows.Forms.TextBox();
            this.pEncLabel = new System.Windows.Forms.Label();
            this.xorButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.encGroupBox = new System.Windows.Forms.GroupBox();
            this.decGroupBox = new System.Windows.Forms.GroupBox();
            this.encToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.encGroupBox.SuspendLayout();
            this.decGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cDecLabel
            // 
            this.cDecLabel.AutoSize = true;
            this.cDecLabel.Location = new System.Drawing.Point(30, 25);
            this.cDecLabel.Name = "cDecLabel";
            this.cDecLabel.Size = new System.Drawing.Size(26, 13);
            this.cDecLabel.TabIndex = 32;
            this.cDecLabel.Text = "C = ";
            // 
            // keyDecLabel
            // 
            this.keyDecLabel.AutoSize = true;
            this.keyDecLabel.Location = new System.Drawing.Point(16, 51);
            this.keyDecLabel.Name = "keyDecLabel";
            this.keyDecLabel.Size = new System.Drawing.Size(40, 13);
            this.keyDecLabel.TabIndex = 31;
            this.keyDecLabel.Text = "KEY = ";
            // 
            // pDecTextBox
            // 
            this.pDecTextBox.Location = new System.Drawing.Point(62, 74);
            this.pDecTextBox.Name = "pDecTextBox";
            this.pDecTextBox.Size = new System.Drawing.Size(100, 20);
            this.pDecTextBox.TabIndex = 30;
            // 
            // keyDecTextBox
            // 
            this.keyDecTextBox.Location = new System.Drawing.Point(62, 48);
            this.keyDecTextBox.Name = "keyDecTextBox";
            this.keyDecTextBox.Size = new System.Drawing.Size(100, 20);
            this.keyDecTextBox.TabIndex = 29;
            // 
            // cDecTextBox
            // 
            this.cDecTextBox.Location = new System.Drawing.Point(62, 22);
            this.cDecTextBox.Name = "cDecTextBox";
            this.cDecTextBox.Size = new System.Drawing.Size(100, 20);
            this.cDecTextBox.TabIndex = 28;
            // 
            // pDecLabel
            // 
            this.pDecLabel.AutoSize = true;
            this.pDecLabel.Location = new System.Drawing.Point(30, 77);
            this.pDecLabel.Name = "pDecLabel";
            this.pDecLabel.Size = new System.Drawing.Size(26, 13);
            this.pDecLabel.TabIndex = 27;
            this.pDecLabel.Text = "P = ";
            // 
            // cEncLabel
            // 
            this.cEncLabel.AutoSize = true;
            this.cEncLabel.Location = new System.Drawing.Point(25, 77);
            this.cEncLabel.Name = "cEncLabel";
            this.cEncLabel.Size = new System.Drawing.Size(26, 13);
            this.cEncLabel.TabIndex = 26;
            this.cEncLabel.Text = "C = ";
            // 
            // keyEncLabel
            // 
            this.keyEncLabel.AutoSize = true;
            this.keyEncLabel.Location = new System.Drawing.Point(11, 51);
            this.keyEncLabel.Name = "keyEncLabel";
            this.keyEncLabel.Size = new System.Drawing.Size(40, 13);
            this.keyEncLabel.TabIndex = 25;
            this.keyEncLabel.Text = "KEY = ";
            // 
            // cEncTextBox
            // 
            this.cEncTextBox.Location = new System.Drawing.Point(57, 74);
            this.cEncTextBox.Name = "cEncTextBox";
            this.cEncTextBox.Size = new System.Drawing.Size(100, 20);
            this.cEncTextBox.TabIndex = 24;
            // 
            // keyEncTextBox
            // 
            this.keyEncTextBox.Location = new System.Drawing.Point(57, 48);
            this.keyEncTextBox.Name = "keyEncTextBox";
            this.keyEncTextBox.Size = new System.Drawing.Size(100, 20);
            this.keyEncTextBox.TabIndex = 23;
            // 
            // pEncTextBox
            // 
            this.pEncTextBox.Location = new System.Drawing.Point(57, 22);
            this.pEncTextBox.Name = "pEncTextBox";
            this.pEncTextBox.Size = new System.Drawing.Size(100, 20);
            this.pEncTextBox.TabIndex = 22;
            // 
            // pEncLabel
            // 
            this.pEncLabel.AutoSize = true;
            this.pEncLabel.Location = new System.Drawing.Point(25, 25);
            this.pEncLabel.Name = "pEncLabel";
            this.pEncLabel.Size = new System.Drawing.Size(26, 13);
            this.pEncLabel.TabIndex = 21;
            this.pEncLabel.Text = "P = ";
            // 
            // xorButton
            // 
            this.xorButton.Location = new System.Drawing.Point(426, 41);
            this.xorButton.Name = "xorButton";
            this.xorButton.Size = new System.Drawing.Size(75, 27);
            this.xorButton.TabIndex = 20;
            this.xorButton.Text = "XOR";
            this.xorButton.UseVisualStyleBackColor = true;
            this.xorButton.Click += new System.EventHandler(this.xorButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(426, 84);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 29);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Очистити";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // encGroupBox
            // 
            this.encGroupBox.Controls.Add(this.pEncLabel);
            this.encGroupBox.Controls.Add(this.pEncTextBox);
            this.encGroupBox.Controls.Add(this.keyEncTextBox);
            this.encGroupBox.Controls.Add(this.cEncTextBox);
            this.encGroupBox.Controls.Add(this.keyEncLabel);
            this.encGroupBox.Controls.Add(this.cEncLabel);
            this.encGroupBox.Location = new System.Drawing.Point(12, 23);
            this.encGroupBox.Name = "encGroupBox";
            this.encGroupBox.Size = new System.Drawing.Size(200, 104);
            this.encGroupBox.TabIndex = 38;
            this.encGroupBox.TabStop = false;
            this.encGroupBox.Text = "Зашифрувати";
            // 
            // decGroupBox
            // 
            this.decGroupBox.Controls.Add(this.pDecLabel);
            this.decGroupBox.Controls.Add(this.cDecTextBox);
            this.decGroupBox.Controls.Add(this.keyDecTextBox);
            this.decGroupBox.Controls.Add(this.pDecTextBox);
            this.decGroupBox.Controls.Add(this.cDecLabel);
            this.decGroupBox.Controls.Add(this.keyDecLabel);
            this.decGroupBox.Location = new System.Drawing.Point(220, 23);
            this.decGroupBox.Name = "decGroupBox";
            this.decGroupBox.Size = new System.Drawing.Size(200, 104);
            this.decGroupBox.TabIndex = 39;
            this.decGroupBox.TabStop = false;
            this.decGroupBox.Text = "Розшифрувати";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 149);
            this.Controls.Add(this.decGroupBox);
            this.Controls.Add(this.encGroupBox);
            this.Controls.Add(this.xorButton);
            this.Controls.Add(this.clearButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.encGroupBox.ResumeLayout(false);
            this.encGroupBox.PerformLayout();
            this.decGroupBox.ResumeLayout(false);
            this.decGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cDecLabel;
        private System.Windows.Forms.Label keyDecLabel;
        private System.Windows.Forms.TextBox pDecTextBox;
        private System.Windows.Forms.TextBox keyDecTextBox;
        private System.Windows.Forms.TextBox cDecTextBox;
        private System.Windows.Forms.Label pDecLabel;
        private System.Windows.Forms.Label cEncLabel;
        private System.Windows.Forms.Label keyEncLabel;
        private System.Windows.Forms.TextBox cEncTextBox;
        private System.Windows.Forms.TextBox keyEncTextBox;
        private System.Windows.Forms.TextBox pEncTextBox;
        private System.Windows.Forms.Label pEncLabel;
        private System.Windows.Forms.Button xorButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox encGroupBox;
        private System.Windows.Forms.GroupBox decGroupBox;
        private System.Windows.Forms.ToolTip encToolTip;
    }
}

