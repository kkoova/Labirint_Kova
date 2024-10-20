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
            this.MazePngOic = new System.Windows.Forms.PictureBox();
            this.rotationTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MazePngOic)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitBtn.Location = new System.Drawing.Point(50, 875);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(450, 80);
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
            this.StartBtn.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartBtn.Location = new System.Drawing.Point(50, 520);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(359, 80);
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
            this.SettBtn.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SettBtn.Location = new System.Drawing.Point(50, 698);
            this.SettBtn.Name = "SettBtn";
            this.SettBtn.Size = new System.Drawing.Size(333, 80);
            this.SettBtn.TabIndex = 2;
            this.SettBtn.Text = "Настройки";
            this.SettBtn.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.SettBtn.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // MazePngOic
            // 
            this.MazePngOic.Location = new System.Drawing.Point(506, -130);
            this.MazePngOic.Name = "MazePngOic";
            this.MazePngOic.Size = new System.Drawing.Size(2000, 2000);
            this.MazePngOic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MazePngOic.TabIndex = 3;
            this.MazePngOic.TabStop = false;
            this.MazePngOic.Paint += new System.Windows.Forms.PaintEventHandler(this.MazePngOic_Paint);
            // 
            // rotationTimer
            // 
            this.rotationTimer.Interval = 50;
            this.rotationTimer.Tick += new System.EventHandler(this.RotationTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(212)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1916, 1028);
            this.ControlBox = false;
            this.Controls.Add(this.MazePngOic);
            this.Controls.Add(this.SettBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.ExitBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(1918, 1030);
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.MazePngOic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitBtn;
        private System.Windows.Forms.Label StartBtn;
        private System.Windows.Forms.Label SettBtn;
        private System.Windows.Forms.PictureBox MazePngOic;
        private System.Windows.Forms.Timer rotationTimer;
    }
}

