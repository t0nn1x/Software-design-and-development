namespace SubscriptionFactory
{
    public interface ISubscriptionFactory
    {
        Subscription CreateSubscription();
    }

    public class WebSiteSubscriptionFactory : ISubscriptionFactory
    {
        public Subscription CreateSubscription()
        {
            // website-specific logic for creating subscriptions
            return new DomesticSubscription(); // for example purposes only
        }
    }

    public class MobileAppSubscriptionFactory : ISubscriptionFactory
    {
        public Subscription CreateSubscription()
        {
            // mobile app-specific logic for creating subscriptions
            return new EducationalSubscription(); // for example purposes only
        }
    }

    public class ManagerCallSubscriptionFactory : ISubscriptionFactory
    {
        public Subscription CreateSubscription()
        {
            // manager call-specific logic for creating subscriptions
            return new PremiumSubscription(); // for example purposes only
        }
    }
}
