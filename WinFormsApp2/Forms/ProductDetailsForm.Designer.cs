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
            SuspendLayout();
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Location = new Point(16, 14);
            lblClientName.Margin = new Padding(4, 0, 4, 0);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(91, 20);
            lblClientName.TabIndex = 0;
            lblClientName.Text = "Client Name";
            // 
            // lblContactInfo
            // 
            lblContactInfo.AutoSize = true;
            lblContactInfo.Location = new Point(16, 49);
            lblContactInfo.Margin = new Padding(4, 0, 4, 0);
            lblContactInfo.Name = "lblContactInfo";
            lblContactInfo.Size = new Size(90, 20);
            lblContactInfo.TabIndex = 1;
            lblContactInfo.Text = "Contact Info";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(16, 85);
            lblProductName.Margin = new Padding(4, 0, 4, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(104, 20);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Product Name";
            // 
            // lblEstimatedValue
            // 
            lblEstimatedValue.AutoSize = true;
            lblEstimatedValue.Location = new Point(16, 120);
            lblEstimatedValue.Margin = new Padding(4, 0, 4, 0);
            lblEstimatedValue.Name = "lblEstimatedValue";
            lblEstimatedValue.Size = new Size(115, 20);
            lblEstimatedValue.TabIndex = 3;
            lblEstimatedValue.Text = "Estimated Value";
            // 
            // lblPawnValue
            // 
            lblPawnValue.AutoSize = true;
            lblPawnValue.Location = new Point(16, 155);
            lblPawnValue.Margin = new Padding(4, 0, 4, 0);
            lblPawnValue.Name = "lblPawnValue";
            lblPawnValue.Size = new Size(83, 20);
            lblPawnValue.TabIndex = 4;
            lblPawnValue.Text = "Pawn Value";
            // 
            // lblDateReceived
            // 
            lblDateReceived.AutoSize = true;
            lblDateReceived.Location = new Point(16, 191);
            lblDateReceived.Margin = new Padding(4, 0, 4, 0);
            lblDateReceived.Name = "lblDateReceived";
            lblDateReceived.Size = new Size(105, 20);
            lblDateReceived.TabIndex = 5;
            lblDateReceived.Text = "Date Received";
            // 
            // lblStoragePeriod
            // 
            lblStoragePeriod.AutoSize = true;
            lblStoragePeriod.Location = new Point(16, 226);
            lblStoragePeriod.Margin = new Padding(4, 0, 4, 0);
            lblStoragePeriod.Name = "lblStoragePeriod";
            lblStoragePeriod.Size = new Size(107, 20);
            lblStoragePeriod.TabIndex = 6;
            lblStoragePeriod.Text = "Storage Period";
            // 
            // ProductDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 495);
            Controls.Add(lblStoragePeriod);
            Controls.Add(lblDateReceived);
            Controls.Add(lblPawnValue);
            Controls.Add(lblEstimatedValue);
            Controls.Add(lblProductName);
            Controls.Add(lblContactInfo);
            Controls.Add(lblClientName);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ProductDetailsForm";
            Text = "Product Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}