using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mini_Market_Management_System
{
    public partial class LoginForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public static string sellerName;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Goldenrod;
        }

        private void label_clear_MouseEnter(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Red;
        }

        private void label_clear_MouseLeave(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Goldenrod;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_clear_Click(object sender, EventArgs e)
        {
            TextBox_username.Clear();
            TextBox_password.Clear();
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            // Check empty fields
            if (TextBox_username.Text == "" ||
                TextBox_password.Text == "")
            {
                MessageBox.Show(
                    "Please Enter Username and Password",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // Check role selected
            if (comboBox_role.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please Select Role",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                SqlConnection con = dBCon.GetCon();

                // ======================
                // ADMIN LOGIN
                // ======================
                if (comboBox_role.SelectedItem.ToString() == "ADMIN")
                {
                    string adminQuery =
                        "SELECT COUNT(*) FROM AdminTbl " +
                        "WHERE AdminName=@username " +
                        "AND AdminPass=@password";

                    SqlCommand cmd =
                        new SqlCommand(adminQuery, con);

                    cmd.Parameters.AddWithValue(
                        "@username",
                        TextBox_username.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@password",
                        TextBox_password.Text.Trim());

                    con.Open();

                    int count =
                        (int)cmd.ExecuteScalar();

                    con.Close();

                    if (count > 0)
                    {
                        ProductForm product =
                            new ProductForm();

                        product.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Wrong Admin Username or Password",
                            "Login Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }

                // ======================
                // SELLER LOGIN
                // ======================
                else if (comboBox_role.SelectedItem.ToString() == "SELLER")
                {
                    string sellerQuery =
                        "SELECT COUNT(*) FROM Seller " +
                        "WHERE SellerName=@username " +
                        "AND SellerPass=@password";

                    SqlCommand cmd =
                        new SqlCommand(sellerQuery, con);

                    cmd.Parameters.AddWithValue(
                        "@username",
                        TextBox_username.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@password",
                        TextBox_password.Text.Trim());

                    con.Open();

                    int count =
                        (int)cmd.ExecuteScalar();

                    con.Close();

                    if (count > 0)
                    {
                        sellerName =
                            TextBox_username.Text;

                        SellingForm selling =
                            new SellingForm();

                        selling.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Wrong Seller Username or Password",
                            "Login Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}