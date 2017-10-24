namespace FightClub
{
    partial class CreatePlayerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Submit = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HPBar = new System.Windows.Forms.TrackBar();
            this.HPBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.HPBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(93, 111);
            this.Submit.Margin = new System.Windows.Forms.Padding(4);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(112, 32);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(93, 20);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(170, 24);
            this.NameBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(20, 22);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 18);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "HP:";
            // 
            // HPBar
            // 
            this.HPBar.LargeChange = 25;
            this.HPBar.Location = new System.Drawing.Point(93, 67);
            this.HPBar.Margin = new System.Windows.Forms.Padding(2);
            this.HPBar.Maximum = 300;
            this.HPBar.Minimum = 100;
            this.HPBar.Name = "HPBar";
            this.HPBar.Size = new System.Drawing.Size(107, 45);
            this.HPBar.SmallChange = 5;
            this.HPBar.TabIndex = 5;
            this.HPBar.Value = 100;
            this.HPBar.Scroll += new System.EventHandler(this.HPBar_Scroll);
            // 
            // HPBox
            // 
            this.HPBox.Location = new System.Drawing.Point(217, 67);
            this.HPBox.Margin = new System.Windows.Forms.Padding(4);
            this.HPBox.Name = "HPBox";
            this.HPBox.ReadOnly = true;
            this.HPBox.Size = new System.Drawing.Size(46, 24);
            this.HPBox.TabIndex = 6;
            // 
            // CreatePlayerForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 156);
            this.ControlBox = false;
            this.Controls.Add(this.HPBox);
            this.Controls.Add(this.HPBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Submit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreatePlayerForm";
            this.Text = "New Player";
            this.Load += new System.EventHandler(this.CreatePlayerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HPBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar HPBar;
        private System.Windows.Forms.TextBox HPBox;
    }
}