namespace Генератор_строк__с_нейросетью_
{
    partial class SelectNetwork_Form
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
            this.NetName_ComboBox = new System.Windows.Forms.ComboBox();
            this.Select_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NetName_ComboBox
            // 
            this.NetName_ComboBox.FormattingEnabled = true;
            this.NetName_ComboBox.Location = new System.Drawing.Point(12, 54);
            this.NetName_ComboBox.MaxDropDownItems = 4;
            this.NetName_ComboBox.Name = "NetName_ComboBox";
            this.NetName_ComboBox.Size = new System.Drawing.Size(195, 21);
            this.NetName_ComboBox.TabIndex = 0;
            this.NetName_ComboBox.Text = "-Выбрать-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(167, 13);
            label1.TabIndex = 1;
            label1.Text = "Выберите нейросеть из списка";
            // 
            // Select_Button
            // 
            this.Select_Button.Location = new System.Drawing.Point(132, 169);
            this.Select_Button.Name = "Select_Button";
            this.Select_Button.Size = new System.Drawing.Size(75, 23);
            this.Select_Button.TabIndex = 2;
            this.Select_Button.Text = "Выбрать";
            this.Select_Button.UseVisualStyleBackColor = true;
            this.Select_Button.Click += new System.EventHandler(this.Select_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(12, 169);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 3;
            this.Cancel_Button.Text = "Отмена";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // SelectNetwork_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 204);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Select_Button);
            this.Controls.Add(label1);
            this.Controls.Add(this.NetName_ComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectNetwork_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбрать";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NetName_ComboBox;
        private System.Windows.Forms.Button Select_Button;
        private System.Windows.Forms.Button Cancel_Button;
    }
}