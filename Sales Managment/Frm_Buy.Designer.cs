
namespace Sales_Managment
{
    partial class Frm_Buy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Buy));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.cbxSupplier = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbxItems = new System.Windows.Forms.ComboBox();
            this.btnItems = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteItem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSupplierBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvBuy = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblItemsCount = new System.Windows.Forms.Label();
            this.rbtnCash = new System.Windows.Forms.RadioButton();
            this.rbtnAagel = new System.Windows.Forms.RadioButton();
            this.dtpAagel = new System.Windows.Forms.DateTimePicker();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(118, 11);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(173, 39);
            this.txtId.TabIndex = 8;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(36, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 32);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "رقم الفاتورة:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(24, 120);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 32);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "باركود المنتج:";
            this.labelControl2.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(118, 120);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(173, 39);
            this.txtBarcode.TabIndex = 8;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // cbxSupplier
            // 
            this.cbxSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSupplier.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbxSupplier.FormattingEnabled = true;
            this.cbxSupplier.Location = new System.Drawing.Point(442, 18);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.Size = new System.Drawing.Size(173, 40);
            this.cbxSupplier.TabIndex = 14;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(354, 18);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 32);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "اختر مورد:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(354, 120);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 32);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "اختر منتج:";
            // 
            // cbxItems
            // 
            this.cbxItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxItems.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbxItems.FormattingEnabled = true;
            this.cbxItems.Location = new System.Drawing.Point(442, 120);
            this.cbxItems.Name = "cbxItems";
            this.cbxItems.Size = new System.Drawing.Size(173, 40);
            this.cbxItems.TabIndex = 14;
            // 
            // btnItems
            // 
            this.btnItems.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.Appearance.Options.UseFont = true;
            this.btnItems.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnItems.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnItems.Location = new System.Drawing.Point(621, 120);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(49, 40);
            this.btnItems.TabIndex = 15;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Appearance.Options.UseFont = true;
            this.btnDeleteItem.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnDeleteItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.btnDeleteItem.Location = new System.Drawing.Point(735, 119);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(49, 40);
            this.btnDeleteItem.TabIndex = 15;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnSupplierBrowse
            // 
            this.btnSupplierBrowse.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierBrowse.Appearance.Options.UseFont = true;
            this.btnSupplierBrowse.Location = new System.Drawing.Point(621, 18);
            this.btnSupplierBrowse.Name = "btnSupplierBrowse";
            this.btnSupplierBrowse.Size = new System.Drawing.Size(49, 40);
            this.btnSupplierBrowse.TabIndex = 16;
            this.btnSupplierBrowse.Text = "...";
            this.btnSupplierBrowse.Click += new System.EventHandler(this.btnSupplierBrowse_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(877, 122);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(184, 39);
            this.dtpDate.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(676, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 34);
            this.label1.TabIndex = 18;
            this.label1.Text = "F2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(790, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 34);
            this.label2.TabIndex = 18;
            this.label2.Text = "Delete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(297, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 34);
            this.label3.TabIndex = 18;
            this.label3.Text = "F1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(690, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 34);
            this.label4.TabIndex = 18;
            this.label4.Text = "لدفع وحفظ وطباعة الفاتورة اضغط F12";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(690, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 34);
            this.label5.TabIndex = 18;
            this.label5.Text = "لتعديل  الكمية او الخصم اضغط   F11";
            // 
            // dgvBuy
            // 
            this.dgvBuy.AllowUserToAddRows = false;
            this.dgvBuy.AllowUserToDeleteRows = false;
            this.dgvBuy.AllowUserToResizeColumns = false;
            this.dgvBuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBuy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBuy.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuy.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvBuy.GridColor = System.Drawing.SystemColors.Desktop;
            this.dgvBuy.Location = new System.Drawing.Point(-5, 177);
            this.dgvBuy.Name = "dgvBuy";
            this.dgvBuy.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuy.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuy.Size = new System.Drawing.Size(1481, 438);
            this.dgvBuy.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 40F;
            this.Column1.HeaderText = "رقم المنتج";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 80F;
            this.Column2.HeaderText = "اسم المنتج";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 35F;
            this.Column3.HeaderText = "الكمية";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 40F;
            this.Column4.HeaderText = "السعر";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 35F;
            this.Column5.HeaderText = "الخصم ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 70F;
            this.Column6.HeaderText = "الاجمالي";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(12, 635);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 34);
            this.label6.TabIndex = 20;
            this.label6.Text = "اسم المستخدم";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUserName.Location = new System.Drawing.Point(121, 635);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(47, 34);
            this.lblUserName.TabIndex = 20;
            this.lblUserName.Text = ".....";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(12, 675);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 34);
            this.label8.TabIndex = 20;
            this.label8.Text = "عدد الاصناف";
            // 
            // lblItemsCount
            // 
            this.lblItemsCount.AutoSize = true;
            this.lblItemsCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItemsCount.Location = new System.Drawing.Point(121, 675);
            this.lblItemsCount.Name = "lblItemsCount";
            this.lblItemsCount.Size = new System.Drawing.Size(47, 34);
            this.lblItemsCount.TabIndex = 20;
            this.lblItemsCount.Text = ".....";
            // 
            // rbtnCash
            // 
            this.rbtnCash.AutoSize = true;
            this.rbtnCash.Checked = true;
            this.rbtnCash.Location = new System.Drawing.Point(280, 621);
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.Size = new System.Drawing.Size(138, 36);
            this.rbtnCash.TabIndex = 21;
            this.rbtnCash.TabStop = true;
            this.rbtnCash.Text = "دفع الفاتورة كاش";
            this.rbtnCash.UseVisualStyleBackColor = true;
            // 
            // rbtnAagel
            // 
            this.rbtnAagel.AutoSize = true;
            this.rbtnAagel.Location = new System.Drawing.Point(280, 668);
            this.rbtnAagel.Name = "rbtnAagel";
            this.rbtnAagel.Size = new System.Drawing.Size(133, 36);
            this.rbtnAagel.TabIndex = 21;
            this.rbtnAagel.Text = "دفع الفاتورة اجل";
            this.rbtnAagel.UseVisualStyleBackColor = true;
            // 
            // dtpAagel
            // 
            this.dtpAagel.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtpAagel.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAagel.Location = new System.Drawing.Point(557, 666);
            this.dtpAagel.Name = "dtpAagel";
            this.dtpAagel.Size = new System.Drawing.Size(187, 39);
            this.dtpAagel.TabIndex = 17;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(435, 668);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(105, 32);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "تاريخ الاستحقاق:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotal.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(1247, 635);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(229, 65);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(1138, 638);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(103, 32);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "اجمالي المطلوب:";
            // 
            // Frm_Buy
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1488, 716);
            this.Controls.Add(this.rbtnAagel);
            this.Controls.Add(this.rbtnCash);
            this.Controls.Add(this.lblItemsCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvBuy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpAagel);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnSupplierBrowse);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.cbxItems);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cbxSupplier);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Frm_Buy";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عمليات الشراء";
            this.Load += new System.EventHandler(this.Frm_Buy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Buy_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtBarcode;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cbxItems;
        private DevExpress.XtraEditors.SimpleButton btnItems;
        private DevExpress.XtraEditors.SimpleButton btnDeleteItem;
        private DevExpress.XtraEditors.SimpleButton btnSupplierBrowse;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblItemsCount;
        private System.Windows.Forms.RadioButton rbtnCash;
        private System.Windows.Forms.RadioButton rbtnAagel;
        private System.Windows.Forms.DateTimePicker dtpAagel;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtTotal;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        public System.Windows.Forms.ComboBox cbxSupplier;
    }
}