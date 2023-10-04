// <copyright file="MiscController.cs" company="APIMatic">
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
    /// MiscController.
    /// </summary>
    public class MiscController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MiscController"/> class.
        /// </summary>
        internal MiscController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// All Categories EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        public void AllCategories(
                int userId)
            => CoreHelper.RunVoidTask(AllCategoriesAsync(userId));

        /// <summary>
        /// All Categories EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task AllCategoriesAsync(
                int userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/all/categories")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// New Request EndPoint.
        /// </summary>
        public void NewRequest()
            => CoreHelper.RunVoidTask(NewRequestAsync());

        /// <summary>
        /// New Request EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task NewRequestAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);
    }
}