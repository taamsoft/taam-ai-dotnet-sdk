// <copyright file="PromptTemplateController.cs" company="APIMatic">
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
    /// PromptTemplateController.
    /// </summary>
    public class PromptTemplateController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PromptTemplateController"/> class.
        /// </summary>
        internal PromptTemplateController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Prompt Templates EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cat">Required parameter: Example: .</param>
        /// <param name="subCat">Required parameter: Example: .</param>
        /// <returns>Returns the Models.PromptTemplates response from the API call.</returns>
        public Models.PromptTemplates PromptTemplates(
                int userId,
                string cat,
                string subCat)
            => CoreHelper.RunTask(PromptTemplatesAsync(userId, cat, subCat));

        /// <summary>
        /// Prompt Templates EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cat">Required parameter: Example: .</param>
        /// <param name="subCat">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PromptTemplates response from the API call.</returns>
        public async Task<Models.PromptTemplates> PromptTemplatesAsync(
                int userId,
                string cat,
                string subCat,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PromptTemplates>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/prompt-templates")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("cat", cat))
                      .Query(_query => _query.Setup("sub_cat", subCat))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Add and remove from bookmark prompt template EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="templateId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.NewRequest1 response from the API call.</returns>
        public Models.NewRequest1 AddAndRemoveFromBookmarkPromptTemplate(
                int userId,
                int templateId)
            => CoreHelper.RunTask(AddAndRemoveFromBookmarkPromptTemplateAsync(userId, templateId));

        /// <summary>
        /// Add and remove from bookmark prompt template EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="templateId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.NewRequest1 response from the API call.</returns>
        public async Task<Models.NewRequest1> AddAndRemoveFromBookmarkPromptTemplateAsync(
                int userId,
                int templateId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.NewRequest1>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/prompt-template/add-bookmark")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("template_id", templateId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// prompt template like or remove from like EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="templateId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.PromptTemplateLikeOrRemoveFromLike response from the API call.</returns>
        public Models.PromptTemplateLikeOrRemoveFromLike PromptTemplateLikeOrRemoveFromLike(
                int userId,
                int templateId)
            => CoreHelper.RunTask(PromptTemplateLikeOrRemoveFromLikeAsync(userId, templateId));

        /// <summary>
        /// prompt template like or remove from like EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="templateId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PromptTemplateLikeOrRemoveFromLike response from the API call.</returns>
        public async Task<Models.PromptTemplateLikeOrRemoveFromLike> PromptTemplateLikeOrRemoveFromLikeAsync(
                int userId,
                int templateId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PromptTemplateLikeOrRemoveFromLike>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/prompt-template/add-like")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("template_id", templateId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Create Prompt Template EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="mPublic">Required parameter: Example: .</param>
        /// <param name="edit">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="activate">Required parameter: Example: .</param>
        /// <param name="tone">Required parameter: Example: .</param>
        /// <param name="prompt">Required parameter: Example: .</param>
        /// <param name="language">Required parameter: Example: .</param>
        /// <param name="package">Required parameter: Example: .</param>
        /// <param name="category">Required parameter: Example: .</param>
        /// <param name="names0">Required parameter: Example: .</param>
        /// <param name="placeholders0">Required parameter: Example: .</param>
        /// <param name="code0">Required parameter: Example: .</param>
        /// <param name="inputField0">Required parameter: Example: .</param>
        /// <returns>Returns the Models.CreatePromptTemplate response from the API call.</returns>
        public Models.CreatePromptTemplate CreatePromptTemplate(
                int userId,
                int mPublic,
                int edit,
                string name,
                int activate,
                int tone,
                string prompt,
                string language,
                string package,
                string category,
                string names0,
                string placeholders0,
                string code0,
                string inputField0)
            => CoreHelper.RunTask(CreatePromptTemplateAsync(userId, mPublic, edit, name, activate, tone, prompt, language, package, category, names0, placeholders0, code0, inputField0));

        /// <summary>
        /// Create Prompt Template EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="mPublic">Required parameter: Example: .</param>
        /// <param name="edit">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="activate">Required parameter: Example: .</param>
        /// <param name="tone">Required parameter: Example: .</param>
        /// <param name="prompt">Required parameter: Example: .</param>
        /// <param name="language">Required parameter: Example: .</param>
        /// <param name="package">Required parameter: Example: .</param>
        /// <param name="category">Required parameter: Example: .</param>
        /// <param name="names0">Required parameter: Example: .</param>
        /// <param name="placeholders0">Required parameter: Example: .</param>
        /// <param name="code0">Required parameter: Example: .</param>
        /// <param name="inputField0">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreatePromptTemplate response from the API call.</returns>
        public async Task<Models.CreatePromptTemplate> CreatePromptTemplateAsync(
                int userId,
                int mPublic,
                int edit,
                string name,
                int activate,
                int tone,
                string prompt,
                string language,
                string package,
                string category,
                string names0,
                string placeholders0,
                string code0,
                string inputField0,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreatePromptTemplate>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/prompt-template/create")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("public", mPublic))
                      .Query(_query => _query.Setup("edit", edit))
                      .Query(_query => _query.Setup("name", name))
                      .Query(_query => _query.Setup("activate", activate))
                      .Query(_query => _query.Setup("tone", tone))
                      .Query(_query => _query.Setup("prompt", prompt))
                      .Query(_query => _query.Setup("language", language))
                      .Query(_query => _query.Setup("package", package))
                      .Query(_query => _query.Setup("category", category))
                      .Query(_query => _query.Setup("names[0]", names0))
                      .Query(_query => _query.Setup("placeholders[0]", placeholders0))
                      .Query(_query => _query.Setup("code[0]", code0))
                      .Query(_query => _query.Setup("input_field[0]", inputField0))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Trashed Prompt Templates EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.TrashedPromptTemplates response from the API call.</returns>
        public Models.TrashedPromptTemplates TrashedPromptTemplates(
                int userId)
            => CoreHelper.RunTask(TrashedPromptTemplatesAsync(userId));

        /// <summary>
        /// Trashed Prompt Templates EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TrashedPromptTemplates response from the API call.</returns>
        public async Task<Models.TrashedPromptTemplates> TrashedPromptTemplatesAsync(
                int userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TrashedPromptTemplates>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/prompt-templates/trashed")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// delete prmopt template EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="templateId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.DeletePrmoptTemplate response from the API call.</returns>
        public Models.DeletePrmoptTemplate DeletePrmoptTemplate(
                int userId,
                int templateId)
            => CoreHelper.RunTask(DeletePrmoptTemplateAsync(userId, templateId));

        /// <summary>
        /// delete prmopt template EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="templateId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DeletePrmoptTemplate response from the API call.</returns>
        public async Task<Models.DeletePrmoptTemplate> DeletePrmoptTemplateAsync(
                int userId,
                int templateId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeletePrmoptTemplate>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/prompt-templates/delete")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("template_id", templateId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Restore Prompt Template EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="templateId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.RestorePromptTemplate response from the API call.</returns>
        public Models.RestorePromptTemplate RestorePromptTemplate(
                int userId,
                int templateId)
            => CoreHelper.RunTask(RestorePromptTemplateAsync(userId, templateId));

        /// <summary>
        /// Restore Prompt Template EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="templateId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RestorePromptTemplate response from the API call.</returns>
        public async Task<Models.RestorePromptTemplate> RestorePromptTemplateAsync(
                int userId,
                int templateId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RestorePromptTemplate>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/prompt-templates/restore")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("template_id", templateId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Parmanent Delete Prompt template EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="templateId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ParmanentDeletePromptTemplate response from the API call.</returns>
        public Models.ParmanentDeletePromptTemplate ParmanentDeletePromptTemplate(
                int userId,
                int templateId)
            => CoreHelper.RunTask(ParmanentDeletePromptTemplateAsync(userId, templateId));

        /// <summary>
        /// Parmanent Delete Prompt template EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="templateId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ParmanentDeletePromptTemplate response from the API call.</returns>
        public async Task<Models.ParmanentDeletePromptTemplate> ParmanentDeletePromptTemplateAsync(
                int userId,
                int templateId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ParmanentDeletePromptTemplate>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/prompt-templates/permanent-delete")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("template_id", templateId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Generate prompt template EndPoint.
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
        /// <param name="text1">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GeneratePromptTemplate response from the API call.</returns>
        public Models.GeneratePromptTemplate GeneratePromptTemplate(
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
                string text1)
            => CoreHelper.RunTask(GeneratePromptTemplateAsync(userId, templateCode, language, maxResults, words, creativity, title, description, workbookId, folderId, text1));

        /// <summary>
        /// Generate prompt template EndPoint.
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
        /// <param name="text1">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GeneratePromptTemplate response from the API call.</returns>
        public async Task<Models.GeneratePromptTemplate> GeneratePromptTemplateAsync(
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
                string text1,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GeneratePromptTemplate>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/templates/prompt-generate")
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
                      .Query(_query => _query.Setup("text1", text1))))
              .ExecuteAsync(cancellationToken);
    }
}