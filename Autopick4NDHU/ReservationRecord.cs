using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autopick4NDHU
{
    public partial class ReservationRecord : Form
    {
        public ReservationRecord()
        {
            InitializeComponent();
        }

        private static ReservationRecord fm;
        public static ReservationRecord GetInstance()
        {
            if (fm == null || fm.IsDisposed)
            {
                fm = new ReservationRecord();
            }
            return fm;
        }

        private void ReservationRecord_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dgvRecord.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvRecord.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRecord.ColumnHeadersDefaultCellStyle.Font =
                new Font(dgvRecord.Font, FontStyle.Bold);

            dgvRecord.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvRecord.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            dgvRecord.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvRecord.GridColor = Color.Black;
            dgvRecord.RowHeadersVisible = false;

            /*dgvRecord.Columns[6].DefaultCellStyle.Font =
                new Font(dgvRecord.DefaultCellStyle.Font, FontStyle.Italic);*/

            dgvRecord.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvRecord.MultiSelect = false;
            //dgvRecord.Dock = DockStyle.Fill;

            dgvRecord.AllowUserToAddRows = false;
        }

        private void ReservationRecord_Shown(object sender, EventArgs e)
        {
            RecordManipulation recMan = new RecordManipulation();
            DataTable dt = recMan.GetAll();
            dgvRecord.DataSource = dt;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Wanna delete the row?", "Comfirm", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                int id = Int32.Parse(dgvRecord.CurrentRow.Cells[0].Value.ToString());
                RecordManipulation recMan = new RecordManipulation();
                if (recMan.Delete(id))
                {
                    DataTable dt = recMan.GetAll();
                    dgvRecord.DataSource = dt;

                    MessageBox.Show("Delete succesfully.");
                }
                else
                {
                    MessageBox.Show("Delete error");
                }
            }
        }
    }
}
