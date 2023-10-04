// <copyright file="AddonFeaturesController.cs" company="APIMatic">
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
    /// AddonFeaturesController.
    /// </summary>
    public class AddonFeaturesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddonFeaturesController"/> class.
        /// </summary>
        internal AddonFeaturesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Generate Code EndPoint.
        /// </summary>
        /// <param name="language">Required parameter: Example: .</param>
        /// <param name="instructions">Required parameter: Example: .</param>
        /// <param name="document">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GenerateCode response from the API call.</returns>
        public Models.GenerateCode GenerateCode(
                string language,
                string instructions,
                string document,
                int userId)
            => CoreHelper.RunTask(GenerateCodeAsync(language, instructions, document, userId));

        /// <summary>
        /// Generate Code EndPoint.
        /// </summary>
        /// <param name="language">Required parameter: Example: .</param>
        /// <param name="instructions">Required parameter: Example: .</param>
        /// <param name="document">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GenerateCode response from the API call.</returns>
        public async Task<Models.GenerateCode> GenerateCodeAsync(
                string language,
                string instructions,
                string document,
                int userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GenerateCode>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/code/process")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("language", language))
                      .Query(_query => _query.Setup("instructions", instructions))
                      .Query(_query => _query.Setup("document", document))
                      .Query(_query => _query.Setup("user_id", userId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Save code in workspace EndPoint.
        /// </summary>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="folderId">Required parameter: Example: .</param>
        /// <param name="codeId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.SaveCodeInWorkspace response from the API call.</returns>
        public Models.SaveCodeInWorkspace SaveCodeInWorkspace(
                int workbookId,
                int userId,
                int folderId,
                int codeId)
            => CoreHelper.RunTask(SaveCodeInWorkspaceAsync(workbookId, userId, folderId, codeId));

        /// <summary>
        /// Save code in workspace EndPoint.
        /// </summary>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="folderId">Required parameter: Example: .</param>
        /// <param name="codeId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SaveCodeInWorkspace response from the API call.</returns>
        public async Task<Models.SaveCodeInWorkspace> SaveCodeInWorkspaceAsync(
                int workbookId,
                int userId,
                int folderId,
                int codeId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SaveCodeInWorkspace>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/code/save")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("workbook_id", workbookId))
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("folder_id", folderId))
                      .Query(_query => _query.Setup("code_id", codeId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Generate image from AI EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="title">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="workbookFolderId">Required parameter: Example: .</param>
        /// <param name="maxResults">Required parameter: Example: .</param>
        /// <param name="resolution">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GenerateImageFromAI response from the API call.</returns>
        public Models.GenerateImageFromAI GenerateImageFromAI(
                int userId,
                string name,
                string title,
                int workbookId,
                int workbookFolderId,
                int maxResults,
                string resolution)
            => CoreHelper.RunTask(GenerateImageFromAIAsync(userId, name, title, workbookId, workbookFolderId, maxResults, resolution));

        /// <summary>
        /// Generate image from AI EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="title">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="workbookFolderId">Required parameter: Example: .</param>
        /// <param name="maxResults">Required parameter: Example: .</param>
        /// <param name="resolution">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GenerateImageFromAI response from the API call.</returns>
        public async Task<Models.GenerateImageFromAI> GenerateImageFromAIAsync(
                int userId,
                string name,
                string title,
                int workbookId,
                int workbookFolderId,
                int maxResults,
                string resolution,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GenerateImageFromAI>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/image/process")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("name", name))
                      .Query(_query => _query.Setup("title", title))
                      .Query(_query => _query.Setup("workbook_id", workbookId))
                      .Query(_query => _query.Setup("workbook_folder_id", workbookFolderId))
                      .Query(_query => _query.Setup("max_results", maxResults))
                      .Query(_query => _query.Setup("resolution", resolution))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Generate speech to text EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="document">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="workbookFolderId">Required parameter: Example: .</param>
        /// <param name="language">Required parameter: Example: .</param>
        /// <param name="task">Required parameter: Example: .</param>
        /// <param name="audioFile">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GenerateSpeechToText response from the API call.</returns>
        public Models.GenerateSpeechToText GenerateSpeechToText(
                int userId,
                string document,
                int workbookId,
                int workbookFolderId,
                string language,
                string task,
                FileStreamInfo audioFile)
            => CoreHelper.RunTask(GenerateSpeechToTextAsync(userId, document, workbookId, workbookFolderId, language, task, audioFile));

        /// <summary>
        /// Generate speech to text EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="document">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="workbookFolderId">Required parameter: Example: .</param>
        /// <param name="language">Required parameter: Example: .</param>
        /// <param name="task">Required parameter: Example: .</param>
        /// <param name="audioFile">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GenerateSpeechToText response from the API call.</returns>
        public async Task<Models.GenerateSpeechToText> GenerateSpeechToTextAsync(
                int userId,
                string document,
                int workbookId,
                int workbookFolderId,
                string language,
                string task,
                FileStreamInfo audioFile,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GenerateSpeechToText>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transcribe/process")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Form(_form => _form.Setup("user_id", userId))
                      .Form(_form => _form.Setup("document", document))
                      .Form(_form => _form.Setup("workbook_id", workbookId))
                      .Form(_form => _form.Setup("workbook_folder_id", workbookFolderId))
                      .Form(_form => _form.Setup("language", language))
                      .Form(_form => _form.Setup("task", task))
                      .Form(_form => _form.Setup("audio_file", audioFile))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Save transcript EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="title">Required parameter: Example: .</param>
        /// <param name="transcriptId">Required parameter: Example: .</param>
        /// <param name="text">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="workbookFolderId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.SaveTranscript response from the API call.</returns>
        public Models.SaveTranscript SaveTranscript(
                int userId,
                string title,
                int transcriptId,
                string text,
                int workbookId,
                int workbookFolderId)
            => CoreHelper.RunTask(SaveTranscriptAsync(userId, title, transcriptId, text, workbookId, workbookFolderId));

        /// <summary>
        /// Save transcript EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="title">Required parameter: Example: .</param>
        /// <param name="transcriptId">Required parameter: Example: .</param>
        /// <param name="text">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="workbookFolderId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SaveTranscript response from the API call.</returns>
        public async Task<Models.SaveTranscript> SaveTranscriptAsync(
                int userId,
                string title,
                int transcriptId,
                string text,
                int workbookId,
                int workbookFolderId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SaveTranscript>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transcribe/save")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("title", title))
                      .Query(_query => _query.Setup("transcript_id", transcriptId))
                      .Query(_query => _query.Setup("text", text))
                      .Query(_query => _query.Setup("workbook_id", workbookId))
                      .Query(_query => _query.Setup("workbook_folder_id", workbookFolderId))))
              .ExecuteAsync(cancellationToken);
    }
}