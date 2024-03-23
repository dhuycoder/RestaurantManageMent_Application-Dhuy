namespace GUI
{
    partial class DetailBill
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
            flpFoodOrder = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // flpFoodOrder
            // 
            flpFoodOrder.AutoScroll = true;
            flpFoodOrder.Location = new Point(72, 86);
            flpFoodOrder.Name = "flpFoodOrder";
            flpFoodOrder.Size = new Size(566, 441);
            flpFoodOrder.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 25);
            label1.Name = "label1";
            label1.Size = new Size(238, 38);
            label1.TabIndex = 1;
            label1.Text = "Chi tiết hóa đơn ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(507, 589);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "Tiền giảm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(604, 589);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 3;
            label3.Text = "500000  đ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(507, 550);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 4;
            label4.Text = "Tổng tiền: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(604, 550);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 5;
            label5.Text = "20000000  đ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(507, 625);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 6;
            label6.Text = "Thành tiền:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(604, 625);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 7;
            label7.Text = "15000000  đ";
            // 
            // DetailBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 650);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flpFoodOrder);
            Name = "DetailBill";
            Text = "DetailBill";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpFoodOrder;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}