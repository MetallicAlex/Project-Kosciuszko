namespace Kosciuszko
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureMinimize = new System.Windows.Forms.PictureBox();
            this.pictureWindowState = new System.Windows.Forms.PictureBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWindowState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelHeader.Controls.Add(this.pictureMinimize);
            this.panelHeader.Controls.Add(this.pictureWindowState);
            this.panelHeader.Controls.Add(this.pictureClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(782, 32);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            // 
            // pictureMinimize
            // 
            this.pictureMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureMinimize.Image")));
            this.pictureMinimize.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureMinimize.InitialImage")));
            this.pictureMinimize.Location = new System.Drawing.Point(686, 0);
            this.pictureMinimize.Name = "pictureMinimize";
            this.pictureMinimize.Size = new System.Drawing.Size(32, 32);
            this.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMinimize.TabIndex = 3;
            this.pictureMinimize.TabStop = false;
            this.pictureMinimize.Click += new System.EventHandler(this.pictureMinimize_Click);
            this.pictureMinimize.MouseLeave += new System.EventHandler(this.pictureMinimize_MouseLeave);
            this.pictureMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureMinimize_MouseMove);
            // 
            // pictureWindowState
            // 
            this.pictureWindowState.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureWindowState.Image = ((System.Drawing.Image)(resources.GetObject("pictureWindowState.Image")));
            this.pictureWindowState.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureWindowState.InitialImage")));
            this.pictureWindowState.Location = new System.Drawing.Point(718, 0);
            this.pictureWindowState.Name = "pictureWindowState";
            this.pictureWindowState.Size = new System.Drawing.Size(32, 32);
            this.pictureWindowState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureWindowState.TabIndex = 2;
            this.pictureWindowState.TabStop = false;
            this.pictureWindowState.Click += new System.EventHandler(this.pictureWindowState_Click);
            this.pictureWindowState.MouseLeave += new System.EventHandler(this.pictureWindowState_MouseLeave);
            this.pictureWindowState.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureWindowState_MouseMove);
            // 
            // pictureClose
            // 
            this.pictureClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureClose.InitialImage")));
            this.pictureClose.Location = new System.Drawing.Point(750, 0);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(32, 32);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClose.TabIndex = 1;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            this.pictureClose.MouseLeave += new System.EventHandler(this.pictureClose_MouseLeave);
            this.pictureClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureClose_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.panelHeader);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Kosciuszko";
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWindowState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.PictureBox pictureWindowState;
        private System.Windows.Forms.PictureBox pictureMinimize;
    }
}

