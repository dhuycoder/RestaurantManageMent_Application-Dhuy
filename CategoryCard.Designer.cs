namespace GUI
{
    partial class CategoryCard
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
            CategoryImagePtb = new Guna.UI2.WinForms.Guna2PictureBox();
            CategoryNameLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)CategoryImagePtb).BeginInit();
            SuspendLayout();
            // 
            // CategoryImagePtb
            // 
            CategoryImagePtb.CustomizableEdges = customizableEdges1;
            CategoryImagePtb.ImageRotate = 0F;
            CategoryImagePtb.Location = new Point(3, 3);
            CategoryImagePtb.Name = "CategoryImagePtb";
            CategoryImagePtb.ShadowDecoration.CustomizableEdges = customizableEdges2;
            CategoryImagePtb.Size = new Size(242, 96);
            CategoryImagePtb.SizeMode = PictureBoxSizeMode.Zoom;
            CategoryImagePtb.TabIndex = 0;
            CategoryImagePtb.TabStop = false;
            // 
            // CategoryNameLbl
            // 
            CategoryNameLbl.AutoSize = true;
            CategoryNameLbl.Location = new Point(101, 102);
            CategoryNameLbl.Name = "CategoryNameLbl";
            CategoryNameLbl.Size = new Size(50, 20);
            CategoryNameLbl.TabIndex = 1;
            CategoryNameLbl.Text = "label1";
            // 
            // CategoryCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CategoryNameLbl);
            Controls.Add(CategoryImagePtb);
            Name = "CategoryCard";
            Size = new Size(248, 133);
            ((System.ComponentModel.ISupportInitialize)CategoryImagePtb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox CategoryImagePtb;
        private Label CategoryNameLbl;
    }
}
