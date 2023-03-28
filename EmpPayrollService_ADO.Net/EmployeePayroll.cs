using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpPayrollService_ADO.Net
{
    public class EmployeePayroll
    {
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Payroll_Service_DB";
        public void AddNewDataIntoDataBase(EmpPayrollModel empPayrollModel)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                using (sqlConnection)
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("SpEmployeePayroll_Table", sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@EmployeeName", empPayrollModel.EmployeeName);
                    sqlCommand.Parameters.AddWithValue("@BasicPay", empPayrollModel.BasicPay);
                    sqlCommand.Parameters.AddWithValue("@Startdate", empPayrollModel.Startdate); 
                    sqlCommand.Parameters.AddWithValue("@Gender", empPayrollModel.Gender);
                    sqlCommand.Parameters.AddWithValue("@AddressOfEmp", empPayrollModel.AddressOfEmp);
                    sqlCommand.Parameters.AddWithValue("@PhoneNumber", empPayrollModel.PhoneNumber);
                    sqlCommand.Parameters.AddWithValue("@Department", empPayrollModel.Department);
                    sqlCommand.Parameters.AddWithValue("@Deduction", empPayrollModel.Deduction);
                    sqlCommand.Parameters.AddWithValue("@TaxablePay", empPayrollModel.TaxablePay);
                    sqlCommand.Parameters.AddWithValue("@IncomeTax", empPayrollModel.IncomeTax);
                    sqlCommand.Parameters.AddWithValue("@NetPay", empPayrollModel.NetPay);

                    int result = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    if(result >= 1)
                        Console.WriteLine("New employee data added successfully");
                    else
                        Console.WriteLine("Error while adding new data");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void UpadteSpecificData(EmpPayrollModel empPayrollModel)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                using (sqlConnection)
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("SpUpdateSalaryData", sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@EmployeeName", empPayrollModel.EmployeeName);
                    sqlCommand.Parameters.AddWithValue("@BasicPay", empPayrollModel.BasicPay);
                    int result = sqlCommand.ExecuteNonQuery();

                    if(result >= 1)
                        Console.WriteLine("Data updated successfully");
                    else
                        Console.WriteLine("Data not found for updating");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
