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
            ((System.ComponentModel.ISupportInitialize)(this.pwLenght_NmbUD)).BeginInit();
            this.SuspendLayout();
            // 
            // pw_TextBox
            // 
            this.pw_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pw_TextBox.Location = new System.Drawing.Point(12, 108);
            this.pw_TextBox.Name = "pw_TextBox";
            this.pw_TextBox.Size = new System.Drawing.Size(339, 38);
            this.pw_TextBox.TabIndex = 0;
            // 
            // gen_Button
            // 
            this.gen_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gen_Button.Location = new System.Drawing.Point(12, 57);
            this.gen_Button.Name = "gen_Button";
            this.gen_Button.Size = new System.Drawing.Size(339, 45);
            this.gen_Button.TabIndex = 1;
            this.gen_Button.Text = "Give me a password";
            this.gen_Button.UseVisualStyleBackColor = true;
            this.gen_Button.Click += new System.EventHandler(this.gen_Button_Click);
            // 
            // pwLenght_NmbUD
            // 
            this.pwLenght_NmbUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pwLenght_NmbUD.Location = new System.Drawing.Point(280, 14);
            this.pwLenght_NmbUD.Name = "pwLenght_NmbUD";
            this.pwLenght_NmbUD.Size = new System.Drawing.Size(71, 34);
            this.pwLenght_NmbUD.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lenght of password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 162);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwLenght_NmbUD);
            this.Controls.Add(this.gen_Button);
            this.Controls.Add(this.pw_TextBox);
            this.Name = "Form1";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pwLenght_NmbUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pw_TextBox;
        private System.Windows.Forms.Button gen_Button;
        private System.Windows.Forms.NumericUpDown pwLenght_NmbUD;
        private System.Windows.Forms.Label label1;
    }
}

