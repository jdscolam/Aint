using System.Collections.Generic;
using Aint.Domain.Model;

namespace Aint.Domain.Services
{
    public class TopicService
    {
        public const string Wildcard = "*";

        private readonly Dictionary<string, Topic> _topics;
        
        public TopicService()
        {
            _topics = new Dictionary<string, Topic>();
        }

        public void Subscribe(int userId, string topicKey)
        {
            if (string.IsNullOrWhiteSpace(topicKey))
                return;

            var topicQueue = new Queue<string>(topicKey.Split('.'));
            
            Subscribe(userId, _topics, topicQueue);
        }

        private void Subscribe(int userId, IDictionary<string, Topic> currentTopics, Queue<string> topicQueue)
        {
            var topicKey = topicQueue.Dequeue();

            if (!currentTopics.ContainsKey(topicKey))
                currentTopics.Add(topicKey, new Topic { Name = topicKey });

            if (topicQueue.Count > 0)
                Subscribe(userId, currentTopics[topicKey].SubTopics, topicQueue);
            else
            {
                if(topicKey == Wildcard)
                    foreach (var topic in currentTopics.Values)
                    {
                        topic.Subscribers.Add(userId);
                    }
                else
                    currentTopics[topicKey].Subscribers.Add(userId);
            }
        }

        public Topic Get(string topicKey)
        {
            if (string.IsNullOrWhiteSpace(topicKey))
                return null;

            var topicQueue = new Queue<string>(topicKey.Split('.'));

            return Get(_topics, topicQueue);
        }

        private Topic Get(IDictionary<string, Topic> currentTopics, Queue<string> topicQueue)
        {
            var topicKey = topicQueue.Dequeue();

            if (!currentTopics.ContainsKey(topicKey))
                return null;

            if (topicQueue.Count == 0)
                return currentTopics[topicKey];

            return Get(currentTopics[topicKey].SubTopics, topicQueue);
        }
    }
}