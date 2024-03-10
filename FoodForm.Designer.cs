namespace GUI
{
    partial class FoodForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            addFoodbtn = new FontAwesome.Sharp.IconButton();
            FoodDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            dvgId = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            dgvCategory = new DataGridViewTextBoxColumn();
            dgvEdit = new DataGridViewImageColumn();
            dgvDel = new DataGridViewImageColumn();
            SearchFoodTxt = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FoodDgv).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(1486, 82);
            guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 29);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // addFoodbtn
            // 
            addFoodbtn.BackColor = Color.LightCoral;
            addFoodbtn.FlatStyle = FlatStyle.Popup;
            addFoodbtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            addFoodbtn.IconColor = Color.White;
            addFoodbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addFoodbtn.Location = new Point(57, 114);
            addFoodbtn.Name = "addFoodbtn";
            addFoodbtn.Size = new Size(52, 53);
            addFoodbtn.TabIndex = 1;
            addFoodbtn.UseVisualStyleBackColor = false;
            addFoodbtn.Click += addFoodbtn_Click;
            // 
            // FoodDgv
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            FoodDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            FoodDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            FoodDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            FoodDgv.ColumnHeadersHeight = 22;
            FoodDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            FoodDgv.Columns.AddRange(new DataGridViewColumn[] { dvgId, dgvName, dgvCategory, dgvEdit, dgvDel });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            FoodDgv.DefaultCellStyle = dataGridViewCellStyle6;
            FoodDgv.GridColor = Color.FromArgb(231, 229, 255);
            FoodDgv.Location = new Point(66, 190);
            FoodDgv.Name = "FoodDgv";
            FoodDgv.RowHeadersVisible = false;
            FoodDgv.RowHeadersWidth = 51;
            FoodDgv.Size = new Size(1323, 584);
            FoodDgv.TabIndex = 2;
            FoodDgv.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            FoodDgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            FoodDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            FoodDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            FoodDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            FoodDgv.ThemeStyle.BackColor = Color.White;
            FoodDgv.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            FoodDgv.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            FoodDgv.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            FoodDgv.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            FoodDgv.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            FoodDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            FoodDgv.ThemeStyle.HeaderStyle.Height = 22;
            FoodDgv.ThemeStyle.ReadOnly = false;
            FoodDgv.ThemeStyle.RowsStyle.BackColor = Color.White;
            FoodDgv.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            FoodDgv.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            FoodDgv.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            FoodDgv.ThemeStyle.RowsStyle.Height = 29;
            FoodDgv.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            FoodDgv.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            FoodDgv.CellClick += FoodDgv_CellClick;
            // 
            // dvgId
            // 
            dvgId.DataPropertyName = "FoodId";
            dvgId.HeaderText = "Id";
            dvgId.MinimumWidth = 6;
            dvgId.Name = "dvgId";
            dvgId.Width = 160;
            // 
            // dgvName
            // 
            dgvName.DataPropertyName = "FoodName";
            dgvName.HeaderText = "Product Name";
            dgvName.MinimumWidth = 6;
            dgvName.Name = "dgvName";
            dgvName.Width = 550;
            // 
            // dgvCategory
            // 
            dgvCategory.DataPropertyName = "CategoryName";
            dgvCategory.HeaderText = "Category";
            dgvCategory.MinimumWidth = 6;
            dgvCategory.Name = "dgvCategory";
            dgvCategory.Width = 360;
            // 
            // dgvEdit
            // 
            dgvEdit.HeaderText = "";
            dgvEdit.Image = (Image)resources.GetObject("dgvEdit.Image");
            dgvEdit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvEdit.MinimumWidth = 6;
            dgvEdit.Name = "dgvEdit";
            dgvEdit.Width = 125;
            // 
            // dgvDel
            // 
            dgvDel.HeaderText = "";
            dgvDel.Image = (Image)resources.GetObject("dgvDel.Image");
            dgvDel.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvDel.MinimumWidth = 6;
            dgvDel.Name = "dgvDel";
            dgvDel.Width = 125;
            // 
            // SearchFoodTxt
            // 
            SearchFoodTxt.CustomizableEdges = customizableEdges7;
            SearchFoodTxt.DefaultText = "";
            SearchFoodTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            SearchFoodTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            SearchFoodTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            SearchFoodTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            SearchFoodTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchFoodTxt.Font = new Font("Segoe UI", 9F);
            SearchFoodTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchFoodTxt.IconLeft = (Image)resources.GetObject("SearchFoodTxt.IconLeft");
            SearchFoodTxt.IconLeftSize = new Size(50, 50);
            SearchFoodTxt.Location = new Point(1100, 114);
            SearchFoodTxt.Margin = new Padding(3, 4, 3, 4);
            SearchFoodTxt.Name = "SearchFoodTxt";
            SearchFoodTxt.PasswordChar = '\0';
            SearchFoodTxt.PlaceholderText = "";
            SearchFoodTxt.SelectedText = "";
            SearchFoodTxt.ShadowDecoration.CustomizableEdges = customizableEdges8;
            SearchFoodTxt.Size = new Size(289, 51);
            SearchFoodTxt.TabIndex = 3;
            SearchFoodTxt.TextChanged += SearchFood;
            // 
            // FoodForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 806);
            Controls.Add(SearchFoodTxt);
            Controls.Add(FoodDgv);
            Controls.Add(addFoodbtn);
            Controls.Add(guna2Panel1);
            Name = "FoodForm";
            Text = "FoodForm";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FoodDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label1;
        private FontAwesome.Sharp.IconButton addFoodbtn;
        private Guna.UI2.WinForms.Guna2DataGridView FoodDgv;
        private DataGridViewTextBoxColumn dvgId;
        private DataGridViewTextBoxColumn dgvName;
        private DataGridViewTextBoxColumn dgvCategory;
        private DataGridViewImageColumn dgvEdit;
        private DataGridViewImageColumn dgvDel;
        private Guna.UI2.WinForms.Guna2TextBox SearchFoodTxt;
    }
}