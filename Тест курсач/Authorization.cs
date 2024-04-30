using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СделаНо
{
    public partial class Authorization : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Тест_курсач.Properties.Settings.СделаНоConnectionString"].ConnectionString;

        public Authorization()
        {
            InitializeComponent();
        }

        private void butAut_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand checkAdminQuery = new SqlCommand("SELECT COUNT(*) FROM Сотрудник WHERE Роль = 'Администратор'", connection);
                int adminCount = (int)checkAdminQuery.ExecuteScalar();

                if (adminCount == 0)
                {
                    SqlCommand createAdminQuery = new SqlCommand("INSERT INTO Сотрудник (ФИО, Логин, Пароль, Роль, Телефон) VALUES (@ФИО, @Логин, @Пароль, 'Администратор', @Телефон)", connection);
                    createAdminQuery.Parameters.AddWithValue("@ФИО", "Бугай Дмитрий Александрович");
                    createAdminQuery.Parameters.AddWithValue("@Логин", "администратор");
                    createAdminQuery.Parameters.AddWithValue("@Пароль", "администратор");
                    createAdminQuery.Parameters.AddWithValue("@Телефон", "+375259482128");
                    createAdminQuery.ExecuteNonQuery();
                }

                SqlCommand loginQuery = new SqlCommand("SELECT ИдСотрудника, ФИО, Роль FROM Сотрудник WHERE Логин = @Логин AND Пароль = @Пароль", connection);
                loginQuery.Parameters.AddWithValue("@Логин", username);
                loginQuery.Parameters.AddWithValue("@Пароль", password);

                using (SqlDataReader reader = loginQuery.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string role = reader["Роль"].ToString();
                        string fns = reader["ФИО"].ToString();
                        int idsotr = Convert.ToInt32(reader["ИдСотрудника"]);
                        switch (role)
                        {
                            case "Администратор":
                                Admin adminForm = new Admin(fns);
                                adminForm.Show();
                                
                                break;
                            case "Менеджер":
                                Manager managerForm = new Manager(fns);
                                managerForm.Show();
                                break;
                            case "Мастер":
                                MasterForm masterForm = new MasterForm(fns,idsotr);
                                masterForm.Show();
                                break;
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                    }
                }
            }
            usernameTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void butExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
