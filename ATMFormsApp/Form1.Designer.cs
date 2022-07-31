namespace ATMFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sumBox = new System.Windows.Forms.TextBox();
            this.destBox = new System.Windows.Forms.TextBox();
            this.Gobutton = new System.Windows.Forms.Button();
            this.BalanceButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sumBox
            // 
            this.sumBox.Location = new System.Drawing.Point(125, 20);
            this.sumBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sumBox.Name = "sumBox";
            this.sumBox.PlaceholderText = "Номер картки";
            this.sumBox.Size = new System.Drawing.Size(110, 23);
            this.sumBox.TabIndex = 2;
            // 
            // destBox
            // 
            this.destBox.Location = new System.Drawing.Point(126, 55);
            this.destBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.destBox.Name = "destBox";
            this.destBox.PlaceholderText = "PIN-код";
            this.destBox.Size = new System.Drawing.Size(110, 23);
            this.destBox.TabIndex = 3;
            // 
            // Gobutton
            // 
            this.Gobutton.Location = new System.Drawing.Point(126, 90);
            this.Gobutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gobutton.Name = "Gobutton";
            this.Gobutton.Size = new System.Drawing.Size(110, 23);
            this.Gobutton.TabIndex = 4;
            this.Gobutton.Text = "Аутентифікувати";
            this.Gobutton.UseVisualStyleBackColor = true;
            this.Gobutton.Click += new System.EventHandler(this.Gobutton_Click);
            // 
            // BalanceButton
            // 
            this.BalanceButton.Location = new System.Drawing.Point(10, 20);
            this.BalanceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BalanceButton.Name = "BalanceButton";
            this.BalanceButton.Size = new System.Drawing.Size(110, 23);
            this.BalanceButton.TabIndex = 7;
            this.BalanceButton.Text = "Баланс";
            this.BalanceButton.UseVisualStyleBackColor = true;
            this.BalanceButton.Visible = false;
            this.BalanceButton.Click += new System.EventHandler(this.BalanceButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(10, 55);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(110, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Нарахувати";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Visible = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.Location = new System.Drawing.Point(242, 20);
            this.WithdrawButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(110, 23);
            this.WithdrawButton.TabIndex = 9;
            this.WithdrawButton.Text = "Зняти";
            this.WithdrawButton.UseVisualStyleBackColor = true;
            this.WithdrawButton.Visible = false;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(242, 55);
            this.SendButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(110, 23);
            this.SendButton.TabIndex = 10;
            this.SendButton.Text = "Надіслати";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Visible = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(126, 120);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(110, 23);
            this.LogoutButton.TabIndex = 11;
            this.LogoutButton.Text = "Вийти";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Visible = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(364, 161);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.WithdrawButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BalanceButton);
            this.Controls.Add(this.Gobutton);
            this.Controls.Add(this.destBox);
            this.Controls.Add(this.sumBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Термінал";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox sumBox;
        private TextBox destBox;
        private Button Gobutton;
        private Button BalanceButton;
        private Button AddButton;
        private Button WithdrawButton;
        private Button SendButton;
        private Button LogoutButton;
    }
}