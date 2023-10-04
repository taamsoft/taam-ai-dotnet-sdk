// <copyright file="CustimTemplatesController.cs" company="APIMatic">
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
    /// CustimTemplatesController.
    /// </summary>
    public class CustimTemplatesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustimTemplatesController"/> class.
        /// </summary>
        internal CustimTemplatesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Custom Templates EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        public void CustomTemplates(
                int userId)
            => CoreHelper.RunVoidTask(CustomTemplatesAsync(userId));

        /// <summary>
        /// Custom Templates EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task CustomTemplatesAsync(
                int userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/templates/custom-template")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Fav Custom Templates EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        public void FavCustomTemplates(
                int userId)
            => CoreHelper.RunVoidTask(FavCustomTemplatesAsync(userId));

        /// <summary>
        /// Fav Custom Templates EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task FavCustomTemplatesAsync(
                int userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/templates/custom/favorite")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Custom Template generate EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="templateCode">Required parameter: Example: .</param>
        /// <param name="language">Required parameter: Example: .</param>
        /// <param name="maxResults">Required parameter: Example: .</param>
        /// <param name="words">Required parameter: Example: .</param>
        /// <param name="creativity">Required parameter: Example: .</param>
        /// <param name="title">Required parameter: Example: .</param>
        /// <param name="description">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="folderId">Required parameter: Example: .</param>
        /// <param name="text">Required parameter: Example: .</param>
        /// <param name="text2">Required parameter: Example: .</param>
        /// <returns>Returns the Models.CustomTemplateGenerate response from the API call.</returns>
        public Models.CustomTemplateGenerate CustomTemplateGenerate(
                int userId,
                string templateCode,
                string language,
                int maxResults,
                int words,
                double creativity,
                string title,
                string description,
                int workbookId,
                int folderId,
                string text,
                string text2)
            => CoreHelper.RunTask(CustomTemplateGenerateAsync(userId, templateCode, language, maxResults, words, creativity, title, description, workbookId, folderId, text, text2));

        /// <summary>
        /// Custom Template generate EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="templateCode">Required parameter: Example: .</param>
        /// <param name="language">Required parameter: Example: .</param>
        /// <param name="maxResults">Required parameter: Example: .</param>
        /// <param name="words">Required parameter: Example: .</param>
        /// <param name="creativity">Required parameter: Example: .</param>
        /// <param name="title">Required parameter: Example: .</param>
        /// <param name="description">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="folderId">Required parameter: Example: .</param>
        /// <param name="text">Required parameter: Example: .</param>
        /// <param name="text2">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CustomTemplateGenerate response from the API call.</returns>
        public async Task<Models.CustomTemplateGenerate> CustomTemplateGenerateAsync(
                int userId,
                string templateCode,
                string language,
                int maxResults,
                int words,
                double creativity,
                string title,
                string description,
                int workbookId,
                int folderId,
                string text,
                string text2,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CustomTemplateGenerate>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/templates/custom-generate")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("template_code", templateCode))
                      .Query(_query => _query.Setup("language", language))
                      .Query(_query => _query.Setup("max_results", maxResults))
                      .Query(_query => _query.Setup("words", words))
                      .Query(_query => _query.Setup("creativity", creativity))
                      .Query(_query => _query.Setup("title", title))
                      .Query(_query => _query.Setup("description", description))
                      .Query(_query => _query.Setup("workbook_id", workbookId))
                      .Query(_query => _query.Setup("folder_id", folderId))
                      .Query(_query => _query.Setup("text", text))
                      .Query(_query => _query.Setup("text2", text2))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Create Custom Template EndPoint.
        /// </summary>
        /// <returns>Returns the Models.CreateCustomTemplate response from the API call.</returns>
        public Models.CreateCustomTemplate CreateCustomTemplate()
            => CoreHelper.RunTask(CreateCustomTemplateAsync());

        /// <summary>
        /// Create Custom Template EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreateCustomTemplate response from the API call.</returns>
        public async Task<Models.CreateCustomTemplate> CreateCustomTemplateAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreateCustomTemplate>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Trashed Custom Templates EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.TrashedCustomTemplates response from the API call.</returns>
        public Models.TrashedCustomTemplates TrashedCustomTemplates(
                int userId)
            => CoreHelper.RunTask(TrashedCustomTemplatesAsync(userId));

        /// <summary>
        /// Trashed Custom Templates EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TrashedCustomTemplates response from the API call.</returns>
        public async Task<Models.TrashedCustomTemplates> TrashedCustomTemplatesAsync(
                int userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TrashedCustomTemplates>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/customTemplate/trashed")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Delete Custom template EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="templateId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.DeleteCustomTemplate response from the API call.</returns>
        public Models.DeleteCustomTemplate DeleteCustomTemplate(
                int userId,
                int templateId)
            => CoreHelper.RunTask(DeleteCustomTemplateAsync(userId, templateId));

        /// <summary>
        /// Delete Custom template EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="templateId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DeleteCustomTemplate response from the API call.</returns>
        public async Task<Models.DeleteCustomTemplate> DeleteCustomTemplateAsync(
                int userId,
                int templateId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeleteCustomTemplate>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/customTemplate/delete")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("template_id", templateId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Restore Custom template EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="templateId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.RestoreCustomTemplate response from the API call.</returns>
        public Models.RestoreCustomTemplate RestoreCustomTemplate(
                int userId,
                int templateId)
            => CoreHelper.RunTask(RestoreCustomTemplateAsync(userId, templateId));

        /// <summary>
        /// Restore Custom template EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="templateId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RestoreCustomTemplate response from the API call.</returns>
        public async Task<Models.RestoreCustomTemplate> RestoreCustomTemplateAsync(
                int userId,
                int templateId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RestoreCustomTemplate>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/customTemplate/restore")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("template_id", templateId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// permanent delete custom template EndPoint.
        /// </summary>
        /// <returns>Returns the Models.PermanentDeleteCustomTemplate response from the API call.</returns>
        public Models.PermanentDeleteCustomTemplate PermanentDeleteCustomTemplate()
            => CoreHelper.RunTask(PermanentDeleteCustomTemplateAsync());

        /// <summary>
        /// permanent delete custom template EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PermanentDeleteCustomTemplate response from the API call.</returns>
        public async Task<Models.PermanentDeleteCustomTemplate> PermanentDeleteCustomTemplateAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PermanentDeleteCustomTemplate>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);
    }
}