namespace GUI
{
    partial class MenuFlowPanel
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            MenuFoodCardLeftflp = new FlowLayoutPanel();
            menuFoodFlpnR = new FlowLayoutPanel();
            SearchFoodTxt = new Guna.UI2.WinForms.Guna2TextBox();
            CategoryFlowPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            applyDiscountBtn = new FontAwesome.Sharp.IconButton();
            lbl4 = new Label();
            CodeTxt = new Guna.UI2.WinForms.Guna2TextBox();
            DiscountPriceLbl = new Label();
            label1 = new Label();
            label2 = new Label();
            subTotalLbl = new Label();
            CheckOutBtn = new Guna.UI2.WinForms.Guna2Button();
            totalLbl = new Label();
            label4 = new Label();
            iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // MenuFoodCardLeftflp
            // 
            MenuFoodCardLeftflp.AutoScroll = true;
            MenuFoodCardLeftflp.BorderStyle = BorderStyle.FixedSingle;
            MenuFoodCardLeftflp.Location = new Point(58, 222);
            MenuFoodCardLeftflp.Name = "MenuFoodCardLeftflp";
            MenuFoodCardLeftflp.Size = new Size(888, 581);
            MenuFoodCardLeftflp.TabIndex = 0;
            // 
            // menuFoodFlpnR
            // 
            menuFoodFlpnR.AutoScroll = true;
            menuFoodFlpnR.BorderStyle = BorderStyle.FixedSingle;
            menuFoodFlpnR.Location = new Point(28, 0);
            menuFoodFlpnR.Name = "menuFoodFlpnR";
            menuFoodFlpnR.Size = new Size(530, 504);
            menuFoodFlpnR.TabIndex = 1;
            // 
            // SearchFoodTxt
            // 
            SearchFoodTxt.CustomizableEdges = customizableEdges1;
            SearchFoodTxt.DefaultText = "";
            SearchFoodTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            SearchFoodTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            SearchFoodTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            SearchFoodTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            SearchFoodTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchFoodTxt.Font = new Font("Segoe UI", 9F);
            SearchFoodTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchFoodTxt.IconLeft = Properties.Resources.EditIcon;
            SearchFoodTxt.IconLeftSize = new Size(50, 50);
            SearchFoodTxt.Location = new Point(623, 169);
            SearchFoodTxt.Margin = new Padding(3, 4, 3, 4);
            SearchFoodTxt.Name = "SearchFoodTxt";
            SearchFoodTxt.PasswordChar = '\0';
            SearchFoodTxt.PlaceholderText = "";
            SearchFoodTxt.SelectedText = "";
            SearchFoodTxt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            SearchFoodTxt.Size = new Size(326, 46);
            SearchFoodTxt.TabIndex = 2;
            SearchFoodTxt.Click += SearchFoodTxt_TextChanged;
            // 
            // CategoryFlowPanel
            // 
            CategoryFlowPanel.AutoScroll = true;
            CategoryFlowPanel.BorderStyle = BorderStyle.FixedSingle;
            CategoryFlowPanel.Location = new Point(58, 0);
            CategoryFlowPanel.Name = "CategoryFlowPanel";
            CategoryFlowPanel.Size = new Size(888, 162);
            CategoryFlowPanel.TabIndex = 3;
            CategoryFlowPanel.WrapContents = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(menuFoodFlpnR);
            panel1.Controls.Add(CheckOutBtn);
            panel1.Controls.Add(totalLbl);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(927, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(771, 806);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(applyDiscountBtn);
            panel2.Controls.Add(lbl4);
            panel2.Controls.Add(CodeTxt);
            panel2.Controls.Add(DiscountPriceLbl);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(subTotalLbl);
            panel2.Location = new Point(28, 510);
            panel2.Name = "panel2";
            panel2.Size = new Size(529, 174);
            panel2.TabIndex = 2;
            // 
            // applyDiscountBtn
            // 
            applyDiscountBtn.BackColor = Color.FromArgb(192, 0, 0);
            applyDiscountBtn.ForeColor = Color.White;
            applyDiscountBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            applyDiscountBtn.IconColor = Color.Black;
            applyDiscountBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            applyDiscountBtn.Location = new Point(433, 58);
            applyDiscountBtn.Name = "applyDiscountBtn";
            applyDiscountBtn.Size = new Size(95, 51);
            applyDiscountBtn.TabIndex = 20;
            applyDiscountBtn.Text = "Áp dụng";
            applyDiscountBtn.UseVisualStyleBackColor = false;
            applyDiscountBtn.Click += applyDiscountBtn_Click;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(49, 75);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(190, 20);
            lbl4.TabIndex = 19;
            lbl4.Text = "Nhập mã giảm giá(nếu có):";
            // 
            // CodeTxt
            // 
            CodeTxt.CustomizableEdges = customizableEdges3;
            CodeTxt.DefaultText = "";
            CodeTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            CodeTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            CodeTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            CodeTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            CodeTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            CodeTxt.Font = new Font("Segoe UI", 9F);
            CodeTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            CodeTxt.Location = new Point(245, 58);
            CodeTxt.Margin = new Padding(3, 4, 3, 4);
            CodeTxt.Name = "CodeTxt";
            CodeTxt.PasswordChar = '\0';
            CodeTxt.PlaceholderText = "";
            CodeTxt.SelectedText = "";
            CodeTxt.ShadowDecoration.CustomizableEdges = customizableEdges4;
            CodeTxt.Size = new Size(182, 51);
            CodeTxt.TabIndex = 18;
            // 
            // DiscountPriceLbl
            // 
            DiscountPriceLbl.AutoSize = true;
            DiscountPriceLbl.Location = new Point(311, 129);
            DiscountPriceLbl.Name = "DiscountPriceLbl";
            DiscountPriceLbl.Size = new Size(0, 20);
            DiscountPriceLbl.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 129);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 14;
            label1.Text = "Giảm giá:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 21);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 12;
            label2.Text = "Tổng tiền:";
            // 
            // subTotalLbl
            // 
            subTotalLbl.AutoSize = true;
            subTotalLbl.Location = new Point(308, 21);
            subTotalLbl.Name = "subTotalLbl";
            subTotalLbl.Size = new Size(0, 20);
            subTotalLbl.TabIndex = 11;
            // 
            // CheckOutBtn
            // 
            CheckOutBtn.CustomizableEdges = customizableEdges5;
            CheckOutBtn.DisabledState.BorderColor = Color.DarkGray;
            CheckOutBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            CheckOutBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            CheckOutBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            CheckOutBtn.FillColor = Color.FromArgb(192, 0, 0);
            CheckOutBtn.Font = new Font("Segoe UI", 9F);
            CheckOutBtn.ForeColor = Color.White;
            CheckOutBtn.Location = new Point(69, 738);
            CheckOutBtn.Name = "CheckOutBtn";
            CheckOutBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            CheckOutBtn.Size = new Size(466, 56);
            CheckOutBtn.TabIndex = 13;
            CheckOutBtn.Text = "Check out";
            CheckOutBtn.Click += CheckOutBtn_Click;
            // 
            // totalLbl
            // 
            totalLbl.AutoSize = true;
            totalLbl.Location = new Point(262, 701);
            totalLbl.Name = "totalLbl";
            totalLbl.Size = new Size(0, 20);
            totalLbl.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 701);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 16;
            label4.Text = "Tiền phải trả:";
            // 
            // iconSplitButton1
            // 
            iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSplitButton1.IconColor = Color.Black;
            iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSplitButton1.IconSize = 48;
            iconSplitButton1.Name = "iconSplitButton1";
            iconSplitButton1.Rotation = 0D;
            iconSplitButton1.Size = new Size(23, 23);
            iconSplitButton1.Text = "iconSplitButton1";
            // 
            // panel3
            // 
            panel3.Controls.Add(SearchFoodTxt);
            panel3.Controls.Add(CategoryFlowPanel);
            panel3.Controls.Add(MenuFoodCardLeftflp);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(949, 806);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // MenuFlowPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 806);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "MenuFlowPanel";
            Text = "MenuFlowPanel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel MenuFoodCardLeftflp;
        private FlowLayoutPanel menuFoodFlpnR;
        private Guna.UI2.WinForms.Guna2TextBox SearchFoodTxt;
        private FlowLayoutPanel CategoryFlowPanel;
        private Panel panel1;
        private Panel panel2;
        private Label totalLbl;
        private Label label4;
        private Label DiscountPriceLbl;
        private Label label1;
        private Label label2;
        private Label subTotalLbl;
        private Guna.UI2.WinForms.Guna2Button CheckOutBtn;
        private Guna.UI2.WinForms.Guna2TextBox CodeTxt;
        private Label lbl4;
        private FontAwesome.Sharp.IconButton applyDiscountBtn;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private Panel panel3;
    }
}