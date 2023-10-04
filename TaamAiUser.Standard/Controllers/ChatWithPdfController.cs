// <copyright file="ChatWithPdfController.cs" company="APIMatic">
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
    /// ChatWithPdfController.
    /// </summary>
    public class ChatWithPdfController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatWithPdfController"/> class.
        /// </summary>
        internal ChatWithPdfController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// upload file for chat pdf EndPoint.
        /// </summary>
        /// <param name="file">Required parameter: Example: .</param>
        public void UploadFileForChatPdf(
                FileStreamInfo file)
            => CoreHelper.RunVoidTask(UploadFileForChatPdfAsync(file));

        /// <summary>
        /// upload file for chat pdf EndPoint.
        /// </summary>
        /// <param name="file">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task UploadFileForChatPdfAsync(
                FileStreamInfo file,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/add-url")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Form(_form => _form.Setup("file", file))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Send and get msg to chat pdf EndPoint.
        /// </summary>
        /// <param name="question">Required parameter: Example: .</param>
        public void SendAndGetMsgToChatPdf(
                string question)
            => CoreHelper.RunVoidTask(SendAndGetMsgToChatPdfAsync(question));

        /// <summary>
        /// Send and get msg to chat pdf EndPoint.
        /// </summary>
        /// <param name="question">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task SendAndGetMsgToChatPdfAsync(
                string question,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/send-message")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Form(_form => _form.Setup("question", question))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// pdf to text EndPoint.
        /// </summary>
        /// <param name="file">Required parameter: Example: .</param>
        public void PdfToText(
                FileStreamInfo file)
            => CoreHelper.RunVoidTask(PdfToTextAsync(file));

        /// <summary>
        /// pdf to text EndPoint.
        /// </summary>
        /// <param name="file">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task PdfToTextAsync(
                FileStreamInfo file,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/pdf-text")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Form(_form => _form.Setup("file", file))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// file upload EndPoint.
        /// </summary>
        /// <param name="file">Required parameter: Example: .</param>
        public void FileUpload(
                FileStreamInfo file)
            => CoreHelper.RunVoidTask(FileUploadAsync(file));

        /// <summary>
        /// file upload EndPoint.
        /// </summary>
        /// <param name="file">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task FileUploadAsync(
                FileStreamInfo file,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/pdf/upload")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Form(_form => _form.Setup("file", file))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// answer the question EndPoint.
        /// </summary>
        public void AnswerTheQuestion()
            => CoreHelper.RunVoidTask(AnswerTheQuestionAsync());

        /// <summary>
        /// answer the question EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task AnswerTheQuestionAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// New Request EndPoint.
        /// </summary>
        /// <param name="question">Required parameter: Example: .</param>
        /// <param name="path">Required parameter: Example: .</param>
        public void NewRequest(
                string question,
                string path)
            => CoreHelper.RunVoidTask(NewRequestAsync(question, path));

        /// <summary>
        /// New Request EndPoint.
        /// </summary>
        /// <param name="question">Required parameter: Example: .</param>
        /// <param name="path">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task NewRequestAsync(
                string question,
                string path,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/pdf/text")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("question", question))
                      .Query(_query => _query.Setup("path", path))))
              .ExecuteAsync(cancellationToken);
    }
}