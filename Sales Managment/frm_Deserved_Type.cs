using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Sales_Managment
{
    public partial class frm_Deserved_Type : DevExpress.XtraEditors.XtraForm
    {
        public frm_Deserved_Type()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void autoNumber()
        {
            //دالة لملئ خانة الايدي و للترقيم التلقائي 
            tbl.Clear();
            tbl = db.readData("select max (Des_Id) from Deserved_Type", string.Empty);

            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {
                txtId.Text = "1";
            }
            else
            {
                txtId.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }

            txtName.Clear();
            txtName.Select();
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
            tbl = db.readData("select * from Deserved_Type", string.Empty);

            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لا يوجد بيانات في هذه الشاشة");
            }
            else
            {
                txtId.Text = tbl.Rows[row][0].ToString();
                txtName.Text = tbl.Rows[row][1].ToString();
            }
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
            btnSave.Enabled = true;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("من فضلك ادخل اسم النوع");
                return;
            }
            else
            {
                db.excuteData("insert into Deserved_Type Values (" + txtId.Text + ",'" + txtName.Text + "')", "تم الادخال بنجاح");
                autoNumber();
            }
        }

        private void frm_Deserved_Type_Load(object sender, EventArgs e)
        {
            autoNumber();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select count (Des_Id) from Deserved_Type", string.Empty);
            row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select count (Des_Id) from Deserved_Type", string.Empty);
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

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (row == 0)
            {
                tbl.Clear();
                tbl = db.readData("select count (Des_Id) from Deserved_Type", string.Empty);
                row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
                show();
            }
            else
            {
                row--;
                show();
            }
        }

        private void btnFiest_Click(object sender, EventArgs e)
        {
            row = 0;
            show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            autoNumber();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("يرجى ادخال اسم النوع");
                return;
            }
            else
            {
                db.readData("update Deserved_Type set Sup_Name = '" + txtName.Text + "' where Des_Id = " + txtId.Text + " ", "تم تعديل البيانات بنجاح");
                autoNumber();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" هل انت متأكد من مسح النوع", "تاكيد ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Deserved_Type where Des_Id = " + txtId.Text + string.Empty, "تم مسح النوع بنجاح");
                autoNumber();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" هل انت متأكد من مسح جميع البيانات", "تاكيد ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Deserved_Type", "تم مسح جميع البيانات بنجاح");
                autoNumber();
            }
        }
    }
}