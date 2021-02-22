
namespace RGB_CMYK
{
    partial class RGB
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
            this.bezierPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.k0RadioButton = new System.Windows.Forms.RadioButton();
            this.k100RadioButton = new System.Windows.Forms.RadioButton();
            this.changePicButton = new System.Windows.Forms.Button();
            this.showSeparatedButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.clearKButton = new System.Windows.Forms.Button();
            this.kCurveRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.changePicOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Magenta = new System.Windows.Forms.RadioButton();
            this.Yellow = new System.Windows.Forms.RadioButton();
            this.Cyan = new System.Windows.Forms.RadioButton();
            this.clearMButton = new System.Windows.Forms.Button();
            this.clearYButton = new System.Windows.Forms.Button();
            this.clearCButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bezierPictureBox)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bezierPictureBox
            // 
            this.bezierPictureBox.BackColor = System.Drawing.Color.Silver;
            this.bezierPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bezierPictureBox.Location = new System.Drawing.Point(4, 4);
            this.bezierPictureBox.Name = "bezierPictureBox";
            this.bezierPictureBox.Size = new System.Drawing.Size(510, 510);
            this.bezierPictureBox.TabIndex = 0;
            this.bezierPictureBox.TabStop = false;
            this.bezierPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bezierPictureBox_MouseDown);
            this.bezierPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bezierPictureBox_MouseMove);
            this.bezierPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bezierPictureBox_MouseUp);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 524F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.pictureBox, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1340, 696);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.bezierPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 516F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(518, 688);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.88968F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.11032F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.changePicButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.showSeparatedButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 521);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(510, 163);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.k0RadioButton);
            this.flowLayoutPanel.Controls.Add(this.k100RadioButton);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.tableLayoutPanel2.SetRowSpan(this.flowLayoutPanel, 2);
            this.flowLayoutPanel.Size = new System.Drawing.Size(164, 157);
            this.flowLayoutPanel.TabIndex = 3;
            // 
            // k0RadioButton
            // 
            this.k0RadioButton.AutoSize = true;
            this.k0RadioButton.Location = new System.Drawing.Point(3, 3);
            this.k0RadioButton.Name = "k0RadioButton";
            this.k0RadioButton.Size = new System.Drawing.Size(85, 17);
            this.k0RadioButton.TabIndex = 0;
            this.k0RadioButton.Text = "0% cofnięcia";
            this.k0RadioButton.UseVisualStyleBackColor = true;
            this.k0RadioButton.CheckedChanged += new System.EventHandler(this.k0RadioButton_CheckedChanged);
            // 
            // k100RadioButton
            // 
            this.k100RadioButton.AutoSize = true;
            this.k100RadioButton.Checked = true;
            this.k100RadioButton.Location = new System.Drawing.Point(3, 26);
            this.k100RadioButton.Name = "k100RadioButton";
            this.k100RadioButton.Size = new System.Drawing.Size(97, 17);
            this.k100RadioButton.TabIndex = 1;
            this.k100RadioButton.TabStop = true;
            this.k100RadioButton.Text = "100% cofnięcia";
            this.k100RadioButton.UseVisualStyleBackColor = true;
            this.k100RadioButton.CheckedChanged += new System.EventHandler(this.k100RadioButton_CheckedChanged);
            // 
            // changePicButton
            // 
            this.changePicButton.Location = new System.Drawing.Point(173, 3);
            this.changePicButton.Name = "changePicButton";
            this.changePicButton.Size = new System.Drawing.Size(105, 23);
            this.changePicButton.TabIndex = 2;
            this.changePicButton.Text = "Change Picture";
            this.changePicButton.UseVisualStyleBackColor = true;
            this.changePicButton.Click += new System.EventHandler(this.changePicButton_Click);
            // 
            // showSeparatedButton
            // 
            this.showSeparatedButton.Location = new System.Drawing.Point(173, 84);
            this.showSeparatedButton.Name = "showSeparatedButton";
            this.showSeparatedButton.Size = new System.Drawing.Size(103, 23);
            this.showSeparatedButton.TabIndex = 3;
            this.showSeparatedButton.Text = "Show separated";
            this.showSeparatedButton.UseVisualStyleBackColor = true;
            this.showSeparatedButton.Click += new System.EventHandler(this.showSeparatedButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(337, 3);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel2.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(170, 157);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edytuj krzywą";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.clearYButton, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.clearMButton, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.Magenta, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.Yellow, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.Cyan, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.kCurveRadioButton, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.clearCButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.clearKButton, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.72464F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.27536F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(164, 138);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // clearKButton
            // 
            this.clearKButton.Location = new System.Drawing.Point(85, 111);
            this.clearKButton.Name = "clearKButton";
            this.clearKButton.Size = new System.Drawing.Size(74, 24);
            this.clearKButton.TabIndex = 2;
            this.clearKButton.Text = "Wyprostuj";
            this.clearKButton.UseVisualStyleBackColor = true;
            this.clearKButton.Click += new System.EventHandler(this.clearKButton_Click);
            // 
            // kCurveRadioButton
            // 
            this.kCurveRadioButton.AutoSize = true;
            this.kCurveRadioButton.Checked = true;
            this.kCurveRadioButton.Location = new System.Drawing.Point(3, 111);
            this.kCurveRadioButton.Name = "kCurveRadioButton";
            this.kCurveRadioButton.Size = new System.Drawing.Size(76, 17);
            this.kCurveRadioButton.TabIndex = 1;
            this.kCurveRadioButton.TabStop = true;
            this.kCurveRadioButton.Text = "Black curve";
            this.kCurveRadioButton.UseVisualStyleBackColor = true;
            this.kCurveRadioButton.CheckedChanged += new System.EventHandler(this.kCurveRadioButton_CheckedChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.ErrorImage = global::RGB_CMYK.Properties.Resources.Mogielica;
            this.pictureBox.ImageLocation = "../../Photos/Mogielica.jpg";
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(529, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(807, 688);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.WaitOnLoad = true;
            // 
            // Magenta
            // 
            this.Magenta.AutoSize = true;
            this.Magenta.Location = new System.Drawing.Point(3, 38);
            this.Magenta.Name = "Magenta";
            this.Magenta.Size = new System.Drawing.Size(67, 17);
            this.Magenta.TabIndex = 3;
            this.Magenta.TabStop = true;
            this.Magenta.Text = "Magenta";
            this.Magenta.UseVisualStyleBackColor = true;
            this.Magenta.CheckedChanged += new System.EventHandler(this.Magenta_CheckedChanged);
            // 
            // Yellow
            // 
            this.Yellow.AutoSize = true;
            this.Yellow.Location = new System.Drawing.Point(3, 72);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(56, 17);
            this.Yellow.TabIndex = 4;
            this.Yellow.TabStop = true;
            this.Yellow.Text = "Yellow";
            this.Yellow.UseVisualStyleBackColor = true;
            this.Yellow.CheckedChanged += new System.EventHandler(this.Yellow_CheckedChanged);
            // 
            // Cyan
            // 
            this.Cyan.AutoSize = true;
            this.Cyan.Location = new System.Drawing.Point(3, 3);
            this.Cyan.Name = "Cyan";
            this.Cyan.Size = new System.Drawing.Size(49, 17);
            this.Cyan.TabIndex = 5;
            this.Cyan.TabStop = true;
            this.Cyan.Text = "Cyan";
            this.Cyan.UseVisualStyleBackColor = true;
            this.Cyan.CheckedChanged += new System.EventHandler(this.Cyan_CheckedChanged);
            // 
            // clearMButton
            // 
            this.clearMButton.Location = new System.Drawing.Point(85, 38);
            this.clearMButton.Name = "clearMButton";
            this.clearMButton.Size = new System.Drawing.Size(74, 27);
            this.clearMButton.TabIndex = 6;
            this.clearMButton.Text = "Wyprostuj";
            this.clearMButton.UseVisualStyleBackColor = true;
            this.clearMButton.Click += new System.EventHandler(this.clearMButton_Click);
            // 
            // clearYButton
            // 
            this.clearYButton.Location = new System.Drawing.Point(85, 72);
            this.clearYButton.Name = "clearYButton";
            this.clearYButton.Size = new System.Drawing.Size(74, 27);
            this.clearYButton.TabIndex = 7;
            this.clearYButton.Text = "Wyprostuj";
            this.clearYButton.UseVisualStyleBackColor = true;
            this.clearYButton.Click += new System.EventHandler(this.clearYButton_Click);
            // 
            // clearCButton
            // 
            this.clearCButton.Location = new System.Drawing.Point(85, 3);
            this.clearCButton.Name = "clearCButton";
            this.clearCButton.Size = new System.Drawing.Size(74, 27);
            this.clearCButton.TabIndex = 8;
            this.clearCButton.Text = "Wyprostuj";
            this.clearCButton.UseVisualStyleBackColor = true;
            this.clearCButton.Click += new System.EventHandler(this.clearCButton_Click);
            // 
            // RGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 696);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "RGB";
            this.Text = "RGB -> CMYK";
            ((System.ComponentModel.ISupportInitialize)(this.bezierPictureBox)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bezierPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button changePicButton;
        private System.Windows.Forms.OpenFileDialog changePicOpenFileDialog;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button showSeparatedButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton k0RadioButton;
        private System.Windows.Forms.RadioButton k100RadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton kCurveRadioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button clearKButton;
        private System.Windows.Forms.Button clearYButton;
        private System.Windows.Forms.Button clearMButton;
        private System.Windows.Forms.RadioButton Magenta;
        private System.Windows.Forms.RadioButton Yellow;
        private System.Windows.Forms.RadioButton Cyan;
        private System.Windows.Forms.Button clearCButton;
    }
}

