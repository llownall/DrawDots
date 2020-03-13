namespace DrawDots
{
    partial class GraphicalForm
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
            this.openGLWindow = new SharpGL.OpenGLControl();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.SaveData = new System.Windows.Forms.Button();
            this.checkBoxDeletePointMode = new System.Windows.Forms.CheckBox();
            this.labelPointThicknessValue = new System.Windows.Forms.Label();
            this.labelPointThickness = new System.Windows.Forms.Label();
            this.trackBarPointThickness = new System.Windows.Forms.TrackBar();
            this.buttonDeleteGroup = new System.Windows.Forms.Button();
            this.buttonNewGroup = new System.Windows.Forms.Button();
            this.labelChooseGroup = new System.Windows.Forms.Label();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.debugInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.openGLWindow)).BeginInit();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPointThickness)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLWindow
            // 
            this.openGLWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openGLWindow.DrawFPS = true;
            this.openGLWindow.FrameRate = 30;
            this.openGLWindow.Location = new System.Drawing.Point(166, 0);
            this.openGLWindow.Name = "openGLWindow";
            this.openGLWindow.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLWindow.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLWindow.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLWindow.Size = new System.Drawing.Size(939, 702);
            this.openGLWindow.TabIndex = 0;
            this.openGLWindow.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLWindow_OpenGLDraw);
            this.openGLWindow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openGLWindow_MouseClick);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.SaveData);
            this.leftPanel.Controls.Add(this.checkBoxDeletePointMode);
            this.leftPanel.Controls.Add(this.labelPointThicknessValue);
            this.leftPanel.Controls.Add(this.labelPointThickness);
            this.leftPanel.Controls.Add(this.trackBarPointThickness);
            this.leftPanel.Controls.Add(this.buttonDeleteGroup);
            this.leftPanel.Controls.Add(this.buttonNewGroup);
            this.leftPanel.Controls.Add(this.labelChooseGroup);
            this.leftPanel.Controls.Add(this.comboBoxGroups);
            this.leftPanel.Controls.Add(this.debugInfo);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(160, 702);
            this.leftPanel.TabIndex = 1;
            // 
            // SaveData
            // 
            this.SaveData.Location = new System.Drawing.Point(18, 486);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(113, 61);
            this.SaveData.TabIndex = 9;
            this.SaveData.Text = "Сохраниться";
            this.SaveData.UseVisualStyleBackColor = true;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // checkBoxDeletePointMode
            // 
            this.checkBoxDeletePointMode.AutoSize = true;
            this.checkBoxDeletePointMode.Location = new System.Drawing.Point(15, 123);
            this.checkBoxDeletePointMode.Name = "checkBoxDeletePointMode";
            this.checkBoxDeletePointMode.Size = new System.Drawing.Size(107, 17);
            this.checkBoxDeletePointMode.TabIndex = 8;
            this.checkBoxDeletePointMode.Text = "Удаление точек";
            this.checkBoxDeletePointMode.UseVisualStyleBackColor = true;
            // 
            // labelPointThicknessValue
            // 
            this.labelPointThicknessValue.AutoSize = true;
            this.labelPointThicknessValue.Location = new System.Drawing.Point(108, 267);
            this.labelPointThicknessValue.Name = "labelPointThicknessValue";
            this.labelPointThicknessValue.Size = new System.Drawing.Size(13, 13);
            this.labelPointThicknessValue.TabIndex = 7;
            this.labelPointThicknessValue.Text = "1";
            // 
            // labelPointThickness
            // 
            this.labelPointThickness.AutoSize = true;
            this.labelPointThickness.Location = new System.Drawing.Point(15, 268);
            this.labelPointThickness.Name = "labelPointThickness";
            this.labelPointThickness.Size = new System.Drawing.Size(84, 13);
            this.labelPointThickness.TabIndex = 6;
            this.labelPointThickness.Text = "Толщина точек";
            // 
            // trackBarPointThickness
            // 
            this.trackBarPointThickness.Location = new System.Drawing.Point(12, 287);
            this.trackBarPointThickness.Maximum = 20;
            this.trackBarPointThickness.Minimum = 5;
            this.trackBarPointThickness.Name = "trackBarPointThickness";
            this.trackBarPointThickness.Size = new System.Drawing.Size(135, 45);
            this.trackBarPointThickness.SmallChange = 3;
            this.trackBarPointThickness.TabIndex = 3;
            this.trackBarPointThickness.TickFrequency = 3;
            this.trackBarPointThickness.Value = 5;
            this.trackBarPointThickness.Scroll += new System.EventHandler(this.trackBarPointThickness_Scroll);
            // 
            // buttonDeleteGroup
            // 
            this.buttonDeleteGroup.Location = new System.Drawing.Point(81, 80);
            this.buttonDeleteGroup.Name = "buttonDeleteGroup";
            this.buttonDeleteGroup.Size = new System.Drawing.Size(66, 23);
            this.buttonDeleteGroup.TabIndex = 4;
            this.buttonDeleteGroup.Text = "Удалить";
            this.buttonDeleteGroup.UseVisualStyleBackColor = true;
            this.buttonDeleteGroup.Click += new System.EventHandler(this.buttonDeleteGroup_Click);
            // 
            // buttonNewGroup
            // 
            this.buttonNewGroup.Location = new System.Drawing.Point(15, 80);
            this.buttonNewGroup.Name = "buttonNewGroup";
            this.buttonNewGroup.Size = new System.Drawing.Size(60, 23);
            this.buttonNewGroup.TabIndex = 3;
            this.buttonNewGroup.Text = "Новая";
            this.buttonNewGroup.UseVisualStyleBackColor = true;
            this.buttonNewGroup.Click += new System.EventHandler(this.buttonNewGroup_Click);
            // 
            // labelChooseGroup
            // 
            this.labelChooseGroup.AutoSize = true;
            this.labelChooseGroup.Location = new System.Drawing.Point(12, 18);
            this.labelChooseGroup.Name = "labelChooseGroup";
            this.labelChooseGroup.Size = new System.Drawing.Size(82, 13);
            this.labelChooseGroup.TabIndex = 2;
            this.labelChooseGroup.Text = "Выбор группы:";
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(15, 48);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(132, 21);
            this.comboBoxGroups.TabIndex = 1;
            this.comboBoxGroups.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroups_SelectedIndexChanged);
            // 
            // debugInfo
            // 
            this.debugInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.debugInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.debugInfo.Location = new System.Drawing.Point(0, 570);
            this.debugInfo.Name = "debugInfo";
            this.debugInfo.Size = new System.Drawing.Size(160, 132);
            this.debugInfo.TabIndex = 0;
            this.debugInfo.Text = "Debug Info:\r\n";
            // 
            // GraphicalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 702);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.openGLWindow);
            this.Name = "GraphicalForm";
            this.Text = "GraphicalForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GraphicalForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.openGLWindow)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPointThickness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SharpGL.OpenGLControl openGLWindow;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Label debugInfo;
        private System.Windows.Forms.Label labelChooseGroup;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.Button buttonDeleteGroup;
        private System.Windows.Forms.Button buttonNewGroup;
        private System.Windows.Forms.TrackBar trackBarPointThickness;
        private System.Windows.Forms.Label labelPointThicknessValue;
        private System.Windows.Forms.Label labelPointThickness;
        private System.Windows.Forms.CheckBox checkBoxDeletePointMode;
        private System.Windows.Forms.Button SaveData;
    }
}