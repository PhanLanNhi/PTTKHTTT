using Form1.Payment.Services;

namespace Form1
{
    public partial class Form_LapHoaDon : Form
    {
        PayService payService { get; set; }
        public Form_LapHoaDon()
        {
            InitializeComponent();
            payService = new PayService();
        }
        private void ThanhToan_Load(object sender, EventArgs e)
        {
            timer1.Start();
            panel_chucnang.Hide();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            txt_timeOrder.Text = dt.ToString();
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            new App().Show();
            Close();
        }
        bool checkItem(string s)
        {
            foreach (ListViewItem item in listview_ThanhToan.Items)
            {
                if (s == item.Text)
                {
                    MessageBox.Show("Đã có trong hóa đơn!", "Vui lòng kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }
        private void addItem(string food)
        {
            if (!checkItem(food))
            {
                payService.AddItemToListView(food, listview_ThanhToan);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            addItem(btn.Text);
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            listview_ThanhToan.Items.Clear();
            txt_nameCus.Clear();
            txt_totalProductPay.Clear();
        }

        private void listview_ThanhToan_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            panel_chucnang.Show();
            txt_nameProduct.Text = listview_ThanhToan.SelectedItems[0].SubItems[0].Text;
            txt_amount.Text = listview_ThanhToan.SelectedItems[0].SubItems[1].Text;
        }

        private int total;

        private void bt_update_Click(object sender, EventArgs e)
        {
            // khi cập nhật số lượng mới thì sẽ ra tổng tiền mới
            listview_ThanhToan.SelectedItems[0].SubItems[1].Text = txt_amount.Text;
            int price = Convert.ToInt32(listview_ThanhToan.SelectedItems[0].SubItems[2].Text);
            int amount = Convert.ToInt32(txt_amount.Text);
            int totalPrice = price * amount;
            listview_ThanhToan.SelectedItems[0].SubItems[3].Text = totalPrice.ToString();

            // tổng số tiền cần thanh toán
            total = 0;
            foreach (ListViewItem item in listview_ThanhToan.Items)
            {
                int temp = Convert.ToInt32(item.SubItems[3].Text);
                total += temp;
            }
            txt_totalProductPay.Text = total.ToString();
            panel_chucnang.Hide();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (listview_ThanhToan.Items.Count > 0)
            {
                listview_ThanhToan.Items.Remove(listview_ThanhToan.SelectedItems[0]);
                total = 0;
                foreach (ListViewItem item in listview_ThanhToan.Items)
                {
                    int temp = Convert.ToInt32(item.SubItems[3].Text);
                    total += temp;
                }
                txt_totalProductPay.Text = total.ToString();
            }
            else if (listview_ThanhToan.SelectedItems.Count < 1)
            {
                MessageBox.Show("Xóa lỗi", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void bt_pay_Click(object sender, EventArgs e)
        {
            total = 0;
            foreach (ListViewItem item in listview_ThanhToan.Items)
            {
                int temp = Convert.ToInt32(item.SubItems[3].Text);
                total += temp;
            }
            txt_totalProductPay.Text = total.ToString();
        }

        private delegate void SetTotalValueCallBack(string total);
        private delegate void SetTextValueCallBack(string name, string time);
        private delegate void SetItemValueCallBack(string val1, string val2, string val3, string val4);
        private SetTotalValueCallBack SetTotal;
        private SetTextValueCallBack SetTextValue;
        private SetItemValueCallBack SetItemValue;

        private void bt_bill_Click(object sender, EventArgs e)
        {
            if (txt_nameCus.Text.Length < 1)
            {
                MessageBox.Show("Tên khách hàng không được trống!", "Vui lòng kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txt_totalProductPay.Text))
            {
                MessageBox.Show("Vui lòng ấn tính tiền trước!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FormBill frm = new FormBill();
                SetTotal += new SetTotalValueCallBack(frm.SetTotal);
                SetTextValue += new SetTextValueCallBack(frm.SetText);
                SetItemValue += new SetItemValueCallBack(frm.SetValue);
                frm.Show();
                SetTextValue(txt_nameCus.Text, txt_timeOrder.Text);
                SetTotal(txt_totalProductPay.Text);
                foreach (ListViewItem item in listview_ThanhToan.Items)
                {
                    SetItemValue(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text);
                }
            }
        }


    }
}
