namespace Password_Generator
{
    partial class Form1
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
            this.pw_TextBox = new System.Windows.Forms.TextBox();
            this.gen_Button = new System.Windows.Forms.Button();
            this.pwLenght_NmbUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.copy_Btn = new System.Windows.Forms.Button();
            this.upperCase_CB = new System.Windows.Forms.CheckBox();
            this.lowerCase_CB = new System.Windows.Forms.CheckBox();
            this.specialChars_CB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pwLenght_NmbUD)).BeginInit();
            this.SuspendLayout();
            // 
            // pw_TextBox
            // 
            this.pw_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pw_TextBox.Location = new System.Drawing.Point(12, 143);
            this.pw_TextBox.Name = "pw_TextBox";
            this.pw_TextBox.Size = new System.Drawing.Size(262, 38);
            this.pw_TextBox.TabIndex = 6;
            // 
            // gen_Button
            // 
            this.gen_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gen_Button.Location = new System.Drawing.Point(12, 92);
            this.gen_Button.Name = "gen_Button";
            this.gen_Button.Size = new System.Drawing.Size(360, 45);
            this.gen_Button.TabIndex = 4;
            this.gen_Button.Text = "Give me a password";
            this.gen_Button.UseVisualStyleBackColor = true;
            this.gen_Button.Click += new System.EventHandler(this.gen_Button_Click);
            // 
            // pwLenght_NmbUD
            // 
            this.pwLenght_NmbUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pwLenght_NmbUD.Location = new System.Drawing.Point(280, 47);
            this.pwLenght_NmbUD.Name = "pwLenght_NmbUD";
            this.pwLenght_NmbUD.Size = new System.Drawing.Size(87, 34);
            this.pwLenght_NmbUD.TabIndex = 3;
            this.pwLenght_NmbUD.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lenght of password";
            // 
            // copy_Btn
            // 
            this.copy_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.copy_Btn.Location = new System.Drawing.Point(280, 143);
            this.copy_Btn.Name = "copy_Btn";
            this.copy_Btn.Size = new System.Drawing.Size(92, 38);
            this.copy_Btn.TabIndex = 5;
            this.copy_Btn.Text = "Copy";
            this.copy_Btn.UseVisualStyleBackColor = true;
            this.copy_Btn.Click += new System.EventHandler(this.copy_Btn_Click);
            // 
            // upperCase_CB
            // 
            this.upperCase_CB.AutoSize = true;
            this.upperCase_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.upperCase_CB.Location = new System.Drawing.Point(18, 13);
            this.upperCase_CB.Name = "upperCase_CB";
            this.upperCase_CB.Size = new System.Drawing.Size(100, 33);
            this.upperCase_CB.TabIndex = 0;
            this.upperCase_CB.Text = "ABCD";
            this.upperCase_CB.UseVisualStyleBackColor = true;
            // 
            // lowerCase_CB
            // 
            this.lowerCase_CB.AutoSize = true;
            this.lowerCase_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lowerCase_CB.Location = new System.Drawing.Point(152, 13);
            this.lowerCase_CB.Name = "lowerCase_CB";
            this.lowerCase_CB.Size = new System.Drawing.Size(88, 33);
            this.lowerCase_CB.TabIndex = 1;
            this.lowerCase_CB.Text = "abcd";
            this.lowerCase_CB.UseVisualStyleBackColor = true;
            // 
            // specialChars_CB
            // 
            this.specialChars_CB.AutoSize = true;
            this.specialChars_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.specialChars_CB.Location = new System.Drawing.Point(274, 8);
            this.specialChars_CB.Name = "specialChars_CB";
            this.specialChars_CB.Size = new System.Drawing.Size(93, 33);
            this.specialChars_CB.TabIndex = 2;
            this.specialChars_CB.Text = "@&#>[";
            this.specialChars_CB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 193);
            this.Controls.Add(this.specialChars_CB);
            this.Controls.Add(this.lowerCase_CB);
            this.Controls.Add(this.upperCase_CB);
            this.Controls.Add(this.copy_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwLenght_NmbUD);
            this.Controls.Add(this.gen_Button);
            this.Controls.Add(this.pw_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pwLenght_NmbUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pw_TextBox;
        private System.Windows.Forms.Button gen_Button;
        private System.Windows.Forms.NumericUpDown pwLenght_NmbUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button copy_Btn;
        private System.Windows.Forms.CheckBox upperCase_CB;
        private System.Windows.Forms.CheckBox lowerCase_CB;
        private System.Windows.Forms.CheckBox specialChars_CB;
    }
}

