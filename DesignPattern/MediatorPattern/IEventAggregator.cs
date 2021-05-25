using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public interface IEventAggregator
    {
        void Subscribe(string EventName, ISubscriber subscriber);
        void Publish(string EventName);
    }

    public class EventAggregrator : IEventAggregator
    {
        private Dictionary<string, List<ISubscriber>> subscribers;

        public EventAggregrator()
        {
            subscribers = new Dictionary<string, List<ISubscriber>>();
        }
        public void Publish(string EventName)
        {
            if (subscribers.ContainsKey(EventName))
            {
                var list = subscribers[EventName];
                foreach (var subscriber in list)
                {
                    subscriber.Update();
                }
            }
        }

        public void Subscribe(string EventName, ISubscriber subscriber)
        {
            if (subscribers.ContainsKey(EventName))
            {
                var sublist = subscribers[EventName];
                sublist.Add(subscriber);
            }
            else
            {
                List<ISubscriber> sub = new List<ISubscriber>();
                sub.Add(subscriber);
                subscribers[EventName] = sub;

            }
        }
    }
}
