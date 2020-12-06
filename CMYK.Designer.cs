
namespace RGB_CMYK
{
    partial class CMYK
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cPictureBox = new System.Windows.Forms.PictureBox();
            this.mPictureBox = new System.Windows.Forms.PictureBox();
            this.yPictureBox = new System.Windows.Forms.PictureBox();
            this.kPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mPictureBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.yPictureBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.kPictureBox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cPictureBox
            // 
            this.cPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cPictureBox.Location = new System.Drawing.Point(4, 4);
            this.cPictureBox.Name = "cPictureBox";
            this.cPictureBox.Size = new System.Drawing.Size(464, 273);
            this.cPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cPictureBox.TabIndex = 0;
            this.cPictureBox.TabStop = false;
            // 
            // mPictureBox
            // 
            this.mPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mPictureBox.Location = new System.Drawing.Point(475, 4);
            this.mPictureBox.Name = "mPictureBox";
            this.mPictureBox.Size = new System.Drawing.Size(465, 273);
            this.mPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mPictureBox.TabIndex = 1;
            this.mPictureBox.TabStop = false;
            // 
            // yPictureBox
            // 
            this.yPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yPictureBox.Location = new System.Drawing.Point(4, 284);
            this.yPictureBox.Name = "yPictureBox";
            this.yPictureBox.Size = new System.Drawing.Size(464, 273);
            this.yPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yPictureBox.TabIndex = 2;
            this.yPictureBox.TabStop = false;
            // 
            // kPictureBox
            // 
            this.kPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kPictureBox.Location = new System.Drawing.Point(475, 284);
            this.kPictureBox.Name = "kPictureBox";
            this.kPictureBox.Size = new System.Drawing.Size(465, 273);
            this.kPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kPictureBox.TabIndex = 3;
            this.kPictureBox.TabStop = false;
            // 
            // CMYK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CMYK";
            this.Text = "CMYK";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox cPictureBox;
        private System.Windows.Forms.PictureBox mPictureBox;
        private System.Windows.Forms.PictureBox yPictureBox;
        private System.Windows.Forms.PictureBox kPictureBox;
    }
}