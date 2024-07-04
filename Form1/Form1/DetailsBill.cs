using Form1.Bill.Model;
using Form1.Bill.Services;

namespace Form1
{
    public partial class DetailsBill : Form
    {
        BillServices billServices { get; set; }
        BillInfo bill { get; set; }
        public string? Id_Order { get; set; }
        public DetailsBill(string? id)
        {
            InitializeComponent();
            billServices = new BillServices();    
            bill = new BillInfo();
            Id_Order = id;
        }

        private void SetInfo()
        {
            lb_numBill.Text = bill.ID_order;
            lb_nameCus.Text = bill.NameCus;
            lb_time.Text = bill.TimeOrder;
        }

        private void DetailsBill_Load(object sender, EventArgs e)
        {
            bill.GetInfoBill(Id_Order);
            SetInfo();
            billServices.ShowDetailsBill(Id_Order, dgv_billDetails);
        }
    }
}
