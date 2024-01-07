using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace AbstractFactoryDesignPatttern
{
    public interface IAbstractFactory
    {
        IVeg GetVegInstance();
        INonVeg GetNonVegInstance();

    }

    public class factory : IAbstractFactory
    {
        public INonVeg GetNonVegInstance()
        {
            return new NonVeg();
        }

        public IVeg GetVegInstance()
        {
            return new Veg();
        }
    }
    public interface IVeg
    {
        public void VegFood();
    }
    public interface INonVeg
    {
        public void VegNonFood();
    }

    public class Veg : IVeg
    {
        public void VegFood()
        {
            Console.WriteLine("Veg Food Available");
        }
    }

    public class NonVeg : INonVeg
    {
        public void VegNonFood()
        {
            Console.WriteLine("Non Veg Food Available");
        }
    }

    

   
    internal class Program
    {
        public static IAbstractFactory ClientMethod()
        {
            IAbstractFactory factory =  new factory();
            return factory;
        }
        static void Main(string[] args)
        {
            var instance = ClientMethod().GetVegInstance();
            instance.VegFood();
            var non = ClientMethod().GetNonVegInstance();
            non.VegNonFood();
            Console.WriteLine("Hello, World!");
        }
    }
}