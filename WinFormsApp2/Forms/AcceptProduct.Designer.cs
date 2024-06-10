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
            textBoxDateReceived = new TextBox();
            labelDateReceived = new Label();
            textBoxStoragePeriod = new TextBox();
            labelStoragePeriod = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(220, 15);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(150, 27);
            textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(15, 18);
            labelName.Name = "labelName";
            labelName.Size = new Size(38, 20);
            labelName.TabIndex = 1;
            labelName.Text = "Ім'я:";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(220, 45);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(150, 27);
            textBoxSurname.TabIndex = 2;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(15, 48);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(80, 20);
            labelSurname.TabIndex = 3;
            labelSurname.Text = "Прізвище:";
            // 
            // textBoxContactInfo
            // 
            textBoxContactInfo.Location = new Point(220, 75);
            textBoxContactInfo.Name = "textBoxContactInfo";
            textBoxContactInfo.Size = new Size(150, 27);
            textBoxContactInfo.TabIndex = 4;
            // 
            // labelContactInfo
            // 
            labelContactInfo.AutoSize = true;
            labelContactInfo.Location = new Point(15, 78);
            labelContactInfo.Name = "labelContactInfo";
            labelContactInfo.Size = new Size(168, 20);
            labelContactInfo.TabIndex = 5;
            labelContactInfo.Text = "Контактна інформація:";
            // 
            // textBoxProductName
            // 
            textBoxProductName.Location = new Point(220, 105);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(150, 27);
            textBoxProductName.TabIndex = 6;
            // 
            // labelItemName
            // 
            labelItemName.AutoSize = true;
            labelItemName.Location = new Point(15, 108);
            labelItemName.Name = "labelItemName";
            labelItemName.Size = new Size(105, 20);
            labelItemName.TabIndex = 7;
            labelItemName.Text = "Назва товару:";
            // 
            // textBoxEstimatedValue
            // 
            textBoxEstimatedValue.Location = new Point(220, 135);
            textBoxEstimatedValue.Name = "textBoxEstimatedValue";
            textBoxEstimatedValue.Size = new Size(150, 27);
            textBoxEstimatedValue.TabIndex = 8;
            // 
            // labelEstimatedValue
            // 
            labelEstimatedValue.AutoSize = true;
            labelEstimatedValue.Location = new Point(15, 138);
            labelEstimatedValue.Name = "labelEstimatedValue";
            labelEstimatedValue.Size = new Size(139, 20);
            labelEstimatedValue.TabIndex = 9;
            labelEstimatedValue.Text = "Оціночна вартість:";
            // 
            // textBoxPawnValue
            // 
            textBoxPawnValue.Location = new Point(220, 165);
            textBoxPawnValue.Name = "textBoxPawnValue";
            textBoxPawnValue.Size = new Size(150, 27);
            textBoxPawnValue.TabIndex = 10;
            // 
            // labelPawnValue
            // 
            labelPawnValue.AutoSize = true;
            labelPawnValue.Location = new Point(15, 168);
            labelPawnValue.Name = "labelPawnValue";
            labelPawnValue.Size = new Size(127, 20);
            labelPawnValue.TabIndex = 11;
            labelPawnValue.Text = "Сума під заставу:";
            // 
            // textBoxDateReceived
            // 
            textBoxDateReceived.Location = new Point(220, 195);
            textBoxDateReceived.Name = "textBoxDateReceived";
            textBoxDateReceived.Size = new Size(150, 27);
            textBoxDateReceived.TabIndex = 12;
            // 
            // labelDateReceived
            // 
            labelDateReceived.AutoSize = true;
            labelDateReceived.Location = new Point(15, 198);
            labelDateReceived.Name = "labelDateReceived";
            labelDateReceived.Size = new Size(83, 20);
            labelDateReceived.TabIndex = 13;
            labelDateReceived.Text = "Дата здачі:";
            // 
            // textBoxStoragePeriod
            // 
            textBoxStoragePeriod.Location = new Point(220, 225);
            textBoxStoragePeriod.Name = "textBoxStoragePeriod";
            textBoxStoragePeriod.Size = new Size(150, 27);
            textBoxStoragePeriod.TabIndex = 14;
            // 
            // labelStoragePeriod
            // 
            labelStoragePeriod.AutoSize = true;
            labelStoragePeriod.Location = new Point(15, 228);
            labelStoragePeriod.Name = "labelStoragePeriod";
            labelStoragePeriod.Size = new Size(142, 20);
            labelStoragePeriod.TabIndex = 15;
            labelStoragePeriod.Text = "Термін зберігання:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(260, 328);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 30);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Зберегти";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.TextChanged += textBox_TextChanged;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(73, 328);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 30);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(textBoxStoragePeriod);
            Controls.Add(labelStoragePeriod);
            Controls.Add(textBoxDateReceived);
            Controls.Add(labelDateReceived);
            Controls.Add(textBoxPawnValue);
            Controls.Add(labelPawnValue);
            Controls.Add(textBoxEstimatedValue);
            Controls.Add(labelEstimatedValue);
            Controls.Add(textBoxProductName);
            Controls.Add(labelItemName);
            Controls.Add(textBoxContactInfo);
            Controls.Add(labelContactInfo);
            Controls.Add(textBoxSurname);
            Controls.Add(labelSurname);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Name = "AddForm";
            Text = "Прийом товару";
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxDateReceived;
        private System.Windows.Forms.Label labelDateReceived;
        private System.Windows.Forms.TextBox textBoxStoragePeriod;
        private System.Windows.Forms.Label labelStoragePeriod;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;

        #endregion
    }
}