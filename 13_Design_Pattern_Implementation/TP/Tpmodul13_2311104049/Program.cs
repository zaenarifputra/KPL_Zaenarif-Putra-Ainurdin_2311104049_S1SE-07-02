using System;
using Tpmodul13_2311104049;

namespace Tpmodul13_2311104049
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            ConcreteObserver observer1 = new ConcreteObserver("Observer 1");
            ConcreteObserver observer2 = new ConcreteObserver("Observer 2");

            subject.Attach(observer1);
            subject.Attach(observer2);

            subject.Notify("Update pertama!");

            subject.Detach(observer1);

            subject.Notify("Update kedua!");
        }
    }
}
