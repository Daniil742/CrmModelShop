
namespace CrmUI
{
    partial class CustomerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.buttonCustomerAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCustomerName.Location = new System.Drawing.Point(110, 4);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(227, 22);
            this.textBoxCustomerName.TabIndex = 1;
            // 
            // buttonCustomerAdd
            // 
            this.buttonCustomerAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCustomerAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCustomerAdd.Location = new System.Drawing.Point(249, 229);
            this.buttonCustomerAdd.Name = "buttonCustomerAdd";
            this.buttonCustomerAdd.Size = new System.Drawing.Size(88, 29);
            this.buttonCustomerAdd.TabIndex = 2;
            this.buttonCustomerAdd.Text = "Добавить";
            this.buttonCustomerAdd.UseVisualStyleBackColor = true;
            this.buttonCustomerAdd.Click += new System.EventHandler(this.buttonCustomerAdd_Click);
            // 
            // CustomerForm
            // 
            this.AcceptButton = this.buttonCustomerAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 270);
            this.Controls.Add(this.buttonCustomerAdd);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.label1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Button buttonCustomerAdd;
    }
}