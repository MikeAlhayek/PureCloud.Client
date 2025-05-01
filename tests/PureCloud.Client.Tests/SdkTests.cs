using PureCloud.Client.Apis;
using PureCloud.Client.Extensions;
using PureCloud.Client.Extensions.Notifications;
using PureCloud.Client.Models;
using Xunit;

namespace PureCloud.Client.Tests;

public class SdkTests
{
    // private string _clientId = Environment.GetEnvironmentVariable("PURECLOUD_CLIENT_ID");
    // private string _clientSecret = Environment.GetEnvironmentVariable("PURECLOUD_CLIENT_SECRET");
    // private string _environment = Environment.GetEnvironmentVariable("PURECLOUD_ENVIRONMENT");
    // 
    // private UsersApi _usersApi = new UsersApi();
    // private PresenceApi _presenceApi = new PresenceApi();
    // 
    // private string _userId;
    // private string _userEmail;
    // private string _userName = ".NET SDK Tester";
    // private string _userDepartment = "Ministry of Testing";
    // private string _userProfileSkill = "Testmaster";
    // private string _busyPresenceId = "31fe3bac-dea6-44b7-bed7-47f91660a1a0";
    // private string _availablePresenceId = "6a3af858-942f-489d-9700-5f9bcdcdae9b";
    public SdkTests()
    {
        Environment.SetEnvironmentVariable("PURECLOUD_ENVIRONMENT", "usw2.pure.cloud");
        Environment.SetEnvironmentVariable("PURECLOUD_CLIENTID", "97167000-eec1-454a-9abb-2375ebf31099");
        Environment.SetEnvironmentVariable("PURECLOUD_CLIENTSECRET", "44FP7uPEKCJ0b2HcqRGb2hSEMTKHBUbzMSSgVka4iVU");
    }

    private static ApiClient GetAuthenticatedClient()
    {
        var environment = Environment.GetEnvironmentVariable("PURECLOUD_ENVIRONMENT");
        var clientId = Environment.GetEnvironmentVariable("PURECLOUD_CLIENTID");
        var clientSecret = Environment.GetEnvironmentVariable("PURECLOUD_CLIENTSECRET");

        Console.WriteLine("clientId:" + clientId);
        Console.WriteLine("clientSecret:" + clientSecret);
        Console.WriteLine("environment:" + environment);

        var client = new ApiClient();
        var region = GetRegion(environment);

        if (region == null)
        { //Returned in the case of default value
            client.setBasePath("https://api." + environment);
        }
        else
        {
            var regionValue = region.GetValueOrDefault();
            client.setBasePath(regionValue);
        }

        client.PostToken(clientId, clientSecret);

        Assert.NotEmpty(client.Configuration.AccessToken);

        return client;
    }

    private static User GetNewUser(ApiClient client)
    {
        var usersApi = new UsersApi(client.Configuration);
        var environment = Environment.GetEnvironmentVariable("PURECLOUD_ENVIRONMENT");

        var userEmail = $"{Guid.NewGuid()}@{environment}";

        var userName = ".NET SDK Tester";

        var newUser = new CreateUser()
        {
            Name = userName,
            Email = userEmail,
            Password = Guid.NewGuid() + "!@#$1234asdfASDF"
        };

        var response = usersApi.PostUsersWithHttpInfo(newUser);

        Assert.NotNull(response);
        Assert.NotNull(response.Data);

        Assert.NotNull(response.Data.Id);
        Assert.Equal(response.Data.Name, userName);
        Assert.Equal(response.Data.Email, userEmail);

        return response.Data;
    }

    ///<Summary>
    /// CreateUser
    ///</Summary>
    [Fact]
    public void UsersApi_PostUsersWithHttpInfo_CreatesUser()
    {
        var client = GetAuthenticatedClient();

        GetNewUser(client);
    }

    ///<Summary>
    /// UpdateUser
    ///</Summary>
    [Fact]
    public void UsersApi_PatchUser_UpdatesTheUser()
    {
        var client = GetAuthenticatedClient();
        var user = GetNewUser(client);

        var userDepartment = "Ministry of Testing";

        var updateUser = new UpdateUser()
        {
            Department = userDepartment,
            Version = 1
        };

        var usersApi = new UsersApi(client.Configuration);
        var updatedUser = usersApi.PatchUser(user.Id, updateUser);

        Assert.Equal(updatedUser.Id, user.Id);
        Assert.Equal(updatedUser.Name, user.Name);
        Assert.Equal(updatedUser.Email, user.Email);
        Assert.Equal(updatedUser.Department, userDepartment);
    }

    ///<Summary>
    /// SetProfileSkills
    ///</Summary>
    [Fact]
    public void UsersApit_PutUserProfileskillsWithHttpInfo_SetsCorrectSkill()
    {
        var client = GetAuthenticatedClient();
        var user = GetNewUser(client);
        var usersApi = new UsersApi(client.Configuration);
        var userProfileSkill = "Testmaster";

        var skills = usersApi.PutUserProfileskillsWithHttpInfo(user.Id, new List<string>() { userProfileSkill });

        Assert.Single(skills.Data);
        Assert.Equal(userProfileSkill, skills.Data[0]);
    }

