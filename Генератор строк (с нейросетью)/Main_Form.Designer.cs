namespace Генератор_строк__с_нейросетью_
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.NetName_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Events_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.нейроннаяСетьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNet_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Select_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateString_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Learn_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Remove_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NetName_StatusLabel,
            this.Events_StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.MaximumSize = new System.Drawing.Size(0, 30);
            this.statusStrip1.MinimumSize = new System.Drawing.Size(0, 30);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(703, 30);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // NetName_StatusLabel
            // 
            this.NetName_StatusLabel.Name = "NetName_StatusLabel";
            this.NetName_StatusLabel.Size = new System.Drawing.Size(615, 25);
            this.NetName_StatusLabel.Spring = true;
            this.NetName_StatusLabel.Text = "Нейросеть не выбрана!";
            this.NetName_StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Events_StatusLabel
            // 
            this.Events_StatusLabel.Name = "Events_StatusLabel";
            this.Events_StatusLabel.Size = new System.Drawing.Size(73, 25);
            this.Events_StatusLabel.Text = "Ожидание...";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(703, 436);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.нейроннаяСетьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // нейроннаяСетьToolStripMenuItem
            // 
            this.нейроннаяСетьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateNet_ToolStripMenuItem,
            this.Select_ToolStripMenuItem,
            this.GenerateString_ToolStripMenuItem,
            this.Learn_ToolStripMenuItem,
            this.Remove_ToolStripMenuItem});
            this.нейроннаяСетьToolStripMenuItem.Name = "нейроннаяСетьToolStripMenuItem";
            this.нейроннаяСетьToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.нейроннаяСетьToolStripMenuItem.Text = "Действия";
            // 
            // CreateNet_ToolStripMenuItem
            // 
            this.CreateNet_ToolStripMenuItem.Name = "CreateNet_ToolStripMenuItem";
            this.CreateNet_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CreateNet_ToolStripMenuItem.Text = "Создать нейросеть";
            this.CreateNet_ToolStripMenuItem.Click += new System.EventHandler(this.CreateNet_ToolStripMenuItem_Click);
            // 
            // Select_ToolStripMenuItem
            // 
            this.Select_ToolStripMenuItem.Name = "Select_ToolStripMenuItem";
            this.Select_ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.Select_ToolStripMenuItem.Text = "Выбрать нейросеть";
            this.Select_ToolStripMenuItem.Click += new System.EventHandler(this.Select_ToolStripMenuItem_Click);
            // 
            // GenerateString_ToolStripMenuItem
            // 
            this.GenerateString_ToolStripMenuItem.Name = "GenerateString_ToolStripMenuItem";
            this.GenerateString_ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.GenerateString_ToolStripMenuItem.Text = "Сгенерировать строку";
            this.GenerateString_ToolStripMenuItem.Click += new System.EventHandler(this.GenerateString_ToolStripMenuItem_Click);
            // 
            // Learn_ToolStripMenuItem
            // 
            this.Learn_ToolStripMenuItem.Name = "Learn_ToolStripMenuItem";
            this.Learn_ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.Learn_ToolStripMenuItem.Text = "Обучить нейросеть";
            this.Learn_ToolStripMenuItem.Click += new System.EventHandler(this.Learn_ToolStripMenuItem_Click);
            // 
            // Remove_ToolStripMenuItem
            // 
            this.Remove_ToolStripMenuItem.Name = "Remove_ToolStripMenuItem";
            this.Remove_ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.Remove_ToolStripMenuItem.Text = "Удалить нейросеть";
            this.Remove_ToolStripMenuItem.Click += new System.EventHandler(this.Remove_ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 490);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор строк";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel NetName_StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel Events_StatusLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem нейроннаяСетьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateNet_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Select_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GenerateString_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Learn_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Remove_ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

