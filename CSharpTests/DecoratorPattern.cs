using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    public abstract class BakeryComponent
    {
        public abstract string GetName();
        public abstract double GetPrice();
    }

    class Cake : BakeryComponent
    {
        public override string GetName()
        {
            return "Cake";
        }

        public override double GetPrice()
        {
            return 20.00;
        }
    }
    class Pastery : BakeryComponent
    {
        public override string GetName()
        {
            return "Pastry";
        }

        public override double GetPrice()
        {
            return 10.0;
        }
    }

    public abstract class Decorator : BakeryComponent
    {
        BakeryComponent _baseComponent = null;

        protected string _name = "Undefined Decorator";
        protected double _price = 0.0;

        protected Decorator(BakeryComponent baseComponent)
        {
            _baseComponent = baseComponent;
        }

        #region BakeryComponent Members

        public override string GetName()
        {
            return string.Format("{0}, {1}", _baseComponent.GetName(), _name);
        }

        public override double GetPrice()
        {
            return _price + _baseComponent.GetPrice();
        }
        #endregion
    }
    class ArtificialScentDecorator : Decorator
    {
        public ArtificialScentDecorator(BakeryComponent baseComponent)
            : base(baseComponent)
        {
            this._name = "Artificial Scent";
            this._price = 3.0;
        }
    }

    class CherryDecorator : Decorator
    {
        public CherryDecorator(BakeryComponent baseComponent)
            : base(baseComponent)
        {
            this._name = "Cherry";
            this._price = 2.0;
        }
    }

    class CreamDecorator : Decorator
    {
        public CreamDecorator(BakeryComponent baseComponent)
            : base(baseComponent)
        {
            this._name = "Cream";
            this._price = 1.0;
        }
    }

    class Bakery
    {
        public static void Create()
        {

            var cake = new Cake();
            var cherry = new CherryDecorator(cake);//adding detail to cake without changing cake

           Console.WriteLine(cherry.GetName() + " " + cherry.GetPrice());


        }
    }
}
