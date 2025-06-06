namespace PureCloud.Client.Notifications;

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
    public SubscriptionBuilder Add(string topicTemplate, params object[] ids)
    {
        ArgumentNullException.ThrowIfNull(topicTemplate);

        if (!PureCloudConstants.TopicTemplates.TryGetValue(topicTemplate, out var topicType))
        {
            throw new InvalidOperationException($"The topic template '{topicTemplate}' is invalid. Valid templates can be found in {nameof(PureCloudConstants)}.{nameof(PureCloudConstants.TopicTemplates)}");
        }

        if (ids is not null && ids.Length > 0)
        {
            var topic = string.Format(topicTemplate, ids);

            _map[topic] = topicType;
        }
        else
        {
            _map[topicTemplate] = topicType;
        }

        return this;
    }

    public IEnumerable<KeyValuePair<string, Type>> Build()
    {
        return _map;
    }
}
