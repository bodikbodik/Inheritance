using System;
using System.Collections.Generic;
using System.Text;


namespace InheritanceTask
{
    public class Company
    {
        private readonly Employee[] employees;
        public Company (Employee[] employees)
        {
            this.employees = employees;
        }
        public void GiveEverybodyBonus(decimal companyBonus)
        {
            foreach (Employee employee in employees)
            {
                employee.SetBonus(companyBonus);
            }
        }
        public decimal TotalToPay()
        {
            decimal totalSalary = 0;
            foreach (Employee employee in employees)
            {
                totalSalary += employee.ToPay();
            }
            return totalSalary;

        }
        public string NameMaxSalary()
        {
            int index = 0;
            for (int i = 1; i < employees.Length; i++)
            {
                if(employees[index].ToPay() < employees[i].ToPay())
                    index = i;

            }
            return employees[index].Name;
        }
    }
}