    ///<Summary>
    /// TestNotifications
    ///</Summary>
    [Fact]
    public async Task TestNotifications()
    {
        var _busyPresenceId = "31fe3bac-dea6-44b7-bed7-47f91660a1a0";
        var _availablePresenceId = "6a3af858-942f-489d-9700-5f9bcdcdae9b";

        var client = GetAuthenticatedClient();
        var user = GetNewUser(client);

        await using var handler = new NotificationHandler();

        await handler.StartAsync(client.Configuration);

        // Start the handler inside of the task to block this test until the notifications come in
        var tcs = new TaskCompletionSource<bool>();
        var busyReceived = false;
        var availableReceived = false;

        handler.NotificationReceived += (data) =>
        {
            try
            {
                if (data.GetType() == typeof(NotificationData<PresenceEventUserPresence>))
                {
                    var presence = (NotificationData<PresenceEventUserPresence>)data;

                    // Check to see what we got
                    if (presence.EventBody.PresenceDefinition.Id == _availablePresenceId)
                    {
                        availableReceived = true;
                    }

                    if (presence.EventBody.PresenceDefinition.Id == _busyPresenceId)
                    {
                        busyReceived = true;
                    }

                    // Complete the async task
                    if (busyReceived && availableReceived)
                    {
                        tcs.SetResult(true);
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                // Suppress this error that happens occasionally:
                // An attempt was made to transition a task to a final state when it had already completed.
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        };

        // Register topic
        handler.AddSubscription($"v2.users.{user.Id}.presence", typeof(PresenceEventUserPresence));

        var presenceApi = new PresenceApi(client.Configuration);

        // Change presences
        presenceApi.PatchUserPresence(user.Id, "PURECLOUD", new UserPresence()
        {
            PresenceDefinition = new PresenceDefinition(_busyPresenceId),
        });
        presenceApi.PatchUserPresence(user.Id, "PURECLOUD", new UserPresence()
        {
            PresenceDefinition = new PresenceDefinition(_availablePresenceId),
        });

        // The getter for Result will block until the task has completed
        var result = await tcs.Task;

        // Assert that both worked
        Assert.True(busyReceived);
        Assert.True(availableReceived);
    }

    ///<Summary>
    /// GetUser
    ///</Summary>
    [Fact]
    public void GetUser()
    {
        var client = GetAuthenticatedClient();
        var user = GetNewUser(client);
        var usersApi = new UsersApi(client.Configuration);

        var response = usersApi.GetUserWithHttpInfo(user.Id, new List<string>() { "profileSkills" }, null, null);
        Assert.Equal(response.Data.Id, user.Id);
        Assert.Equal(response.Data.Name, user.Name);
        Assert.Equal(response.Data.Email, user.Email);
        Assert.Equal(response.Data.Department, user.Department);

        // Commented out until the issue with APIs to send the latest Version of the User is fixed.
        // Assert.IsNotNull(user.Data.ProfileSkills);
        // Assert.AreEqual(user.Data.ProfileSkills.Count, 1);
        // Assert.AreEqual(user.Data.ProfileSkills[0], userProfileSkill);
    }

    ///<Summary>
    /// DeleteUserWithProxy
    ///</Summary>
    /*
    [Test]
    public void DeleteUserWithProxy()
    {
        Configuration.Default.ApiClient.ClientOptions.Proxy = new WebProxy("http://localhost:4001", true);

        _usersApi.DeleteUser(_userId);
    }
    */

    ///<Summary>
    /// getRegion
    ///</Summary>
    private static PureCloudRegionHosts? GetRegion(string str = "http://api.mypurecloud.com")
    {
        switch (str)
        {
            case "mypurecloud.com":
                return PureCloudRegionHosts.us_east_1;
            case "mypurecloud.ie":
                return PureCloudRegionHosts.eu_west_1;
            case "mypurecloud.de":
                return PureCloudRegionHosts.eu_central_1;
            case "mypurecloud.jp":
                return PureCloudRegionHosts.ap_northeast_1;
            case "mypurecloud.com.au":
                return PureCloudRegionHosts.ap_southeast_2;
            case "usw2.pure.cloud":
                return PureCloudRegionHosts.us_west_2;
            case "cac1.pure.cloud":
                return PureCloudRegionHosts.ca_central_1;
            case "apne2.pure.cloud":
                return PureCloudRegionHosts.ap_northeast_2;
            case "euw2.pure.cloud":
                return PureCloudRegionHosts.eu_west_2;
            case "aps1.pure.cloud":
                return PureCloudRegionHosts.ap_south_1;
            case "use2.us-gov-pure.cloud":
                return PureCloudRegionHosts.us_east_2;
            default:
                Console.WriteLine("Value does not exist in enum using default val");
                return null;
        }
    }
}
