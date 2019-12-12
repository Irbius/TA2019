namespace MarkovMachine
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_Rules = new System.Windows.Forms.ListBox();
            this.listBox_Log = new System.Windows.Forms.ListBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_Add = new System.Windows.Forms.TextBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьИзToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_clear_rules = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox_start = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Rules
            // 
            this.listBox_Rules.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.listBox_Rules, "Список правил");
            this.listBox_Rules.ItemHeight = 16;
            this.listBox_Rules.Location = new System.Drawing.Point(12, 113);
            this.listBox_Rules.Name = "listBox_Rules";
            this.helpProvider1.SetShowHelp(this.listBox_Rules, true);
            this.listBox_Rules.Size = new System.Drawing.Size(181, 228);
            this.listBox_Rules.TabIndex = 0;
            // 
            // listBox_Log
            // 
            this.listBox_Log.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.listBox_Log, "Журнал расчета. Выводит ход рассчета по введеным данным.");
            this.listBox_Log.ItemHeight = 16;
            this.listBox_Log.Location = new System.Drawing.Point(486, 67);
            this.listBox_Log.Name = "listBox_Log";
            this.helpProvider1.SetShowHelp(this.listBox_Log, true);
            this.listBox_Log.Size = new System.Drawing.Size(188, 276);
            this.listBox_Log.TabIndex = 1;
            // 
            // button_Add
            // 
            this.helpProvider1.SetHelpString(this.button_Add, "Добавляет правило из TextBox в список");
            this.button_Add.Location = new System.Drawing.Point(199, 67);
            this.button_Add.Name = "button_Add";
            this.helpProvider1.SetShowHelp(this.button_Add, true);
            this.button_Add.Size = new System.Drawing.Size(95, 34);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_Add
            // 
            this.textBox_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Add.Location = new System.Drawing.Point(12, 67);
            this.textBox_Add.Name = "textBox_Add";
            this.textBox_Add.Size = new System.Drawing.Size(181, 34);
            this.textBox_Add.TabIndex = 5;
            // 
            // button_Delete
            // 
            this.helpProvider1.SetHelpString(this.button_Delete, "Удалить выбранное правило.");
            this.button_Delete.Location = new System.Drawing.Point(98, 347);
            this.button_Delete.Name = "button_Delete";
            this.helpProvider1.SetShowHelp(this.button_Delete, true);
            this.button_Delete.Size = new System.Drawing.Size(95, 34);
            this.button_Delete.TabIndex = 6;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Start
            // 
            this.helpProvider1.SetHelpString(this.button_Start, "Начинает расчет по введеным данным.");
            this.button_Start.Location = new System.Drawing.Point(359, 185);
            this.button_Start.Name = "button_Start";
            this.helpProvider1.SetShowHelp(this.button_Start, true);
            this.button_Start.Size = new System.Drawing.Size(95, 32);
            this.button_Start.TabIndex = 7;
            this.button_Start.Text = "Старт";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьИзToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // загрузитьИзToolStripMenuItem
            // 
            this.загрузитьИзToolStripMenuItem.Name = "загрузитьИзToolStripMenuItem";
            this.загрузитьИзToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.загрузитьИзToolStripMenuItem.Text = "Загрузить";
            this.загрузитьИзToolStripMenuItem.Click += new System.EventHandler(this.загрзитьИзToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_clear_rules
            // 
            this.helpProvider1.SetHelpString(this.button_clear_rules, "Очистить весь список правил");
            this.button_clear_rules.Location = new System.Drawing.Point(98, 387);
            this.button_clear_rules.Name = "button_clear_rules";
            this.helpProvider1.SetShowHelp(this.button_clear_rules, true);
            this.button_clear_rules.Size = new System.Drawing.Size(95, 34);
            this.button_clear_rules.TabIndex = 10;
            this.button_clear_rules.Text = "Очистить";
            this.button_clear_rules.UseVisualStyleBackColor = true;
            this.button_clear_rules.Click += new System.EventHandler(this.button_clear_rules_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // textBox_start
            // 
            this.textBox_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_start.Location = new System.Drawing.Point(220, 145);
            this.textBox_start.Name = "textBox_start";
            this.helpProvider1.SetShowHelp(this.textBox_start, true);
            this.textBox_start.Size = new System.Drawing.Size(234, 34);
            this.textBox_start.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Выражение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Правила";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Журнал расчета";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_start);
            this.Controls.Add(this.button_clear_rules);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.textBox_Add);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.listBox_Log);
            this.Controls.Add(this.listBox_Rules);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Машина Маркова";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Rules;
        private System.Windows.Forms.ListBox listBox_Log;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_Add;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьИзToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_clear_rules;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox_start;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

