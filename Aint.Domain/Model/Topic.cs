using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aint.Domain.Model
{
    public class Topic
    {
        public Topic()
        {
            Subscribers = new HashSet<int>();
            SubTopics = new Dictionary<string, Topic>();
        }

        public string Name { get; set; }
        public HashSet<int> Subscribers { get; set; }
        public Dictionary<string, Topic> SubTopics { get; set; }
    }
}