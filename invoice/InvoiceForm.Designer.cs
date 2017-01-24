namespace invoice
{
    partial class InvoiceForm
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
            this.SellerLabel = new System.Windows.Forms.GroupBox();
            this.InputSellerField = new System.Windows.Forms.ComboBox();
            this.BuyerLabel = new System.Windows.Forms.GroupBox();
            this.InputBuyerField = new System.Windows.Forms.ComboBox();
            this.DocumentNumberLabel = new System.Windows.Forms.Label();
            this.DateOfIssueLabel = new System.Windows.Forms.Label();
            this.GoodsTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.CodeOfGoodsLabel = new System.Windows.Forms.Label();
            this.GoodsLabel = new System.Windows.Forms.Label();
            this.UnitLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.UnitPriceNoVATLabel = new System.Windows.Forms.Label();
            this.AmountNoVATLabel = new System.Windows.Forms.Label();
            this.AmountVATLabel = new System.Windows.Forms.Label();
            this.QuantityField = new System.Windows.Forms.TextBox();
            this.UnitPriceNoVATField = new System.Windows.Forms.TextBox();
            this.AmountNoVATField = new System.Windows.Forms.TextBox();
            this.AmountVATField = new System.Windows.Forms.TextBox();
            this.CodeOfGoodsField = new System.Windows.Forms.ComboBox();
            this.GoodsField = new System.Windows.Forms.ComboBox();
            this.UnitField = new System.Windows.Forms.ComboBox();
            this.TypeOfInvoiceField = new System.Windows.Forms.ListBox();
            this.DocumentNumberField = new System.Windows.Forms.ComboBox();
            this.DateOfIssueField = new System.Windows.Forms.DateTimePicker();
            this.VATDateLabel = new System.Windows.Forms.Label();
            this.VATDateField = new System.Windows.Forms.DateTimePicker();
            this.TaxPlaceLabel = new System.Windows.Forms.Label();
            this.TaxPlaceField = new System.Windows.Forms.ComboBox();
            this.IssuingPersonLabel = new System.Windows.Forms.Label();
            this.IssuingPersonField = new System.Windows.Forms.ComboBox();
            this.ReceivingPersonLabel = new System.Windows.Forms.Label();
            this.ReceivingPersonField = new System.Windows.Forms.ComboBox();
            this.WayOfPaymentLabel = new System.Windows.Forms.Label();
            this.WayOfPaymentField = new System.Windows.Forms.ListBox();
            this.AuthorityLabel = new System.Windows.Forms.Label();
            this.AuthorityField = new System.Windows.Forms.ComboBox();
            this.ExplanationLabel = new System.Windows.Forms.Label();
            this.ExplanationField = new System.Windows.Forms.ComboBox();
            this.BankLabel = new System.Windows.Forms.Label();
            this.BankField = new System.Windows.Forms.ComboBox();
            this.BICLabel = new System.Windows.Forms.Label();
            this.BICField = new System.Windows.Forms.ComboBox();
            this.IBANLabel = new System.Windows.Forms.Label();
            this.IBANField = new System.Windows.Forms.ComboBox();
            this.SellerLabel.SuspendLayout();
            this.BuyerLabel.SuspendLayout();
            this.GoodsTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SellerLabel
            // 
            this.SellerLabel.Controls.Add(this.InputSellerField);
            this.SellerLabel.Location = new System.Drawing.Point(12, 12);
            this.SellerLabel.Name = "SellerLabel";
            this.SellerLabel.Size = new System.Drawing.Size(368, 66);
            this.SellerLabel.TabIndex = 31;
            this.SellerLabel.TabStop = false;
            this.SellerLabel.Text = "Продавач";
            this.SellerLabel.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // InputSellerField
            // 
            this.InputSellerField.FormattingEnabled = true;
            this.InputSellerField.Location = new System.Drawing.Point(8, 27);
            this.InputSellerField.Name = "InputSellerField";
            this.InputSellerField.Size = new System.Drawing.Size(354, 24);
            this.InputSellerField.TabIndex = 0;
            // 
            // BuyerLabel
            // 
            this.BuyerLabel.Controls.Add(this.InputBuyerField);
            this.BuyerLabel.Location = new System.Drawing.Point(646, 12);
            this.BuyerLabel.Name = "BuyerLabel";
            this.BuyerLabel.Size = new System.Drawing.Size(449, 66);
            this.BuyerLabel.TabIndex = 32;
            this.BuyerLabel.TabStop = false;
            this.BuyerLabel.Text = "Купувач";
            this.BuyerLabel.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // InputBuyerField
            // 
            this.InputBuyerField.FormattingEnabled = true;
            this.InputBuyerField.Location = new System.Drawing.Point(16, 29);
            this.InputBuyerField.Name = "InputBuyerField";
            this.InputBuyerField.Size = new System.Drawing.Size(426, 24);
            this.InputBuyerField.TabIndex = 2;
            // 
            // DocumentNumberLabel
            // 
            this.DocumentNumberLabel.AutoSize = true;
            this.DocumentNumberLabel.Location = new System.Drawing.Point(293, 102);
            this.DocumentNumberLabel.Name = "DocumentNumberLabel";
            this.DocumentNumberLabel.Size = new System.Drawing.Size(84, 17);
            this.DocumentNumberLabel.TabIndex = 33;
            this.DocumentNumberLabel.Text = "Фактура №";
            // 
            // DateOfIssueLabel
            // 
            this.DateOfIssueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfIssueLabel.Location = new System.Drawing.Point(521, 95);
            this.DateOfIssueLabel.Name = "DateOfIssueLabel";
            this.DateOfIssueLabel.Size = new System.Drawing.Size(76, 38);
            this.DateOfIssueLabel.TabIndex = 34;
            this.DateOfIssueLabel.Text = "Дата на издаване";
            // 
            // GoodsTablePanel
            // 
            this.GoodsTablePanel.ColumnCount = 7;
            this.GoodsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.69405F));
            this.GoodsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.30595F));
            this.GoodsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.GoodsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.GoodsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.GoodsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.GoodsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.GoodsTablePanel.Controls.Add(this.CodeOfGoodsLabel, 0, 0);
            this.GoodsTablePanel.Controls.Add(this.GoodsLabel, 1, 0);
            this.GoodsTablePanel.Controls.Add(this.UnitLabel, 2, 0);
            this.GoodsTablePanel.Controls.Add(this.QuantityLabel, 3, 0);
            this.GoodsTablePanel.Controls.Add(this.UnitPriceNoVATLabel, 4, 0);
            this.GoodsTablePanel.Controls.Add(this.AmountNoVATLabel, 5, 0);
            this.GoodsTablePanel.Controls.Add(this.AmountVATLabel, 6, 0);
            this.GoodsTablePanel.Controls.Add(this.QuantityField, 3, 1);
            this.GoodsTablePanel.Controls.Add(this.UnitPriceNoVATField, 4, 1);
            this.GoodsTablePanel.Controls.Add(this.AmountNoVATField, 5, 1);
            this.GoodsTablePanel.Controls.Add(this.AmountVATField, 6, 1);
            this.GoodsTablePanel.Controls.Add(this.CodeOfGoodsField, 0, 1);
            this.GoodsTablePanel.Controls.Add(this.GoodsField, 1, 1);
            this.GoodsTablePanel.Controls.Add(this.UnitField, 2, 1);
            this.GoodsTablePanel.Location = new System.Drawing.Point(16, 169);
            this.GoodsTablePanel.Name = "GoodsTablePanel";
            this.GoodsTablePanel.RowCount = 2;
            this.GoodsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.GoodsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.GoodsTablePanel.Size = new System.Drawing.Size(1072, 133);
            this.GoodsTablePanel.TabIndex = 9;
            this.GoodsTablePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // CodeOfGoodsLabel
            // 
            this.CodeOfGoodsLabel.AutoEllipsis = true;
            this.CodeOfGoodsLabel.Location = new System.Drawing.Point(3, 0);
            this.CodeOfGoodsLabel.Name = "CodeOfGoodsLabel";
            this.CodeOfGoodsLabel.Size = new System.Drawing.Size(129, 25);
            this.CodeOfGoodsLabel.TabIndex = 35;
            this.CodeOfGoodsLabel.Text = "Код на стоката/услугата";
            this.CodeOfGoodsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CodeOfGoodsLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // GoodsLabel
            // 
            this.GoodsLabel.Location = new System.Drawing.Point(138, 0);
            this.GoodsLabel.Name = "GoodsLabel";
            this.GoodsLabel.Size = new System.Drawing.Size(291, 25);
            this.GoodsLabel.TabIndex = 36;
            this.GoodsLabel.Text = "Стока/услуга";
            this.GoodsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GoodsLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // UnitLabel
            // 
            this.UnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnitLabel.Location = new System.Drawing.Point(510, 0);
            this.UnitLabel.Name = "UnitLabel";
            this.UnitLabel.Size = new System.Drawing.Size(62, 25);
            this.UnitLabel.TabIndex = 37;
            this.UnitLabel.Text = "Мерна единица";
            this.UnitLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.Location = new System.Drawing.Point(579, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(110, 17);
            this.QuantityLabel.TabIndex = 38;
            this.QuantityLabel.Text = "Количество";
            this.QuantityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UnitPriceNoVATLabel
            // 
            this.UnitPriceNoVATLabel.Location = new System.Drawing.Point(703, 0);
            this.UnitPriceNoVATLabel.Name = "UnitPriceNoVATLabel";
            this.UnitPriceNoVATLabel.Size = new System.Drawing.Size(119, 25);
            this.UnitPriceNoVATLabel.TabIndex = 39;
            this.UnitPriceNoVATLabel.Text = "Единична цена без ДДС";
            this.UnitPriceNoVATLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AmountNoVATLabel
            // 
            this.AmountNoVATLabel.Location = new System.Drawing.Point(835, 0);
            this.AmountNoVATLabel.Name = "AmountNoVATLabel";
            this.AmountNoVATLabel.Size = new System.Drawing.Size(106, 17);
            this.AmountNoVATLabel.TabIndex = 40;
            this.AmountNoVATLabel.Text = "Сума без ДДС";
            // 
            // AmountVATLabel
            // 
            this.AmountVATLabel.Location = new System.Drawing.Point(962, 0);
            this.AmountVATLabel.Name = "AmountVATLabel";
            this.AmountVATLabel.Size = new System.Drawing.Size(90, 25);
            this.AmountVATLabel.TabIndex = 41;
            this.AmountVATLabel.Text = "Сума с ДДС";
            this.AmountVATLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QuantityField
            // 
            this.QuantityField.Location = new System.Drawing.Point(579, 28);
            this.QuantityField.Name = "QuantityField";
            this.QuantityField.Size = new System.Drawing.Size(100, 22);
            this.QuantityField.TabIndex = 8;
            // 
            // UnitPriceNoVATField
            // 
            this.UnitPriceNoVATField.Location = new System.Drawing.Point(703, 28);
            this.UnitPriceNoVATField.Name = "UnitPriceNoVATField";
            this.UnitPriceNoVATField.Size = new System.Drawing.Size(116, 22);
            this.UnitPriceNoVATField.TabIndex = 9;
            // 
            // AmountNoVATField
            // 
            this.AmountNoVATField.Location = new System.Drawing.Point(835, 28);
            this.AmountNoVATField.Name = "AmountNoVATField";
            this.AmountNoVATField.Size = new System.Drawing.Size(100, 22);
            this.AmountNoVATField.TabIndex = 10;
            // 
            // AmountVATField
            // 
            this.AmountVATField.Location = new System.Drawing.Point(962, 28);
            this.AmountVATField.Name = "AmountVATField";
            this.AmountVATField.Size = new System.Drawing.Size(87, 22);
            this.AmountVATField.TabIndex = 11;
            this.AmountVATField.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // CodeOfGoodsField
            // 
            this.CodeOfGoodsField.FormattingEnabled = true;
            this.CodeOfGoodsField.Location = new System.Drawing.Point(3, 28);
            this.CodeOfGoodsField.Name = "CodeOfGoodsField";
            this.CodeOfGoodsField.Size = new System.Drawing.Size(127, 24);
            this.CodeOfGoodsField.TabIndex = 5;
            // 
            // GoodsField
            // 
            this.GoodsField.FormattingEnabled = true;
            this.GoodsField.Location = new System.Drawing.Point(138, 28);
            this.GoodsField.Name = "GoodsField";
            this.GoodsField.Size = new System.Drawing.Size(344, 24);
            this.GoodsField.TabIndex = 6;
            // 
            // UnitField
            // 
            this.UnitField.FormattingEnabled = true;
            this.UnitField.Location = new System.Drawing.Point(510, 28);
            this.UnitField.Name = "UnitField";
            this.UnitField.Size = new System.Drawing.Size(60, 24);
            this.UnitField.TabIndex = 7;
            // 
            // TypeOfInvoiceField
            // 
            this.TypeOfInvoiceField.FormattingEnabled = true;
            this.TypeOfInvoiceField.ItemHeight = 16;
            this.TypeOfInvoiceField.Location = new System.Drawing.Point(405, 39);
            this.TypeOfInvoiceField.Name = "TypeOfInvoiceField";
            this.TypeOfInvoiceField.Size = new System.Drawing.Size(222, 20);
            this.TypeOfInvoiceField.TabIndex = 1;
            // 
            // DocumentNumberField
            // 
            this.DocumentNumberField.FormattingEnabled = true;
            this.DocumentNumberField.Location = new System.Drawing.Point(383, 99);
            this.DocumentNumberField.Name = "DocumentNumberField";
            this.DocumentNumberField.Size = new System.Drawing.Size(121, 24);
            this.DocumentNumberField.TabIndex = 3;
            // 
            // DateOfIssueField
            // 
            this.DateOfIssueField.Location = new System.Drawing.Point(609, 95);
            this.DateOfIssueField.Name = "DateOfIssueField";
            this.DateOfIssueField.Size = new System.Drawing.Size(200, 22);
            this.DateOfIssueField.TabIndex = 4;
            // 
            // VATDateLabel
            // 
            this.VATDateLabel.AutoSize = true;
            this.VATDateLabel.Location = new System.Drawing.Point(21, 321);
            this.VATDateLabel.Name = "VATDateLabel";
            this.VATDateLabel.Size = new System.Drawing.Size(194, 17);
            this.VATDateLabel.TabIndex = 42;
            this.VATDateLabel.Text = "дата на данъчното събитие";
            // 
            // VATDateField
            // 
            this.VATDateField.Location = new System.Drawing.Point(239, 319);
            this.VATDateField.Name = "VATDateField";
            this.VATDateField.Size = new System.Drawing.Size(200, 22);
            this.VATDateField.TabIndex = 12;
            // 
            // TaxPlaceLabel
            // 
            this.TaxPlaceLabel.AutoSize = true;
            this.TaxPlaceLabel.Location = new System.Drawing.Point(521, 321);
            this.TaxPlaceLabel.Name = "TaxPlaceLabel";
            this.TaxPlaceLabel.Size = new System.Drawing.Size(134, 17);
            this.TaxPlaceLabel.TabIndex = 43;
            this.TaxPlaceLabel.Text = "Място на сделката";
            // 
            // TaxPlaceField
            // 
            this.TaxPlaceField.FormattingEnabled = true;
            this.TaxPlaceField.Location = new System.Drawing.Point(688, 320);
            this.TaxPlaceField.Name = "TaxPlaceField";
            this.TaxPlaceField.Size = new System.Drawing.Size(272, 24);
            this.TaxPlaceField.TabIndex = 13;
            // 
            // IssuingPersonLabel
            // 
            this.IssuingPersonLabel.AutoSize = true;
            this.IssuingPersonLabel.Location = new System.Drawing.Point(19, 363);
            this.IssuingPersonLabel.Name = "IssuingPersonLabel";
            this.IssuingPersonLabel.Size = new System.Drawing.Size(71, 17);
            this.IssuingPersonLabel.TabIndex = 44;
            this.IssuingPersonLabel.Text = "Съставил";
            // 
            // IssuingPersonField
            // 
            this.IssuingPersonField.FormattingEnabled = true;
            this.IssuingPersonField.Location = new System.Drawing.Point(114, 360);
            this.IssuingPersonField.Name = "IssuingPersonField";
            this.IssuingPersonField.Size = new System.Drawing.Size(390, 24);
            this.IssuingPersonField.TabIndex = 14;
            // 
            // ReceivingPersonLabel
            // 
            this.ReceivingPersonLabel.AutoSize = true;
            this.ReceivingPersonLabel.Location = new System.Drawing.Point(525, 361);
            this.ReceivingPersonLabel.Name = "ReceivingPersonLabel";
            this.ReceivingPersonLabel.Size = new System.Drawing.Size(65, 17);
            this.ReceivingPersonLabel.TabIndex = 45;
            this.ReceivingPersonLabel.Text = "Получил";
            // 
            // ReceivingPersonField
            // 
            this.ReceivingPersonField.FormattingEnabled = true;
            this.ReceivingPersonField.Location = new System.Drawing.Point(609, 359);
            this.ReceivingPersonField.Name = "ReceivingPersonField";
            this.ReceivingPersonField.Size = new System.Drawing.Size(479, 24);
            this.ReceivingPersonField.TabIndex = 15;
            // 
            // WayOfPaymentLabel
            // 
            this.WayOfPaymentLabel.AutoSize = true;
            this.WayOfPaymentLabel.Location = new System.Drawing.Point(21, 507);
            this.WayOfPaymentLabel.Name = "WayOfPaymentLabel";
            this.WayOfPaymentLabel.Size = new System.Drawing.Size(133, 17);
            this.WayOfPaymentLabel.TabIndex = 48;
            this.WayOfPaymentLabel.Text = "Начин на плащане";
            // 
            // WayOfPaymentField
            // 
            this.WayOfPaymentField.FormattingEnabled = true;
            this.WayOfPaymentField.ItemHeight = 16;
            this.WayOfPaymentField.Location = new System.Drawing.Point(166, 504);
            this.WayOfPaymentField.Name = "WayOfPaymentField";
            this.WayOfPaymentField.Size = new System.Drawing.Size(186, 20);
            this.WayOfPaymentField.TabIndex = 18;
            // 
            // AuthorityLabel
            // 
            this.AuthorityLabel.AutoSize = true;
            this.AuthorityLabel.Location = new System.Drawing.Point(19, 406);
            this.AuthorityLabel.Name = "AuthorityLabel";
            this.AuthorityLabel.Size = new System.Drawing.Size(166, 17);
            this.AuthorityLabel.TabIndex = 46;
            this.AuthorityLabel.Text = "Основание на сделката";
            this.AuthorityLabel.Click += new System.EventHandler(this.label15_Click);
            // 
            // AuthorityField
            // 
            this.AuthorityField.FormattingEnabled = true;
            this.AuthorityField.Location = new System.Drawing.Point(213, 403);
            this.AuthorityField.Name = "AuthorityField";
            this.AuthorityField.Size = new System.Drawing.Size(875, 24);
            this.AuthorityField.TabIndex = 16;
            // 
            // ExplanationLabel
            // 
            this.ExplanationLabel.AutoSize = true;
            this.ExplanationLabel.Location = new System.Drawing.Point(21, 451);
            this.ExplanationLabel.Name = "ExplanationLabel";
            this.ExplanationLabel.Size = new System.Drawing.Size(159, 17);
            this.ExplanationLabel.TabIndex = 47;
            this.ExplanationLabel.Text = "Описание на сделката";
            // 
            // ExplanationField
            // 
            this.ExplanationField.FormattingEnabled = true;
            this.ExplanationField.Location = new System.Drawing.Point(215, 449);
            this.ExplanationField.Name = "ExplanationField";
            this.ExplanationField.Size = new System.Drawing.Size(873, 24);
            this.ExplanationField.TabIndex = 17;
            // 
            // BankLabel
            // 
            this.BankLabel.AutoSize = true;
            this.BankLabel.Location = new System.Drawing.Point(21, 546);
            this.BankLabel.Name = "BankLabel";
            this.BankLabel.Size = new System.Drawing.Size(48, 17);
            this.BankLabel.TabIndex = 49;
            this.BankLabel.Text = "Банка";
            // 
            // BankField
            // 
            this.BankField.FormattingEnabled = true;
            this.BankField.Location = new System.Drawing.Point(87, 544);
            this.BankField.Name = "BankField";
            this.BankField.Size = new System.Drawing.Size(466, 24);
            this.BankField.TabIndex = 19;
            // 
            // BICLabel
            // 
            this.BICLabel.AutoSize = true;
            this.BICLabel.Location = new System.Drawing.Point(584, 547);
            this.BICLabel.Name = "BICLabel";
            this.BICLabel.Size = new System.Drawing.Size(29, 17);
            this.BICLabel.TabIndex = 50;
            this.BICLabel.Text = "BIC";
            // 
            // BICField
            // 
            this.BICField.FormattingEnabled = true;
            this.BICField.Location = new System.Drawing.Point(633, 545);
            this.BICField.Name = "BICField";
            this.BICField.Size = new System.Drawing.Size(195, 24);
            this.BICField.TabIndex = 20;
            // 
            // IBANLabel
            // 
            this.IBANLabel.AutoSize = true;
            this.IBANLabel.Location = new System.Drawing.Point(21, 589);
            this.IBANLabel.Name = "IBANLabel";
            this.IBANLabel.Size = new System.Drawing.Size(39, 17);
            this.IBANLabel.TabIndex = 51;
            this.IBANLabel.Text = "IBAN";
            // 
            // IBANField
            // 
            this.IBANField.FormattingEnabled = true;
            this.IBANField.Location = new System.Drawing.Point(82, 586);
            this.IBANField.Name = "IBANField";
            this.IBANField.Size = new System.Drawing.Size(509, 24);
            this.IBANField.TabIndex = 21;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 635);
            this.Controls.Add(this.IBANField);
            this.Controls.Add(this.IBANLabel);
            this.Controls.Add(this.BICField);
            this.Controls.Add(this.BICLabel);
            this.Controls.Add(this.BankField);
            this.Controls.Add(this.BankLabel);
            this.Controls.Add(this.ExplanationField);
            this.Controls.Add(this.ExplanationLabel);
            this.Controls.Add(this.AuthorityField);
            this.Controls.Add(this.AuthorityLabel);
            this.Controls.Add(this.WayOfPaymentField);
            this.Controls.Add(this.WayOfPaymentLabel);
            this.Controls.Add(this.ReceivingPersonField);
            this.Controls.Add(this.ReceivingPersonLabel);
            this.Controls.Add(this.IssuingPersonField);
            this.Controls.Add(this.IssuingPersonLabel);
            this.Controls.Add(this.TaxPlaceField);
            this.Controls.Add(this.TaxPlaceLabel);
            this.Controls.Add(this.VATDateField);
            this.Controls.Add(this.VATDateLabel);
            this.Controls.Add(this.DateOfIssueField);
            this.Controls.Add(this.DocumentNumberField);
            this.Controls.Add(this.TypeOfInvoiceField);
            this.Controls.Add(this.GoodsTablePanel);
            this.Controls.Add(this.DateOfIssueLabel);
            this.Controls.Add(this.DocumentNumberLabel);
            this.Controls.Add(this.BuyerLabel);
            this.Controls.Add(this.SellerLabel);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SellerLabel.ResumeLayout(false);
            this.BuyerLabel.ResumeLayout(false);
            this.GoodsTablePanel.ResumeLayout(false);
            this.GoodsTablePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox SellerLabel;
        private System.Windows.Forms.GroupBox BuyerLabel;
        private System.Windows.Forms.Label DocumentNumberLabel;
        private System.Windows.Forms.Label DateOfIssueLabel;
        private System.Windows.Forms.TableLayoutPanel GoodsTablePanel;
        private System.Windows.Forms.Label CodeOfGoodsLabel;
        private System.Windows.Forms.Label GoodsLabel;
        private System.Windows.Forms.Label UnitLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label UnitPriceNoVATLabel;
        private System.Windows.Forms.Label AmountNoVATLabel;
        private System.Windows.Forms.Label AmountVATLabel;
        private System.Windows.Forms.ComboBox InputSellerField;
        private System.Windows.Forms.ComboBox InputBuyerField;
        private System.Windows.Forms.TextBox QuantityField;
        private System.Windows.Forms.TextBox UnitPriceNoVATField;
        private System.Windows.Forms.TextBox AmountNoVATField;
        private System.Windows.Forms.TextBox AmountVATField;
        private System.Windows.Forms.ComboBox CodeOfGoodsField;
        private System.Windows.Forms.ComboBox GoodsField;
        private System.Windows.Forms.ComboBox UnitField;
        private System.Windows.Forms.ListBox TypeOfInvoiceField;
        private System.Windows.Forms.ComboBox DocumentNumberField;
        private System.Windows.Forms.DateTimePicker DateOfIssueField;
        private System.Windows.Forms.Label VATDateLabel;
        private System.Windows.Forms.DateTimePicker VATDateField;
        private System.Windows.Forms.Label TaxPlaceLabel;
        private System.Windows.Forms.ComboBox TaxPlaceField;
        private System.Windows.Forms.Label IssuingPersonLabel;
        private System.Windows.Forms.ComboBox IssuingPersonField;
        private System.Windows.Forms.Label ReceivingPersonLabel;
        private System.Windows.Forms.ComboBox ReceivingPersonField;
        private System.Windows.Forms.Label WayOfPaymentLabel;
        private System.Windows.Forms.ListBox WayOfPaymentField;
        private System.Windows.Forms.Label AuthorityLabel;
        private System.Windows.Forms.ComboBox AuthorityField;
        private System.Windows.Forms.Label ExplanationLabel;
        private System.Windows.Forms.ComboBox ExplanationField;
        private System.Windows.Forms.Label BankLabel;
        private System.Windows.Forms.ComboBox BankField;
        private System.Windows.Forms.Label BICLabel;
        private System.Windows.Forms.ComboBox BICField;
        private System.Windows.Forms.Label IBANLabel;
        private System.Windows.Forms.ComboBox IBANField;
    }
}

