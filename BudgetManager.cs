using System;
namespace CourseAssignment
{
	public class BudgetManager: Budget
	{
		private List<Budget> BudgetItems;
		private List<Expense> ExpenseItems;
        //private List<Timeline> DatePeriod;

        public BudgetManager()
        {
            BudgetItems = new List<Budget>();
            ExpenseItems = new List<Expense>();
            //DatePeriod = new List<Timeline>();
        }

        //public void AddMonthYear(string month, string year)
        //{

        //    Timeline period = new Timeline(month, year);
        //    DatePeriod.Add(period);

        //    Console.WriteLine(" ");
        //    Console.WriteLine(">>> >> Month and Year Added Successfully << <<<");
        //    Console.WriteLine(" ");
        //}

        public bool AddBudgetCategory(string name, decimal amount)
        {

             foreach (Budget item in BudgetItems)
             {
                 if(item.GetName() == name)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(">>> >> Category Already Exist!!! << <<<");
                    Console.WriteLine(" ");
                    return false;
                }
            }
             Budget budget = new Budget(name, amount);
             BudgetItems.Add(budget);
            Console.WriteLine(" ");
            Console.WriteLine(">>> >> Category Added Successfully << <<<");
            Console.WriteLine(" ");
            return true;

        }


        public bool EditBudgetCategory(string oldName, string newName, decimal newAmount)
        {
            foreach (Budget item in BudgetItems)
            {
                if (item.GetName() == oldName)
                {
                    item.SetName(newName);
                    item.SetAmount(newAmount);
                    Console.WriteLine(">>>  Category Name and Amount Updated <<<");
                    return true;
                }
            }

            Console.WriteLine(">>> Category Name and Amount not found <<<");
            return false;
        }

        public bool DeleteBudgetCategory(string name)
        {
            foreach (Budget item in BudgetItems)
            {
                if(item.GetName() == name)
                {
                    BudgetItems.Remove(item);
                    Console.WriteLine(" ");
                    Console.WriteLine("--- Category deleted successfully ---");
                    Console.WriteLine(" ");
                    return true;
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine(">>> >> No record found for the category selected << <<<");
            Console.WriteLine(" ");
            return false;

        }

        public void AddExpenses(string name, decimal amount, DateOnly expenseDate)
        {
            Expense expense = new Expense(name, amount, expenseDate);
            ExpenseItems.Add(expense);
        }

        public void DeleteExpenseCategory(string name, decimal amount)
        {
            foreach (Expense item in ExpenseItems)
            {
                if (item.GetName() == name && item.GetAmount() == amount)
                {
                   ExpenseItems.Remove(item);
                }
            }

        }

        public void DisplayBudgetItems()
        {

            //foreach (Timeline i in DatePeriod)
            //{
            //    Console.WriteLine($"Budget List for the month of {i.getMonth()} {i.getYear()}");
            //}

            Console.WriteLine("Budget List");

            foreach (Budget items in BudgetItems)
            {
                Console.WriteLine($"Category Name: {items.GetName()}, Category Amount: £{items.GetAmount()}");
            }

            Console.WriteLine(" ");
        }


        public void DisplayExpenseItems()
        {
            Console.WriteLine("Expense List");

            foreach (Budget items in ExpenseItems)
            {
                Console.WriteLine($"Category Name: {items.GetName()}, Category Amount: £{items.GetAmount()}");
            }

            Console.WriteLine(" ");
        }


        public void DisplayBudgetTotal()
        {
            decimal totalBudget = 0;

            foreach (Budget item in BudgetItems)
            {
                totalBudget += item.GetAmount();
            }

            Console.WriteLine($"Total Budget Amount = £{totalBudget}");
        }



        //public static DateOnly ConvertToDateOnly(string expenseDate)
        //{
        //    DateOnly eDate;

        //    if (DateOnly.TryParse(expenseDate, out result))
        //    {
        //        return eDate;
        //    }
        //    else
        //    {
        //        throw new ArgumentException("Invalid date string format.");
        //    }
        //}


    }
}

