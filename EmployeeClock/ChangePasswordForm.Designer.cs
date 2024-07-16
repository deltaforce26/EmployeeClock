namespace EmployeeClock
{
    partial class ChangePasswordForm
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
            label_id = new Label();
            textBox_id = new TextBox();
            label_oldPassword = new Label();
            textBox_old_password = new TextBox();
            label_new_password = new Label();
            textBox_NewPassword = new TextBox();
            label_confirmNewPassword = new Label();
            textBoxConfirmNewPassword = new TextBox();
            button_changePassword = new Button();
            button_cancel = new Button();
            SuspendLayout();
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Location = new Point(433, 38);
            label_id.Name = "label_id";
            label_id.Size = new Size(113, 28);
            label_id.TabIndex = 0;
            label_id.Text = "תעודת זהות";
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(110, 32);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(149, 34);
            textBox_id.TabIndex = 1;
            // 
            // label_oldPassword
            // 
            label_oldPassword.AutoSize = true;
            label_oldPassword.Location = new Point(427, 116);
            label_oldPassword.Name = "label_oldPassword";
            label_oldPassword.Size = new Size(119, 28);
            label_oldPassword.TabIndex = 2;
            label_oldPassword.Text = "סיסמה ישנה";
            // 
            // textBox_old_password
            // 
            textBox_old_password.Location = new Point(110, 110);
            textBox_old_password.Name = "textBox_old_password";
            textBox_old_password.Size = new Size(149, 34);
            textBox_old_password.TabIndex = 3;
            // 
            // label_new_password
            // 
            label_new_password.AutoSize = true;
            label_new_password.Location = new Point(418, 208);
            label_new_password.Name = "label_new_password";
            label_new_password.Size = new Size(128, 28);
            label_new_password.TabIndex = 4;
            label_new_password.Text = "סיסמה חדשה";
            // 
            // textBox_NewPassword
            // 
            textBox_NewPassword.BackColor = SystemColors.Info;
            textBox_NewPassword.Location = new Point(110, 202);
            textBox_NewPassword.Name = "textBox_NewPassword";
            textBox_NewPassword.Size = new Size(149, 34);
            textBox_NewPassword.TabIndex = 5;
            // 
            // label_confirmNewPassword
            // 
            label_confirmNewPassword.AutoSize = true;
            label_confirmNewPassword.Location = new Point(361, 289);
            label_confirmNewPassword.Name = "label_confirmNewPassword";
            label_confirmNewPassword.Size = new Size(185, 28);
            label_confirmNewPassword.TabIndex = 6;
            label_confirmNewPassword.Text = "אישור סיסמה חדשה";
            // 
            // textBoxConfirmNewPassword
            // 
            textBoxConfirmNewPassword.BackColor = SystemColors.Info;
            textBoxConfirmNewPassword.Location = new Point(110, 283);
            textBoxConfirmNewPassword.Name = "textBoxConfirmNewPassword";
            textBoxConfirmNewPassword.Size = new Size(149, 34);
            textBoxConfirmNewPassword.TabIndex = 7;
            // 
            // button_changePassword
            // 
            button_changePassword.BackColor = SystemColors.Info;
            button_changePassword.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_changePassword.Location = new Point(110, 359);
            button_changePassword.Name = "button_changePassword";
            button_changePassword.Size = new Size(149, 37);
            button_changePassword.TabIndex = 8;
            button_changePassword.Text = "ביצוע החלפת סיסמה";
            button_changePassword.UseVisualStyleBackColor = false;
            button_changePassword.Click += button_changePassword_Click;
            // 
            // button_cancel
            // 
            button_cancel.ForeColor = Color.Blue;
            button_cancel.Location = new Point(442, 359);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(104, 37);
            button_cancel.TabIndex = 9;
            button_cancel.Text = "ביטול";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 452);
            Controls.Add(button_cancel);
            Controls.Add(button_changePassword);
            Controls.Add(textBoxConfirmNewPassword);
            Controls.Add(label_confirmNewPassword);
            Controls.Add(textBox_NewPassword);
            Controls.Add(label_new_password);
            Controls.Add(textBox_old_password);
            Controls.Add(label_oldPassword);
            Controls.Add(textBox_id);
            Controls.Add(label_id);
            Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "ChangePasswordForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_id;
        private TextBox textBox_id;
        private Label label_oldPassword;
        private TextBox textBox_old_password;
        private Label label_new_password;
        private TextBox textBox_NewPassword;
        private Label label_confirmNewPassword;
        private TextBox textBoxConfirmNewPassword;
        private Button button_changePassword;
        private Button button_cancel;
    }
}