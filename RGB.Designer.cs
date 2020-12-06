
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
            this.bezzierPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.changePicButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.changePicOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.showSeparatedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bezzierPictureBox)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bezzierPictureBox
            // 
            this.bezzierPictureBox.BackColor = System.Drawing.Color.Silver;
            this.bezzierPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bezzierPictureBox.Location = new System.Drawing.Point(4, 4);
            this.bezzierPictureBox.Name = "bezzierPictureBox";
            this.bezzierPictureBox.Size = new System.Drawing.Size(486, 394);
            this.bezzierPictureBox.TabIndex = 0;
            this.bezzierPictureBox.TabStop = false;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
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
            this.tableLayoutPanel1.Controls.Add(this.bezzierPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 599);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // changePicButton
            // 
            this.changePicButton.Location = new System.Drawing.Point(3, 3);
            this.changePicButton.Name = "changePicButton";
            this.changePicButton.Size = new System.Drawing.Size(105, 23);
            this.changePicButton.TabIndex = 2;
            this.changePicButton.Text = "Change Picture";
            this.changePicButton.UseVisualStyleBackColor = true;
            this.changePicButton.Click += new System.EventHandler(this.changePicButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.ErrorImage = global::RGB_CMYK.Properties.Resources.Mogielica;
            this.pictureBox.ImageLocation = "../../Photos/Mogielica.jpg";
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(505, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(719, 599);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.WaitOnLoad = true;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.changePicButton);
            this.flowLayoutPanel.Controls.Add(this.showSeparatedButton);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(4, 405);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(486, 190);
            this.flowLayoutPanel.TabIndex = 3;
            // 
            // showSeparatedButton
            // 
            this.showSeparatedButton.Location = new System.Drawing.Point(114, 3);
            this.showSeparatedButton.Name = "showSeparatedButton";
            this.showSeparatedButton.Size = new System.Drawing.Size(103, 23);
            this.showSeparatedButton.TabIndex = 3;
            this.showSeparatedButton.Text = "Show separated";
            this.showSeparatedButton.UseVisualStyleBackColor = true;
            this.showSeparatedButton.Click += new System.EventHandler(this.showSeparatedButton_Click);
            // 
            // RGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 607);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "RGB";
            this.Text = "RGB -> CMYK";
            ((System.ComponentModel.ISupportInitialize)(this.bezzierPictureBox)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bezzierPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button changePicButton;
        private System.Windows.Forms.OpenFileDialog changePicOpenFileDialog;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button showSeparatedButton;
    }
}

