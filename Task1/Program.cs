using System;

namespace SubscriptionFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubscriptionFactory websiteSubscriptionFactory = new WebSiteSubscriptionFactory();
            Subscription websiteSubscription = websiteSubscriptionFactory.CreateSubscription();
            Console.WriteLine("Website subscription:");
            websiteSubscription.Display();

            ISubscriptionFactory mobileAppSubscriptionFactory = new MobileAppSubscriptionFactory();
            Subscription mobileAppSubscription = mobileAppSubscriptionFactory.CreateSubscription();
            Console.WriteLine("Mobile app subscription:");
            mobileAppSubscription.Display();

            ISubscriptionFactory managerCallSubscriptionFactory = new ManagerCallSubscriptionFactory();
            Subscription managerCallSubscription = managerCallSubscriptionFactory.CreateSubscription();
            Console.WriteLine("Manager call subscription:");
            managerCallSubscription.Display();

            Console.ReadLine();
        }
    }
}
