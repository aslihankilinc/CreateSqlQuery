namespace Guncelleme
{
    partial class Form1
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
            DevExpress.XtraEditors.Controls.CheckedListBoxItem checkedListBoxItem1 = new DevExpress.XtraEditors.Controls.CheckedListBoxItem();
            DevExpress.XtraEditors.Controls.CheckedListBoxItem checkedListBoxItem2 = new DevExpress.XtraEditors.Controls.CheckedListBoxItem();
            DevExpress.XtraEditors.Controls.CheckedListBoxItem checkedListBoxItem3 = new DevExpress.XtraEditors.Controls.CheckedListBoxItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkSut = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.chkTablo = new DevExpress.XtraEditors.LookUpEdit();
            this.chckDb = new DevExpress.XtraEditors.LookUpEdit();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtKul = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnGetir = new DevExpress.XtraEditors.SimpleButton();
            this.txtSunucu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkProcedur = new System.Windows.Forms.CheckBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtSorgu = new System.Windows.Forms.RichTextBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chkSorgu = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkSut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTablo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chckDb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKul.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSunucu.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSorgu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkSut);
            this.panel1.Controls.Add(this.chkTablo);
            this.panel1.Controls.Add(this.chckDb);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.txtKul);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.btnGetir);
            this.panel1.Controls.Add(this.txtSunucu);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 223);
            this.panel1.TabIndex = 0;
            // 
            // chkSut
            // 
            this.chkSut.Location = new System.Drawing.Point(87, 182);
            this.chkSut.Name = "chkSut";
            // 
            // 
            // 
            this.chkSut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.chkSut.Size = new System.Drawing.Size(237, 20);
            this.chkSut.TabIndex = 16;
            this.chkSut.EditValueChanged += new System.EventHandler(this.chkSut_EditValueChanged);
            // 
            // chkTablo
            // 
            this.chkTablo.Location = new System.Drawing.Point(87, 148);
            this.chkTablo.Name = "chkTablo";
            // 
            // 
            // 
            this.chkTablo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.chkTablo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "DB")});
            this.chkTablo.Properties.NullText = "";
            this.chkTablo.Properties.ShowHeader = false;
            this.chkTablo.Size = new System.Drawing.Size(237, 20);
            this.chkTablo.TabIndex = 15;
            this.chkTablo.EditValueChanged += new System.EventHandler(this.chkTablo_EditValueChanged);
            // 
            // chckDb
            // 
            this.chckDb.Location = new System.Drawing.Point(87, 117);
            this.chckDb.Name = "chckDb";
            // 
            // 
            // 
            this.chckDb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.chckDb.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "DB")});
            this.chckDb.Properties.NullText = "";
            this.chckDb.Properties.ShowHeader = false;
            this.chckDb.Size = new System.Drawing.Size(237, 20);
            this.chckDb.TabIndex = 14;
            this.chckDb.EditValueChanged += new System.EventHandler(this.chckDb_EditValueChanged);
            // 
            // txtSifre
            // 
            this.txtSifre.EditValue = "sapass";
            this.txtSifre.Location = new System.Drawing.Point(87, 90);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(237, 20);
            this.txtSifre.TabIndex = 13;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(12, 89);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 18);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Şifre";
            // 
            // txtKul
            // 
            this.txtKul.EditValue = "sa";
            this.txtKul.Location = new System.Drawing.Point(87, 59);
            this.txtKul.Name = "txtKul";
            this.txtKul.Size = new System.Drawing.Size(237, 20);
            this.txtKul.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 58);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 18);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Kullanıcı";
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(330, 81);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(75, 34);
            this.btnGetir.TabIndex = 9;
            this.btnGetir.Text = "Getir";
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // txtSunucu
            // 
            this.txtSunucu.Location = new System.Drawing.Point(87, 25);
            this.txtSunucu.Name = "txtSunucu";
            this.txtSunucu.Size = new System.Drawing.Size(237, 20);
            this.txtSunucu.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 182);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 18);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Sütunlar";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 151);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 18);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Tablo";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 120);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Veritabanı ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Sunucu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkProcedur);
            this.panel2.Controls.Add(this.panelControl2);
            this.panel2.Controls.Add(this.panelControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 567);
            this.panel2.TabIndex = 1;
            // 
            // chkProcedur
            // 
            this.chkProcedur.AutoSize = true;
            this.chkProcedur.Location = new System.Drawing.Point(23, 99);
            this.chkProcedur.Name = "chkProcedur";
            this.chkProcedur.Size = new System.Drawing.Size(69, 17);
            this.chkProcedur.TabIndex = 2;
            this.chkProcedur.Text = "Procedur";
            this.chkProcedur.UseVisualStyleBackColor = true;
            this.chkProcedur.CheckedChanged += new System.EventHandler(this.chkProcedur_CheckedChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtSorgu);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(149, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(491, 567);
            this.panelControl2.TabIndex = 1;
            // 
            // txtSorgu
            // 
            this.txtSorgu.Location = new System.Drawing.Point(23, 17);
            this.txtSorgu.Name = "txtSorgu";
            this.txtSorgu.Size = new System.Drawing.Size(414, 538);
            this.txtSorgu.TabIndex = 0;
            this.txtSorgu.Text = "";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.chkSorgu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(149, 567);
            this.panelControl1.TabIndex = 0;
            // 
            // chkSorgu
            // 
            this.chkSorgu.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSorgu.Appearance.Options.UseFont = true;
            checkedListBoxItem1.Description = "Insert";
            checkedListBoxItem1.Value = ((short)(0));
            checkedListBoxItem2.Description = "Update";
            checkedListBoxItem2.Value = ((short)(1));
            checkedListBoxItem3.Description = "Select";
            checkedListBoxItem3.Value = ((short)(2));
            this.chkSorgu.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            checkedListBoxItem1,
            checkedListBoxItem2,
            checkedListBoxItem3});
            this.chkSorgu.Location = new System.Drawing.Point(12, 17);
            this.chkSorgu.Name = "chkSorgu";
            this.chkSorgu.Size = new System.Drawing.Size(120, 67);
            this.chkSorgu.TabIndex = 0;
            this.chkSorgu.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxControl1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 790);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "SORGU";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkSut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTablo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chckDb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKul.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSunucu.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSorgu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit txtSunucu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGetir;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.RichTextBox txtSorgu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.CheckedListBoxControl chkSorgu;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtKul;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit chckDb;
        private DevExpress.XtraEditors.LookUpEdit chkTablo;
        private DevExpress.XtraEditors.CheckedComboBoxEdit chkSut;
        private System.Windows.Forms.CheckBox chkProcedur;
    }
}

