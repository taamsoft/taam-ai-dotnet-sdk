
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Environment` | Environment | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `AccessToken` | `string` | The OAuth 2.0 Access Token to use for API requests. |

The API client can be initialized as follows:

```csharp
TaamAiUser.Standard.TaamAiUserClient client = new TaamAiUser.Standard.TaamAiUserClient.Builder()
    .AccessToken("AccessToken")
    .Environment(TaamAiUser.Standard.Environment.Production)
    .Build();
```

## taam ai userClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| TemplatesController | Gets TemplatesController controller. |
| AuthController | Gets AuthController controller. |
| WorkbookAndFoldersController | Gets WorkbookAndFoldersController controller. |
| CustimTemplatesController | Gets CustimTemplatesController controller. |
| ProductController | Gets ProductController controller. |
| PromptTemplateController | Gets PromptTemplateController controller. |
| ChatWithPdfController | Gets ChatWithPdfController controller. |
| AddonFeaturesController | Gets AddonFeaturesController controller. |
| MiscController | Gets MiscController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| AccessTokenCredentials | Gets the access token to use with OAuth 2 authentication. | `IAccessTokenCredentials` |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Server1)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the taam ai userClient using the values provided for the builder. | `Builder` |

## taam ai userClient Builder Class

Class to build instances of taam ai userClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `AccessTokenCredentials(IAccessTokenCredentials accessTokenCredentials)` | Gets the access token to use with OAuth 2 authentication. | `Builder` |

