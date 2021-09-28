using System;
using System.Collections.Generic;
using System.Text;


namespace InheritanceTask
{
    public class Company
    {
        private Employee[] employees;

        public Company(Employee[] employees)
        {
            this.employees = employees;
        }
        public void GiveEverybodyBonus (decimal companyBonus)
        {
            foreach (Employee employee in employees)
                employee.SetBonus(companyBonus);
        }
        public decimal TotalToPay()
        {
            decimal total = 0;
            foreach (Employee employee in employees)
                total += employee.ToPay();
            return total;
        }
        public string NameMaxSalary()
        {
            decimal maximum = employees[0].ToPay();
            Employee employee = employees[0];
            for(int i = 0; i < employees.Length; i++)
            {
                if (employees[i].ToPay() > maximum)
                {
                    maximum = employees[i].ToPay();
                    employee = employees[i];
                }
            }
            return employee.Name;
        }
    }
}
