using System;
using System.Collections.Generic;

namespace SubscriptionFactory
{
    public abstract class Subscription
    {
        public decimal MonthlyFee { get; set; }
        public int MinimumSubscriptionPeriod { get; set; }
        public List<string> ChannelsAndFeatures { get; set; }

        public virtual void Display()
        {
            Console.WriteLine($"Monthly fee: {MonthlyFee:C}");
            Console.WriteLine($"Minimum subscription period: {MinimumSubscriptionPeriod} months");
            Console.WriteLine("Channels and features:");
            foreach (string channelOrFeature in ChannelsAndFeatures)
            {
                Console.WriteLine($"- {channelOrFeature}");
            }
        }
    }

    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription()
        {
            MonthlyFee = 9.99M;
            MinimumSubscriptionPeriod = 12;
            ChannelsAndFeatures = new List<string> { "Basic channels", "HD channels", "DVR" };
        }
    }

    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription()
        {
            MonthlyFee = 14.99M;
            MinimumSubscriptionPeriod = 6;
            ChannelsAndFeatures = new List<string> { "Educational channels", "Documentaries", "Webinars" };
        }
    }

    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription()
        {
            MonthlyFee = 24.99M;
            MinimumSubscriptionPeriod = 3;
            ChannelsAndFeatures = new List<string> { "Premium channels", "Live sports", "Original content" };
        }
    }
}
