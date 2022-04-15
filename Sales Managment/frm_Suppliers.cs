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
    public partial class frm_Suppliers : DevExpress.XtraEditors.XtraForm
    {
        public frm_Suppliers()
        {
            InitializeComponent();
        }


        Database db = new Database();
        DataTable tbl = new DataTable();
        private void autoNumber()
        {
            //دالة لملئ خانة الايدي و للترقيم التلقائي 
            tbl.Clear();
            tbl = db.readData("select max (Sup_Id) from Suppliers", "");

            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {
                txtId.Text = "1";
            }
            else
            {
                txtId.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }

            txtName.Clear();
            txtPhone.Clear();
            txtNotes.Clear();
            txtAddress.Clear();
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
                tbl = db.readData("select * from Suppliers", "");

                if (tbl.Rows.Count <= 0)
                {
                    MessageBox.Show("لا يوجد بيانات في هذه الشاشة");
                }
                else
                {
                    txtId.Text = tbl.Rows[row][0].ToString();
                    txtName.Text = tbl.Rows[row][1].ToString();
                    txtAddress.Text = tbl.Rows[row][2].ToString();
                    txtPhone.Text = tbl.Rows[row][3].ToString();
                    txtNotes.Text = tbl.Rows[row][4].ToString();
                }
                btnAdd.Enabled = false;
                btnNew.Enabled = true;
                btnDelete.Enabled = true;
                btnDeleteAll.Enabled = true;
                btnSave.Enabled = true;
            }

        

        private void frm_Suppliers_Load(object sender, EventArgs e)
        {
            autoNumber();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المورد");
                return;
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("من فضلك ادخل رقم المورد");
                return;
            }
            else
            {
                db.excuteData("insert into Suppliers Values (" + txtId.Text + ",'" + txtName.Text + "','"
                               + txtAddress.Text + "','" + txtPhone.Text + "','" + txtNotes.Text + "')", "تم الادخال بنجاح");
                autoNumber();
            }

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
                tbl = db.readData("select count (Sup_Id) from Suppliers", "");
                row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
                show();
            }
            else
            {
                row--;
                show();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select count (Sup_Id) from Suppliers", "");
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

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select count (Sup_Id) from Suppliers", "");
            row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            autoNumber();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("يرجى ادخال اسم المورد");
                return;
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("يرجى ادخال رقم المورد");
                return;
            }
            else
            {
                db.readData("update Suppliers set Sup_Name = '" + txtName.Text + "' , Sup_Adderes = '" + txtAddress.Text + "' , Sup_Phone = '" + txtPhone.Text + "' , Notes = '" + txtNotes.Text + "' where Sup_Id = " + txtId.Text + " ", "تم تعديل البيانات بنجاح");
                autoNumber();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" هل انت متأكد من مسح بيانات المورد", "تاكيد ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Suppliers where Sup_Id = " + txtId.Text + "", "تم مسح المورد بنجاح");
                autoNumber();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" هل انت متأكد من مسح جميع البيانات", "تاكيد ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Suppliers", "تم مسح جميع العملاء بنجاح");
                autoNumber();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            DataTable tblSearch = new DataTable();
            tblSearch.Clear();
            tblSearch = db.readData("select * from Suppliers where Sup_Name like '%" + txtSearch.Text + "%'", "");
            try
            {
                txtId.Text = tblSearch.Rows[0][0].ToString();
                txtName.Text = tblSearch.Rows[0][1].ToString();
                txtAddress.Text = tblSearch.Rows[0][2].ToString();
                txtPhone.Text = tblSearch.Rows[0][3].ToString();
                txtNotes.Text = tblSearch.Rows[0][4].ToString();
            }
            catch (Exception)
            {


            }


            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
            btnSave.Enabled = true;

        }

        private void frm_Suppliers_FormClosing(object sender, FormClosingEventArgs e)
        {
            try 
            {
                Frm_Buy.GetFormBuy.FillSuppliers();
            }
            catch (Exception) 
            { }

        }
    }
}