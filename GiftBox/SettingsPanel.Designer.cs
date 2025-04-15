namespace GiftBox
{
    partial class SettingsPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flp_gifts = new FlowLayoutPanel();
            btn_add = new Button();
            btn_save = new Button();
            button_back = new Button();
            label_name = new Label();
            label_priority = new Label();
            label_type = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // flp_gifts
            // 
            flp_gifts.AutoScroll = true;
            flp_gifts.AutoSize = true;
            flp_gifts.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flp_gifts.FlowDirection = FlowDirection.TopDown;
            flp_gifts.Location = new Point(93, 83);
            flp_gifts.MaximumSize = new Size(750, 430);
            flp_gifts.Name = "flp_gifts";
            flp_gifts.Size = new Size(0, 0);
            flp_gifts.TabIndex = 1;
            flp_gifts.WrapContents = false;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Green;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Tahoma", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(996, 180);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(130, 66);
            btn_add.TabIndex = 2;
            btn_add.Text = "Yenisini əlavə et";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += button_add_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(0, 0, 192);
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Font = new Font("Tahoma", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(996, 294);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(130, 74);
            btn_save.TabIndex = 3;
            btn_save.Text = "Yadda saxla";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // button_back
            // 
            button_back.BackColor = Color.Teal;
            button_back.FlatAppearance.BorderSize = 0;
            button_back.FlatStyle = FlatStyle.Flat;
            button_back.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_back.ForeColor = Color.White;
            button_back.Location = new Point(1145, 0);
            button_back.Name = "button_back";
            button_back.Size = new Size(94, 51);
            button_back.TabIndex = 4;
            button_back.Text = "Geri";
            button_back.UseVisualStyleBackColor = false;
            button_back.Click += button_back_Click;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_name.ForeColor = Color.White;
            label_name.Location = new Point(245, 55);
            label_name.Name = "label_name";
            label_name.Size = new Size(39, 28);
            label_name.TabIndex = 5;
            label_name.Text = "Ad";
            // 
            // label_priority
            // 
            label_priority.AutoSize = true;
            label_priority.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_priority.ForeColor = Color.White;
            label_priority.Location = new Point(543, 55);
            label_priority.Name = "label_priority";
            label_priority.Size = new Size(87, 28);
            label_priority.TabIndex = 6;
            label_priority.Text = "Ehtimal";
            // 
            // label_type
            // 
            label_type.AutoSize = true;
            label_type.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_type.ForeColor = Color.White;
            label_type.Location = new Point(720, 55);
            label_type.Name = "label_type";
            label_type.Size = new Size(43, 28);
            label_type.TabIndex = 7;
            label_type.Text = "Tip";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(406, 631);
            label1.Name = "label1";
            label1.Size = new Size(421, 18);
            label1.TabIndex = 12;
            label1.Text = "© Dunay Gudratli 2025 – Crafted with code, protected by logic.";
            // 
            // SettingsPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label1);
            Controls.Add(label_type);
            Controls.Add(label_priority);
            Controls.Add(label_name);
            Controls.Add(button_back);
            Controls.Add(btn_save);
            Controls.Add(btn_add);
            Controls.Add(flp_gifts);
            Name = "SettingsPanel";
            Size = new Size(1239, 660);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flp_gifts;
        private Button btn_add;
        private Button btn_save;
        private Button button_back;
        private Label label_name;
        private Label label_priority;
        private Label label_type;
        private Label label1;
    }
}
