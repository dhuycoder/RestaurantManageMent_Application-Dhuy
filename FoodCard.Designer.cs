namespace GUI
{
    partial class FoodCard
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            foodImage = new Guna.UI2.WinForms.Guna2PictureBox();
            foodNameTxt = new Label();
            foodPriceTxt = new Label();
            foodSizeComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)foodImage).BeginInit();
            SuspendLayout();
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.IndianRed;
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.ForeColor = Color.Red;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(324, 15);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(5, 4, 0, 0);
            iconButton1.Size = new Size(69, 42);
            iconButton1.TabIndex = 0;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // foodImage
            // 
            foodImage.CustomizableEdges = customizableEdges1;
            foodImage.ImageRotate = 0F;
            foodImage.Location = new Point(13, 63);
            foodImage.Name = "foodImage";
            foodImage.ShadowDecoration.CustomizableEdges = customizableEdges2;
            foodImage.Size = new Size(380, 160);
            foodImage.TabIndex = 2;
            foodImage.TabStop = false;
            // 
            // foodNameTxt
            // 
            foodNameTxt.AutoSize = true;
            foodNameTxt.Location = new Point(13, 226);
            foodNameTxt.Name = "foodNameTxt";
            foodNameTxt.Size = new Size(50, 20);
            foodNameTxt.TabIndex = 3;
            foodNameTxt.Text = "label1";
            // 
            // foodPriceTxt
            // 
            foodPriceTxt.AutoSize = true;
            foodPriceTxt.Location = new Point(13, 246);
            foodPriceTxt.Name = "foodPriceTxt";
            foodPriceTxt.Size = new Size(50, 20);
            foodPriceTxt.TabIndex = 4;
            foodPriceTxt.Text = "label2";
            // 
            // foodSizeComboBox
            // 
            foodSizeComboBox.FormattingEnabled = true;
            foodSizeComboBox.Location = new Point(242, 226);
            foodSizeComboBox.Name = "foodSizeComboBox";
            foodSizeComboBox.Size = new Size(151, 28);
            foodSizeComboBox.TabIndex = 5;
            foodSizeComboBox.SelectedIndexChanged += foodSizeComboBox_SelectedIndexChanged;
            // 
            // FoodCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(foodSizeComboBox);
            Controls.Add(foodPriceTxt);
            Controls.Add(foodNameTxt);
            Controls.Add(foodImage);
            Controls.Add(iconButton1);
            Name = "FoodCard";
            Size = new Size(411, 282);
            ((System.ComponentModel.ISupportInitialize)foodImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI2.WinForms.Guna2PictureBox foodImage;
        private Label foodNameTxt;
        private Label foodPriceTxt;
        private ComboBox foodSizeComboBox;
    }
}
