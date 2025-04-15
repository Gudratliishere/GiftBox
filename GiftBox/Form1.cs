using System.Windows.Forms;

namespace GiftBox
{
    public partial class form1 : Form
    {
        private GiftManager giftManager = new GiftManager();
        private GiftService giftService = new GiftService();

        public form1()
        {
            InitializeComponent();

            loadGifts();
        }

        private void button_openGift_Click(object sender, EventArgs e)
        {
            var gift = giftManager.GetGift(2);
            giftBox_pb.Image = Properties.Resources.output_onlinegiftools__1_;
            System.Windows.Forms.Timer delayTimer = new System.Windows.Forms.Timer();
            delayTimer.Interval = 1300;
            delayTimer.Tick += (s, e) =>
            {
                delayTimer.Stop();
                giftBox_pb.Image = null;
                label_winner.Text = GetWinnerText(gift);
                label_winner.Visible = true;
            };
            delayTimer.Start();
            button_openGift.Enabled = false;
            button_reset.Enabled = true;

            giftManager.saveGifts();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            giftBox_pb.Image = Properties.Resources.output_onlinegiftools;
            label_winner.Visible = false;
            button_openGift.Enabled = true;
            button_reset.Enabled = false;
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            var panel = (Panel)this.Controls[0];
            this.Controls.Clear();
            this.Controls.Add(new SettingsPanel(this, panel));
        }

        public void loadGifts()
        {
            giftManager.loadGifts();
            List<Gift> gifts = giftService.ReadGifts();
            string giftsText = "Hədiyyələr:\n";
            for (int i = 0; i < gifts.Count; i++)
            {
                giftsText += (i + 1) + ". " + gifts[i].Name + "\n";
            }
            label_giftsList.Text = giftsText;
        }

        private string GetWinnerText(Gift gift)
        {
            if (gift.GiftType.Type == GiftTypeEnum.LOSE)
            {
                return "              Bəxtini bir daha sına :(              ";
            }
            else if (gift.GiftType.Type == GiftTypeEnum.SILVER)
            {
                return "              " + gift.Name + " qazandın!              ";
            }
            else
            {
                return "Ooo yenə yaxşısan, " + gift.Name + " qazandın ;)";
            }
        }
    }
}
