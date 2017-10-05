namespace ExampleSecondWinForm
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
            this.startGameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.largerButton = new System.Windows.Forms.Button();
            this.lessButton = new System.Windows.Forms.Button();
            this.endGameButton = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(12, 12);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(75, 23);
            this.startGameButton.TabIndex = 0;
            this.startGameButton.Text = "StartGame";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // largerButton
            // 
            this.largerButton.Location = new System.Drawing.Point(258, 33);
            this.largerButton.Name = "largerButton";
            this.largerButton.Size = new System.Drawing.Size(75, 23);
            this.largerButton.TabIndex = 2;
            this.largerButton.Text = "Больше";
            this.largerButton.UseVisualStyleBackColor = true;
            this.largerButton.Click += new System.EventHandler(this.largerButton_Click);
            // 
            // lessButton
            // 
            this.lessButton.Location = new System.Drawing.Point(258, 62);
            this.lessButton.Name = "lessButton";
            this.lessButton.Size = new System.Drawing.Size(75, 23);
            this.lessButton.TabIndex = 3;
            this.lessButton.Text = "Меньше";
            this.lessButton.UseVisualStyleBackColor = true;
            this.lessButton.Click += new System.EventHandler(this.lessButton_Click);
            // 
            // endGameButton
            // 
            this.endGameButton.Location = new System.Drawing.Point(244, 91);
            this.endGameButton.Name = "endGameButton";
            this.endGameButton.Size = new System.Drawing.Size(103, 23);
            this.endGameButton.TabIndex = 4;
            this.endGameButton.Text = "Это Мое число!!!";
            this.endGameButton.UseVisualStyleBackColor = true;
            this.endGameButton.Click += new System.EventHandler(this.EndGameButton_Click);
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(269, 17);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(44, 13);
            this.number.TabIndex = 5;
            this.number.Text = "Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 470);
            this.Controls.Add(this.number);
            this.Controls.Add(this.endGameButton);
            this.Controls.Add(this.lessButton);
            this.Controls.Add(this.largerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startGameButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button largerButton;
        private System.Windows.Forms.Button lessButton;
        private System.Windows.Forms.Button endGameButton;
        private System.Windows.Forms.Label number;
    }
}

