using Guna.UI2.WinForms;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace СделаНо
{
	public partial class Admin : Form
	{
		string connectionString = ConfigurationManager.ConnectionStrings["Тест_курсач.Properties.Settings.СделаНоConnectionString"].ConnectionString;
		private string fns1;
		private int click = 0;
		public Admin(string fns)
		{
			InitializeComponent();
			fns1 = fns;
		}

		private void Admin_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "сделаНоDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
			this.сотрудникTableAdapter.Fill(this.сделаНоDataSet.Сотрудник);

			MessageBox.Show("Здравствуйте, " + fns1);
			label3.Text = fns1;

			FillDataGridView();

			textFIO.Enabled = false;
			textLogin.Enabled = false;
			textPass.Enabled = false;
			comboRole.Enabled = false;
			textTel.Enabled = false;

			butGood.Visible = false;
			butBack.Visible = false;
		}

		private void butExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void clear()
		{
			textFIO.Clear();
			textLogin.Clear();
			textPass.Clear();
			textTel.Clear();
		}

		private void butClear_Click(object sender, EventArgs e)
		{
			if (click == 1)
			{
				try
				{
					if (string.IsNullOrWhiteSpace(textFIO.Text) || string.IsNullOrWhiteSpace(textLogin.Text)
							|| string.IsNullOrWhiteSpace(textPass.Text) || string.IsNullOrWhiteSpace(textTel.Text))
					{
						MessageBox.Show("Пожалуйста, заполните все поля.");
						return;
					}

					string FIO = textFIO.Text;
					string login = textLogin.Text;
					string pass = textPass.Text;
					string role = comboRole.Text;
					string tel = textTel.Text;

					if (!IsValidName(FIO))
					{
						MessageBox.Show("ФИО должно: состоять из 3 слов, каждое слово начинаться с большой буквы и быть на русском языке.");
						return;
					}
					else if (!IsValidTelefon(tel))
					{
						MessageBox.Show("Номер телефона должен начинаться на +375 и состоять из 12 цифр");
						return;
					}
					else
					{
						using (SqlConnection connection = new SqlConnection(connectionString))
						{
							connection.Open();

							using (SqlCommand command = new SqlCommand("InsertEmployee", connection))
							{
								command.CommandType = CommandType.StoredProcedure;
								command.Parameters.AddWithValue("@ФИО", FIO);
								command.Parameters.AddWithValue("@Логин", login);
								command.Parameters.AddWithValue("@Пароль", pass);
								command.Parameters.AddWithValue("@Роль", role);
								command.Parameters.AddWithValue("@Телефон", tel);

								command.ExecuteNonQuery();
							}

							FillDataGridView();

							MessageBox.Show("Данные добавлены успешно.");
						}
					}
				}
				catch (System.Data.SqlClient.SqlException)
				{
					MessageBox.Show("Строка не может быть добавление!!!",
				   "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else if (click == 2)
			{
				try
				{
					if (string.IsNullOrWhiteSpace(textFIO.Text) || string.IsNullOrWhiteSpace(textLogin.Text)
						|| string.IsNullOrWhiteSpace(textPass.Text) || string.IsNullOrWhiteSpace(textTel.Text))
					{
						MessageBox.Show("Пожалуйста, заполните все поля.");
						return;
					}
					int selectedEmployeeId = (int)data1.CurrentRow.Cells[0].Value;
					string FIO = textFIO.Text;
					string login = textLogin.Text;
					string pass = textPass.Text;
					string role = comboRole.Text;
					string tel = textTel.Text.ToString();

					if (!IsValidName(FIO))
					{
						MessageBox.Show("ФИО должно: состоять из 3 слов, каждое слово начинаться с большой буквы и быть на русском языке.");
						return;
					}
					else if (!IsValidTelefon(tel))
					{
						MessageBox.Show("Номер телефона должен начинаться на +375 и состоять из 12 цифр");
						return;
					}
					else
					{
						using (SqlConnection connection = new SqlConnection(connectionString))
						{
							connection.Open();

							using (SqlCommand command = new SqlCommand("UpdateEmployee", connection))
							{
								command.CommandType = CommandType.StoredProcedure;
								command.Parameters.AddWithValue("@ИдСотрудника", selectedEmployeeId);
								command.Parameters.AddWithValue("@ФИО", FIO);
								command.Parameters.AddWithValue("@Логин", login);
								command.Parameters.AddWithValue("@Пароль", pass);
								command.Parameters.AddWithValue("@Роль", role);
								command.Parameters.AddWithValue("@Телефон", tel);

								command.ExecuteNonQuery();
							}
							FillDataGridView();
						}
						MessageBox.Show("Данные изменены успешно.");
					}
				}
				catch (System.Data.SqlClient.SqlException)
				{
					MessageBox.Show("Строка не может быть добавление!!!",
				   "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			click = 0;
			textFIO.Enabled = false;
			textLogin.Enabled = false;
			textPass.Enabled = false;
			comboRole.Enabled = false;
			textTel.Enabled = false;

			butGood.Visible = false;
			butBack.Visible = false;

			butAdd.Visible = true;
			butEdit.Visible = true;
			butDelete.Visible = true;
			butExp.Visible = true;
		}

		private void FillDataGridView()
		{
			string storedProcedureName = "GetEmployees";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
				{
					command.CommandType = CommandType.StoredProcedure;

					SqlDataAdapter adapter = new SqlDataAdapter(command);
					DataTable table = new DataTable();
					adapter.Fill(table);
					data1.DataSource = table;
				}
			}
		}

		private bool IsValidName(string name)
		{
			string pattern = @"^[\p{L}\p{M}'\.\-]+ [\p{L}\p{M}'\.\-]+ [\p{L}\p{M}'\.\-]+$";
			return Regex.IsMatch(name, pattern);
		}

		private bool IsValidTelefon(string name)
		{
			string pattern = @"^\+375\d{2}\d{3}\d{2}\d{2}$";
			return Regex.IsMatch(name, pattern);
		}

		private void butAdd_Click(object sender, EventArgs e)
		{
			textFIO.Enabled = true;
			textLogin.Enabled = true;
			textPass.Enabled = true;
			comboRole.Enabled = true;
			textTel.Enabled = true;

			clear();

			click = 1;

			butGood.Visible = true;
			butBack.Visible = true;

			butAdd.Visible = false;
			butEdit.Visible = false;
			butDelete.Visible = false;
			butExp.Visible = false;
		}

		private void butEdit_Click(object sender, EventArgs e)
		{
			textFIO.Enabled = true;
			textLogin.Enabled = true;
			textPass.Enabled = true;
			comboRole.Enabled = true;
			textTel.Enabled = true;

			click = 2;

			butGood.Visible = true;
			butBack.Visible = true;

			butAdd.Visible = false;
			butEdit.Visible = false;
			butDelete.Visible = false;
			butExp.Visible = false;
		}

		private void butDelete_Click(object sender, EventArgs e)
		{
			try
			{
				int selectedEmployeeId = (int)data1.CurrentRow.Cells[0].Value;

				bool isDeletingAdmin = IsEmployeeAdmin(selectedEmployeeId);

				if (!isDeletingAdmin || CountAdministrators() > 1)
				{
					using (SqlConnection connection = new SqlConnection(connectionString))
					{
						connection.Open();

						using (SqlCommand command = new SqlCommand("DeleteEmployee", connection))
						{
							command.CommandType = CommandType.StoredProcedure;
							command.Parameters.AddWithValue("@ИдСотрудника", selectedEmployeeId);
							command.ExecuteNonQuery();
						}

						FillDataGridView();
						MessageBox.Show("Данные удалены успешно.");
					}
				}
				else
				{
					MessageBox.Show("Нельзя удалить последнего администратора.");
				}
			}
			catch (System.Data.SqlClient.SqlException)
			{
				MessageBox.Show("Строка не может быть удалена!!!",
					"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool IsEmployeeAdmin(int employeeId)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string query = "SELECT COUNT(*) FROM Сотрудник WHERE Роль = 'Администратор' AND ИдСотрудника = @EmployeeId";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@EmployeeId", employeeId);
					int adminCount = (int)command.ExecuteScalar();
					return adminCount > 0;
				}
			}
		}

		private int CountAdministrators()
		{
			int adminCount = 0;

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string query = "SELECT COUNT(*) FROM Сотрудник WHERE Роль = 'Администратор'";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					adminCount = (int)command.ExecuteScalar();
				}
			}

			return adminCount;
		}

		private void butSort_Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string sortField = "ФИО";
				string sortOrder = comboBoxSort2.Text;

				sortOrder = comboBoxSort2.Text;
				switch (sortOrder)
				{
					case "По возрастанию":
						sortOrder = "ASC";
						break;
					case "По убыванию":
						sortOrder = "DESC";
						break;
				}

				using (SqlCommand command = new SqlCommand("SortEmployees", connection))
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@SortField", sortField);
					command.Parameters.AddWithValue("@SortOrder", sortOrder);

					SqlDataAdapter adapter = new SqlDataAdapter(command);
					DataTable table = new DataTable();
					adapter.Fill(table);
					data1.DataSource = table;
				}

				MessageBox.Show("Список отсортирован.");
			}
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			if (data1.SelectedRows.Count > 0)
			{
				textFIO.Text = data1.CurrentRow.Cells[1].Value.ToString();
				textLogin.Text = data1.CurrentRow.Cells[2].Value.ToString();
				textPass.Text = data1.CurrentRow.Cells[3].Value.ToString();
				comboRole.Text = data1.CurrentRow.Cells[4].Value.ToString();
				textTel.Text = data1.CurrentRow.Cells[5].Value.ToString();

			}
		}

		private void textBoxFindFam_TextChanged(object sender, EventArgs e)
		{
			try
			{
				string filterText = textBoxFindFam.Text;
				string findField = "ФИО";

				if (data1.DataSource is DataTable dataTable)
				{
					if (!string.IsNullOrWhiteSpace(filterText))
					{
						dataTable.DefaultView.RowFilter = $"{findField} LIKE '{filterText}%'";
					}
					else
					{
						dataTable.DefaultView.RowFilter = string.Empty;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ошибка фильтрации: {ex.Message}");
			}
		}

		private void butBack_Click(object sender, EventArgs e)
		{
			click = 0;
			textFIO.Enabled = false;
			textLogin.Enabled = false;
			textPass.Enabled = false;
			comboRole.Enabled = false;
			textTel.Enabled = false;

			butGood.Visible = false;
			butBack.Visible = false;

			butAdd.Visible = true;
			butEdit.Visible = true;
			butDelete.Visible = true;
			butExp.Visible = true;
		}

		private void butExp_Click(object sender, EventArgs e)
		{
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
				saveFileDialog.FilterIndex = 1;
				saveFileDialog.RestoreDirectory = true;

				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					string exportFilePath = saveFileDialog.FileName;
					FileInfo templateFile = new FileInfo("Список сотрудников.xlsx");

					FileInfo exportFile = new FileInfo(exportFilePath);

					using (ExcelPackage package = new ExcelPackage(exportFile, templateFile))
					{
						ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

						DataTable dataTable = GetEmployeeData();

						worksheet.Cells["B2"].LoadFromDataTable(dataTable, true);

						package.Save();
						MessageBox.Show("Экспорт данных завершен.");
					}
				}
			}
		}

		private DataTable GetEmployeeData()
		{

			DataTable dataTable = new DataTable();
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string query = "SELECT ИдСотрудника, ФИО, Логин, Пароль, Роль, Телефон FROM Сотрудник";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					connection.Open();
					using (SqlDataAdapter adapter = new SqlDataAdapter(command))
					{
						adapter.Fill(dataTable);
					}
				}
			}

			return dataTable;
		}
	}
}
