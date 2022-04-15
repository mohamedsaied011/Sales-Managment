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
    public partial class frm_Products : DevExpress.XtraEditors.XtraForm
    {
        public frm_Products()
        {
            InitializeComponent();
        }

        Database db = new Database();
        DataTable tbl = new DataTable();
        private void autoNumber()
        {
            //دالة لملئ خانة الايدي و للترقيم التلقائي 
            tbl.Clear();
            tbl = db.readData("select max (Pro_Id) from Products", "");

            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {
                txtId.Text = "1";
            }
            else
            {
                txtId.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }


            txtBarcode.Clear();
            txtProName.Clear();
            txtProNameSearch.Clear();
            nudBuyPrice.Value = 1;
            nudSalePrice.Value = 1;
            nudMaxDiscount.Value = 0;
            nudMinQty.Value = 0;
            nudQty.Value = 0;
            FillPro();
            try
            {
                cbxProducts.SelectedIndex = 0;
            }
            catch (Exception)
            {


            }

            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            btnSave.Enabled = false;


        }

        private void FillPro()

        {
            cbxProducts.DataSource = db.readData("select * from Products", "");
            cbxProducts.DisplayMember = "Pro_Name";
            cbxProducts.ValueMember = "Pro_Id";
        }
        int row;
        // دالة لعرض البيانات
        private void show()
        {
            tbl.Clear();
            tbl = db.readData("select * from Products", "");

            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لا يوجد بيانات في هذه الشاشة");
            }
            else
            {
                txtId.Text = tbl.Rows[row][0].ToString();
                txtProName.Text = tbl.Rows[row][1].ToString();
                nudQty.Value = Convert.ToDecimal(tbl.Rows[row][2]);
                nudBuyPrice.Value = Convert.ToDecimal(tbl.Rows[row][3]);
                nudSalePrice.Value = Convert.ToDecimal(tbl.Rows[row][4]);
                txtBarcode.Text = tbl.Rows[row][5].ToString();
                nudMinQty.Value = Convert.ToDecimal(tbl.Rows[row][6]);
                nudMaxDiscount.Value = Convert.ToDecimal(tbl.Rows[row][7]);
            }
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
            btnSave.Enabled = true;
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_Products_Load(object sender, EventArgs e)
        {
            try
            {
                autoNumber();
            }
            catch (Exception)
            {


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
                tbl = db.readData("select count (Pro_Name) from Products", "");
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
            tbl = db.readData("select count (Pro_Name) from Products", "");
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
            tbl = db.readData("select count (Pro_Name) from Products", "");
            row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            autoNumber();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProName.Text == "")
            {
                MessageBox.Show("  من فضلك ادخل اسم المنتج اولا");
                return;
            }
            if (nudBuyPrice.Value <= 0)
            {
                MessageBox.Show(" لا يمكن ان يكون سعر الشراء اقل من 1");
                return;
            }
            if (nudSalePrice.Value <= 0)
            {
                MessageBox.Show(" لا يمكن ان يكون سعر البيع اقل من 1");
                return;
            }
            if (nudMaxDiscount.Value >= nudSalePrice.Value)
            {
                MessageBox.Show(" لا يمكن ان يكون الخصم المسموح اقل من سعر البيع");
                return;
            }
            if (nudBuyPrice.Value > nudSalePrice.Value)
            {
                MessageBox.Show(" لا يمكن ان يكون سعر الشراء اكبر من سعر البيع");
                return;
            }
            if (nudMinQty.Value > nudQty.Value)
            {
                MessageBox.Show(" لا يمكن ان يكون حد الطلب اكبر من الكمية المطلوبة");
                return;
            }

            else
            {
                db.excuteData("insert into Products Values (" + txtId.Text + ", '" + txtProName.Text + "', " + nudQty.Value + ", " + nudBuyPrice.Value + ", " + nudSalePrice.Value + ", '" + txtBarcode.Text + "', " + nudMinQty.Value + ", " + nudMaxDiscount.Value + ")", "تم الادخال بنجاح");
                autoNumber();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProName.Text == "")
            {
                MessageBox.Show("  من فضلك ادخل اسم المنتج اولا");
                return;
            }
            if (nudBuyPrice.Value <= 0)
            {
                MessageBox.Show(" لا يمكن ان يكون سعر الشراء اقل من 1");
                return;
            }
            if (nudSalePrice.Value <= 0)
            {
                MessageBox.Show(" لا يمكن ان يكون سعر البيع اقل من 1");
                return;
            }
            if (nudMaxDiscount.Value >= nudSalePrice.Value)
            {
                MessageBox.Show(" لا يمكن ان يكون الخصم المسموح اقل من سعر البيع");
                return;
            }
            if (nudBuyPrice.Value > nudSalePrice.Value)
            {
                MessageBox.Show(" لا يمكن ان يكون سعر الشراء اكبر من سعر البيع");
                return;
            }
            if (nudMinQty.Value > nudQty.Value)
            {
                MessageBox.Show(" لا يمكن ان يكون حد الطلب اكبر من الكمية المطلوبة");
                return;
            }

            else
            {
                db.excuteData("update Products set  Pro_Name = '" + txtProName.Text + "' , Qty = " + nudQty.Value + " , Buy_Price = " + nudBuyPrice.Value + ", Sale_Price = " + nudSalePrice.Value + " , Barcode = '" + txtBarcode.Text + "', MinQty = " + nudMinQty.Value + " , MaxDiscount = " + nudMaxDiscount.Value + "  where  Pro_Id =" + txtId.Text + " ", "تم تعديل البيانات بنجاح");
                autoNumber();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" هل انت متأكد من مسح بيانات المنتج ", "تاكيد ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Products where Pro_Id = " + txtId.Text + "", "تم مسح البيانات بنجاح");
                autoNumber();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" هل انت متأكد من مسح  جميع المنتجات", "تاكيد ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                db.readData("delete from Products ", "تم مسح البيانات بنجاح");
            autoNumber();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtProNameSearch.Text != "")
            {
                DataTable tblSearch = new DataTable();
                tblSearch.Clear();

                tblSearch = db.readData("select * from Products where Pro_Name Like '%" + txtProNameSearch.Text + "%' ", "");

                if (tblSearch.Rows.Count <= 0)
                {
                    MessageBox.Show("لا يوجد منتج بهذا الاسم");
                }
                else
                {
                    txtId.Text = tblSearch.Rows[0][0].ToString();
                    txtProName.Text = tblSearch.Rows[0][1].ToString();
                    nudQty.Value = Convert.ToDecimal(tblSearch.Rows[0][2]);
                    nudBuyPrice.Value = Convert.ToDecimal(tblSearch.Rows[0][3]);
                    nudSalePrice.Value = Convert.ToDecimal(tblSearch.Rows[0][4]);
                    txtBarcode.Text = tblSearch.Rows[0][5].ToString();
                    nudMinQty.Value = Convert.ToDecimal(tblSearch.Rows[0][6]);
                    nudMaxDiscount.Value = Convert.ToDecimal(tblSearch.Rows[0][7]);
                }
                btnAdd.Enabled = false;
                btnNew.Enabled = true;
                btnDelete.Enabled = true;
                btnDeleteAll.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void cbxProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxProducts.Items.Count >= 1)
            {
                DataTable tblSearch = new DataTable();
                tblSearch.Clear();

                tblSearch = db.readData("select * from Products where Pro_Id  = " + cbxProducts.SelectedValue + " ", "");


                txtId.Text = tblSearch.Rows[0][0].ToString();
                txtProName.Text = tblSearch.Rows[0][1].ToString();
                nudQty.Value = Convert.ToDecimal(tblSearch.Rows[0][2]);
                nudBuyPrice.Value = Convert.ToDecimal(tblSearch.Rows[0][3]);
                nudSalePrice.Value = Convert.ToDecimal(tblSearch.Rows[0][4]);
                txtBarcode.Text = tblSearch.Rows[0][5].ToString();
                nudMinQty.Value = Convert.ToDecimal(tblSearch.Rows[0][6]);
                nudMaxDiscount.Value = Convert.ToDecimal(tblSearch.Rows[0][7]);
            }
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
            btnSave.Enabled = true;

        }
    }
}