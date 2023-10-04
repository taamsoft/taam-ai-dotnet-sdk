// <copyright file="AuthController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace TaamAiUser.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;
    using TaamAiUser.Standard;
    using TaamAiUser.Standard.Authentication;
    using TaamAiUser.Standard.Http.Client;
    using TaamAiUser.Standard.Utilities;

    /// <summary>
    /// AuthController.
    /// </summary>
    public class AuthController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthController"/> class.
        /// </summary>
        internal AuthController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// login EndPoint.
        /// </summary>
        /// <param name="email">Required parameter: Example: .</param>
        /// <param name="password">Required parameter: Example: .</param>
        /// <returns>Returns the Models.Login response from the API call.</returns>
        public Models.Login Login(
                string email,
                string password)
            => CoreHelper.RunTask(LoginAsync(email, password));

        /// <summary>
        /// login EndPoint.
        /// </summary>
        /// <param name="email">Required parameter: Example: .</param>
        /// <param name="password">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Login response from the API call.</returns>
        public async Task<Models.Login> LoginAsync(
                string email,
                string password,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Login>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/login")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Form(_form => _form.Setup("email", email))
                      .Form(_form => _form.Setup("password", password))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Register EndPoint.
        /// </summary>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="email">Required parameter: Example: .</param>
        /// <param name="password">Required parameter: Example: .</param>
        /// <param name="country">Required parameter: Example: .</param>
        /// <param name="subdomain">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ExampleWithDefaultPlanSubdomainAndSubsctpion response from the API call.</returns>
        public Models.ExampleWithDefaultPlanSubdomainAndSubsctpion Register(
                string name,
                string email,
                string password,
                string country,
                string subdomain)
            => CoreHelper.RunTask(RegisterAsync(name, email, password, country, subdomain));

        /// <summary>
        /// Register EndPoint.
        /// </summary>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="email">Required parameter: Example: .</param>
        /// <param name="password">Required parameter: Example: .</param>
        /// <param name="country">Required parameter: Example: .</param>
        /// <param name="subdomain">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExampleWithDefaultPlanSubdomainAndSubsctpion response from the API call.</returns>
        public async Task<Models.ExampleWithDefaultPlanSubdomainAndSubsctpion> RegisterAsync(
                string name,
                string email,
                string password,
                string country,
                string subdomain,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExampleWithDefaultPlanSubdomainAndSubsctpion>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/register")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("name", name))
                      .Query(_query => _query.Setup("email", email))
                      .Query(_query => _query.Setup("password", password))
                      .Query(_query => _query.Setup("country", country))
                      .Query(_query => _query.Setup("subdomain", subdomain))))
              .ExecuteAsync(cancellationToken);
    }
}