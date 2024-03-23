namespace GUI
{
    partial class foodCardRIght
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
            foodImage = new PictureBox();
            foodNameLbl = new Label();
            label2 = new Label();
            foodSizeLbl = new Label();
            foodPriceLbl = new Label();
            DelFoodCardRightBtn = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            MinusBtn = new FontAwesome.Sharp.IconButton();
            PlusBtn = new FontAwesome.Sharp.IconButton();
            FoodNumberLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)foodImage).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // foodImage
            // 
            foodImage.Location = new Point(0, 22);
            foodImage.Name = "foodImage";
            foodImage.Size = new Size(162, 92);
            foodImage.TabIndex = 0;
            foodImage.TabStop = false;
            // 
            // foodNameLbl
            // 
            foodNameLbl.AutoSize = true;
            foodNameLbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foodNameLbl.Location = new Point(179, 34);
            foodNameLbl.Name = "foodNameLbl";
            foodNameLbl.Size = new Size(59, 25);
            foodNameLbl.TabIndex = 1;
            foodNameLbl.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(179, 81);
            label2.Name = "label2";
            label2.Size = new Size(21, 17);
            label2.TabIndex = 2;
            label2.Text = "x1";
            // 
            // foodSizeLbl
            // 
            foodSizeLbl.AutoSize = true;
            foodSizeLbl.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foodSizeLbl.Location = new Point(215, 81);
            foodSizeLbl.Name = "foodSizeLbl";
            foodSizeLbl.Size = new Size(43, 17);
            foodSizeLbl.TabIndex = 3;
            foodSizeLbl.Text = "label3";
            // 
            // foodPriceLbl
            // 
            foodPriceLbl.AutoSize = true;
            foodPriceLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foodPriceLbl.Location = new Point(315, 28);
            foodPriceLbl.Name = "foodPriceLbl";
            foodPriceLbl.Size = new Size(76, 31);
            foodPriceLbl.TabIndex = 4;
            foodPriceLbl.Text = "label4";
            // 
            // DelFoodCardRightBtn
            // 
            DelFoodCardRightBtn.BackColor = Color.IndianRed;
            DelFoodCardRightBtn.Dock = DockStyle.Right;
            DelFoodCardRightBtn.FlatStyle = FlatStyle.Popup;
            DelFoodCardRightBtn.ForeColor = SystemColors.ControlText;
            DelFoodCardRightBtn.IconChar = FontAwesome.Sharp.IconChar.TrashCan;
            DelFoodCardRightBtn.IconColor = Color.White;
            DelFoodCardRightBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DelFoodCardRightBtn.IconSize = 35;
            DelFoodCardRightBtn.Location = new Point(469, 0);
            DelFoodCardRightBtn.Name = "DelFoodCardRightBtn";
            DelFoodCardRightBtn.Size = new Size(50, 144);
            DelFoodCardRightBtn.TabIndex = 6;
            DelFoodCardRightBtn.UseVisualStyleBackColor = false;
            DelFoodCardRightBtn.Click += DelFoodCardRightBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(MinusBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(FoodNumberLbl, 1, 0);
            tableLayoutPanel1.Controls.Add(PlusBtn, 2, 0);
            tableLayoutPanel1.ForeColor = Color.WhiteSmoke;
            tableLayoutPanel1.Location = new Point(302, 66);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(132, 48);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // MinusBtn
            // 
            MinusBtn.BackColor = Color.WhiteSmoke;
            MinusBtn.ForeColor = Color.White;
            MinusBtn.IconChar = FontAwesome.Sharp.IconChar.Minus;
            MinusBtn.IconColor = Color.Black;
            MinusBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MinusBtn.IconSize = 35;
            MinusBtn.Location = new Point(1, 1);
            MinusBtn.Margin = new Padding(0);
            MinusBtn.Name = "MinusBtn";
            MinusBtn.Padding = new Padding(0, 5, 0, 0);
            MinusBtn.Size = new Size(42, 46);
            MinusBtn.TabIndex = 0;
            MinusBtn.UseVisualStyleBackColor = false;
            MinusBtn.Click += MinusBtn_Click;
            // 
            // PlusBtn
            // 
            PlusBtn.AutoSize = true;
            PlusBtn.BackColor = Color.WhiteSmoke;
            PlusBtn.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            PlusBtn.ForeColor = Color.White;
            PlusBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            PlusBtn.IconColor = Color.Black;
            PlusBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PlusBtn.IconSize = 35;
            PlusBtn.Location = new Point(87, 1);
            PlusBtn.Margin = new Padding(0);
            PlusBtn.Name = "PlusBtn";
            PlusBtn.Padding = new Padding(0, 3, 0, 0);
            PlusBtn.Size = new Size(44, 46);
            PlusBtn.TabIndex = 1;
            PlusBtn.UseVisualStyleBackColor = false;
            PlusBtn.Click += PlusBtn_Click;
            // 
            // FoodNumberLbl
            // 
            FoodNumberLbl.BackColor = Color.Transparent;
            FoodNumberLbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FoodNumberLbl.ForeColor = Color.Black;
            FoodNumberLbl.Location = new Point(47, 8);
            FoodNumberLbl.Margin = new Padding(3, 7, 3, 0);
            FoodNumberLbl.Name = "FoodNumberLbl";
            FoodNumberLbl.Size = new Size(36, 37);
            FoodNumberLbl.TabIndex = 2;
            FoodNumberLbl.Text = "1";
            FoodNumberLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // foodCardRIght
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(DelFoodCardRightBtn);
            Controls.Add(foodPriceLbl);
            Controls.Add(foodSizeLbl);
            Controls.Add(label2);
            Controls.Add(foodNameLbl);
            Controls.Add(foodImage);
            Margin = new Padding(0);
            Name = "foodCardRIght";
            Size = new Size(519, 144);
            ((System.ComponentModel.ISupportInitialize)foodImage).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox foodImage;
        private Label foodNameLbl;
        private Label label2;
        private Label foodSizeLbl;
        private Label foodPriceLbl;
        private FontAwesome.Sharp.IconButton DelFoodCardRightBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton MinusBtn;
        private FontAwesome.Sharp.IconButton PlusBtn;
        private Label FoodNumberLbl;
    }
}
