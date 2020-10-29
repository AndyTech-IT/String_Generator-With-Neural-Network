namespace Генератор_строк__с_нейросетью_
{
    partial class Training_Form
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
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.GroupBox groupBox3;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
            System.Windows.Forms.Label label1;
            this.Nets_CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.Train_Button1 = new System.Windows.Forms.Button();
            this.Train_Button2 = new System.Windows.Forms.Button();
            this.Training_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Training_ListBox1 = new System.Windows.Forms.ListBox();
            this.Training_ListBox2 = new System.Windows.Forms.ListBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nets_CheckedListBox
            // 
            this.Nets_CheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nets_CheckedListBox.FormattingEnabled = true;
            this.Nets_CheckedListBox.Location = new System.Drawing.Point(3, 16);
            this.Nets_CheckedListBox.Name = "Nets_CheckedListBox";
            this.Nets_CheckedListBox.Size = new System.Drawing.Size(194, 442);
            this.Nets_CheckedListBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.Nets_CheckedListBox);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(200, 461);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Обучаемые нейросети";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            groupBox2.Enabled = false;
            groupBox2.Location = new System.Drawing.Point(200, 116);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(524, 345);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "2 Обучающие пары слов";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel1);
            groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox3.Location = new System.Drawing.Point(200, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(524, 116);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "1 Обучающая строка";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.83839F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.16162F));
            tableLayoutPanel1.Controls.Add(this.Train_Button1, 1, 0);
            tableLayoutPanel1.Controls.Add(this.Train_Button2, 1, 1);
            tableLayoutPanel1.Controls.Add(this.Training_RichTextBox, 0, 0);
            tableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 2);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel1.Size = new System.Drawing.Size(518, 97);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Train_Button1
            // 
            this.Train_Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Train_Button1.Location = new System.Drawing.Point(438, 4);
            this.Train_Button1.Name = "Train_Button1";
            this.Train_Button1.Size = new System.Drawing.Size(75, 23);
            this.Train_Button1.TabIndex = 0;
            this.Train_Button1.Text = "Обучить 1";
            this.Train_Button1.UseVisualStyleBackColor = true;
            this.Train_Button1.Click += new System.EventHandler(this.Train_Button1_Click);
            // 
            // Train_Button2
            // 
            this.Train_Button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Train_Button2.Enabled = false;
            this.Train_Button2.Location = new System.Drawing.Point(438, 36);
            this.Train_Button2.Name = "Train_Button2";
            this.Train_Button2.Size = new System.Drawing.Size(75, 23);
            this.Train_Button2.TabIndex = 1;
            this.Train_Button2.Text = "Обучить 2";
            this.Train_Button2.UseVisualStyleBackColor = true;
            this.Train_Button2.Click += new System.EventHandler(this.Train_Button2_Click);
            // 
            // Training_RichTextBox
            // 
            this.Training_RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Training_RichTextBox.Location = new System.Drawing.Point(3, 3);
            this.Training_RichTextBox.Name = "Training_RichTextBox";
            tableLayoutPanel1.SetRowSpan(this.Training_RichTextBox, 3);
            this.Training_RichTextBox.Size = new System.Drawing.Size(428, 91);
            this.Training_RichTextBox.TabIndex = 2;
            this.Training_RichTextBox.Text = "";
            this.Training_RichTextBox.TextChanged += new System.EventHandler(this.Training_RichTextBox_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(this.Training_ListBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(this.Training_ListBox2, 2, 0);
            tableLayoutPanel2.Controls.Add(label1, 1, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Enabled = false;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(518, 326);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.Location = new System.Drawing.Point(438, 69);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 3;
            this.Cancel_Button.Text = "Отмена";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Training_ListBox1
            // 
            this.Training_ListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Training_ListBox1.Enabled = false;
            this.Training_ListBox1.FormattingEnabled = true;
            this.Training_ListBox1.Location = new System.Drawing.Point(3, 3);
            this.Training_ListBox1.Name = "Training_ListBox1";
            this.Training_ListBox1.Size = new System.Drawing.Size(203, 320);
            this.Training_ListBox1.TabIndex = 0;
            this.Training_ListBox1.Click += new System.EventHandler(this.Training_ListBox_Click);
            // 
            // Training_ListBox2
            // 
            this.Training_ListBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Training_ListBox2.Enabled = false;
            this.Training_ListBox2.FormattingEnabled = true;
            this.Training_ListBox2.Location = new System.Drawing.Point(312, 3);
            this.Training_ListBox2.Name = "Training_ListBox2";
            this.Training_ListBox2.Size = new System.Drawing.Size(203, 320);
            this.Training_ListBox2.TabIndex = 1;
            this.Training_ListBox2.Click += new System.EventHandler(this.Training_ListBox_Click);
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new System.Drawing.Point(212, 156);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 13);
            label1.TabIndex = 2;
            label1.Text = "...В разработке...";
            // 
            // Training_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 461);
            this.Controls.Add(groupBox3);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Training_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обучить";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Nets_CheckedListBox;
        private System.Windows.Forms.ListBox Training_ListBox1;
        private System.Windows.Forms.ListBox Training_ListBox2;
        private System.Windows.Forms.Button Train_Button1;
        private System.Windows.Forms.Button Train_Button2;
        private System.Windows.Forms.RichTextBox Training_RichTextBox;
        private System.Windows.Forms.Button Cancel_Button;
    }
}