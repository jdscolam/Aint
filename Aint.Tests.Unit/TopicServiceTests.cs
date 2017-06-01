using System.Linq;
using Aint.Domain.Services;
using FluentAssertions;
using NUnit.Framework;

namespace Aint.Tests.Unit
{
    [TestFixture]
    public class TopicServiceTests
    {
        [Test]
        public void Can_subscribe_to_a_topic()
        {
            //Setup.
            const int userId = 10;
            const string topicKey = "News";
            var topicService = new TopicService();

            //Execute.
            topicService.Subscribe(userId, topicKey);
            var topic = topicService.Get(topicKey);

            //Verify.
            topic.Subscribers.Should().Contain(userId);

            //Teardown.
        }

        [Test]
        public void Should_not_duplicate_subscribers()
        {
            //Setup.
            const int userId = 10;
            const string topicKey = "News";
            var topicService = new TopicService();

            //Execute.
            topicService.Subscribe(userId, topicKey);
            topicService.Subscribe(userId, topicKey);
            var topic = topicService.Get(topicKey);

            //Verify.
            topic.Subscribers.Count.Should().Be(1);

            //Teardown.
        }

        [Test]
        public void Should_allow_subscriptions_to_sub_topics()
        {
            //Setup.
            const int userId = 10;
            const string rootTopicKey = "News";
            const string oklahomaTopicKey = "News.Oklahoma";
            const string topicKey1 = "News.NewHampshire";
            const string topicKey2 = "News.Oklahoma.Tulsa";
            var topicService = new TopicService();

            //Execute.
            topicService.Subscribe(userId, topicKey1);
            topicService.Subscribe(userId, topicKey2);
            var topic1 = topicService.Get(topicKey1);
            var topic2 = topicService.Get(topicKey2);
            var rootTopic = topicService.Get(rootTopicKey);
            var oklahomaTopic = topicService.Get(oklahomaTopicKey);

            //Verify.
            rootTopic.SubTopics.Should().HaveCount(2);
            oklahomaTopic.SubTopics.Should().HaveCount(1);
            topic1.Subscribers.Should().Contain(userId);
            topic2.Subscribers.Should().Contain(userId);

            //Teardown.
        }

        [Test]
        public void Should_allow_subscriptions_to_all_sub_topics()
        {
            //Setup.
            const int userId1 = 10;
            const int userId2 = 20;
            const int userId3 = 30;
            const string rootTopicKey = "News";
            const string topicKey1 = "News.NewHampshire";
            const string topicKey2 = "News.Oklahoma";
            const string topicKey3 = "News.*";
            var topicService = new TopicService();

            //Execute.
            topicService.Subscribe(userId1, topicKey1);
            topicService.Subscribe(userId2, topicKey2);
            topicService.Subscribe(userId3, topicKey3);
            var topic1 = topicService.Get(topicKey1);
            var topic2 = topicService.Get(topicKey2);
            var rootTopic = topicService.Get(rootTopicKey);

            //Verify.
            topic1.Subscribers.Should().Contain(userId1);
            topic1.Subscribers.Should().NotContain(userId2);
            topic2.Subscribers.Should().Contain(userId2);
            topic2.Subscribers.Should().NotContain(userId1);
            rootTopic.SubTopics.All(x => x.Value.Subscribers.Contains(userId3)).Should().BeTrue();
            
            //Teardown.
        }
    }
}
