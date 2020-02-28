namespace DrawDots
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
            this.panelBackground = new System.Windows.Forms.Panel();
            this.buttonLoadPicture = new System.Windows.Forms.Button();
            this.buttonNewPicture = new System.Windows.Forms.Button();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.buttonLoadPicture);
            this.panelBackground.Controls.Add(this.buttonNewPicture);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(418, 94);
            this.panelBackground.TabIndex = 0;
            // 
            // buttonLoadPicture
            // 
            this.buttonLoadPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadPicture.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadPicture.Location = new System.Drawing.Point(216, 12);
            this.buttonLoadPicture.Name = "buttonLoadPicture";
            this.buttonLoadPicture.Size = new System.Drawing.Size(190, 70);
            this.buttonLoadPicture.TabIndex = 1;
            this.buttonLoadPicture.Text = "Загрузить рисунок";
            this.buttonLoadPicture.UseVisualStyleBackColor = true;
            // 
            // buttonNewPicture
            // 
            this.buttonNewPicture.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewPicture.Location = new System.Drawing.Point(12, 12);
            this.buttonNewPicture.Name = "buttonNewPicture";
            this.buttonNewPicture.Size = new System.Drawing.Size(190, 70);
            this.buttonNewPicture.TabIndex = 0;
            this.buttonNewPicture.Text = "Новый рисунок";
            this.buttonNewPicture.UseVisualStyleBackColor = true;
            this.buttonNewPicture.Click += new System.EventHandler(this.buttonNewPicture_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 94);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "DrawDots";
            this.panelBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Button buttonNewPicture;
        private System.Windows.Forms.Button buttonLoadPicture;
    }
}

