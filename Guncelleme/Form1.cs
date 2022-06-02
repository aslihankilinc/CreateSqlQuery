using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guncelleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string ConStr = "";
        public static string dbName = "";
        public static string tbName = "";
        public string sorgu = "";
        List<string> Kolon = new List<string>();
        DataTable dtType;
        private void btnGetir_Click(object sender, EventArgs e)
        {
            if (txtKul.Text == "" && txtSifre.Text == "")
                MessageBox.Show("Şifre ve Kullanıcı Adı Gir");
            else
                ConStr = @"Data Source=" + txtSunucu.Text + ";User ID=" + txtKul.Text + ";Password=" + txtSifre.Text + ";";
            chckDb.Properties.DataSource = Dbname();
            chckDb.Properties.ValueMember = "name";
            chckDb.Properties.DisplayMember = "name";
        }
        //(LocalDB)\MSSQLLocalDB
        DataTable Dbname()
        {
            string sql = @"SELECT * FROM sys.databases where name NOT IN
                 ('master', 'model', 'msdb', 'tempdb', 'Resource',
                    'distribution' , 'reportserver', 'reportservertempdb')";
            return SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql).Tables[0];
        }


        private void chckDb_EditValueChanged(object sender, EventArgs e)
        {
            dbName = chckDb.EditValue.ToString();
            ConStr = @"Data Source=" + txtSunucu.Text + ";Database=" + dbName + ";User ID=" + txtKul.Text + ";Password=" + txtSifre.Text + ";";
            chkTablo.Properties.DataSource = Tbname();
            chkTablo.Properties.ValueMember = "name";
            chkTablo.Properties.DisplayMember = "name";
        }

        private void chkTablo_EditValueChanged(object sender, EventArgs e)
        {
            tbName = chkTablo.EditValue.ToString();
            chkSut.Properties.DataSource = stname();
            chkSut.Properties.ValueMember = "name";
            chkSut.Properties.DisplayMember = "name";

        }

        DataTable Tbname()
        {
            string sql = @"SELECT TABLE_NAME as name FROM INFORMATION_SCHEMA.TABLES";
            return SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql).Tables[0];
        }

        DataTable stname()
        {
            string sql = @"SELECT COLUMN_NAME as name FROM INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='" + tbName + "'";
            return SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql).Tables[0];
        }
        DataTable sttype(string colname)
        {
            string sql = @"SELECT  '@'+COLUMN_NAME+'  '+ UPPER(DATA_TYPE)+'('+ CONVERT(varchar,ISNULL(CHARACTER_MAXIMUM_LENGTH,0)) +')'  as colType from " + dbName + ".INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '" + tbName + "' and COLUMN_NAME='"+ colname + "'";
            return SqlHelper.ExecuteDataset(ConStr, CommandType.Text, sql).Tables[0];
        }

        private void chkSut_EditValueChanged(object sender, EventArgs e)
        {
            Kolon.Clear();
            foreach (var item in chkSut.Properties.Items.GetCheckedValues())
            {
                Kolon.Add(chkSut.Properties.Items[item].ToString());
            }
        }

        private void checkedListBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkSorgu.SelectedIndex == 0)
            {
                txtSorgu.Text = Insert();
            }

            else if (chkSorgu.SelectedIndex == 1)
            {
                txtSorgu.Text = Update();
            }

            else if (chkSorgu.SelectedIndex == 2)
            {
                txtSorgu.Text = Select();
            }
        }

        // insert into tblCari(CariID, CariAdivalues(, @CariAdi
        string Insert()
        {
            sorgu = "";
            sorgu = "INSERT INTO " + tbName.ToUpper() + "(" + Kolon[0];

            for (int i = 1; i < Kolon.Count; i++)
            {
                sorgu = sorgu + "," + Kolon[i].ToUpper();
            }
            sorgu = sorgu + ")VALUES(@" + Kolon[0];
            for (int i = 1; i < Kolon.Count; i++)
            {
                sorgu = sorgu + ",@" + Kolon[i].ToUpper();
            }
            sorgu = sorgu + ")";
            return sorgu.ToUpper();
        }

        string Update()
        {
            sorgu = "";
            sorgu = "UPDATE " + tbName.ToUpper() + " SET " + Kolon[0].ToUpper() + "=@" + Kolon[0].ToUpper();

            for (int i = 1; i < Kolon.Count; i++)
            {
                sorgu = sorgu + "," + Kolon[i].ToUpper() + "=";
                sorgu = sorgu + "@" + Kolon[i].ToUpper();
            }

            return sorgu.ToUpper();
        }

        string Select()
        {
            sorgu = "";
            sorgu = "SELECT " + Kolon[0].ToUpper();

            for (int i = 1; i < Kolon.Count; i++)
            {
                sorgu = sorgu + "," + Kolon[i].ToUpper();

            }
            sorgu = sorgu + " from " + tbName.ToUpper();
            return sorgu.ToUpper();
        }
        string Procedur()
        {
            sorgu = "";
           
            for (int i = 0; i < Kolon.Count; i++)
            { dtType = sttype(Kolon[i]);
                 sorgu = sorgu +dtType.Rows[0]["colType"].ToString()+","+ "\n";
            }
            sorgu = sorgu+"\n\n\n";
            sorgu = sorgu+Kolon[0] + "=@" + Kolon[0];

            for (int i = 1; i < Kolon.Count; i++)
            {
                sorgu = sorgu + "," + "\n" + Kolon[i] + "=";
                sorgu = sorgu + "@" + Kolon[i];
            }

            return sorgu.ToUpper();
        }

        private void chkProcedur_CheckedChanged(object sender, EventArgs e)
        {
            txtSorgu.Text = Procedur();
        }

        
    }
}
