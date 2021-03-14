using System;
using System.Collections.Generic;
using System.Linq;

namespace ExceptionsExtensionsEvents
{
    public class UserSubscriptions
    {
        public string Name { get; set; }
        private List<Subscription> subscriptions;
        public UserSubscriptions(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name can't be null or whitespace", nameof(name));
            }
            subscriptions = new List<Subscription>();
            Name = name;
        }
        public void Add(Subscription subscription)
        {
            if (subscription == null)
            {
                throw new ArgumentNullException("subscription can't be null", nameof(subscription));
            }
            if (subscriptions.Any(x => x.Title.Equals(subscription.Title)))
            {
                throw new DuplicateException("Title should be unique");
            }
            subscriptions.Add(subscription);
        }
        public Subscription[] GetSubscriptions()
        {
            return subscriptions.ToArray();
        }
    }
    public class Subscription
    {
        public Subscription(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Title can't be null or whitespace", nameof(title));
            }
            Title = title;
        }
        public string Title { get; private set; }
    }
    public class DuplicateException: Exception
    {
        public DuplicateException() : base()
        {

        }
        public DuplicateException(string message) : base(message)
        {

        }
        public DuplicateException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
