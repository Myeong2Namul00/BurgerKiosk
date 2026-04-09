namespace BurgerKiosk
{
    public partial class Form1 : Form
    {

        int price;
        int burgerPrice = 0;
        int sidePrice = 0;
        string burgerType = "선택하지 않음";
        List<string> sideList = new List<string>();

        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Shown(object? sender, EventArgs e)
        {
            uncheckAll();
            burgerPrice = 0;
            sidePrice = 0;
            refreshTotalPrice();

            lblKeyHelp.Text = "위아래 방향키로 메뉴 이동\n스페이스바로 선택/해제\n엔터키로 주문\nR키로 초기화";
        }

        private void refreshTotalPrice()
        {
            price = burgerPrice + sidePrice;
            lblTotal.Text = $"주문 금액 : " + price.ToString("N0");
            lblError.Visible = false;
            refreshOrderList();
        }

        private void refreshOrderList()
        {
            lstOrder.Items.Clear();
            lstOrder.Items.Add(burgerType);
            foreach (var side in sideList)
            {
                lstOrder.Items.Add(side);
            }
        }

        private void uncheckAll()
        {
            rbtnHamburger.Checked = false;
            rbtnBulgogi.Checked = false;
            rbtnChicken.Checked = false;

            chkFries.Checked = false;
            chkCoke.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;
        }

        private void setBurgerOrder()
        {
            burgerPrice = 0;
            if (rbtnHamburger.Checked)
            {
                burgerPrice = 3000;
                burgerType = "햄버거";
            }
            else if (rbtnBulgogi.Checked)
            {
                burgerPrice = 3500;
                burgerType = "불고기버거";
            }
            else if (rbtnChicken.Checked)
            {
                burgerPrice = 4000;
                burgerType = "치킨버거";
            }
            refreshTotalPrice();
        }

        private void setSideOrder()
        {
            sideList.Clear();
            sidePrice = 0;
            if (chkFries.Checked)
            {
                sidePrice += 1500;
                sideList.Add("감자튀김");
            }
            if (chkCoke.Checked)
            {
                sidePrice += 1000;
                sideList.Add("콜라");
            }
            if (chkCheese.Checked)
            {
                sidePrice += 800;
                sideList.Add("치즈 추가");
            }
            if (chkSauce.Checked)
            {
                sidePrice += 500;
                sideList.Add("소스 추가");
            }
            refreshTotalPrice();
        }


        // Events

        private void rbtnHamburger_CheckedChanged(object sender, EventArgs e) { setBurgerOrder(); }
        private void rbtnBulgogi_CheckedChanged(object sender, EventArgs e) { setBurgerOrder(); }
        private void rbtnChicken_CheckedChanged(object sender, EventArgs e) { setBurgerOrder(); }


        private void chkFries_CheckedChanged(object sender, EventArgs e) { setSideOrder(); }
        private void chkCoke_CheckedChanged(object sender, EventArgs e) { setSideOrder(); }
        private void chkCheese_CheckedChanged(object sender, EventArgs e) { setSideOrder(); }
        private void chkSauce_CheckedChanged(object sender, EventArgs e) { setSideOrder(); }

        private void btnReset_Click(object sender, EventArgs e) { uncheckAll(); refreshTotalPrice(); }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (price == 0) { lblError.Visible = true; lblError.Text = "메뉴를 선택하고 주문해주세요."; return; }
            else if (burgerPrice == 0) { lblError.Visible = true; lblError.Text = "사이드만 주문할 수 없습니다."; return; }
            MessageBox.Show($"주문이 완료되었습니다.\n주문 금액 : " + price.ToString("N0"), "주문 완료");
            btnReset_Click(sender, e);
        }

        // Keydown

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            { 
                if (Focus() == false) rbtnHamburger.Focus();  return;
                
            }
            if (e.KeyCode == Keys.Down) { if (Focus() == false) rbtnHamburger.Focus(); }
        }
    }
}
