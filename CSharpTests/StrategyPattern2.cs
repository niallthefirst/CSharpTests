using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    /// <summary>
    /// Employee Class
    /// </summary>
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int YearsSinceLastPromotion { get; set; }
        public int NoOfSkillCertificate { get; set; }
        public int PercentageOfGoalAchieved { get; set; }
    }

    public enum PromotionStrategy { 
        BasedOnYears, 
        BasedOnCertificates
    }

    /// <summary>
    /// Human Resource Class
    /// </summary>
    public class HumanResource
    {
        private List<Employee> _employees;

        public List<Employee> Employees
        {
            get { return _employees; }
            
        }
        private IPromotionStrategy _promotionStategy;

        public IPromotionStrategy PromotionStategy
        {
            get { return _promotionStategy; }
            set { _promotionStategy = value; }
        }
        

        public HumanResource(IPromotionStrategy promotionStrategy)
        {
            _employees = new List<Employee>();
            _promotionStategy = promotionStrategy;
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        /// <summary>
        /// Uses Promotion Strategy classes to find out list of Employee Eligible
        /// </summary>
        /// <returns>List of Eligible Employee</returns>
        public List<Employee> GetPromotionEligibleEmployees()
        {
            return _promotionStategy.IdentifyPromotionEligibleEmployees(_employees);
            
        }

        
        /// <summary>
        /// Utility function to Print Employees
        /// </summary>
        /// <param name="employees">List of Employees</param>
        /// <param name="criterion">Criterion</param>
        public static void Print(List<Employee> employees, string criterion)
        {
            Console.WriteLine(" Based On '{0}'", criterion);
            Console.WriteLine(" ID\tName");
            foreach (Employee e in employees)
            {
                Console.WriteLine(" {0}\t{1}", e.ID, e.Name);
            }
            Console.WriteLine();
        }
    }
    public interface IPromotionStrategy
    {
        System.Collections.Generic.List<Employee> IdentifyPromotionEligibleEmployees(System.Collections.Generic.List<Employee> employees);
    }


    class BasedOnYearsSinceLastPromotion : IPromotionStrategy
    {
        public List<Employee> IdentifyPromotionEligibleEmployees(List<Employee> employees)
        {
            return employees.Where(e => e.YearsSinceLastPromotion >= 4).ToList();
        }
    }

    class BasedOnNoOfSkillCertificate : IPromotionStrategy
    {
        public List<Employee> IdentifyPromotionEligibleEmployees(List<Employee> employees)
        {
            return employees.Where(e => e.NoOfSkillCertificate >= 3).ToList();
        }
    }

    class BasedOnPercentageOfGoal : IPromotionStrategy
    {
        public List<Employee> IdentifyPromotionEligibleEmployees(List<Employee> employees)
        {
            return employees.OrderBy(e => e.PercentageOfGoalAchieved).Reverse().ToList();
        }
    }
}
