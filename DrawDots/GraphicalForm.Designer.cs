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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.debugInfo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelPointThickness = new System.Windows.Forms.Label();
            this.labelPointThicknessValue = new System.Windows.Forms.Label();
            this.trackBarPointThickness = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelChooseGroup = new System.Windows.Forms.Label();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonNewGroup = new System.Windows.Forms.Button();
            this.buttonDeleteGroup = new System.Windows.Forms.Button();
            this.checkBoxDeletePointMode = new System.Windows.Forms.CheckBox();
            this.chooseColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openGLWindow)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPointThickness)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openGLWindow
            // 
            this.openGLWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openGLWindow.DrawFPS = true;
            this.openGLWindow.FrameRate = 30;
            this.openGLWindow.Location = new System.Drawing.Point(217, 0);
            this.openGLWindow.Name = "openGLWindow";
            this.openGLWindow.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLWindow.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLWindow.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLWindow.Size = new System.Drawing.Size(888, 702);
            this.openGLWindow.TabIndex = 0;
            this.openGLWindow.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLWindow_OpenGLDraw);
            this.openGLWindow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openGLWindow_MouseClick);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.groupBox3);
            this.leftPanel.Controls.Add(this.groupBox2);
            this.leftPanel.Controls.Add(this.groupBox1);
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(211, 702);
            this.leftPanel.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.flowLayoutPanel6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 663);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 39);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Debug info";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.Controls.Add(this.debugInfo);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(205, 20);
            this.flowLayoutPanel6.TabIndex = 0;
            // 
            // debugInfo
            // 
            this.debugInfo.AutoSize = true;
            this.debugInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.debugInfo.Location = new System.Drawing.Point(3, 0);
            this.debugInfo.Name = "debugInfo";
            this.debugInfo.Size = new System.Drawing.Size(93, 20);
            this.debugInfo.TabIndex = 0;
            this.debugInfo.Text = "Debug Info:\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.flowLayoutPanel4);
            this.groupBox2.Location = new System.Drawing.Point(12, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 131);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Внешний вид";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel4.Controls.Add(this.chooseColor);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(172, 112);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel5.Controls.Add(this.trackBarPointThickness);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(158, 70);
            this.flowLayoutPanel5.TabIndex = 11;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.labelPointThickness);
            this.flowLayoutPanel3.Controls.Add(this.labelPointThicknessValue);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(109, 13);
            this.flowLayoutPanel3.TabIndex = 11;
            // 
            // labelPointThickness
            // 
            this.labelPointThickness.AutoSize = true;
            this.labelPointThickness.Location = new System.Drawing.Point(3, 0);
            this.labelPointThickness.Name = "labelPointThickness";
            this.labelPointThickness.Size = new System.Drawing.Size(84, 13);
            this.labelPointThickness.TabIndex = 6;
            this.labelPointThickness.Text = "Толщина точек";
            // 
            // labelPointThicknessValue
            // 
            this.labelPointThicknessValue.AutoSize = true;
            this.labelPointThicknessValue.Location = new System.Drawing.Point(93, 0);
            this.labelPointThicknessValue.Name = "labelPointThicknessValue";
            this.labelPointThicknessValue.Size = new System.Drawing.Size(13, 13);
            this.labelPointThicknessValue.TabIndex = 7;
            this.labelPointThicknessValue.Text = "1";
            // 
            // trackBarPointThickness
            // 
            this.trackBarPointThickness.Location = new System.Drawing.Point(3, 22);
            this.trackBarPointThickness.Maximum = 20;
            this.trackBarPointThickness.Minimum = 5;
            this.trackBarPointThickness.Name = "trackBarPointThickness";
            this.trackBarPointThickness.Size = new System.Drawing.Size(152, 45);
            this.trackBarPointThickness.SmallChange = 3;
            this.trackBarPointThickness.TabIndex = 3;
            this.trackBarPointThickness.TickFrequency = 3;
            this.trackBarPointThickness.Value = 5;
            this.trackBarPointThickness.Scroll += new System.EventHandler(this.trackBarPointThickness_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 137);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление группой";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.labelChooseGroup);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxGroups);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxDeletePointMode);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 10, 0, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(172, 118);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // labelChooseGroup
            // 
            this.labelChooseGroup.AutoSize = true;
            this.labelChooseGroup.Location = new System.Drawing.Point(8, 10);
            this.labelChooseGroup.Name = "labelChooseGroup";
            this.labelChooseGroup.Size = new System.Drawing.Size(82, 13);
            this.labelChooseGroup.TabIndex = 2;
            this.labelChooseGroup.Text = "Выбор группы:";
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(8, 26);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(132, 21);
            this.comboBoxGroups.TabIndex = 1;
            this.comboBoxGroups.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroups_SelectedIndexChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.buttonNewGroup);
            this.flowLayoutPanel2.Controls.Add(this.buttonDeleteGroup);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(5, 53);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(138, 29);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // buttonNewGroup
            // 
            this.buttonNewGroup.Location = new System.Drawing.Point(3, 3);
            this.buttonNewGroup.Name = "buttonNewGroup";
            this.buttonNewGroup.Size = new System.Drawing.Size(60, 23);
            this.buttonNewGroup.TabIndex = 3;
            this.buttonNewGroup.Text = "Новая";
            this.buttonNewGroup.UseVisualStyleBackColor = true;
            this.buttonNewGroup.Click += new System.EventHandler(this.buttonNewGroup_Click);
            // 
            // buttonDeleteGroup
            // 
            this.buttonDeleteGroup.Location = new System.Drawing.Point(69, 3);
            this.buttonDeleteGroup.Name = "buttonDeleteGroup";
            this.buttonDeleteGroup.Size = new System.Drawing.Size(66, 23);
            this.buttonDeleteGroup.TabIndex = 4;
            this.buttonDeleteGroup.Text = "Удалить";
            this.buttonDeleteGroup.UseVisualStyleBackColor = true;
            this.buttonDeleteGroup.Click += new System.EventHandler(this.buttonDeleteGroup_Click);
            // 
            // checkBoxDeletePointMode
            // 
            this.checkBoxDeletePointMode.AutoSize = true;
            this.checkBoxDeletePointMode.Location = new System.Drawing.Point(8, 88);
            this.checkBoxDeletePointMode.Name = "checkBoxDeletePointMode";
            this.checkBoxDeletePointMode.Size = new System.Drawing.Size(107, 17);
            this.checkBoxDeletePointMode.TabIndex = 8;
            this.checkBoxDeletePointMode.Text = "Удаление точек";
            this.checkBoxDeletePointMode.UseVisualStyleBackColor = true;
            // 
            // chooseColor
            // 
            this.chooseColor.Location = new System.Drawing.Point(3, 79);
            this.chooseColor.Name = "chooseColor";
            this.chooseColor.Size = new System.Drawing.Size(125, 23);
            this.chooseColor.TabIndex = 12;
            this.chooseColor.Text = "Выбрать цвет";
            this.chooseColor.UseVisualStyleBackColor = true;
            this.chooseColor.Click += new System.EventHandler(this.chooseColor_Click);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPointThickness)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Button chooseColor;
    }
}