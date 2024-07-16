namespace EmployeeClock
{
    partial class EmployeeIdentityForm
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
            label_employee_identity = new Label();
            label_last_entry_date = new Label();
            label_last_exit_date = new Label();
            button_entry = new Button();
            button_exit = new Button();
            linkLabel_cancel = new LinkLabel();
            label_employee_nat = new Label();
            label_last_entry2 = new Label();
            label_last_exit2 = new Label();
            SuspendLayout();
            // 
            // label_employee_identity
            // 
            label_employee_identity.AutoSize = true;
            label_employee_identity.Font = new Font("Miriam", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_employee_identity.Location = new Point(269, 30);
            label_employee_identity.Margin = new Padding(4, 0, 4, 0);
            label_employee_identity.Name = "label_employee_identity";
            label_employee_identity.Size = new Size(124, 23);
            label_employee_identity.TabIndex = 0;
            label_employee_identity.Text = "זהות עובד :";
            // 
            // label_last_entry_date
            // 
            label_last_entry_date.AutoSize = true;
            label_last_entry_date.Location = new Point(132, 106);
            label_last_entry_date.Name = "label_last_entry_date";
            label_last_entry_date.Size = new Size(180, 20);
            label_last_entry_date.TabIndex = 1;
            label_last_entry_date.Text = "תאריך כניסה אחרון";
            // 
            // label_last_exit_date
            // 
            label_last_exit_date.AutoSize = true;
            label_last_exit_date.Location = new Point(132, 177);
            label_last_exit_date.Name = "label_last_exit_date";
            label_last_exit_date.Size = new Size(181, 20);
            label_last_exit_date.TabIndex = 2;
            label_last_exit_date.Text = "תאריך יציאה אחרון";
            // 
            // button_entry
            // 
            button_entry.BackColor = Color.FromArgb(192, 192, 0);
            button_entry.Location = new Point(320, 320);
            button_entry.Name = "button_entry";
            button_entry.Size = new Size(94, 108);
            button_entry.TabIndex = 4;
            button_entry.Text = "כניסה";
            button_entry.UseVisualStyleBackColor = false;
            button_entry.Click += button_entry_Click;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.Red;
            button_exit.Location = new Point(42, 320);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(94, 108);
            button_exit.TabIndex = 5;
            button_exit.Text = "יציאה";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button_exit_Click;
            // 
            // linkLabel_cancel
            // 
            linkLabel_cancel.AutoSize = true;
            linkLabel_cancel.Location = new Point(196, 271);
            linkLabel_cancel.Name = "linkLabel_cancel";
            linkLabel_cancel.Size = new Size(61, 20);
            linkLabel_cancel.TabIndex = 6;
            linkLabel_cancel.TabStop = true;
            linkLabel_cancel.Text = "ביטול";
            linkLabel_cancel.LinkClicked += linkLabel_cancel_LinkClicked;
            // 
            // label_employee_nat
            // 
            label_employee_nat.AutoSize = true;
            label_employee_nat.Font = new Font("Miriam", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_employee_nat.ForeColor = Color.Lime;
            label_employee_nat.Location = new Point(106, 30);
            label_employee_nat.Margin = new Padding(4, 0, 4, 0);
            label_employee_nat.Name = "label_employee_nat";
            label_employee_nat.Size = new Size(0, 23);
            label_employee_nat.TabIndex = 7;
            // 
            // label_last_entry2
            // 
            label_last_entry2.AutoSize = true;
            label_last_entry2.ForeColor = Color.FromArgb(192, 192, 0);
            label_last_entry2.Location = new Point(133, 142);
            label_last_entry2.Name = "label_last_entry2";
            label_last_entry2.Size = new Size(0, 20);
            label_last_entry2.TabIndex = 8;
            // 
            // label_last_exit2
            // 
            label_last_exit2.AutoSize = true;
            label_last_exit2.ForeColor = Color.FromArgb(255, 128, 0);
            label_last_exit2.Location = new Point(132, 212);
            label_last_exit2.Name = "label_last_exit2";
            label_last_exit2.Size = new Size(0, 20);
            label_last_exit2.TabIndex = 9;
            // 
            // EmployeeIdentityForm
            // 
            AutoScaleDimensions = new SizeF(12F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 450);
            Controls.Add(label_last_exit2);
            Controls.Add(label_last_entry2);
            Controls.Add(label_employee_nat);
            Controls.Add(linkLabel_cancel);
            Controls.Add(button_exit);
            Controls.Add(button_entry);
            Controls.Add(label_last_exit_date);
            Controls.Add(label_last_entry_date);
            Controls.Add(label_employee_identity);
            Font = new Font("Miriam", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EmployeeIdentityForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeIdentityForm";
            Load += EmployeeIdentityForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_employee_identity;
        private Label label_last_entry_date;
        private Label label_last_exit_date;
        private Button button_entry;
        private Button button_exit;
        private LinkLabel linkLabel_cancel;
        private Label label_employee_nat;
        private Label label_last_entry2;
        private Label label_last_exit2;
    }
}