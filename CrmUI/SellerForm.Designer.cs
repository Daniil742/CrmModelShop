
namespace CrmUI
{
    partial class SellerForm
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
            this.buttonSellerAdd = new System.Windows.Forms.Button();
            this.textBoxSellerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSellerAdd
            // 
            this.buttonSellerAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSellerAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSellerAdd.Location = new System.Drawing.Point(249, 229);
            this.buttonSellerAdd.Name = "buttonSellerAdd";
            this.buttonSellerAdd.Size = new System.Drawing.Size(88, 29);
            this.buttonSellerAdd.TabIndex = 0;
            this.buttonSellerAdd.Text = "Добавить";
            this.buttonSellerAdd.UseVisualStyleBackColor = true;
            this.buttonSellerAdd.Click += new System.EventHandler(this.buttonSellerAdd_Click);
            // 
            // textBoxSellerName
            // 
            this.textBoxSellerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSellerName.Location = new System.Drawing.Point(110, 4);
            this.textBoxSellerName.Name = "textBoxSellerName";
            this.textBoxSellerName.Size = new System.Drawing.Size(227, 22);
            this.textBoxSellerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите имя";
            // 
            // SellerForm
            // 
            this.AcceptButton = this.buttonSellerAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 270);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSellerName);
            this.Controls.Add(this.buttonSellerAdd);
            this.Name = "SellerForm";
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSellerAdd;
        private System.Windows.Forms.TextBox textBoxSellerName;
        private System.Windows.Forms.Label label2;
    }
}