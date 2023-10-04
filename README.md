
# Getting Started with taam ai user

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package TaamAiSDK --version 1.0.0
```

You can also view the package at:
https://www.nuget.org/packages/TaamAiSDK/1.0.0

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/taamsoft/taam-ai-dotnet-sdk/tree/1.0.0/doc/client.md)

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

## Authorization

This API uses `OAuth 2 Bearer token`.

## List of APIs

* [Workbookandfolders](https://www.github.com/taamsoft/taam-ai-dotnet-sdk/tree/1.0.0/doc/controllers/workbookandfolders.md)
* [Custim Templates](https://www.github.com/taamsoft/taam-ai-dotnet-sdk/tree/1.0.0/doc/controllers/custim-templates.md)
* [Prompttemplate](https://www.github.com/taamsoft/taam-ai-dotnet-sdk/tree/1.0.0/doc/controllers/prompttemplate.md)
* [Chatwithpdf](https://www.github.com/taamsoft/taam-ai-dotnet-sdk/tree/1.0.0/doc/controllers/chatwithpdf.md)
* [Addon Features](https://www.github.com/taamsoft/taam-ai-dotnet-sdk/tree/1.0.0/doc/controllers/addon-features.md)
* [Templates](https://www.github.com/taamsoft/taam-ai-dotnet-sdk/tree/1.0.0/doc/controllers/templates.md)
* [Auth](https://www.github.com/taamsoft/taam-ai-dotnet-sdk/tree/1.0.0/doc/controllers/auth.md)
* [Product](https://www.github.com/taamsoft/taam-ai-dotnet-sdk/tree/1.0.0/doc/controllers/product.md)
* [Misc](https://www.github.com/taamsoft/taam-ai-dotnet-sdk/tree/1.0.0/doc/controllers/misc.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/taamsoft/taam-ai-dotnet-sdk/tree/1.0.0/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/taamsoft/taam-ai-dotnet-sdk/tree/1.0.0/doc/http-request.md)
* [HttpResponse](https://www.github.com/taamsoft/taam-ai-dotnet-sdk/tree/1.0.0/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/taamsoft/taam-ai-dotnet-sdk/tree/1.0.0/doc/http-string-response.md)
* [HttpContext](https://www.github.com/taamsoft/taam-ai-dotnet-sdk/tree/1.0.0/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/taamsoft/taam-ai-dotnet-sdk/tree/1.0.0/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/taamsoft/taam-ai-dotnet-sdk/tree/1.0.0/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/taamsoft/taam-ai-dotnet-sdk/tree/1.0.0/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/taamsoft/taam-ai-dotnet-sdk/tree/1.0.0/doc/api-exception.md)

