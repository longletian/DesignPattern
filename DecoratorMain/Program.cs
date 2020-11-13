using System;

namespace DecoratorMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "张三"
            };
            Costume costume = new Costume();
            Clothes clothes = new Clothes();

            Pants pants = new Pants();

            costume.Decorate(person);

            clothes.Decorate(costume);

            pants.Decorate(clothes);

            pants.Show();

            Console.ReadKey();
        }
    }
}
