namespace PasswordGenerator
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
            txtNewPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPasswordLength = new TextBox();
            chkIncludesUppercase = new CheckBox();
            chkIncludesLowerCase = new CheckBox();
            chkIncludesNumbers = new CheckBox();
            chkIncludesSymbols = new CheckBox();
            btnGeneratePassword = new Button();
            SuspendLayout();
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(163, 62);
            txtNewPassword.Multiline = true;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(499, 159);
            txtNewPassword.TabIndex = 0;
            txtNewPassword.KeyPress += txtNewPassword_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(306, 19);
            label1.Name = "label1";
            label1.Size = new Size(197, 30);
            label1.TabIndex = 1;
            label1.Text = "Password Generator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(325, 240);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 2;
            label2.Text = "Password Length";
            // 
            // txtPasswordLength
            // 
            txtPasswordLength.Location = new Point(459, 240);
            txtPasswordLength.Name = "txtPasswordLength";
            txtPasswordLength.Size = new Size(54, 23);
            txtPasswordLength.TabIndex = 6;
            // 
            // chkIncludesUppercase
            // 
            chkIncludesUppercase.AutoSize = true;
            chkIncludesUppercase.CheckAlign = ContentAlignment.MiddleRight;
            chkIncludesUppercase.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkIncludesUppercase.Location = new Point(325, 264);
            chkIncludesUppercase.Name = "chkIncludesUppercase";
            chkIncludesUppercase.Size = new Size(167, 25);
            chkIncludesUppercase.TabIndex = 9;
            chkIncludesUppercase.Text = "Includes Uppercase ";
            chkIncludesUppercase.UseVisualStyleBackColor = true;
            // 
            // chkIncludesLowerCase
            // 
            chkIncludesLowerCase.AutoSize = true;
            chkIncludesLowerCase.CheckAlign = ContentAlignment.MiddleRight;
            chkIncludesLowerCase.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkIncludesLowerCase.Location = new Point(328, 295);
            chkIncludesLowerCase.Name = "chkIncludesLowerCase";
            chkIncludesLowerCase.Size = new Size(163, 25);
            chkIncludesLowerCase.TabIndex = 10;
            chkIncludesLowerCase.Text = "Includes Lowercase";
            chkIncludesLowerCase.UseVisualStyleBackColor = true;
            // 
            // chkIncludesNumbers
            // 
            chkIncludesNumbers.AutoSize = true;
            chkIncludesNumbers.CheckAlign = ContentAlignment.MiddleRight;
            chkIncludesNumbers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkIncludesNumbers.Location = new Point(328, 326);
            chkIncludesNumbers.Name = "chkIncludesNumbers";
            chkIncludesNumbers.Size = new Size(163, 25);
            chkIncludesNumbers.TabIndex = 11;
            chkIncludesNumbers.Text = "Includes Numbers  ";
            chkIncludesNumbers.UseVisualStyleBackColor = true;
            // 
            // chkIncludesSymbols
            // 
            chkIncludesSymbols.AutoSize = true;
            chkIncludesSymbols.CheckAlign = ContentAlignment.MiddleRight;
            chkIncludesSymbols.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkIncludesSymbols.Location = new Point(329, 357);
            chkIncludesSymbols.Name = "chkIncludesSymbols";
            chkIncludesSymbols.Size = new Size(162, 25);
            chkIncludesSymbols.TabIndex = 12;
            chkIncludesSymbols.Text = "Includes Symbols   ";
            chkIncludesSymbols.UseVisualStyleBackColor = true;
            // 
            // btnGeneratePassword
            // 
            btnGeneratePassword.Location = new Point(378, 397);
            btnGeneratePassword.Name = "btnGeneratePassword";
            btnGeneratePassword.Size = new Size(75, 23);
            btnGeneratePassword.TabIndex = 13;
            btnGeneratePassword.Text = "Generate!";
            btnGeneratePassword.UseVisualStyleBackColor = true;
            btnGeneratePassword.Click += btnGeneratePassword_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(773, 455);
            Controls.Add(btnGeneratePassword);
            Controls.Add(chkIncludesSymbols);
            Controls.Add(chkIncludesNumbers);
            Controls.Add(chkIncludesLowerCase);
            Controls.Add(chkIncludesUppercase);
            Controls.Add(txtPasswordLength);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNewPassword);
            Name = "Form1";
            Text = "PasswordGenerator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNewPassword;
        private Label label1;
        private Label label2;
        private TextBox txtPasswordLength;
        private CheckBox chkIncludesUppercase;
        private CheckBox chkIncludesLowerCase;
        private CheckBox chkIncludesNumbers;
        private CheckBox chkIncludesSymbols;
        private Button btnGeneratePassword;
    }
}