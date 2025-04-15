namespace GiftBox
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            panel_main = new Panel();
            label1 = new Label();
            label_giftsList = new Label();
            button_settings = new Button();
            label_winner = new Label();
            button_reset = new Button();
            button_openGift = new Button();
            giftBox_pb = new PictureBox();
            panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)giftBox_pb).BeginInit();
            SuspendLayout();
            // 
            // panel_main
            // 
            panel_main.BackColor = Color.Transparent;
            panel_main.Controls.Add(label1);
            panel_main.Controls.Add(label_giftsList);
            panel_main.Controls.Add(button_settings);
            panel_main.Controls.Add(label_winner);
            panel_main.Controls.Add(button_reset);
            panel_main.Controls.Add(button_openGift);
            panel_main.Controls.Add(giftBox_pb);
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(0, 0);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(1239, 660);
            panel_main.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(406, 631);
            label1.Name = "label1";
            label1.Size = new Size(421, 18);
            label1.TabIndex = 11;
            label1.Text = "© Dunay Gudratli 2025 – Crafted with code, protected by logic.";
            // 
            // label_giftsList
            // 
            label_giftsList.AutoSize = true;
            label_giftsList.BorderStyle = BorderStyle.Fixed3D;
            label_giftsList.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_giftsList.ForeColor = Color.White;
            label_giftsList.Location = new Point(153, 202);
            label_giftsList.Name = "label_giftsList";
            label_giftsList.Size = new Size(127, 114);
            label_giftsList.TabIndex = 10;
            label_giftsList.Text = "Hədiyyələr:\r\n1. 100 UC\r\n2. 350 UC\r\n3. 500 UC\r\n";
            // 
            // button_settings
            // 
            button_settings.BackColor = Color.FromArgb(0, 0, 192);
            button_settings.FlatAppearance.BorderSize = 0;
            button_settings.FlatStyle = FlatStyle.Flat;
            button_settings.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_settings.ForeColor = Color.White;
            button_settings.Location = new Point(1067, 0);
            button_settings.Name = "button_settings";
            button_settings.Size = new Size(172, 50);
            button_settings.TabIndex = 9;
            button_settings.Text = "Parametrlər";
            button_settings.UseVisualStyleBackColor = false;
            button_settings.Click += button_settings_Click;
            // 
            // label_winner
            // 
            label_winner.AutoSize = true;
            label_winner.BackColor = Color.Transparent;
            label_winner.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_winner.ForeColor = Color.White;
            label_winner.Location = new Point(347, 162);
            label_winner.Name = "label_winner";
            label_winner.Size = new Size(551, 36);
            label_winner.TabIndex = 7;
            label_winner.Text = "Ooo yenə yaxşısan, 1000 UC qazandın ;)";
            label_winner.Visible = false;
            // 
            // button_reset
            // 
            button_reset.BackColor = Color.FromArgb(117, 4, 4);
            button_reset.FlatStyle = FlatStyle.Popup;
            button_reset.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_reset.ForeColor = Color.AliceBlue;
            button_reset.Location = new Point(642, 398);
            button_reset.Name = "button_reset";
            button_reset.Size = new Size(162, 57);
            button_reset.TabIndex = 6;
            button_reset.Text = "Yenidən qur";
            button_reset.UseVisualStyleBackColor = false;
            button_reset.Click += button_reset_Click;
            // 
            // button_openGift
            // 
            button_openGift.BackColor = Color.FromArgb(61, 27, 190);
            button_openGift.FlatStyle = FlatStyle.Popup;
            button_openGift.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_openGift.ForeColor = Color.AliceBlue;
            button_openGift.Location = new Point(434, 398);
            button_openGift.Name = "button_openGift";
            button_openGift.Size = new Size(162, 57);
            button_openGift.TabIndex = 5;
            button_openGift.Text = "Hədiyyə aç";
            button_openGift.UseVisualStyleBackColor = false;
            button_openGift.Click += button_openGift_Click;
            // 
            // giftBox_pb
            // 
            giftBox_pb.BackColor = Color.Transparent;
            giftBox_pb.Image = Properties.Resources.output_onlinegiftools;
            giftBox_pb.InitialImage = (Image)resources.GetObject("giftBox_pb.InitialImage");
            giftBox_pb.Location = new Point(406, 53);
            giftBox_pb.Name = "giftBox_pb";
            giftBox_pb.Size = new Size(412, 307);
            giftBox_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            giftBox_pb.TabIndex = 4;
            giftBox_pb.TabStop = false;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2025_04_15_222650;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1239, 660);
            Controls.Add(panel_main);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "form1";
            Text = "M313 Hədiyyə qutusu";
            panel_main.ResumeLayout(false);
            panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)giftBox_pb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_main;
        private Label label_winner;
        private Button button_reset;
        private Button button_openGift;
        private PictureBox giftBox_pb;
        private Button button_settings;
        private Label label_giftsList;
        private Label label1;
    }
}
