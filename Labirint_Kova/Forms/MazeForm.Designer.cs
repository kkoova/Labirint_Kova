namespace Labirint_Kova.Forms
{
    partial class MazeForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxblock03 = new System.Windows.Forms.PictureBox();
            this.pictureBoxblock30 = new System.Windows.Forms.PictureBox();
            this.pictureBoxblock44 = new System.Windows.Forms.PictureBox();
            this.pictureBoxblock24 = new System.Windows.Forms.PictureBox();
            this.pictureBoxblock34 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxblock03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxblock30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxblock44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxblock24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxblock34)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Labirint_Kova.Properties.Resources.block_3__3__3_;
            this.pictureBox1.Location = new System.Drawing.Point(-9, 597);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1901, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxblock03
            // 
            this.pictureBoxblock03.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxblock03.Image = global::Labirint_Kova.Properties.Resources.block__0_3_;
            this.pictureBoxblock03.Location = new System.Drawing.Point(1139, 56);
            this.pictureBoxblock03.Name = "pictureBoxblock03";
            this.pictureBoxblock03.Size = new System.Drawing.Size(798, 643);
            this.pictureBoxblock03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxblock03.TabIndex = 4;
            this.pictureBoxblock03.TabStop = false;
            // 
            // pictureBoxblock30
            // 
            this.pictureBoxblock30.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxblock30.Image = global::Labirint_Kova.Properties.Resources.block__3_0_;
            this.pictureBoxblock30.Location = new System.Drawing.Point(-103, 56);
            this.pictureBoxblock30.Name = "pictureBoxblock30";
            this.pictureBoxblock30.Size = new System.Drawing.Size(798, 643);
            this.pictureBoxblock30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxblock30.TabIndex = 3;
            this.pictureBoxblock30.TabStop = false;
            // 
            // pictureBoxblock44
            // 
            this.pictureBoxblock44.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxblock44.Image = global::Labirint_Kova.Properties.Resources.block__2_4_;
            this.pictureBoxblock44.Location = new System.Drawing.Point(1139, 151);
            this.pictureBoxblock44.Name = "pictureBoxblock44";
            this.pictureBoxblock44.Size = new System.Drawing.Size(448, 450);
            this.pictureBoxblock44.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxblock44.TabIndex = 2;
            this.pictureBoxblock44.TabStop = false;
            // 
            // pictureBoxblock24
            // 
            this.pictureBoxblock24.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxblock24.Image = global::Labirint_Kova.Properties.Resources.block__2_4_;
            this.pictureBoxblock24.Location = new System.Drawing.Point(247, 151);
            this.pictureBoxblock24.Name = "pictureBoxblock24";
            this.pictureBoxblock24.Size = new System.Drawing.Size(448, 450);
            this.pictureBoxblock24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxblock24.TabIndex = 1;
            this.pictureBoxblock24.TabStop = false;
            // 
            // pictureBoxblock34
            // 
            this.pictureBoxblock34.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxblock34.Image = global::Labirint_Kova.Properties.Resources.block__3_4_;
            this.pictureBoxblock34.Location = new System.Drawing.Point(693, 151);
            this.pictureBoxblock34.Name = "pictureBoxblock34";
            this.pictureBoxblock34.Size = new System.Drawing.Size(446, 450);
            this.pictureBoxblock34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxblock34.TabIndex = 0;
            this.pictureBoxblock34.TabStop = false;
            // 
            // MazeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1064);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxblock03);
            this.Controls.Add(this.pictureBoxblock30);
            this.Controls.Add(this.pictureBoxblock44);
            this.Controls.Add(this.pictureBoxblock24);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxblock34);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MazeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MazeForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxblock03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxblock30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxblock44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxblock24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxblock34)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxblock34;
        private System.Windows.Forms.PictureBox pictureBoxblock24;
        private System.Windows.Forms.PictureBox pictureBoxblock44;
        private System.Windows.Forms.PictureBox pictureBoxblock30;
        private System.Windows.Forms.PictureBox pictureBoxblock03;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}