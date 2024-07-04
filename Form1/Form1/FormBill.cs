using Form1.Bill.Model;
using Form1.Bill.Services;

namespace Form1
{
    public partial class FormBill : Form
    {
        BillServices billServices { get; set; }
        BillModel billModel { get; set; }
        public FormBill()
        {
            InitializeComponent();
            billServices = new BillServices();
            billModel = new BillModel();
        }
        private void FormBill_Load(object sender, EventArgs e)
        {
            billModel.AutoNumberBill();
            label_numberBill.Text = billModel.ID_order; 
            if(label_numberBill.Text == "")
            {
                label_numberBill.Text = "1";
            }
        }

        private double payment;
        public void SetTotal(string total)
        {
            label_payment.Text = total;
            payment = double.Parse(label_payment.Text);
            if (payment > 1000000)
            {
                label_discount.Text = "10%";
                payment = payment - (payment * 0.1);
            }
            else if (payment > 500000)
            {
                label_discount.Text = "7%";
                payment = payment - (payment * 0.07);
            }
            else if (payment > 200000)
            {
                label_discount.Text = "5%";
                payment = payment - (payment * 0.05);
            }
            label_payment.Text = payment.ToString() + " vnd";

        }
        public void SetText(string name, string time)
        {
            label_nameCustomer.Text = name;
            label_timeBill.Text = time;
        }
        public void SetValue(string val1, string val2, string val3, string val4)
        {
            string[] row = { val2, val3, val4 };
            listview_Bill.Items.Add(val1).SubItems.AddRange(row);
        }
        private void bt_PrintBill_Click(object sender, EventArgs e)
        {
            billServices.AddBill(label_numberBill.Text, label_nameCustomer.Text, payment, label_timeBill.Text);
            
            foreach (ListViewItem item in listview_Bill.Items)
            {
                billServices.AddDetailsBill(item.Text, label_numberBill.Text, Convert.ToInt32(item.SubItems[1].Text));
            }

            billModel.AutoNumberBill();

            MessageBox.Show("Thanh toán thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void label_timeBill_Click(object sender, EventArgs e)
        {

        }
    }
}
