using System.Diagnostics.Tracing;

namespace kurs
{
    partial class Start
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
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.begin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(299, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Подарок";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // begin
            // 
            this.begin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.begin.AutoSize = true;
            this.begin.BackColor = System.Drawing.Color.IndianRed;
            this.begin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.begin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.begin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.begin.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.begin.ForeColor = System.Drawing.SystemColors.Window;
            this.begin.Location = new System.Drawing.Point(215, 308);
            this.begin.Margin = new System.Windows.Forms.Padding(0);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(342, 98);
            this.begin.TabIndex = 1;
            this.begin.Text = "Продолжить";
            this.begin.UseVisualStyleBackColor = false;
            this.begin.UseWaitCursor = true;
            this.begin.Click += new System.EventHandler(this.begin_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::kurs.Properties.Resources.fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 853);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.label1);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button begin;
    }
}