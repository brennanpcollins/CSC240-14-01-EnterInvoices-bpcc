
namespace CSC240_14_01_EnterInvoices_bpcc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            writer.Close();
            outFile.Close();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UxTitleLabel = new System.Windows.Forms.Label();
            this.UxInvoiceLabel = new System.Windows.Forms.Label();
            this.UxNameLabel = new System.Windows.Forms.Label();
            this.UxAmountLabel = new System.Windows.Forms.Label();
            this.UxInvoiceBox = new System.Windows.Forms.TextBox();
            this.UxNameBox = new System.Windows.Forms.TextBox();
            this.UxNumberBox = new System.Windows.Forms.TextBox();
            this.UxEnterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UxTitleLabel
            // 
            this.UxTitleLabel.AutoSize = true;
            this.UxTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxTitleLabel.Location = new System.Drawing.Point(236, 66);
            this.UxTitleLabel.Name = "UxTitleLabel";
            this.UxTitleLabel.Size = new System.Drawing.Size(277, 45);
            this.UxTitleLabel.TabIndex = 0;
            this.UxTitleLabel.Text = "Enter Invoice Data";
            // 
            // UxInvoiceLabel
            // 
            this.UxInvoiceLabel.AutoSize = true;
            this.UxInvoiceLabel.Location = new System.Drawing.Point(176, 166);
            this.UxInvoiceLabel.Name = "UxInvoiceLabel";
            this.UxInvoiceLabel.Size = new System.Drawing.Size(185, 32);
            this.UxInvoiceLabel.TabIndex = 1;
            this.UxInvoiceLabel.Text = "Invoice Number";
            // 
            // UxNameLabel
            // 
            this.UxNameLabel.AutoSize = true;
            this.UxNameLabel.Location = new System.Drawing.Point(176, 255);
            this.UxNameLabel.Name = "UxNameLabel";
            this.UxNameLabel.Size = new System.Drawing.Size(126, 32);
            this.UxNameLabel.TabIndex = 2;
            this.UxNameLabel.Text = "Last Name";
            // 
            // UxAmountLabel
            // 
            this.UxAmountLabel.AutoSize = true;
            this.UxAmountLabel.Location = new System.Drawing.Point(176, 342);
            this.UxAmountLabel.Name = "UxAmountLabel";
            this.UxAmountLabel.Size = new System.Drawing.Size(100, 32);
            this.UxAmountLabel.TabIndex = 3;
            this.UxAmountLabel.Text = "Amount";
            // 
            // UxInvoiceBox
            // 
            this.UxInvoiceBox.Location = new System.Drawing.Point(406, 159);
            this.UxInvoiceBox.Name = "UxInvoiceBox";
            this.UxInvoiceBox.Size = new System.Drawing.Size(200, 39);
            this.UxInvoiceBox.TabIndex = 4;
            // 
            // UxNameBox
            // 
            this.UxNameBox.Location = new System.Drawing.Point(406, 248);
            this.UxNameBox.Name = "UxNameBox";
            this.UxNameBox.Size = new System.Drawing.Size(200, 39);
            this.UxNameBox.TabIndex = 5;
            // 
            // UxNumberBox
            // 
            this.UxNumberBox.Location = new System.Drawing.Point(406, 335);
            this.UxNumberBox.Name = "UxNumberBox";
            this.UxNumberBox.Size = new System.Drawing.Size(200, 39);
            this.UxNumberBox.TabIndex = 6;
            // 
            // UxEnterButton
            // 
            this.UxEnterButton.Location = new System.Drawing.Point(496, 431);
            this.UxEnterButton.Name = "UxEnterButton";
            this.UxEnterButton.Size = new System.Drawing.Size(184, 46);
            this.UxEnterButton.TabIndex = 7;
            this.UxEnterButton.Text = "Enter Record";
            this.UxEnterButton.UseVisualStyleBackColor = true;
            this.UxEnterButton.Click += new System.EventHandler(this.UxEnterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 707);
            this.Controls.Add(this.UxEnterButton);
            this.Controls.Add(this.UxNumberBox);
            this.Controls.Add(this.UxNameBox);
            this.Controls.Add(this.UxInvoiceBox);
            this.Controls.Add(this.UxAmountLabel);
            this.Controls.Add(this.UxNameLabel);
            this.Controls.Add(this.UxInvoiceLabel);
            this.Controls.Add(this.UxTitleLabel);
            this.Name = "Form1";
            this.Text = "Invoice Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UxTitleLabel;
        private System.Windows.Forms.Label UxInvoiceLabel;
        private System.Windows.Forms.Label UxNameLabel;
        private System.Windows.Forms.Label UxAmountLabel;
        private System.Windows.Forms.TextBox UxInvoiceBox;
        private System.Windows.Forms.TextBox UxNameBox;
        private System.Windows.Forms.TextBox UxNumberBox;
        private System.Windows.Forms.Button UxEnterButton;
    }
}

