
namespace OvrBuilder
{
    partial class FormProgress
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
            this.labelFile = new System.Windows.Forms.Label();
            this.progressBarFile = new System.Windows.Forms.ProgressBar();
            this.labelAll = new System.Windows.Forms.Label();
            this.progressBarAll = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(13, 13);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(100, 24);
            this.labelFile.TabIndex = 0;
            this.labelFile.Text = "处理文件：";
            // 
            // progressBarFile
            // 
            this.progressBarFile.Location = new System.Drawing.Point(12, 40);
            this.progressBarFile.Name = "progressBarFile";
            this.progressBarFile.Size = new System.Drawing.Size(753, 34);
            this.progressBarFile.TabIndex = 1;
            // 
            // labelAll
            // 
            this.labelAll.AutoSize = true;
            this.labelAll.Location = new System.Drawing.Point(13, 81);
            this.labelAll.Name = "labelAll";
            this.labelAll.Size = new System.Drawing.Size(82, 24);
            this.labelAll.TabIndex = 2;
            this.labelAll.Text = "已完成：";
            // 
            // progressBarAll
            // 
            this.progressBarAll.Location = new System.Drawing.Point(13, 108);
            this.progressBarAll.Name = "progressBarAll";
            this.progressBarAll.Size = new System.Drawing.Size(753, 34);
            this.progressBarAll.TabIndex = 3;
            // 
            // FormProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 162);
            this.ControlBox = false;
            this.Controls.Add(this.progressBarAll);
            this.Controls.Add(this.labelAll);
            this.Controls.Add(this.progressBarFile);
            this.Controls.Add(this.labelFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "正在生成影像金字塔";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelAll;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBarFile;
        private System.Windows.Forms.ProgressBar progressBarAll;
    }
}