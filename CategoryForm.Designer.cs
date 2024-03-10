namespace GUI
{
    partial class CategoryForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Categorydgv = new Guna.UI2.WinForms.Guna2DataGridView();
            dgvId = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            dgvEdit = new DataGridViewImageColumn();
            dgvDel = new DataGridViewImageColumn();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            SearchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)Categorydgv).BeginInit();
            SuspendLayout();
            // 
            // Categorydgv
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            Categorydgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            Categorydgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Categorydgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Categorydgv.ColumnHeadersHeight = 22;
            Categorydgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Categorydgv.Columns.AddRange(new DataGridViewColumn[] { dgvId, dgvName, dgvEdit, dgvDel });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Categorydgv.DefaultCellStyle = dataGridViewCellStyle3;
            Categorydgv.GridColor = Color.FromArgb(231, 229, 255);
            Categorydgv.Location = new Point(70, 176);
            Categorydgv.Name = "Categorydgv";
            Categorydgv.RowHeadersVisible = false;
            Categorydgv.RowHeadersWidth = 51;
            Categorydgv.Size = new Size(1233, 547);
            Categorydgv.TabIndex = 0;
            Categorydgv.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            Categorydgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            Categorydgv.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            Categorydgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            Categorydgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            Categorydgv.ThemeStyle.BackColor = Color.White;
            Categorydgv.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            Categorydgv.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            Categorydgv.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            Categorydgv.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            Categorydgv.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            Categorydgv.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Categorydgv.ThemeStyle.HeaderStyle.Height = 22;
            Categorydgv.ThemeStyle.ReadOnly = false;
            Categorydgv.ThemeStyle.RowsStyle.BackColor = Color.White;
            Categorydgv.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Categorydgv.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            Categorydgv.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            Categorydgv.ThemeStyle.RowsStyle.Height = 29;
            Categorydgv.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            Categorydgv.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            Categorydgv.CellClick += Categorydgv_CellClick;
            // 
            // dgvId
            // 
            dgvId.DataPropertyName = "CategoryId";
            dgvId.FillWeight = 33.5115852F;
            dgvId.HeaderText = "Id";
            dgvId.MinimumWidth = 6;
            dgvId.Name = "dgvId";
            dgvId.Width = 101;
            // 
            // dgvName
            // 
            dgvName.DataPropertyName = "CategoryName";
            dgvName.FillWeight = 33.5115852F;
            dgvName.HeaderText = "Name";
            dgvName.MinimumWidth = 6;
            dgvName.Name = "dgvName";
            dgvName.Width = 850;
            // 
            // dgvEdit
            // 
            dgvEdit.FillWeight = 299.46524F;
            dgvEdit.HeaderText = "";
            dgvEdit.Image = (Image)resources.GetObject("dgvEdit.Image");
            dgvEdit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvEdit.MinimumWidth = 70;
            dgvEdit.Name = "dgvEdit";
            dgvEdit.Width = 140;
            // 
            // dgvDel
            // 
            dgvDel.FillWeight = 33.5115852F;
            dgvDel.HeaderText = "";
            dgvDel.Image = (Image)resources.GetObject("dgvDel.Image");
            dgvDel.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvDel.MinimumWidth = 6;
            dgvDel.Name = "dgvDel";
            dgvDel.Width = 140;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 28);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 2;
            label1.Text = "Category ";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.LightCoral;
            iconButton1.ForeColor = SystemColors.ControlDark;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(70, 123);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(84, 47);
            iconButton1.TabIndex = 3;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += AddCategory;
            // 
            // SearchTxt
            // 
            SearchTxt.CustomizableEdges = customizableEdges1;
            SearchTxt.DefaultText = "";
            SearchTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            SearchTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            SearchTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            SearchTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            SearchTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchTxt.Font = new Font("Segoe UI", 9F);
            SearchTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchTxt.IconLeft = (Image)resources.GetObject("SearchTxt.IconLeft");
            SearchTxt.IconLeftSize = new Size(50, 50);
            SearchTxt.IconRightSize = new Size(50, 50);
            SearchTxt.Location = new Point(1014, 108);
            SearchTxt.Margin = new Padding(3, 4, 3, 4);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.PasswordChar = '\0';
            SearchTxt.PlaceholderText = "";
            SearchTxt.SelectedText = "";
            SearchTxt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            SearchTxt.Size = new Size(289, 51);
            SearchTxt.TabIndex = 4;
            SearchTxt.TextChanged += SearchCategory;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 806);
            Controls.Add(SearchTxt);
            Controls.Add(iconButton1);
            Controls.Add(label1);
            Controls.Add(Categorydgv);
            Name = "CategoryForm";
            Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)Categorydgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView Categorydgv;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DataGridViewTextBoxColumn dgvId;
        private DataGridViewTextBoxColumn dgvName;
        private DataGridViewImageColumn dgvEdit;
        private DataGridViewImageColumn dgvDel;
        private Guna.UI2.WinForms.Guna2TextBox SearchTxt;
    }
}