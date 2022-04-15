using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Sales_Managment
{
    public partial class Frm_DeservedReport : DevExpress.XtraEditors.XtraForm
    {
        public Frm_DeservedReport()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string date1;
            string date2;
            date1 = dtpFrom.Value.ToString("yyyy-MM-dd");
            date2 = dtpTo.Value.ToString("yyyy-MM-dd");
            tbl.Clear();
            tbl = db.readData("select Deserved.Des_Id as 'رقم العملية', price as 'المبلغ المدفوع', Date as 'تاريخ العملية' , Notes as 'ملاحظات', Deserved_Type.Des_Name as 'النوع' from Deserved, Deserved_Type where Deserved_Type.Des_Id = Deserved.Des_Id and CONVERT(date, Date, 105) between '" + date1 + "' and '" + date2 + "'", string.Empty);
            // لجمع جميع عمليات الشراء مع بعضها
            if (tbl.Rows.Count >= 1)
            {
                dgvSearch.DataSource = tbl;
                decimal sum = 0;
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    sum += Convert.ToDecimal(tbl.Rows[i][1]);
                }
                txtTotal.Text = Math.Round(sum, 2).ToString();

            }
            else
            {
                txtTotal.Text = "0";
            }

        }

        private void Frm_DeservedReport_Load(object sender, EventArgs e)
        {
            dtpFrom.Text = DateTime.Now.ToShortDateString();
            dtpTo.Text = DateTime.Now.ToShortDateString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string date1, date2;
            date1 = dtpFrom.Value.ToString("yyyy-MM-dd");
            date2 = dtpTo.Value.ToString("yyyy-MM-dd");
            if (MessageBox.Show(" هل انت متأكد من مسح تقارير هذه الفترة ", "تاكيد ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.excuteData("delete from Deserved where  CONVERT(date, Date, 105) between '" + date1 + "' and '" + date2 + "'", "تم مسح البيانات بنجاح");


            }
        }
    }
}