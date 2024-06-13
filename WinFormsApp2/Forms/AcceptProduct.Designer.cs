namespace WinFormsApp2.Forms
{
    partial class AcceptProduct
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
            textBoxName = new TextBox();
            labelName = new Label();
            textBoxSurname = new TextBox();
            labelSurname = new Label();
            textBoxContactInfo = new TextBox();
            labelContactInfo = new Label();
            textBoxProductName = new TextBox();
            labelItemName = new Label();
            textBoxEstimatedValue = new TextBox();
            labelEstimatedValue = new Label();
            textBoxPawnValue = new TextBox();
            labelPawnValue = new Label();
            labelDateReceived = new Label();
            labelStoragePeriod = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(351, 21);
            textBoxName.Margin = new Padding(5);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(241, 39);
            textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(17, 26);
            labelName.Margin = new Padding(5, 0, 5, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(60, 32);
            labelName.TabIndex = 1;
            labelName.Text = "Ім'я:";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(351, 69);
            textBoxSurname.Margin = new Padding(5);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(241, 39);
            textBoxSurname.TabIndex = 2;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(17, 74);
            labelSurname.Margin = new Padding(5, 0, 5, 0);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(127, 32);
            labelSurname.TabIndex = 3;
            labelSurname.Text = "Прізвище:";
            // 
            // textBoxContactInfo
            // 
            textBoxContactInfo.Location = new Point(351, 117);
            textBoxContactInfo.Margin = new Padding(5);
            textBoxContactInfo.Name = "textBoxContactInfo";
            textBoxContactInfo.Size = new Size(241, 39);
            textBoxContactInfo.TabIndex = 4;
            // 
            // labelContactInfo
            // 
            labelContactInfo.AutoSize = true;
            labelContactInfo.Location = new Point(17, 122);
            labelContactInfo.Margin = new Padding(5, 0, 5, 0);
            labelContactInfo.Name = "labelContactInfo";
            labelContactInfo.Size = new Size(263, 32);
            labelContactInfo.TabIndex = 5;
            labelContactInfo.Text = "Контактна інформація:";
            // 
            // textBoxProductName
            // 
            textBoxProductName.Location = new Point(351, 165);
            textBoxProductName.Margin = new Padding(5);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(241, 39);
            textBoxProductName.TabIndex = 6;
            // 
            // labelItemName
            // 
            labelItemName.AutoSize = true;
            labelItemName.Location = new Point(17, 170);
            labelItemName.Margin = new Padding(5, 0, 5, 0);
            labelItemName.Name = "labelItemName";
            labelItemName.Size = new Size(166, 32);
            labelItemName.TabIndex = 7;
            labelItemName.Text = "Назва товару:";
            // 
            // textBoxEstimatedValue
            // 
            textBoxEstimatedValue.Location = new Point(351, 213);
            textBoxEstimatedValue.Margin = new Padding(5);
            textBoxEstimatedValue.Name = "textBoxEstimatedValue";
            textBoxEstimatedValue.Size = new Size(241, 39);
            textBoxEstimatedValue.TabIndex = 8;
            // 
            // labelEstimatedValue
            // 
            labelEstimatedValue.AutoSize = true;
            labelEstimatedValue.Location = new Point(17, 218);
            labelEstimatedValue.Margin = new Padding(5, 0, 5, 0);
            labelEstimatedValue.Name = "labelEstimatedValue";
            labelEstimatedValue.Size = new Size(220, 32);
            labelEstimatedValue.TabIndex = 9;
            labelEstimatedValue.Text = "Оціночна вартість:";
            // 
            // textBoxPawnValue
            // 
            textBoxPawnValue.Location = new Point(351, 261);
            textBoxPawnValue.Margin = new Padding(5);
            textBoxPawnValue.Name = "textBoxPawnValue";
            textBoxPawnValue.Size = new Size(241, 39);
            textBoxPawnValue.TabIndex = 10;
            // 
            // labelPawnValue
            // 
            labelPawnValue.AutoSize = true;
            labelPawnValue.Location = new Point(17, 266);
            labelPawnValue.Margin = new Padding(5, 0, 5, 0);
            labelPawnValue.Name = "labelPawnValue";
            labelPawnValue.Size = new Size(203, 32);
            labelPawnValue.TabIndex = 11;
            labelPawnValue.Text = "Сума під заставу:";
            // 
            // labelDateReceived
            // 
            labelDateReceived.AutoSize = true;
            labelDateReceived.Location = new Point(17, 314);
            labelDateReceived.Margin = new Padding(5, 0, 5, 0);
            labelDateReceived.Name = "labelDateReceived";
            labelDateReceived.Size = new Size(133, 32);
            labelDateReceived.TabIndex = 13;
            labelDateReceived.Text = "Дата здачі:";
            // 
            // labelStoragePeriod
            // 
            labelStoragePeriod.AutoSize = true;
            labelStoragePeriod.Location = new Point(17, 362);
            labelStoragePeriod.Margin = new Padding(5, 0, 5, 0);
            labelStoragePeriod.Name = "labelStoragePeriod";
            labelStoragePeriod.Size = new Size(222, 32);
            labelStoragePeriod.TabIndex = 15;
            labelStoragePeriod.Text = "Термін зберігання:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(413, 492);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(179, 48);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Зберегти";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.TextChanged += textBox_TextChanged;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(17, 492);
            btnCancel.Margin = new Padding(5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(179, 48);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(labelStoragePeriod);
            panel1.Controls.Add(labelDateReceived);
            panel1.Controls.Add(textBoxPawnValue);
            panel1.Controls.Add(labelPawnValue);
            panel1.Controls.Add(textBoxEstimatedValue);
            panel1.Controls.Add(labelEstimatedValue);
            panel1.Controls.Add(textBoxProductName);
            panel1.Controls.Add(labelItemName);
            panel1.Controls.Add(textBoxContactInfo);
            panel1.Controls.Add(labelContactInfo);
            panel1.Controls.Add(textBoxSurname);
            panel1.Controls.Add(labelSurname);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(labelName);
            panel1.Location = new Point(199, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(616, 588);
            panel1.TabIndex = 18;
            // 
            // AcceptProduct
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 725);
            Controls.Add(panel1);
            Margin = new Padding(5);
            MinimumSize = new Size(749, 681);
            Name = "AcceptProduct";
            Text = "Прийом товару";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxContactInfo;
        private System.Windows.Forms.Label labelContactInfo;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.TextBox textBoxEstimatedValue;
        private System.Windows.Forms.Label labelEstimatedValue;
        private System.Windows.Forms.TextBox textBoxPawnValue;
        private System.Windows.Forms.Label labelPawnValue;
        private System.Windows.Forms.Label labelDateReceived;
        private System.Windows.Forms.Label labelStoragePeriod;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;

        #endregion

        private Panel panel1;
    }
}