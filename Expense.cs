using System;
namespace CourseAssignment
{
	public class Expense: Budget
	{
		DateOnly ExpenseDate;

		public Expense(string name, decimal amount, DateOnly expenseDate): base (name, amount)
		{
			ExpenseDate = expenseDate;
		}

		
    }
}

