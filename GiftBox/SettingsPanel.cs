using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiftBox
{
    public partial class SettingsPanel : UserControl
    {
        GiftService giftService = new GiftService();

        private form1 form;
        private Panel panel;

        public SettingsPanel(form1 form, Panel panel)
        {
            InitializeComponent();

            this.form = form;
            this.panel = panel;

            List<Gift> gifts = giftService.ReadGifts();
            foreach (var gift in gifts)
            {
                addGiftSetting(gift.Name, gift.Priority, gift.GiftType);
            }

            flp_gifts.Location = new Point(140, 90);
            flp_gifts.MaximumSize = new Size(850, 400);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            addGiftSetting("", 1, new GiftType { Type = GiftTypeEnum.LOSE, DisplayName = "Boş" });
        }

        private void addGiftSetting(string name, int priority, GiftType giftType)
        {
            FlowLayoutPanel flp_gift = new FlowLayoutPanel();
            flp_gift.Width = 760;
            flp_gift.Height = 50;

            TextBox giftTb = new TextBox();
            giftTb.Font = new Font("Tahoma", 15);
            giftTb.Width = 350;
            giftTb.Text = name;

            TextBox priorityTb = new TextBox();
            priorityTb.Font = new Font("Tahoma", 15);
            priorityTb.Width = 150;
            priorityTb.Text = priority.ToString();

            ComboBox giftTypes = new ComboBox();
            giftTypes.Items.Add(new GiftType { Type = GiftTypeEnum.LOSE, DisplayName = "Boş"});
            giftTypes.Items.Add(new GiftType { Type = GiftTypeEnum.SILVER, DisplayName = "Gümüş" });
            giftTypes.Items.Add(new GiftType { Type = GiftTypeEnum.WIN, DisplayName = "Uc" });
            giftTypes.SelectedIndex = (int)giftType.Type;
            giftTypes.Width = 150;
            giftTypes.Height = 50;
            giftTypes.Font = new Font("Tahoma", 15);
            giftTypes.DisplayMember = "DisplayName";
            giftTypes.ValueMember = "Type";

            Button removeBtn = new Button();
            removeBtn.Text = "Sil";
            removeBtn.BackColor = Color.Red;
            removeBtn.ForeColor = Color.White;
            removeBtn.FlatStyle = FlatStyle.Flat;
            removeBtn.FlatAppearance.BorderSize = 0;
            removeBtn.Font = new Font("Tahoma", 13);
            removeBtn.Height = 40;
            removeBtn.Click += (sender, e) =>
            {
                flp_gifts.Controls.Remove(flp_gift);
            };

            flp_gift.Controls.Add(giftTb);
            flp_gift.Controls.Add(priorityTb);
            flp_gift.Controls.Add(giftTypes);
            flp_gift.Controls.Add(removeBtn);
            flp_gifts.Controls.Add(flp_gift);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            List<Gift> gifts = new();
            for (int i = 0; i < flp_gifts.Controls.Count; i++)
            {
                Gift gift = new()
                {
                    Id = i + 1,
                    Name = flp_gifts.Controls[i].Controls[0].Text,
                    Priority = int.Parse(flp_gifts.Controls[i].Controls[1].Text),
                    Period = 1,
                    GiftType = (GiftType)((ComboBox)flp_gifts.Controls[i].Controls[2]).SelectedItem
                };
                gifts.Add(gift);
            }

            giftService.SaveGifts(gifts);
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            form.Controls.Clear();
            form.Controls.Add(panel);
            form.loadGifts();
        }
    }
}
