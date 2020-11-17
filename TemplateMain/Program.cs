using System;

namespace TemplateMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Topic topic;
            topic = new SubTopic();
            topic.TemplateMethod();

            Console.WriteLine("Hello World!");
        }
    }
}
