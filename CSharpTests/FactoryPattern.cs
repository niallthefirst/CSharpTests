using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    interface IBank
    {
        Decimal ProductPrice { get; set; }
        void MakePayment(Decimal amount);
        
    }

    abstract class Bank : IBank
    {
       
        #region IBank Members

        public Decimal ProductPrice
        {
            get;set;
        }

        public abstract void MakePayment(Decimal amount);
        

        #endregion
    }

    class BankOne : Bank
    {
        public override void MakePayment(Decimal amount)
        {
            if (amount < 50)
                Console.WriteLine("Bank One - Charge 2%");
            else
                Console.WriteLine("Bank One - Charge 1%");
        
        }
    }
    class BankTwo : Bank
    {
        
        public override void MakePayment(Decimal amount)
        {
            Console.WriteLine("Bank One - Charge 1.5%");
            
        }
       
    }

    class Paypal : Bank
    {

        public override void MakePayment(Decimal amount)
        {
            Console.WriteLine("Paypal - Charge 4%");

        }

    }


    class BankFactory
    {
        IBank _bank;
        public virtual void MakePayment(PaymentMethod paymentMethod,Decimal amount)
        {
            switch (paymentMethod)
            {
                case (PaymentMethod.BANKONE):
                    if (amount < 50)
                        _bank = new BankOne();
                    else
                        _bank = new BankOne();
                    break;
                case(PaymentMethod.BANKTWO):
                    _bank.MakePayment(amount);
                    break;
                case(PaymentMethod.BESTFORME):
                    _bank = new BankOne();
                    break;
                default:
                    throw new Exception("No bank of this type exists.");

            }
            _bank.MakePayment(amount);
        }
    }

    class BankFactoryWithPaypal : BankFactory
    {
        IBank _bank;
        public override void MakePayment(PaymentMethod paymentMethod, Decimal amount)
        {
            switch (paymentMethod)
            {
                 case (PaymentMethod.PAYPAL):
                    _bank = new Paypal();
                    _bank.MakePayment(amount);
                    break;
                default:
                    base.MakePayment(paymentMethod, amount);
                    break;

            }
            
        }
    }

    public enum PaymentMethod
    { 
        BANKONE,
        BANKTWO,
        BESTFORME,
        PAYPAL
    }
    public class PaymentProcessor
    {
        public static void MakePayment(PaymentMethod paymentMethod, Decimal amount)
        {
            var bankFactory = new BankFactoryWithPaypal();
            bankFactory.MakePayment(paymentMethod, amount);
               
        }
    }
}
