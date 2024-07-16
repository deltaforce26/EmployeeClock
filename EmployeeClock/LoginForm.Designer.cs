namespace EmployeeClock
{
    partial class LoginForm
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
            label_password = new Label();
            textBox_password = new TextBox();
            button_enter = new Button();
            button_forgot_password = new Button();
            SuspendLayout();
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_id.Location = new Point(172, 21);
            label_id.Name = "label_id";
            label_id.Size = new Size(131, 31);
            label_id.TabIndex = 0;
            label_id.Text = "תעודת זהות";
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(161, 74);
            textBox_id.Name = "textBox_id";
            textBox_id.RightToLeft = RightToLeft.Yes;
            textBox_id.Size = new Size(151, 27);
            textBox_id.TabIndex = 1;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_password.Location = new Point(192, 115);
            label_password.Name = "label_password";
            label_password.Size = new Size(84, 31);
            label_password.TabIndex = 2;
            label_password.Text = "סיסמה";
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(161, 168);
            textBox_password.Name = "textBox_password";
            textBox_password.RightToLeft = RightToLeft.Yes;
            textBox_password.Size = new Size(151, 27);
            textBox_password.TabIndex = 3;
            textBox_password.UseSystemPasswordChar = true;
            // 
            // button_enter
            // 
            button_enter.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_enter.Location = new Point(161, 244);
            button_enter.Name = "button_enter";
            button_enter.RightToLeft = RightToLeft.Yes;
            button_enter.Size = new Size(151, 41);
            button_enter.TabIndex = 4;
            button_enter.Text = "כניסה";
            button_enter.UseVisualStyleBackColor = true;
            button_enter.Click += button_enter_Click;
            // 
            // button_forgot_password
            // 
            button_forgot_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_forgot_password.Location = new Point(161, 331);
            button_forgot_password.Name = "button_forgot_password";
            button_forgot_password.RightToLeft = RightToLeft.Yes;
            button_forgot_password.Size = new Size(151, 41);
            button_forgot_password.TabIndex = 5;
            button_forgot_password.Text = "החלפת סיסמה";
            button_forgot_password.UseVisualStyleBackColor = true;
            button_forgot_password.Click += button_forgot_password_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 0);
            ClientSize = new Size(486, 453);
            Controls.Add(button_forgot_password);
            Controls.Add(button_enter);
            Controls.Add(textBox_password);
            Controls.Add(label_password);
            Controls.Add(textBox_id);
            Controls.Add(label_id);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_id;
        private TextBox textBox_id;
        private Label label_password;
        private TextBox textBox_password;
        private Button button_enter;
        private Button button_forgot_password;
    }
}