using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using StolenBreakfastDrone;
using TasksAndParallelism;

namespace CSharpTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Extension Methods
            string value = "dot net perls";
            value = value.UppercaseFirstLetter();
            Console.WriteLine(value);



            Console.WriteLine("\nDelegates");
            // Wrap the methods inside delegate instances and pass to the method.
            DelegateTest.WriteOutput("perls", new DelegateTest.UppercaseDelegate(DelegateTest.UppercaseFirst));
            DelegateTest.WriteOutput("perls", new DelegateTest.UppercaseDelegate(DelegateTest.UppercaseLast));
            DelegateTest.WriteOutput("perls", new DelegateTest.UppercaseDelegate(DelegateTest.UppercaseAll));
            DelegateTest.WriteOutput("perls", new DelegateTest.UppercaseDelegate(x => x.ToUpper()));

            Console.WriteLine("\nMultiCastDelegate");
            DelegateTest.MultiCastDelegateTest();


            Console.WriteLine("\nDelegates2");
            DelegateTest2.Run();

            Console.WriteLine("\nDelegates3");
            DelegateTest3.Run();

              
            //Value and Reference Types
            int val = 10;
            ValueTypes.PassByValue(val);
            Console.WriteLine("After pass by value " + val);//wont change
            val = 12;
            ValueTypes.PassByRef(ref val);
            Console.WriteLine("After pass by ref " + val);//will change
            val = 99;
            ValueTypes valueTypesObj = new ValueTypes(val);
            ValueTypes.PassReferenceType(valueTypesObj);
            Console.WriteLine("After pass by ref " + valueTypesObj.Value);//will change


            Console.WriteLine("\nReference Types");
            ReferenceTypes.Run();

            Console.WriteLine("\nStrings");
            StringTests.AssignmentAsValueType();

            //Statics
            Static obj = new Static();
            Static.StaticMember = 10;
            Static.ShowStatic();
            obj.ShowBoth();

            Static.StaticMember = 30;

            Static obj2 = new Static();
            Static.ShowStatic();
            obj2.ShowBoth();//static is still 30. only one variable no matter what how many objects.



            //StaticClass
            StaticClass.DoNothing();
            StaticClass.DoNothing();




            //Dynamic
            var ae = new ApplicationException("Application Exception");
            //DynamicTest.HandleException((dynamic)ae);
            DynamicTest.HandleException(ae);
            var e = new Exception("Base Exception");
            //DynamicTest.HandleException((dynamic)ae);
            DynamicTest.HandleException(e);

            Console.WriteLine("\nDynamicObject");
            DynamicDictionary.Run();

            Console.WriteLine("\nIncrement");
            Increment.Int();

            Console.WriteLine("\nStructs");
            StructTest.Run();

            Console.WriteLine("\nDate");
            DateTests.NumberOfDays();
            DateTests.DateTimesWithTimeZones();

            Console.WriteLine("\nPatterns");
            MyOneInstanceClass singleton = MyOneInstanceClass.Instance;
            singleton.Print("First");
            singleton.Print("Second");




            Console.WriteLine("\nStrategy Pattern");
            SortedListStrategyPatternContext studentRecords = new SortedListStrategyPatternContext();
            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");
            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();
            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();
            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            //Strategy Pattern 2
            HumanResource hr = new HumanResource(new BasedOnYearsSinceLastPromotion());

            hr.AddEmployee(new Employee { ID = 1, Name = "Steve", YearsSinceLastPromotion = 8, NoOfSkillCertificate = 6, PercentageOfGoalAchieved = 75 });
            hr.AddEmployee(new Employee { ID = 2, Name = "John", YearsSinceLastPromotion = 3, NoOfSkillCertificate = 2, PercentageOfGoalAchieved = 60 });
            hr.AddEmployee(new Employee { ID = 3, Name = "Todd", YearsSinceLastPromotion = 5, NoOfSkillCertificate = 2, PercentageOfGoalAchieved = 80 });
            hr.AddEmployee(new Employee { ID = 4, Name = "Lisa", YearsSinceLastPromotion = 6, NoOfSkillCertificate = 3, PercentageOfGoalAchieved = 87 });
            hr.AddEmployee(new Employee { ID = 5, Name = "Smith", YearsSinceLastPromotion = 2, NoOfSkillCertificate = 1, PercentageOfGoalAchieved = 73 });
            hr.AddEmployee(new Employee { ID = 6, Name = "Debbie", YearsSinceLastPromotion = 5, NoOfSkillCertificate = 3, PercentageOfGoalAchieved = 82 });
            hr.AddEmployee(new Employee { ID = 7, Name = "Kate", YearsSinceLastPromotion = 1, NoOfSkillCertificate = 4, PercentageOfGoalAchieved = 79 });
            hr.AddEmployee(new Employee { ID = 8, Name = "Rehana", YearsSinceLastPromotion = 3, NoOfSkillCertificate = 2, PercentageOfGoalAchieved = 91 });
            var result = hr.GetPromotionEligibleEmployees();
            HumanResource.Print(result, "Years Since Last Promotion");

            hr.PromotionStategy = new BasedOnNoOfSkillCertificate();
            result = hr.GetPromotionEligibleEmployees();
            HumanResource.Print(result,"Number of Certs");

            hr.PromotionStategy = new BasedOnPercentageOfGoal();
            result = hr.GetPromotionEligibleEmployees();
            HumanResource.Print(result, "Percentage of Goal");

     
            //Adaptor Pattern
            ICommunicator communicator = new Teacher();
            communicator.ObjectToTalkTo = new EnglishSpeakerKid();
            communicator.StartChatting();
            var Louis = new AdaptorForNonEnglshSpeaker();
            communicator.ObjectToTalkTo = Louis;
            communicator.StartChatting();

            
            //Factory Pattern
            PaymentProcessor.MakePayment(PaymentMethod.PAYPAL, 20.20M);


            //Decorator Pattern
            Bakery.Create();


            //Numbers
            Numbers.Print();


            //Sort
            var sort = new Sort();
            Console.WriteLine("Before : \n" + sort.ToString());
            Sort.BubbleSort(sort.Data);
            Console.WriteLine("After BubbleSort : \n" + sort.ToString());

            sort = new Sort();
            Console.WriteLine("Before : \n" + sort.ToString());
            Sort.QuickSort(sort.Data);
            Console.WriteLine("After QuickSort : \n" + sort.ToString());

     


            //Type Checks
            TypeChecks.AsA();
            TypeChecks.IsA();


            //Associations
            Associations.Associations.Run();



            //Fizzbuzz
            //FizzBuzz.Run();

            //OOP
            OOP.Business.Business.Run();


            Console.WriteLine("\nLambdas");
            Lambda.Select();
            Lambda.SelectMany();
            Lambda.Where();
            Lambda.SelectAndWhere();
            Lambda.Any();
            Lambda.Func();



            Console.WriteLine("\nInterface, Multiple Inheritance");
            InterfaceMultipleInheritance.Run();


            Console.WriteLine("\nHashTable");
            HashTableTest.Run();

            Console.WriteLine("\nGenerics");
            GenericsTest.Run();

            

            Console.WriteLine("\nLazy Initialization");
            LazyInstantiation.Run();


            Console.WriteLine("\nImmutable");
            Immutable immuatable = new Immutable("my name", 100);


            Console.WriteLine("\nFunc and Action");
            FuncAndActionDelegates.Run();

            Console.WriteLine("\nInheritance override");
            OverrideTest.Run();



            Console.WriteLine("\nRecursion Fibbionacci");
            Recursion.Fibionacci(8, 1, 0);


            Console.WriteLine("\nFactorial");
            Factorial.Run(6);


            Console.WriteLine("\nDelivery Drones");
            var deliverManager = DeliveryManager.Init();
            var lostDroneId = deliverManager.Find();
            Console.WriteLine("Lost drones id is {0}", lostDroneId);


            Console.WriteLine("\nNode Delete");
            var nodeManager = DeleteNode.NodeManager.Instance();
            var deleted = nodeManager.DeleteNode(new DeleteNode.Node() { Value = 'B' });
            Console.WriteLine("Was node deleted : {0}", deleted);


            Console.WriteLine("\nData Structure");
            DataStructure.Run();

            Console.WriteLine("\nLinkedList Kth Node");
            GetKthNode.GetKthNode.Run();



            Console.WriteLine("\nAsync and Await");
            AsyncAwaitTest.Run();

            //Console.WriteLine("\nTasks and Parallelism");
            //Tasks.Run();
            


            //Console.WriteLine("\nThreadSafe");
            //var t1 = new Thread(new ParameterizedThreadStart(ThreadSafe.Run));
            //var t2 = new Thread(new ParameterizedThreadStart(ThreadSafe.Run));
            //t1.Start("First");
            //t2.Start("Second");
            ////t1.Join();The Join method causes the execution to stop until that thread terminates.
            ////t2.Join();


            

            Console.ReadKey();
     
            
        }
    }
}
