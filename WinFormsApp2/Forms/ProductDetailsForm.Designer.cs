namespace WinFormsApp2.Forms
{
    partial class ProductDetailsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblContactInfo;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblEstimatedValue;
        private System.Windows.Forms.Label lblPawnValue;
        private System.Windows.Forms.Label lblDateReceived;
        private System.Windows.Forms.Label lblStoragePeriod;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblClientName = new Label();
            lblContactInfo = new Label();
            lblProductName = new Label();
            lblEstimatedValue = new Label();
            lblPawnValue = new Label();
            lblDateReceived = new Label();
            lblStoragePeriod = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Location = new Point(7, 4);
            lblClientName.Margin = new Padding(6, 0, 6, 0);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(147, 32);
            lblClientName.TabIndex = 0;
            lblClientName.Text = "Client Name";
            // 
            // lblContactInfo
            // 
            lblContactInfo.AutoSize = true;
            lblContactInfo.Location = new Point(7, 57);
            lblContactInfo.Margin = new Padding(6, 0, 6, 0);
            lblContactInfo.Name = "lblContactInfo";
            lblContactInfo.Size = new Size(145, 32);
            lblContactInfo.TabIndex = 1;
            lblContactInfo.Text = "Contact Info";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(9, 115);
            lblProductName.Margin = new Padding(6, 0, 6, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(167, 32);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Product Name";
            // 
            // lblEstimatedValue
            // 
            lblEstimatedValue.AutoSize = true;
            lblEstimatedValue.Location = new Point(7, 172);
            lblEstimatedValue.Margin = new Padding(6, 0, 6, 0);
            lblEstimatedValue.Name = "lblEstimatedValue";
            lblEstimatedValue.Size = new Size(183, 32);
            lblEstimatedValue.TabIndex = 3;
            lblEstimatedValue.Text = "Estimated Value";
            // 
            // lblPawnValue
            // 
            lblPawnValue.AutoSize = true;
            lblPawnValue.Location = new Point(9, 234);
            lblPawnValue.Margin = new Padding(6, 0, 6, 0);
            lblPawnValue.Name = "lblPawnValue";
            lblPawnValue.Size = new Size(134, 32);
            lblPawnValue.TabIndex = 4;
            lblPawnValue.Text = "Pawn Value";
            // 
            // lblDateReceived
            // 
            lblDateReceived.AutoSize = true;
            lblDateReceived.Location = new Point(9, 293);
            lblDateReceived.Margin = new Padding(6, 0, 6, 0);
            lblDateReceived.Name = "lblDateReceived";
            lblDateReceived.Size = new Size(166, 32);
            lblDateReceived.TabIndex = 5;
            lblDateReceived.Text = "Date Received";
            // 
            // lblStoragePeriod
            // 
            lblStoragePeriod.AutoSize = true;
            lblStoragePeriod.Location = new Point(7, 348);
            lblStoragePeriod.Margin = new Padding(6, 0, 6, 0);
            lblStoragePeriod.Name = "lblStoragePeriod";
            lblStoragePeriod.Size = new Size(169, 32);
            lblStoragePeriod.TabIndex = 6;
            lblStoragePeriod.Text = "Storage Period";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblStoragePeriod);
            panel1.Controls.Add(lblDateReceived);
            panel1.Controls.Add(lblPawnValue);
            panel1.Controls.Add(lblEstimatedValue);
            panel1.Controls.Add(lblProductName);
            panel1.Controls.Add(lblContactInfo);
            panel1.Controls.Add(lblClientName);
            panel1.Location = new Point(159, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 431);
            panel1.TabIndex = 7;
            // 
            // ProductDetailsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 566);
            Controls.Add(panel1);
            Margin = new Padding(6, 8, 6, 8);
            MinimumSize = new Size(659, 637);
            Name = "ProductDetailsForm";
            Text = "Деталі товару";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
    }
}