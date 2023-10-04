// <copyright file="TemplatesController.cs" company="APIMatic">
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
    /// TemplatesController.
    /// </summary>
    public class TemplatesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesController"/> class.
        /// </summary>
        internal TemplatesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Fav Templates EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        public void FavTemplates(
                int userId)
            => CoreHelper.RunVoidTask(FavTemplatesAsync(userId));

        /// <summary>
        /// Fav Templates EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task FavTemplatesAsync(
                int userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/templates/favorite")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// All Templates EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.AllTemplates response from the API call.</returns>
        public Models.AllTemplates AllTemplates(
                int userId)
            => CoreHelper.RunTask(AllTemplatesAsync(userId));

        /// <summary>
        /// All Templates EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AllTemplates response from the API call.</returns>
        public async Task<Models.AllTemplates> AllTemplatesAsync(
                int userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AllTemplates>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/templates/all")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Template Detail EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="templateId">Required parameter: Example: .</param>
        public void TemplateDetail(
                int userId,
                int templateId)
            => CoreHelper.RunVoidTask(TemplateDetailAsync(userId, templateId));

        /// <summary>
        /// Template Detail EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="templateId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task TemplateDetailAsync(
                int userId,
                int templateId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/templates/detail")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("template_id", templateId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Process Template EndPoint.
        /// </summary>
        /// <param name="contentId">Required parameter: Example: .</param>
        /// <param name="maxResults">Required parameter: Example: .</param>
        /// <param name="maxWords">Required parameter: Example: .</param>
        /// <param name="temperature">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ProcessTemplate response from the API call.</returns>
        public Models.ProcessTemplate ProcessTemplate(
                int contentId,
                int maxResults,
                int maxWords,
                double temperature,
                int userId)
            => CoreHelper.RunTask(ProcessTemplateAsync(contentId, maxResults, maxWords, temperature, userId));

        /// <summary>
        /// Process Template EndPoint.
        /// </summary>
        /// <param name="contentId">Required parameter: Example: .</param>
        /// <param name="maxResults">Required parameter: Example: .</param>
        /// <param name="maxWords">Required parameter: Example: .</param>
        /// <param name="temperature">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProcessTemplate response from the API call.</returns>
        public async Task<Models.ProcessTemplate> ProcessTemplateAsync(
                int contentId,
                int maxResults,
                int maxWords,
                double temperature,
                int userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProcessTemplate>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/templates/process")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("content_id", contentId))
                      .Query(_query => _query.Setup("max_results", maxResults))
                      .Query(_query => _query.Setup("max_words", maxWords))
                      .Query(_query => _query.Setup("temperature", temperature))
                      .Query(_query => _query.Setup("user_id", userId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Generate Template EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="templateCode">Required parameter: Example: .</param>
        /// <param name="language">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="folderId">Required parameter: Example: .</param>
        /// <param name="maxResults">Required parameter: Example: .</param>
        /// <param name="words">Required parameter: Example: .</param>
        /// <param name="title">Required parameter: Example: .</param>
        /// <param name="description">Required parameter: Example: .</param>
        /// <param name="creativity">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GenerateTemplate response from the API call.</returns>
        public Models.GenerateTemplate GenerateTemplate(
                int userId,
                string templateCode,
                string language,
                int workbookId,
                int folderId,
                int maxResults,
                int words,
                string title,
                string description,
                double creativity)
            => CoreHelper.RunTask(GenerateTemplateAsync(userId, templateCode, language, workbookId, folderId, maxResults, words, title, description, creativity));

        /// <summary>
        /// Generate Template EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="templateCode">Required parameter: Example: .</param>
        /// <param name="language">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="folderId">Required parameter: Example: .</param>
        /// <param name="maxResults">Required parameter: Example: .</param>
        /// <param name="words">Required parameter: Example: .</param>
        /// <param name="title">Required parameter: Example: .</param>
        /// <param name="description">Required parameter: Example: .</param>
        /// <param name="creativity">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GenerateTemplate response from the API call.</returns>
        public async Task<Models.GenerateTemplate> GenerateTemplateAsync(
                int userId,
                string templateCode,
                string language,
                int workbookId,
                int folderId,
                int maxResults,
                int words,
                string title,
                string description,
                double creativity,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GenerateTemplate>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/template/generate")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("template_code", templateCode))
                      .Query(_query => _query.Setup("language", language))
                      .Query(_query => _query.Setup("workbook_id", workbookId))
                      .Query(_query => _query.Setup("folder_id", folderId))
                      .Query(_query => _query.Setup("max_results", maxResults))
                      .Query(_query => _query.Setup("words", words))
                      .Query(_query => _query.Setup("title", title))
                      .Query(_query => _query.Setup("description", description))
                      .Query(_query => _query.Setup("creativity", creativity))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Template groups EndPoint.
        /// </summary>
        public void TemplateGroups()
            => CoreHelper.RunVoidTask(TemplateGroupsAsync());

        /// <summary>
        /// Template groups EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task TemplateGroupsAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/templates/groups")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);
    }
}