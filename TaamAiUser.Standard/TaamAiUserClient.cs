// <copyright file="TaamAiUserClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace TaamAiUser.Standard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using APIMatic.Core;
    using APIMatic.Core.Authentication;
    using APIMatic.Core.Types;
    using TaamAiUser.Standard.Authentication;
    using TaamAiUser.Standard.Controllers;
    using TaamAiUser.Standard.Http.Client;
    using TaamAiUser.Standard.Utilities;

    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class TaamAiUserClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.Server1, "https://taam.ai/api" },
                    { Server.Server2, "http://127.0.0.1:8000/api" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private const string userAgent = "APIMATIC 3.0";
        private readonly HttpCallBack httpCallBack;
        private readonly BearerAuthManager bearerAuthManager;
        private readonly Lazy<TemplatesController> templates;
        private readonly Lazy<AuthController> auth;
        private readonly Lazy<WorkbookAndFoldersController> workbookAndFolders;
        private readonly Lazy<CustimTemplatesController> custimTemplates;
        private readonly Lazy<ProductController> product;
        private readonly Lazy<PromptTemplateController> promptTemplate;
        private readonly Lazy<ChatWithPdfController> chatWithPdf;
        private readonly Lazy<AddonFeaturesController> addonFeatures;
        private readonly Lazy<MiscController> misc;

        private TaamAiUserClient(
            Environment environment,
            string accessToken,
            HttpCallBack httpCallBack,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.httpCallBack = httpCallBack;
            this.HttpClientConfiguration = httpClientConfiguration;
            bearerAuthManager = new BearerAuthManager(accessToken);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                        {"global", bearerAuthManager}
                })
                .ApiCallback(httpCallBack)
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Server1)
                .UserAgent(userAgent)
                .Build();


            this.templates = new Lazy<TemplatesController>(
                () => new TemplatesController(globalConfiguration));
            this.auth = new Lazy<AuthController>(
                () => new AuthController(globalConfiguration));
            this.workbookAndFolders = new Lazy<WorkbookAndFoldersController>(
                () => new WorkbookAndFoldersController(globalConfiguration));
            this.custimTemplates = new Lazy<CustimTemplatesController>(
                () => new CustimTemplatesController(globalConfiguration));
            this.product = new Lazy<ProductController>(
                () => new ProductController(globalConfiguration));
            this.promptTemplate = new Lazy<PromptTemplateController>(
                () => new PromptTemplateController(globalConfiguration));
            this.chatWithPdf = new Lazy<ChatWithPdfController>(
                () => new ChatWithPdfController(globalConfiguration));
            this.addonFeatures = new Lazy<AddonFeaturesController>(
                () => new AddonFeaturesController(globalConfiguration));
            this.misc = new Lazy<MiscController>(
                () => new MiscController(globalConfiguration));
        }

        /// <summary>
        /// Gets TemplatesController controller.
        /// </summary>
        public TemplatesController TemplatesController => this.templates.Value;

        /// <summary>
        /// Gets AuthController controller.
        /// </summary>
        public AuthController AuthController => this.auth.Value;

        /// <summary>
        /// Gets WorkbookAndFoldersController controller.
        /// </summary>
        public WorkbookAndFoldersController WorkbookAndFoldersController => this.workbookAndFolders.Value;

        /// <summary>
        /// Gets CustimTemplatesController controller.
        /// </summary>
        public CustimTemplatesController CustimTemplatesController => this.custimTemplates.Value;

        /// <summary>
        /// Gets ProductController controller.
        /// </summary>
        public ProductController ProductController => this.product.Value;

        /// <summary>
        /// Gets PromptTemplateController controller.
        /// </summary>
        public PromptTemplateController PromptTemplateController => this.promptTemplate.Value;

        /// <summary>
        /// Gets ChatWithPdfController controller.
        /// </summary>
        public ChatWithPdfController ChatWithPdfController => this.chatWithPdf.Value;

        /// <summary>
        /// Gets AddonFeaturesController controller.
        /// </summary>
        public AddonFeaturesController AddonFeaturesController => this.addonFeatures.Value;

        /// <summary>
        /// Gets MiscController controller.
        /// </summary>
        public MiscController MiscController => this.misc.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets http callback.
        /// </summary>
        internal HttpCallBack HttpCallBack => this.httpCallBack;

        /// <summary>
        /// Gets the credentials to use with BearerAuth.
        /// </summary>
        private IBearerAuthCredentials BearerAuthCredentials => this.bearerAuthManager;

        /// <summary>
        /// Gets the access token to use with OAuth 2 authentication.
        /// </summary>
        public string AccessToken => this.BearerAuthCredentials.AccessToken;

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:SERVER 1.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Server1)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the TaamAiUserClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .AccessToken(BearerAuthCredentials.AccessToken)
                .HttpCallBack(httpCallBack)
                .HttpClientConfig(config => config.Build());

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> TaamAiUserClient.</returns>
        internal static TaamAiUserClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("TAAM_AI_USER_STANDARD_ENVIRONMENT");
            string accessToken = System.Environment.GetEnvironmentVariable("TAAM_AI_USER_STANDARD_ACCESS_TOKEN");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (accessToken != null)
            {
                builder.AccessToken(accessToken);
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = TaamAiUser.Standard.Environment.Production;
            private string accessToken = "";
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private HttpCallBack httpCallBack;

            /// <summary>
            /// Sets credentials for BearerAuth.
            /// </summary>
            /// <param name="accessToken">AccessToken.</param>
            /// <returns>Builder.</returns>
            public Builder AccessToken(string accessToken)
            {
                this.accessToken = accessToken ?? throw new ArgumentNullException(nameof(accessToken));
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }

           

            /// <summary>
            /// Sets the HttpCallBack for the Builder.
            /// </summary>
            /// <param name="httpCallBack"> http callback. </param>
            /// <returns>Builder.</returns>
            internal Builder HttpCallBack(HttpCallBack httpCallBack)
            {
                this.httpCallBack = httpCallBack;
                return this;
            }

            /// <summary>
            /// Creates an object of the TaamAiUserClient using the values provided for the builder.
            /// </summary>
            /// <returns>TaamAiUserClient.</returns>
            public TaamAiUserClient Build()
            {

                return new TaamAiUserClient(
                    environment,
                    accessToken,
                    httpCallBack,
                    httpClientConfig.Build());
            }
        }
    }
}
