using Dapper;
using DapperDemo.Model;
using MySqlConnector;
using System.Data.SqlClient;

namespace DapperDemo.Repo
{
    public class EmployeeRepository
    {
        private readonly string _connectionString;

        public EmployeeRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            using var conn = new MySqlConnection(_connectionString);

            string query = "SELECT * FROM Employees WHERE Sala > 20000";

            return await conn.QueryAsync<Employee>(query);
        }

        public async Task<int> Add(EmployeeDTO emp)
        {
            using var connection = new MySqlConnection(_connectionString);

            string query = "INSERT INTO Employees(Name, Sala) VALUES(@Name, @Salary)";

            return await connection.ExecuteAsync(query, emp);
        }

        public async Task<int> Delete(int id)
        {
            using var connection = new MySqlConnection(_connectionString);

            string query = "DELETE FROM Employees WHERE id = @id";

            return await connection.ExecuteAsync(query, new { id });
        }
    }
}