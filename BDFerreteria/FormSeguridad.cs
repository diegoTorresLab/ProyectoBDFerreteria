using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BDFerreteria
{
    public partial class FormSeguridad : Form
    {
        public FormSeguridad()
        {
            InitializeComponent();
        }
        private void btnLateralMenu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show(this);
            this.Hide();
        }

        private void btnLateralClientes_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.Show(this);
            this.Hide();
        }

        private void btnLateralEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleados formEmpleados = new FormEmpleados();
            formEmpleados.Show(this);
            this.Hide();
        }

        private void btnLateralProductos_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos();
            formProductos.Show(this);
            this.Hide();
        }

        private void btnLateralProveedores_Click(object sender, EventArgs e)
        {
            FormProveedores formProveedores = new FormProveedores();
            formProveedores.Show(this);
            this.Hide();
        }

        private void btnLateralPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos formPedidos = new FormPedidos();
            formPedidos.Show(this);
            this.Hide();
        }
        private void btnLateralSeguridad_Click(object sender, EventArgs e)
        {
            FormSeguridad formSeguridad = new FormSeguridad();
            formSeguridad.Show(this);
            this.Hide();
        }

        private void btnLateralVentas_Click(object sender, EventArgs e)
        {
            FormVentas formVentas = new FormVentas();
            formVentas.Show(this);
            this.Hide();
        }

        private void btnMigrar_Click(object sender, EventArgs e)
        {
            string databaseName = PromptForDatabaseName();
            if (string.IsNullOrWhiteSpace(databaseName))
            {
                MessageBox.Show("ERROR!, ingrese un nombre para la Bases de Datos.");
                return;
            }

            string sqlServerConnectionString = "Server=DIEK;Database=FerreteriaPBD;Integrated Security=True;";
            string mySqlServerConnectionString = "Server=localhost;User Id=root;Password=12345;";

            string[] tablas = { "Proveedores", "Categorias", "ProductosAlta", "Estados", "RevisionesInventario", "Clientes", "Empleados", "Venta", "Pedidos", "Devolucion" };

            using (SqlConnection sqlConnection = new SqlConnection(sqlServerConnectionString))
            {
                sqlConnection.Open();

                using (MySqlConnection mySqlConnection = new MySqlConnection(mySqlServerConnectionString))
                {
                    mySqlConnection.Open();

                    // Crear la base de datos en MySQL
                    string createDatabaseQuery = $"CREATE DATABASE IF NOT EXISTS {databaseName};";
                    using (MySqlCommand createDbCommand = new MySqlCommand(createDatabaseQuery, mySqlConnection))
                    {
                        createDbCommand.ExecuteNonQuery();
                    }
                    mySqlConnection.ChangeDatabase(databaseName);

                    foreach (string tabla in tablas)
                    {
                        string sqlTableQuery = $"SELECT * FROM {tabla}";
                        DataTable schemaTable;

                        using (SqlCommand sqlCommand = new SqlCommand(sqlTableQuery, sqlConnection))
                        using (SqlDataReader sqlReader = sqlCommand.ExecuteReader(CommandBehavior.SchemaOnly))
                        {
                            schemaTable = sqlReader.GetSchemaTable();
                        }
                        string checkTableQuery = $"SHOW TABLES LIKE '{tabla}';";
                        using (MySqlCommand checkTableCommand = new MySqlCommand(checkTableQuery, mySqlConnection))
                        {
                            var result = checkTableCommand.ExecuteScalar();

                            if (result == null)
                            {
                                string createTableQuery = GenerateCreateTableQuery(tabla, schemaTable);
                                using (MySqlCommand createTableCommand = new MySqlCommand(createTableQuery, mySqlConnection))
                                {
                                    createTableCommand.ExecuteNonQuery();
                                }
                            }
                        }
                        using (SqlCommand sqlCommand = new SqlCommand(sqlTableQuery, sqlConnection))
                        using (SqlDataReader sqlReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlReader.Read())
                            {
                                string insertQuery = GenerateInsertQuery(tabla, schemaTable);

                                using (MySqlCommand mySqlCommand = new MySqlCommand(insertQuery, mySqlConnection))
                                {
                                    foreach (DataRow row in schemaTable.Rows)
                                    {
                                        string columnName = row["ColumnName"].ToString();
                                        mySqlCommand.Parameters.AddWithValue($"@{columnName}", sqlReader[columnName]);
                                    }
                                    mySqlCommand.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    mySqlConnection.Close();
                }
            }
            MessageBox.Show("Migración de la base de datos completada.");

        }

        private string GenerateCreateTableQuery(string tableName, DataTable schemaTable)
        {
            string createTableQuery = $"CREATE TABLE {tableName} (";

            foreach (DataRow row in schemaTable.Rows)
            {
                string columnName = row["ColumnName"].ToString();
                string columnType = GetMySqlType(row["DataType"].ToString());
                createTableQuery += $"{columnName} {columnType}, ";
            }

            createTableQuery = createTableQuery.TrimEnd(',', ' ') + ");";
            return createTableQuery;
        }

        private string GetMySqlType(string sqlServerType)
        {
            switch (sqlServerType)
            {
                case "System.Int32":
                    return "INT";
                case "System.String":
                    return "VARCHAR(255)"; 
                case "System.DateTime":
                    return "DATETIME";
                case "System.Boolean":
                    return "TINYINT(1)";
                case "System.Decimal":
                    return "DECIMAL(18, 2)";
                case "System.Double":
                    return "DOUBLE";
                case "System.Byte[]":
                    return "BLOB";
                case "System.NVarChar":
                    return "VARCHAR(255)";
                default:
                    throw new Exception($"Tipo de datos no soportado: {sqlServerType}");
            }
        }

        private string GenerateInsertQuery(string tableName, DataTable schemaTable)
        {
            string columns = string.Join(", ", schemaTable.Rows.Cast<DataRow>().Select(row => row["ColumnName"].ToString()));
            string values = string.Join(", ", schemaTable.Rows.Cast<DataRow>().Select(row => $"@{row["ColumnName"].ToString()}"));
            return $"INSERT INTO {tableName} ({columns}) VALUES ({values})";
        }

        private string PromptForDatabaseName()
        {
            using (FormNombreBD inputBox = new FormNombreBD("Ingrese como quiere que se llame la base de datos en MySQL:"))
            {
                if (inputBox.ShowDialog() == DialogResult.OK)
                {
                    return inputBox.NombreBD;
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }
}

