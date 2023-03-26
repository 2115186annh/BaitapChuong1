namespace Vidu_Trang60
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.clbMoHoc = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // clbMoHoc
            // 
            this.clbMoHoc.FormattingEnabled = true;
            this.clbMoHoc.Items.AddRange(new object[] {
            "cc và  MT LT1",
            "Cơ sở dữ liệu",
            "Tiếng Anh 2",
            "Quản trị mạng ",
            "Mạng Máy tính",
            "Phát triển ứng dụng desktop"});
            this.clbMoHoc.Location = new System.Drawing.Point(23, 63);
            this.clbMoHoc.Name = "clbMoHoc";
            this.clbMoHoc.Size = new System.Drawing.Size(230, 123);
            this.clbMoHoc.TabIndex = 0;
            this.clbMoHoc.SelectedIndexChanged += new System.EventHandler(this.clbMoHoc_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.clbMoHoc);
            this.Name = "Form1";
            this.Text = "Demo ChecklistBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckedListBox clbMoHoc;
    }
}

