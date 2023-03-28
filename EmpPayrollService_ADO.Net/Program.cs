namespace EmpPayrollService_ADO.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee payroll service using ADO.Net");
            EmployeePayroll employeePayroll = new EmployeePayroll();
            EmpPayrollModel empPayrollModel = new EmpPayrollModel()
            {
                EmployeeName = "Viraj",
                BasicPay = 2000000,
                Startdate = DateTime.Now,
                Gender = 'M',
                AddressOfEmp = "Panvel",
                PhoneNumber = 7759263023,
                Department = "Manager",
                Deduction = 0,
                TaxablePay = 0,
                IncomeTax = 0,
                NetPay = 0
            };
            EmpPayrollModel empUpdate = new EmpPayrollModel()
            {
                EmployeeName = "Terisa",
                BasicPay = 3000000
            };
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter an option");
                Console.WriteLine("1:Create new employee data\n2:Update Specific data\n3:Get all data from database\n4:Retrieve data for Startdate within range\n5:Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        employeePayroll.AddNewDataIntoDataBase(empPayrollModel);
                        break;
                    case 2:
                        employeePayroll.UpadteSpecificData(empUpdate);
                        break;
                    case 3:
                        employeePayroll.GetAllDataFromDB();
                        break;
                    case 4:
                        employeePayroll.RetriveDataForStartdateWithinRange();
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Please enter right option");
                        break;
                }
            }
        }
    }
}