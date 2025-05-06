namespace PureCloud.Client.Extensions.Notifications;

public sealed class SubscriptionBuilder
{
    private readonly Dictionary<string, Type> _map = new Dictionary<string, Type>();

    public SubscriptionBuilder Add<T>(string topic)
    {
        if (!string.IsNullOrEmpty(topic))
        {
            _map[topic] = typeof(T);
        }

        return this;
    }

    public SubscriptionBuilder Add(string topicTemplate, params string[] ids)
    {
        if (NotificationTopics.Topics.TryGetValue(topicTemplate, out var topicType))
        {
            var topic = topicTemplate;

            if (ids is not null && ids.Length > 0)
            {
                topic = string.Format(topicTemplate, ids);
            }

            _map[topic] = topicType;
        }

        return this;
    }

    public IEnumerable<KeyValuePair<string, Type>> Build()
    {
        return _map;
    }
}
