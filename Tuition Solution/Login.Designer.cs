namespace Tuition_Solution
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            userbox = new TextBox();
            button2 = new Button();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            show_pass = new CheckBox();
            textBox1 = new TextBox();
            login_panel = new Panel();

            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            login_panel.SuspendLayout();
            SuspendLayout();

            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(36, 77);
            label1.Text = "Username";

            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(36, 151);
            label2.Text = "Password";

            userbox.BackColor = Color.WhiteSmoke;
            userbox.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            userbox.Location = new Point(148, 77);
            userbox.Multiline = true;
            userbox.Size = new Size(206, 34);
            userbox.TextAlign = HorizontalAlignment.Center;

            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            textBox1.Location = new Point(148, 151);
            textBox1.Multiline = true;
            textBox1.Size = new Size(206, 34);
            textBox1.TextAlign = HorizontalAlignment.Center;

            show_pass.AutoSize = true;
            show_pass.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            show_pass.ForeColor = Color.White;
            show_pass.Location = new Point(207, 219);
            show_pass.Text = "Show Password";
            show_pass.CheckedChanged += show_pass_click;

            button2.BackColor = Color.Maroon;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(124, 262);
            button2.Size = new Size(122, 35);
            button2.Text = "Login";
            button2.Click += login_bt_click;

            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            linkLabel1.LinkColor = Color.Maroon;
            linkLabel1.Location = new Point(36, 219);
            linkLabel1.Text = "Forgot Password";
            linkLabel1.Click += forgot_click;

            linkLabel2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline);
            linkLabel2.LinkColor = Color.Chartreuse;
            linkLabel2.Location = new Point(113, 317);
            linkLabel2.Text = "Create a Account";
            linkLabel2.Click += create_click;

            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(58, 21);
            label3.Text = "Welcome Back ;)";

            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(625, 0);
            pictureBox2.Size = new Size(354, 517);

            login_panel.BackColor = Color.FromArgb(40, 42, 52);
            login_panel.Controls.Add(label3);
            login_panel.Controls.Add(textBox1);
            login_panel.Controls.Add(label1);
            login_panel.Controls.Add(show_pass);
            login_panel.Controls.Add(label2);
            login_panel.Controls.Add(userbox);
            login_panel.Controls.Add(button2);
            login_panel.Controls.Add(linkLabel1);
            login_panel.Controls.Add(linkLabel2);
            login_panel.Location = new Point(97, 62);
            login_panel.Size = new Size(396, 402);

            BackColor = Color.FromArgb(60, 63, 81);
            ClientSize = new Size(981, 520);
            Controls.Add(login_panel);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";

            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            login_panel.ResumeLayout(false);
            login_panel.PerformLayout();
            ResumeLayout(false);
        }

        private Label label1;
        private Label label2;
        private TextBox userbox;
        private Button button2;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Label label3;
        private PictureBox pictureBox2;
        private CheckBox show_pass;
        private TextBox textBox1;
        private Panel login_panel;
    }
}