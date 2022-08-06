
namespace FifteenGUI
{
    partial class Fifteen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fifteen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.BackMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.TimerBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StepsBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startMenu,
            this.BackMenuButton,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fifteen_KeyDown);
            this.menuStrip1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button9_KeyUp);
            // 
            // startMenu
            // 
            this.startMenu.Name = "startMenu";
            this.startMenu.Size = new System.Drawing.Size(86, 20);
            this.startMenu.Text = "Начать игру";
            this.startMenu.Click += new System.EventHandler(this.startMenu_Click);
            // 
            // BackMenuButton
            // 
            this.BackMenuButton.Name = "BackMenuButton";
            this.BackMenuButton.Size = new System.Drawing.Size(146, 20);
            this.BackMenuButton.Text = "Вернуться на ход назад";
            this.BackMenuButton.Click += new System.EventHandler(this.BackMenuButton_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem2.Text = " ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button15, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button14, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button13, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button12, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button11, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button10, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button9, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button7, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button0, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 426);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button15
            // 
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.Font = new System.Drawing.Font("Mistral", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.Location = new System.Drawing.Point(603, 321);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(194, 102);
            this.button15.TabIndex = 15;
            this.button15.Tag = "15";
            this.button15.Text = "*";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button0_Click);
            this.button15.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fifteen_KeyDown);
            this.button15.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button9_KeyUp);
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.Font = new System.Drawing.Font("Mistral", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(403, 321);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(194, 102);
            this.button14.TabIndex = 14;
            this.button14.Tag = "14";
            this.button14.Text = "*";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button0_Click);
            this.button14.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fifteen_KeyDown);
            this.button14.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button9_KeyUp);
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Font = new System.Drawing.Font("Mistral", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.Location = new System.Drawing.Point(203, 321);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(194, 102);
            this.button13.TabIndex = 13;
            this.button13.Tag = "13";
            this.button13.Text = "*";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button0_Click);
            this.button13.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fifteen_KeyDown);
            this.button13.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button9_KeyUp);
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Font = new System.Drawing.Font("Mistral", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(3, 321);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(194, 102);
            this.button12.TabIndex = 12;
            this.button12.Tag = "12";
            this.button12.Text = "*";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button0_Click);
            this.button12.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fifteen_KeyDown);
            this.button12.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button9_KeyUp);
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Font = new System.Drawing.Font("Mistral", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Location = new System.Drawing.Point(603, 215);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(194, 100);
            this.button11.TabIndex = 11;
            this.button11.Tag = "11";
            this.button11.Text = "*";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button0_Click);
            this.button11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fifteen_KeyDown);
            this.button11.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button9_KeyUp);
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Font = new System.Drawing.Font("Mistral", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(403, 215);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(194, 100);
            this.button10.TabIndex = 10;
            this.button10.Tag = "10";
            this.button10.Text = "*";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button0_Click);
            this.button10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fifteen_KeyDown);
            this.button10.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button9_KeyUp);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Font = new System.Drawing.Font("Mistral", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(203, 215);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(194, 100);
            this.button9.TabIndex = 9;
            this.button9.Tag = "9";
            this.button9.Text = "*";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button0_Click);
            this.button9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fifteen_KeyDown);
            this.button9.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button9_KeyUp);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Font = new System.Drawing.Font("Mistral", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(3, 215);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(194, 100);
            this.button8.TabIndex = 8;
            this.button8.Tag = "8";
            this.button8.Text = "*";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button0_Click);
            this.button8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fifteen_KeyDown);
            this.button8.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button9_KeyUp);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Mistral", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(603, 109);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(194, 100);
            this.button7.TabIndex = 7;
            this.button7.Tag = "7";
            this.button7.Text = "*";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button0_Click);
            this.button7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fifteen_KeyDown);
            this.button7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button9_KeyUp);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Mistral", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(403, 109);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(194, 100);
            this.button6.TabIndex = 6;
            this.button6.Tag = "6";
            this.button6.Text = "*";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button0_Click);
            this.button6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fifteen_KeyDown);
            this.button6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button9_KeyUp);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Mistral", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(203, 109);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 100);
            this.button5.TabIndex = 5;
            this.button5.Tag = "5";
            this.button5.Text = "*";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button0_Click);
            this.button5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fifteen_KeyDown);
            this.button5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button9_KeyUp);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Mistral", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(3, 109);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 100);
            this.button4.TabIndex = 4;
            this.button4.Tag = "4";
            this.button4.Text = "*";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button0_Click);
            this.button4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fifteen_KeyDown);
            this.button4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button9_KeyUp);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Mistral", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(603, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 100);
            this.button3.TabIndex = 3;
            this.button3.Tag = "3";
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button0_Click);
            this.button3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fifteen_KeyDown);
            this.button3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button9_KeyUp);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Mistral", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(403, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 100);
            this.button2.TabIndex = 2;
            this.button2.Tag = "2";
            this.button2.Text = "*";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button0_Click);
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fifteen_KeyDown);
            this.button2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button9_KeyUp);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Mistral", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(203, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 100);
            this.button1.TabIndex = 1;
            this.button1.Tag = "1";
            this.button1.Text = "*";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button0_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fifteen_KeyDown);
            this.button1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button9_KeyUp);
            // 
            // button0
            // 
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.Font = new System.Drawing.Font("Mistral", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.Location = new System.Drawing.Point(3, 3);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(194, 100);
            this.button0.TabIndex = 0;
            this.button0.Tag = "0";
            this.button0.Text = "*";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            this.button0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fifteen_KeyDown);
            this.button0.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button9_KeyUp);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // TimerBox
            // 
            this.TimerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimerBox.Enabled = false;
            this.TimerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerBox.Location = new System.Drawing.Point(715, 0);
            this.TimerBox.Name = "TimerBox";
            this.TimerBox.Size = new System.Drawing.Size(73, 22);
            this.TimerBox.TabIndex = 2;
            this.TimerBox.Text = "0";
            this.TimerBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fifteen_KeyDown);
            this.TimerBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button9_KeyUp);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(657, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Время:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(400, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество шагов:";
            // 
            // StepsBox
            // 
            this.StepsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StepsBox.Enabled = false;
            this.StepsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StepsBox.Location = new System.Drawing.Point(537, 0);
            this.StepsBox.Name = "StepsBox";
            this.StepsBox.Size = new System.Drawing.Size(73, 22);
            this.StepsBox.TabIndex = 5;
            this.StepsBox.Text = "0";
            this.StepsBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fifteen_KeyDown);
            this.StepsBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button9_KeyUp);
            // 
            // Fifteen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StepsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimerBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(503, 234);
            this.Name = "Fifteen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пятнашки";
            this.Load += new System.EventHandler(this.Fifteen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fifteen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button9_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem startMenu;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.ToolStripMenuItem BackMenuButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox TimerBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StepsBox;
    }
}

