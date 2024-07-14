using LINQ_Fundamentals.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Fundamentals.LINQ_Concepts.Aggregate_Operations
{
    public class AggregateOperations
    {
        public List<Product> GetProductList() => Products.ProductList;
        public List<Customer> GetCustomerList() => Customers.CustomerList;

        #region Count 

        public int CountOfUniqueFactors()
        {
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };

            int uniqueFactors = factorsOf300.Distinct().Count();

            return uniqueFactors;
        }

        public int CountOddNumbersInList()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int numberOfOddNumbers = numbers.Count(num => num % 2 == 1);

            return numberOfOddNumbers;
        }

        public void CountOrdersMadeByCustomers()
        {
            List<Customer> customers = GetCustomerList();

            var orderCountDetails = from c in customers select (c.CustomerID, OrderCount: c.Orders.Count());

            foreach(var customerDetails in orderCountDetails)
            {
                Console.WriteLine($"ID:{customerDetails.CustomerID},count:{customerDetails.OrderCount}");
            }
        }



        #endregion
    }
}
