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

    /// <summary>
    /// Register the event type corresponding to the given topic template.
    /// </summary>
    /// <param name="topicTemplate"></param>
    /// <param name="ids"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public SubscriptionBuilder Add(string topicTemplate, params string[] ids)
    {
        if (!PureCloudConstants.TopicTemplates.TryGetValue(topicTemplate, out var topicType))
        {
            throw new InvalidOperationException($"The topic template '{topicTemplate}' is invalid. Valid templates can be found in {nameof(PureCloudConstants)}.{nameof(PureCloudConstants.TopicTemplates)}");
        }

        var topic = topicTemplate;

        if (ids is not null && ids.Length > 0)
        {
            topic = string.Format(topicTemplate, ids);
        }

        _map[topic] = topicType;

        return this;
    }

    public IEnumerable<KeyValuePair<string, Type>> Build()
    {
        return _map;
    }
}
