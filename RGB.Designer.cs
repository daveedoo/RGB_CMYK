
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.changePicOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bezierPictureBox)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bezierPictureBox
            // 
            this.bezierPictureBox.BackColor = System.Drawing.Color.Silver;
            this.bezierPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bezierPictureBox.Location = new System.Drawing.Point(4, 4);
            this.bezierPictureBox.Name = "bezierPictureBox";
            this.bezierPictureBox.Size = new System.Drawing.Size(512, 512);
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
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 526F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.pictureBox, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1228, 607);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 518F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(520, 599);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.66255F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.33745F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.changePicButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.showSeparatedButton, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 523);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(512, 72);
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
            this.flowLayoutPanel.Size = new System.Drawing.Size(115, 66);
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
            this.changePicButton.Location = new System.Drawing.Point(124, 3);
            this.changePicButton.Name = "changePicButton";
            this.changePicButton.Size = new System.Drawing.Size(105, 23);
            this.changePicButton.TabIndex = 2;
            this.changePicButton.Text = "Change Picture";
            this.changePicButton.UseVisualStyleBackColor = true;
            this.changePicButton.Click += new System.EventHandler(this.changePicButton_Click);
            // 
            // showSeparatedButton
            // 
            this.showSeparatedButton.Location = new System.Drawing.Point(124, 39);
            this.showSeparatedButton.Name = "showSeparatedButton";
            this.showSeparatedButton.Size = new System.Drawing.Size(103, 23);
            this.showSeparatedButton.TabIndex = 3;
            this.showSeparatedButton.Text = "Show separated";
            this.showSeparatedButton.UseVisualStyleBackColor = true;
            this.showSeparatedButton.Click += new System.EventHandler(this.showSeparatedButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.ErrorImage = global::RGB_CMYK.Properties.Resources.Mogielica;
            this.pictureBox.ImageLocation = "../../Photos/Mogielica.jpg";
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(531, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(693, 599);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.WaitOnLoad = true;
            // 
            // RGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 607);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "RGB";
            this.Text = "RGB -> CMYK";
            ((System.ComponentModel.ISupportInitialize)(this.bezierPictureBox)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
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
    }
}

