namespace _Calendar_
{
    partial class calendarForm
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
            this.dayBox = new System.Windows.Forms.ComboBox();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nextDayButton = new System.Windows.Forms.Button();
            this.previousDayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.today = new System.Windows.Forms.Button();
            this.fail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dayBox
            // 
            this.dayBox.Font = new System.Drawing.Font("Century725 Cn BT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayBox.FormattingEnabled = true;
            this.dayBox.Location = new System.Drawing.Point(27, 59);
            this.dayBox.Margin = new System.Windows.Forms.Padding(4);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(128, 44);
            this.dayBox.TabIndex = 0;
            this.dayBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dayBox_KeyPress);
            // 
            // monthBox
            // 
            this.monthBox.Font = new System.Drawing.Font("Century725 Cn BT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Location = new System.Drawing.Point(175, 59);
            this.monthBox.Margin = new System.Windows.Forms.Padding(4);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(147, 44);
            this.monthBox.TabIndex = 1;
            this.monthBox.TextChanged += new System.EventHandler(this.monthBox_TextChanged);
            this.monthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.monthBox_KeyPress);
            // 
            // yearBox
            // 
            this.yearBox.Font = new System.Drawing.Font("Century725 Cn BT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearBox.Location = new System.Drawing.Point(344, 61);
            this.yearBox.Margin = new System.Windows.Forms.Padding(4);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(132, 43);
            this.yearBox.TabIndex = 2;
            this.yearBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century725 Cn BT", 13.8F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(68, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century725 Cn BT", 13.8F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(217, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century725 Cn BT", 13.8F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(379, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year";
            // 
            // nextDayButton
            // 
            this.nextDayButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nextDayButton.Font = new System.Drawing.Font("Century725 Cn BT", 13.8F, System.Drawing.FontStyle.Italic);
            this.nextDayButton.Location = new System.Drawing.Point(13, 180);
            this.nextDayButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextDayButton.Name = "nextDayButton";
            this.nextDayButton.Size = new System.Drawing.Size(463, 43);
            this.nextDayButton.TabIndex = 6;
            this.nextDayButton.Text = "Next day";
            this.nextDayButton.UseVisualStyleBackColor = true;
            this.nextDayButton.Click += new System.EventHandler(this.nextDayButton_Click);
            // 
            // previousDayButton
            // 
            this.previousDayButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.previousDayButton.Font = new System.Drawing.Font("Century725 Cn BT", 13.8F, System.Drawing.FontStyle.Italic);
            this.previousDayButton.Location = new System.Drawing.Point(13, 231);
            this.previousDayButton.Margin = new System.Windows.Forms.Padding(4);
            this.previousDayButton.Name = "previousDayButton";
            this.previousDayButton.Size = new System.Drawing.Size(463, 43);
            this.previousDayButton.TabIndex = 7;
            this.previousDayButton.Text = "Previous day";
            this.previousDayButton.UseVisualStyleBackColor = true;
            this.previousDayButton.Click += new System.EventHandler(this.previousDayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Font = new System.Drawing.Font("Century725 Cn BT", 13.8F, System.Drawing.FontStyle.Italic);
            this.exitButton.Location = new System.Drawing.Point(13, 283);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(463, 41);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // today
            // 
            this.today.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.today.Font = new System.Drawing.Font("Century725 Cn BT", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.today.Location = new System.Drawing.Point(13, 129);
            this.today.Margin = new System.Windows.Forms.Padding(4);
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(463, 43);
            this.today.TabIndex = 9;
            this.today.Text = "Today";
            this.today.UseVisualStyleBackColor = true;
            this.today.Click += new System.EventHandler(this.today_Click);
            // 
            // fail
            // 
            this.fail.AutoSize = true;
            this.fail.BackColor = System.Drawing.Color.Red;
            this.fail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fail.Location = new System.Drawing.Point(155, 9);
            this.fail.Name = "fail";
            this.fail.Size = new System.Drawing.Size(0, 24);
            this.fail.TabIndex = 10;
            // 
            // calendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 327);
            this.Controls.Add(this.fail);
            this.Controls.Add(this.today);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.previousDayButton);
            this.Controls.Add(this.nextDayButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.dayBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "calendarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.CalendarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dayBox;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nextDayButton;
        private System.Windows.Forms.Button previousDayButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button today;
        private System.Windows.Forms.Label fail;
    }
}

