using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Managment
{
    public partial class frm_Deserved : DevExpress.XtraEditors.XtraForm
    {
        public frm_Deserved()
        {
            InitializeComponent();
        }
      
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void autoNumber()
        {
            //دالة لملئ خانة الايدي و للترقيم التلقائي 
            tbl.Clear();
            tbl = db.readData("select max (Des_Id) from Deserved", "");

            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {
                txtId.Text = "1";
            }
            else
            {
                txtId.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            nudPrice.Value = 1;
            dtpDate.Text = DateTime.Now.ToShortDateString();
            txtNote.Clear();
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            btnSave.Enabled = false;


        }
        int row;
        // دالة لعرض البيانات
        private void show()
        {
            tbl.Clear();
            tbl = db.readData("select * from Deserved", "");

            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لا يوجد بيانات في هذه الشاشة");
            }
            else
            {
                txtId.Text = tbl.Rows[row][0].ToString();
                nudPrice.Value = Convert.ToDecimal(tbl.Rows[row][1]);
                this.Text= tbl.Rows[row][2].ToString();
                DateTime dt = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                dtpDate.Value = dt;
                txtNote.Text = tbl.Rows[row][3].ToString();
                cbxType.SelectedValue = Convert.ToDecimal(tbl.Rows[row][4]);

            }
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
            btnSave.Enabled = true;
        }

        private void FillType()

        {
            cbxType.DataSource = db.readData("select * from Deserved_Type", "");
            cbxType.DisplayMember = "Des_Name";
            cbxType.ValueMember = "Des_Id";
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void cbx_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_Deserverd_Load(object sender, EventArgs e)
        {
            autoNumber();
            FillType();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxType.Text == "")
            {
                MessageBox.Show("من فضلك حدد النوع");
                return;
            }
            else
            {
                string d = dtpDate.Value.ToString("dd/MM/yyyy");
                db.excuteData("insert into Deserved Values (" + txtId.Text + ","+nudPrice.Value+ ",'"+ d +"','"+txtNote.Text+"'," + cbxType.SelectedValue + ")", "تم الادخال بنجاح");
                autoNumber();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select count (Des_Id) from Deserved", "");
            row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            show();
        }

        private void btnFiest_Click(object sender, EventArgs e)
        {
            row = 0;
            show();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (row == 0)
            {
                tbl.Clear();
                tbl = db.readData("select count (Des_Id) from Deserved", "");
                row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
                show();
            }
            else
            {
                row--;
                show();
            }
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select count (Des_Id) from Deserved", "");
            if (Convert.ToInt32(tbl.Rows[0][0]) - 1 == row)
            {


                row = 0;
                show();
            }
            else
            {
                row++;
                show();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            autoNumber();
            FillType();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (nudPrice.Value <= 0)
            {
                MessageBox.Show("يجب ان تكون القيمة اكبر من صفر");
                return;
            }
          
            else
            {
                string d = dtpDate.Value.ToString("dd/MM/yyyy");
                db.readData("update Deserved set  Price = " + nudPrice.Value + " , Data = '" + d + "' , Notes = '" + txtNote.Text + "', Type_Id = "+cbxType.SelectedValue+ "   where  Des_Id =" + txtId.Text + " ", "تم تعديل البيانات بنجاح");
                autoNumber();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" هل انت متأكد من مسح بيانات المصروف", "تاكيد ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Deserved where Des_Id = " + txtId.Text + "", "تم مسح المصروف بنجاح");
                autoNumber();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" هل انت متأكد من مسح جميع البيانات ", "تاكيد ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete  from Deserved",  "تم مسح جميع المصروفات بنجاح");
                autoNumber();
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}