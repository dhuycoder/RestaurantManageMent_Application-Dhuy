using GUI;

namespace Restaurant_ManageMent_Application
{
    public partial class MainForm : Form
    {

        public MainForm()
        {

            InitializeComponent();


        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null && !activeForm.IsDisposed)
            {
                activeForm.Close();
            }

            activeForm = childForm;

            childForm.FormClosing += (sender, e) =>
            {
                if (!e.CloseReason.HasFlag(CloseReason.UserClosing))
                {
                    return; // Chỉ ngăn chặn đóng form khi là do người dùng tác động
                }

                e.Cancel = true; // Ngăn chặn form đóng
                childForm.Hide(); // Ẩn thay vì đóng
            };

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(childForm);
            childForm.Show();

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CategoryForm form2 = new CategoryForm();
            openChildForm(form2);

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            FoodForm foodfForm = new FoodForm();
            openChildForm(foodfForm);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            activeForm.Close();

        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {

            MenuFlowPanel menuFlowPanel = new MenuFlowPanel();
            openChildForm(menuFlowPanel);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form1 menuFlowPanel = new Form1();
            openChildForm(menuFlowPanel);
        }
    }
}
