namespace Генератор_строк__с_нейросетью_
{
    partial class CreateNetwork_Form
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
            System.Windows.Forms.Label label1;
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.Create_Button = new System.Windows.Forms.Button();
            this.Cancle_Button = new System.Windows.Forms.Button();
            this.Validation_Label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(12, 44);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(180, 20);
            this.Name_TextBox.TabIndex = 0;
            // 
            // Create_Button
            // 
            this.Create_Button.Location = new System.Drawing.Point(117, 108);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(75, 23);
            this.Create_Button.TabIndex = 1;
            this.Create_Button.Text = "Создать";
            this.Create_Button.UseVisualStyleBackColor = true;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // Cancle_Button
            // 
            this.Cancle_Button.Location = new System.Drawing.Point(12, 108);
            this.Cancle_Button.Name = "Cancle_Button";
            this.Cancle_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancle_Button.TabIndex = 2;
            this.Cancle_Button.Text = "Отмена";
            this.Cancle_Button.UseVisualStyleBackColor = true;
            this.Cancle_Button.Click += new System.EventHandler(this.Cancle_Button_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(112, 13);
            label1.TabIndex = 3;
            label1.Text = "Имя нейронной сети";
            // 
            // Validation_Label
            // 
            this.Validation_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Validation_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Validation_Label.Location = new System.Drawing.Point(12, 67);
            this.Validation_Label.Name = "Validation_Label";
            this.Validation_Label.Size = new System.Drawing.Size(180, 23);
            this.Validation_Label.TabIndex = 4;
            this.Validation_Label.Text = "Имя занято";
            this.Validation_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Validation_Label.Visible = false;
            // 
            // CreateNetwork_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 141);
            this.Controls.Add(this.Validation_Label);
            this.Controls.Add(label1);
            this.Controls.Add(this.Cancle_Button);
            this.Controls.Add(this.Create_Button);
            this.Controls.Add(this.Name_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateNetwork_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Button Create_Button;
        private System.Windows.Forms.Button Cancle_Button;
        private System.Windows.Forms.Label Validation_Label;
    }
}