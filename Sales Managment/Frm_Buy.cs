using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Sales_Managment
{
    public partial class Frm_Buy : DevExpress.XtraEditors.XtraForm
    {
        // داله للتأثير على فورم من فورم اخرى
        private static Frm_Buy frm;
        static void frm_FrmClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Frm_Buy GetFormBuy
        {
            get
            {

                if (frm == null)
                {
                    frm = new Frm_Buy();
                    frm.FormClosed += new FormClosedEventHandler(frm_FrmClosed);
                }
                return frm;
            }

        }

        public Frm_Buy()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void autoNumber()
        {
            //دالة لملئ خانة الايدي و للترقيم التلقائي 
            tbl.Clear();
            tbl = db.readData("select max (Order_Id) from Buy", string.Empty);

            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {
                txtId.Text = "1";
            }
            else
            {
                txtId.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            // لعرض تاريخ اليوم
            dtpDate.Text = DateTime.Now.ToShortDateString();
            dtpAagel.Text = DateTime.Now.ToShortDateString();
            try
            {
                cbxItems.SelectedIndex = 0;
                cbxSupplier.SelectedIndex = 0;
            }
            catch (Exception)
            {


            }

            FillSuppliers();
            FillItems();
            dgvBuy.Rows.Clear();
            cbxItems.Text = "اختر منتج";
            rbtnCash.Checked = true;
            txtBarcode.Clear();
            txtBarcode.Focus();
            txtTotal.Clear();

        }
        private void FillItems()
        {
            cbxItems.DataSource = db.readData("select * from Products ", string.Empty);
            cbxItems.DisplayMember = "Pro_Name";
            cbxItems.ValueMember = "Pro_Id";
        }
        public void FillSuppliers()
        {
            cbxSupplier.DataSource = db.readData("select * from Suppliers ", string.Empty);
            cbxSupplier.DisplayMember = "Sup_Name";
            cbxSupplier.ValueMember = "Sup_Id";
        }

        private void Frm_Buy_Load(object sender, EventArgs e)
        {
            try
            {
                autoNumber();
            }
            catch (Exception)
            {


            }



        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnSupplierBrowse_Click(object sender, EventArgs e)
        {
            frm_Suppliers frm = new frm_Suppliers();
            frm.ShowDialog();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            if (cbxItems.Text == "اختر منتج")
            {
                MessageBox.Show("من فضلك اختر منتح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbxItems.Items.Count <= 0)
            {
                MessageBox.Show("من فضلك اختر المنتجات اولا", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable tblItems = new DataTable();
            tblItems.Clear();
            tblItems = db.readData("select * from Products where Pro_Id = " + cbxItems.SelectedValue + string.Empty, string.Empty);
            if (tblItems.Rows.Count >= 1)
            {
                try
                {
                    string Product_Id = tblItems.Rows[0][0].ToString();
                    string Product_Name = tblItems.Rows[0][1].ToString();
                    string Product_Qty = "1";
                    string Product_Price = tblItems.Rows[0][3].ToString();
                    decimal Discount = 0;
                    decimal Total = Convert.ToDecimal(Product_Qty) * Convert.ToDecimal(tblItems.Rows[0][3]);
                    dgvBuy.Rows.Add(1);
                    int RowIndex = dgvBuy.Rows.Count - 1;

                    dgvBuy.Rows[RowIndex].Cells[0].Value = Product_Id;
                    dgvBuy.Rows[RowIndex].Cells[1].Value = Product_Name;
                    dgvBuy.Rows[RowIndex].Cells[2].Value = Product_Qty;
                    dgvBuy.Rows[RowIndex].Cells[3].Value = Product_Price;
                    dgvBuy.Rows[RowIndex].Cells[4].Value = Discount;
                    dgvBuy.Rows[RowIndex].Cells[5].Value = Total;


                }
                catch (Exception)
                {


                }


                try
                {
                    decimal TotalOrder = 0;
                    for (int i = 0; i <= dgvBuy.Rows.Count - 1; i++)
                    {
                        TotalOrder += Convert.ToDecimal(dgvBuy.Rows[i].Cells[5].Value);
                    }

                    txtTotal.Text = Math.Round(TotalOrder, 2).ToString();
                    lblItemsCount.Text = (dgvBuy.Rows.Count).ToString();
                }
                catch (Exception)
                {


                }
            }

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvBuy.Rows.Count >= 1)
            {
                int Index = dgvBuy.SelectedRows[0].Index;
                dgvBuy.Rows.RemoveAt(Index);

                if (dgvBuy.Rows.Count <= 0)
                {
                    txtTotal.Text = "0";
                }

                try
                {
                    decimal TotalOrder = 0;
                    for (int i = 0; i <= dgvBuy.Rows.Count - 1; i++)
                    {
                        TotalOrder += Convert.ToDecimal(dgvBuy.Rows[i].Cells[5].Value);
                    }

                    txtTotal.Text = Math.Round(TotalOrder, 2).ToString();
                    lblItemsCount.Text = (dgvBuy.Rows.Count).ToString();
                }
                catch (Exception)
                {


                }

            }
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBarcode.Text == string.Empty)
            {

            }
            else
            {


                if (e.KeyChar == 13)
                {

                    DataTable tblItems = new DataTable();
                    tblItems.Clear();
                    tblItems = db.readData("select * from Products where Barcode = '" + txtBarcode.Text + "'", string.Empty);
                    if (tblItems.Rows.Count >= 1)
                    {
                        try
                        {
                            string Product_Id = tblItems.Rows[0][0].ToString();
                            string Product_Name = tblItems.Rows[0][1].ToString();
                            string Product_Qty = "1";
                            string Product_Price = tblItems.Rows[0][3].ToString();
                            decimal Discount = 0;
                            decimal Total = Convert.ToDecimal(Product_Qty) * Convert.ToDecimal(tblItems.Rows[0][3]);
                            dgvBuy.Rows.Add(1);
                            int RowIndex = dgvBuy.Rows.Count - 1;
                            dgvBuy.Rows[RowIndex].Cells[0].Value = Product_Id;
                            dgvBuy.Rows[RowIndex].Cells[1].Value = Product_Name;
                            dgvBuy.Rows[RowIndex].Cells[2].Value = Product_Qty;
                            dgvBuy.Rows[RowIndex].Cells[3].Value = Product_Price;
                            dgvBuy.Rows[RowIndex].Cells[4].Value = Discount;
                            dgvBuy.Rows[RowIndex].Cells[5].Value = Total;
                        }
                        catch (Exception)
                        {


                        }
                        try
                        {
                            decimal TotalOrder = 0;
                            for (int i = 0; i <= dgvBuy.Rows.Count - 1; i++)
                            {
                                TotalOrder += Convert.ToDecimal(dgvBuy.Rows[i].Cells[5].Value);
                            }

                            txtTotal.Text = Math.Round(TotalOrder, 2).ToString();
                            lblItemsCount.Text = (dgvBuy.Rows.Count).ToString();
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }
        }

        private void Frm_Buy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                if (dgvBuy.Rows.Count >= 1)
                {
                    if (cbxSupplier.Items.Count <= 0)
                    {
                        MessageBox.Show("من فضلك اختر مورد اولا", "تاكيد");
                        return;
                    }
                    try
                    {

                        string d = dtpDate.Value.ToString("dd/MM/yyyy");
                        db.excuteData("insert into Buy values(" + txtId.Text + ", '" + d + "', " + cbxSupplier.SelectedValue + ")", string.Empty);
                        for (int i = 0; i <= dgvBuy.Rows.Count - 1; i++)
                        {
                            db.excuteData("insert into Buy_Detalis values (" + txtId.Text + ", " + cbxSupplier.SelectedValue + "," + dgvBuy.Rows[i].Cells[0].Value + ",'" + d + "'," + dgvBuy.Rows[i].Cells[2].Value + ", '" + 123 + "'," + dgvBuy.Rows[i].Cells[3].Value + "," + dgvBuy.Rows[i].Cells[4].Value + ", " + dgvBuy.Rows[i].Cells[5].Value + ") ", string.Empty);
                            autoNumber();
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }


                }
            }

        }
    }
}