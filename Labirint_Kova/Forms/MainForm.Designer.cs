namespace Labirint_Kova
{
    partial class MainForm
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
            this.ExitBtn = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Label();
            this.SettBtn = new System.Windows.Forms.Label();
            this.rotationTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitBtn.Location = new System.Drawing.Point(63, 354);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(224, 33);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "Выйти из игры";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            this.ExitBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ExitBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // StartBtn
            // 
            this.StartBtn.AutoSize = true;
            this.StartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartBtn.Location = new System.Drawing.Point(63, 262);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(188, 33);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Начать игру";
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            this.StartBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.StartBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // SettBtn
            // 
            this.SettBtn.AutoSize = true;
            this.SettBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SettBtn.Location = new System.Drawing.Point(63, 307);
            this.SettBtn.Name = "SettBtn";
            this.SettBtn.Size = new System.Drawing.Size(168, 33);
            this.SettBtn.TabIndex = 2;
            this.SettBtn.Text = "Настройки";
            this.SettBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.SettBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // rotationTimer
            // 
            this.rotationTimer.Interval = 50;
            this.rotationTimer.Tick += new System.EventHandler(this.RotationTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(59, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 73);
            this.label1.TabIndex = 3;
            this.label1.Text = "MAZE";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(212)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(814, 463);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SettBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.ExitBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitBtn;
        private System.Windows.Forms.Label StartBtn;
        private System.Windows.Forms.Label SettBtn;
        private System.Windows.Forms.Timer rotationTimer;
        private System.Windows.Forms.Label label1;
    }
}

