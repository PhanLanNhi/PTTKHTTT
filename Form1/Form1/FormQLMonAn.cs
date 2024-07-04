using Form1.MonAn.Model;
using Form1.MonAn.Services;
using System.ComponentModel;

namespace Form1
{
    public partial class FormQLMonAn : Form
    {
        FoodService foodService { get; set; }
        public FormQLMonAn()
        {
            InitializeComponent();
            foodService = new FoodService();
        }

        private void dgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvFood.CurrentRow.Index;
            txt_maMon.Text = dgvFood.Rows[i].Cells[0].Value.ToString();
            txt_tenMon.Text = dgvFood.Rows[i].Cells[1].Value.ToString();
            txt_donGia.Text = dgvFood.Rows[i].Cells[2].Value.ToString();
            txt_thoiGian.Text = dgvFood.Rows[i].Cells[3].Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            txt_thoiGian.Text = dateTime.ToString();
        }

        private void FormAddMonAn_Load(object sender, EventArgs e)
        {
            timer1.Start();
            foodService.ShowListFood(dgvFood);
            dgvFood.Sort(dgvFood.Columns[0], ListSortDirection.Ascending);
        }

        private bool CheckNull()
        {
            if(string.IsNullOrEmpty(txt_maMon.Text) || string.IsNullOrEmpty(txt_tenMon.Text) || string.IsNullOrEmpty(txt_donGia.Text) || string.IsNullOrEmpty(txt_thoiGian.Text))
            {
                return true;
            }
            return false;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if(CheckNull())
            {
                MessageBox.Show("Thông tin nhập vào không được rỗng!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string Result = foodService.AddFood(txt_maMon.Text, txt_tenMon.Text, txt_donGia.Text, txt_thoiGian.Text);
                if (string.IsNullOrEmpty(Result))
                {
                    MessageBox.Show("Thêm món ăn thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foodService.ShowListFood(dgvFood);
                }
                else
                {
                    MessageBox.Show($"{Result}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            int i = dgvFood.CurrentRow.Index;
            var id_update = dgvFood.Rows[i].Cells[0].Value.ToString();
            string Result = foodService.UpdateFood(id_update, txt_tenMon.Text, txt_donGia.Text, txt_thoiGian.Text);
            if (string.IsNullOrEmpty(Result))
            {
                MessageBox.Show("Sửa thông tin món ăn thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foodService.ShowListFood(dgvFood);
            }
            else
            {
                MessageBox.Show($"{Result}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if(dgvFood.SelectedCells.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xóa!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int i = dgvFood.CurrentRow.Index;
                var id_delete = dgvFood.Rows[i].Cells[0].Value.ToString();
                string Result = foodService.DeleteFood(id_delete);
                if (string.IsNullOrEmpty(Result))
                {
                    MessageBox.Show("Xóa thông tin món ăn thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foodService.ShowListFood(dgvFood);
                }
                else
                {
                    MessageBox.Show($"{Result}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }          
        }

        private void Reset()
        {
            txt_maMon.Clear();
            txt_tenMon.Clear();
            txt_donGia.Clear();
            txt_maMon.Focus();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            new App().Show();
            Close();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
