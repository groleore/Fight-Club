namespace FightClub
{
    partial class GameView
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
            this.HumanHPBar = new System.Windows.Forms.ProgressBar();
            this.ComputerHPBar = new System.Windows.Forms.ProgressBar();
            this.HumanName = new System.Windows.Forms.Label();
            this.ComputerName = new System.Windows.Forms.Label();
            this.ComputerHPLabel = new System.Windows.Forms.Label();
            this.HumanHPLabel = new System.Windows.Forms.Label();
            this.GameBtn = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.LegsBtn = new System.Windows.Forms.RadioButton();
            this.BodyBtn = new System.Windows.Forms.RadioButton();
            this.HeadBtn = new System.Windows.Forms.RadioButton();
            this.partBox = new System.Windows.Forms.GroupBox();
            this.computerBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.humanBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RoundLabel2 = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.partBox.SuspendLayout();
            this.computerBox.SuspendLayout();
            this.humanBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HumanHPBar
            // 
            this.HumanHPBar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.HumanHPBar.Location = new System.Drawing.Point(11, 127);
            this.HumanHPBar.Margin = new System.Windows.Forms.Padding(4);
            this.HumanHPBar.Name = "HumanHPBar";
            this.HumanHPBar.Size = new System.Drawing.Size(173, 20);
            this.HumanHPBar.TabIndex = 0;
            // 
            // ComputerHPBar
            // 
            this.ComputerHPBar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.ComputerHPBar.Location = new System.Drawing.Point(11, 127);
            this.ComputerHPBar.Margin = new System.Windows.Forms.Padding(4);
            this.ComputerHPBar.Maximum = 300;
            this.ComputerHPBar.Name = "ComputerHPBar";
            this.ComputerHPBar.Size = new System.Drawing.Size(173, 20);
            this.ComputerHPBar.TabIndex = 1;
            // 
            // HumanName
            // 
            this.HumanName.AutoSize = true;
            this.HumanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HumanName.Location = new System.Drawing.Point(61, 39);
            this.HumanName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HumanName.Name = "HumanName";
            this.HumanName.Size = new System.Drawing.Size(0, 20);
            this.HumanName.TabIndex = 2;
            // 
            // ComputerName
            // 
            this.ComputerName.AutoSize = true;
            this.ComputerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ComputerName.Location = new System.Drawing.Point(74, 39);
            this.ComputerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ComputerName.Name = "ComputerName";
            this.ComputerName.Size = new System.Drawing.Size(0, 20);
            this.ComputerName.TabIndex = 3;
            // 
            // ComputerHPLabel
            // 
            this.ComputerHPLabel.AutoSize = true;
            this.ComputerHPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ComputerHPLabel.Location = new System.Drawing.Point(54, 85);
            this.ComputerHPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ComputerHPLabel.Name = "ComputerHPLabel";
            this.ComputerHPLabel.Size = new System.Drawing.Size(0, 20);
            this.ComputerHPLabel.TabIndex = 5;
            // 
            // HumanHPLabel
            // 
            this.HumanHPLabel.AutoSize = true;
            this.HumanHPLabel.BackColor = System.Drawing.Color.Transparent;
            this.HumanHPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HumanHPLabel.Location = new System.Drawing.Point(54, 85);
            this.HumanHPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HumanHPLabel.Name = "HumanHPLabel";
            this.HumanHPLabel.Size = new System.Drawing.Size(0, 20);
            this.HumanHPLabel.TabIndex = 4;
            // 
            // GameBtn
            // 
            this.GameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GameBtn.Location = new System.Drawing.Point(183, 238);
            this.GameBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GameBtn.Name = "GameBtn";
            this.GameBtn.Size = new System.Drawing.Size(266, 43);
            this.GameBtn.TabIndex = 7;
            this.GameBtn.Text = "Start Game!";
            this.GameBtn.UseVisualStyleBackColor = true;
            this.GameBtn.Click += new System.EventHandler(this.GameBtn_Click);
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(12, 298);
            this.LogBox.Margin = new System.Windows.Forms.Padding(4);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(611, 120);
            this.LogBox.TabIndex = 8;
            this.LogBox.Text = "";
            // 
            // LegsBtn
            // 
            this.LegsBtn.AutoSize = true;
            this.LegsBtn.Location = new System.Drawing.Point(8, 123);
            this.LegsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LegsBtn.Name = "LegsBtn";
            this.LegsBtn.Size = new System.Drawing.Size(120, 24);
            this.LegsBtn.TabIndex = 13;
            this.LegsBtn.Text = "Legs (10 HP)";
            this.LegsBtn.UseVisualStyleBackColor = true;
            // 
            // BodyBtn
            // 
            this.BodyBtn.AutoSize = true;
            this.BodyBtn.Location = new System.Drawing.Point(8, 71);
            this.BodyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BodyBtn.Name = "BodyBtn";
            this.BodyBtn.Size = new System.Drawing.Size(121, 24);
            this.BodyBtn.TabIndex = 12;
            this.BodyBtn.Text = "Body (30 HP)";
            this.BodyBtn.UseVisualStyleBackColor = true;
            // 
            // HeadBtn
            // 
            this.HeadBtn.AutoSize = true;
            this.HeadBtn.Location = new System.Drawing.Point(7, 26);
            this.HeadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.HeadBtn.Name = "HeadBtn";
            this.HeadBtn.Size = new System.Drawing.Size(124, 24);
            this.HeadBtn.TabIndex = 11;
            this.HeadBtn.Text = "Head (50 HP)";
            this.HeadBtn.UseVisualStyleBackColor = true;
            // 
            // partBox
            // 
            this.partBox.Controls.Add(this.LegsBtn);
            this.partBox.Controls.Add(this.HeadBtn);
            this.partBox.Controls.Add(this.BodyBtn);
            this.partBox.Enabled = false;
            this.partBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partBox.Location = new System.Drawing.Point(243, 55);
            this.partBox.Margin = new System.Windows.Forms.Padding(4);
            this.partBox.Name = "partBox";
            this.partBox.Padding = new System.Windows.Forms.Padding(4);
            this.partBox.Size = new System.Drawing.Size(153, 166);
            this.partBox.TabIndex = 14;
            this.partBox.TabStop = false;
            this.partBox.Text = "Part of Body";
            // 
            // computerBox
            // 
            this.computerBox.Controls.Add(this.label4);
            this.computerBox.Controls.Add(this.label3);
            this.computerBox.Controls.Add(this.ComputerHPBar);
            this.computerBox.Controls.Add(this.ComputerName);
            this.computerBox.Controls.Add(this.ComputerHPLabel);
            this.computerBox.Enabled = false;
            this.computerBox.Location = new System.Drawing.Point(403, 55);
            this.computerBox.Name = "computerBox";
            this.computerBox.Size = new System.Drawing.Size(224, 166);
            this.computerBox.TabIndex = 15;
            this.computerBox.TabStop = false;
            this.computerBox.Text = "Computer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(7, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "HP :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(7, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name :";
            // 
            // humanBox
            // 
            this.humanBox.Controls.Add(this.label1);
            this.humanBox.Controls.Add(this.label2);
            this.humanBox.Controls.Add(this.HumanHPBar);
            this.humanBox.Controls.Add(this.HumanName);
            this.humanBox.Controls.Add(this.HumanHPLabel);
            this.humanBox.Enabled = false;
            this.humanBox.Location = new System.Drawing.Point(12, 55);
            this.humanBox.Name = "humanBox";
            this.humanBox.Size = new System.Drawing.Size(224, 166);
            this.humanBox.TabIndex = 16;
            this.humanBox.TabStop = false;
            this.humanBox.Text = "Human";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "HP :";
            // 
            // RoundLabel2
            // 
            this.RoundLabel2.AutoSize = true;
            this.RoundLabel2.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundLabel2.Location = new System.Drawing.Point(239, 18);
            this.RoundLabel2.Name = "RoundLabel2";
            this.RoundLabel2.Size = new System.Drawing.Size(82, 22);
            this.RoundLabel2.TabIndex = 17;
            this.RoundLabel2.Text = "Round  №";
            this.RoundLabel2.Visible = false;
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundLabel.Location = new System.Drawing.Point(357, 18);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(0, 22);
            this.RoundLabel.TabIndex = 18;
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 446);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.RoundLabel2);
            this.Controls.Add(this.humanBox);
            this.Controls.Add(this.computerBox);
            this.Controls.Add(this.partBox);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.GameBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameView";
            this.Text = "Fight Club";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.partBox.ResumeLayout(false);
            this.partBox.PerformLayout();
            this.computerBox.ResumeLayout(false);
            this.computerBox.PerformLayout();
            this.humanBox.ResumeLayout(false);
            this.humanBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar HumanHPBar;
        private System.Windows.Forms.ProgressBar ComputerHPBar;
        private System.Windows.Forms.Label HumanName;
        private System.Windows.Forms.Label ComputerName;
        private System.Windows.Forms.Label ComputerHPLabel;
        private System.Windows.Forms.Label HumanHPLabel;
        private System.Windows.Forms.Button GameBtn;
        private System.Windows.Forms.RichTextBox LogBox;
        private System.Windows.Forms.RadioButton LegsBtn;
        private System.Windows.Forms.RadioButton BodyBtn;
        private System.Windows.Forms.RadioButton HeadBtn;
        private System.Windows.Forms.GroupBox partBox;
        private System.Windows.Forms.GroupBox computerBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox humanBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RoundLabel2;
        private System.Windows.Forms.Label RoundLabel;
    }
}

