// <copyright file="WorkbookAndFoldersController.cs" company="APIMatic">
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
    /// WorkbookAndFoldersController.
    /// </summary>
    public class WorkbookAndFoldersController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkbookAndFoldersController"/> class.
        /// </summary>
        internal WorkbookAndFoldersController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// all workbooks EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.AllWorkbooksLive response from the API call.</returns>
        public Models.AllWorkbooksLive AllWorkbooks(
                int userId)
            => CoreHelper.RunTask(AllWorkbooksAsync(userId));

        /// <summary>
        /// all workbooks EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AllWorkbooksLive response from the API call.</returns>
        public async Task<Models.AllWorkbooksLive> AllWorkbooksAsync(
                int userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AllWorkbooksLive>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/workbooks")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Create Workbook EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="workbookName">Required parameter: Example: .</param>
        /// <returns>Returns the Models.CreateWorkbookLivw response from the API call.</returns>
        public Models.CreateWorkbookLivw CreateWorkbook(
                int userId,
                string workbookName)
            => CoreHelper.RunTask(CreateWorkbookAsync(userId, workbookName));

        /// <summary>
        /// Create Workbook EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="workbookName">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreateWorkbookLivw response from the API call.</returns>
        public async Task<Models.CreateWorkbookLivw> CreateWorkbookAsync(
                int userId,
                string workbookName,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreateWorkbookLivw>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/workbooks/create")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("workbook_name", workbookName))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Workbook Detail EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.WorkbookDetailLive response from the API call.</returns>
        public Models.WorkbookDetailLive WorkbookDetail(
                int userId,
                int workbookId)
            => CoreHelper.RunTask(WorkbookDetailAsync(userId, workbookId));

        /// <summary>
        /// Workbook Detail EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkbookDetailLive response from the API call.</returns>
        public async Task<Models.WorkbookDetailLive> WorkbookDetailAsync(
                int userId,
                int workbookId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkbookDetailLive>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/workbooks/detail")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("workbook_id", workbookId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Delete Workspace EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.DeleteWorkspaceLive response from the API call.</returns>
        public Models.DeleteWorkspaceLive DeleteWorkspace(
                int userId,
                int workbookId)
            => CoreHelper.RunTask(DeleteWorkspaceAsync(userId, workbookId));

        /// <summary>
        /// Delete Workspace EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DeleteWorkspaceLive response from the API call.</returns>
        public async Task<Models.DeleteWorkspaceLive> DeleteWorkspaceAsync(
                int userId,
                int workbookId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeleteWorkspaceLive>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/workbooks/delete")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("workbook_id", workbookId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Trashed workspaces EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.TrashedWorkspacesLive response from the API call.</returns>
        public Models.TrashedWorkspacesLive TrashedWorkspaces(
                int userId)
            => CoreHelper.RunTask(TrashedWorkspacesAsync(userId));

        /// <summary>
        /// Trashed workspaces EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TrashedWorkspacesLive response from the API call.</returns>
        public async Task<Models.TrashedWorkspacesLive> TrashedWorkspacesAsync(
                int userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TrashedWorkspacesLive>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/workbooks/trashed")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Restore Workspace EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.RestoreWorkspaceLive response from the API call.</returns>
        public Models.RestoreWorkspaceLive RestoreWorkspace(
                int userId,
                int workbookId)
            => CoreHelper.RunTask(RestoreWorkspaceAsync(userId, workbookId));

        /// <summary>
        /// Restore Workspace EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RestoreWorkspaceLive response from the API call.</returns>
        public async Task<Models.RestoreWorkspaceLive> RestoreWorkspaceAsync(
                int userId,
                int workbookId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RestoreWorkspaceLive>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/workbooks/restore")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("workbook_id", workbookId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Create Folder EndPoint.
        /// </summary>
        /// <param name="folderName">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.CreateFolderLive response from the API call.</returns>
        public Models.CreateFolderLive CreateFolder(
                string folderName,
                int workbookId,
                int userId)
            => CoreHelper.RunTask(CreateFolderAsync(folderName, workbookId, userId));

        /// <summary>
        /// Create Folder EndPoint.
        /// </summary>
        /// <param name="folderName">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreateFolderLive response from the API call.</returns>
        public async Task<Models.CreateFolderLive> CreateFolderAsync(
                string folderName,
                int workbookId,
                int userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreateFolderLive>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/workbooks/create-folder")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("folder_name", folderName))
                      .Query(_query => _query.Setup("workbook_id", workbookId))
                      .Query(_query => _query.Setup("user_id", userId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// delete folder EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="folderId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.DeleteFolder response from the API call.</returns>
        public Models.DeleteFolder DeleteFolder(
                int userId,
                int folderId)
            => CoreHelper.RunTask(DeleteFolderAsync(userId, folderId));

        /// <summary>
        /// delete folder EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="folderId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DeleteFolder response from the API call.</returns>
        public async Task<Models.DeleteFolder> DeleteFolderAsync(
                int userId,
                int folderId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeleteFolder>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/workbooks/folders/delete")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("folder_id", folderId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// restore folder EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="folderId">Required parameter: Example: .</param>
        public void RestoreFolder(
                int userId,
                int folderId)
            => CoreHelper.RunVoidTask(RestoreFolderAsync(userId, folderId));

        /// <summary>
        /// restore folder EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="folderId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task RestoreFolderAsync(
                int userId,
                int folderId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/workbooks/folders/restore")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("folder_id", folderId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Set defualt workspace EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        public void SetDefualtWorkspace(
                int userId,
                int workbookId)
            => CoreHelper.RunVoidTask(SetDefualtWorkspaceAsync(userId, workbookId));

        /// <summary>
        /// Set defualt workspace EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task SetDefualtWorkspaceAsync(
                int userId,
                int workbookId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/workbooks/set-default")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("workbook_id", workbookId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Permanent Delete folder EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="folderId">Required parameter: Example: .</param>
        public void PermanentDeleteFolder(
                int userId,
                int folderId)
            => CoreHelper.RunVoidTask(PermanentDeleteFolderAsync(userId, folderId));

        /// <summary>
        /// Permanent Delete folder EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="folderId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task PermanentDeleteFolderAsync(
                int userId,
                int folderId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/workbooks/folders/permanent-delete")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("folder_id", folderId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Contents in work book EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ContentsInWorkBook response from the API call.</returns>
        public Models.ContentsInWorkBook ContentsInWorkBook(
                int userId,
                string type,
                int workbookId)
            => CoreHelper.RunTask(ContentsInWorkBookAsync(userId, type, workbookId));

        /// <summary>
        /// Contents in work book EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ContentsInWorkBook response from the API call.</returns>
        public async Task<Models.ContentsInWorkBook> ContentsInWorkBookAsync(
                int userId,
                string type,
                int workbookId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ContentsInWorkBook>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/workbooks/contents")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("type", type))
                      .Query(_query => _query.Setup("workbook_id", workbookId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Trashed folders EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.TrashedFoldersLive response from the API call.</returns>
        public Models.TrashedFoldersLive TrashedFolders(
                int userId,
                int workbookId)
            => CoreHelper.RunTask(TrashedFoldersAsync(userId, workbookId));

        /// <summary>
        /// Trashed folders EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TrashedFoldersLive response from the API call.</returns>
        public async Task<Models.TrashedFoldersLive> TrashedFoldersAsync(
                int userId,
                int workbookId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TrashedFoldersLive>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/workbooks/trashed-folders")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("workbook_id", workbookId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Workbook voiceovers EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="folderId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.WorkbookVoiceovers response from the API call.</returns>
        public Models.WorkbookVoiceovers WorkbookVoiceovers(
                int userId,
                string type,
                int workbookId,
                int folderId)
            => CoreHelper.RunTask(WorkbookVoiceoversAsync(userId, type, workbookId, folderId));

        /// <summary>
        /// Workbook voiceovers EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="folderId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkbookVoiceovers response from the API call.</returns>
        public async Task<Models.WorkbookVoiceovers> WorkbookVoiceoversAsync(
                int userId,
                string type,
                int workbookId,
                int folderId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkbookVoiceovers>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/workbooks/voiceovers")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("type", type))
                      .Query(_query => _query.Setup("workbook_id", workbookId))
                      .Query(_query => _query.Setup("folder_id", folderId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// workbook transcripts EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="folderId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.WorkbookTranscripts response from the API call.</returns>
        public Models.WorkbookTranscripts WorkbookTranscripts(
                int userId,
                string type,
                string workbookId,
                int folderId)
            => CoreHelper.RunTask(WorkbookTranscriptsAsync(userId, type, workbookId, folderId));

        /// <summary>
        /// workbook transcripts EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="folderId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkbookTranscripts response from the API call.</returns>
        public async Task<Models.WorkbookTranscripts> WorkbookTranscriptsAsync(
                int userId,
                string type,
                string workbookId,
                int folderId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkbookTranscripts>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/workbooks/transcripts")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("type", type))
                      .Query(_query => _query.Setup("workbook_id", workbookId))
                      .Query(_query => _query.Setup("folder_id", folderId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Permanent Delete workspace EndPoint.
        /// </summary>
        /// <returns>Returns the Models.PermanentDeleteWorkspaceLive response from the API call.</returns>
        public Models.PermanentDeleteWorkspaceLive PermanentDeleteWorkspace()
            => CoreHelper.RunTask(PermanentDeleteWorkspaceAsync());

        /// <summary>
        /// Permanent Delete workspace EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PermanentDeleteWorkspaceLive response from the API call.</returns>
        public async Task<Models.PermanentDeleteWorkspaceLive> PermanentDeleteWorkspaceAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PermanentDeleteWorkspaceLive>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// workbook images EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="folderId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.WorkbookImages response from the API call.</returns>
        public Models.WorkbookImages WorkbookImages(
                int userId,
                string type,
                string workbookId,
                int folderId)
            => CoreHelper.RunTask(WorkbookImagesAsync(userId, type, workbookId, folderId));

        /// <summary>
        /// workbook images EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="folderId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkbookImages response from the API call.</returns>
        public async Task<Models.WorkbookImages> WorkbookImagesAsync(
                int userId,
                string type,
                string workbookId,
                int folderId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkbookImages>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/workbooks/images")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("type", type))
                      .Query(_query => _query.Setup("workbook_id", workbookId))
                      .Query(_query => _query.Setup("folder_id", folderId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// workbook codes EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="folderId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.NewRequest response from the API call.</returns>
        public Models.NewRequest WorkbookCodes(
                int userId,
                string type,
                string workbookId,
                int folderId)
            => CoreHelper.RunTask(WorkbookCodesAsync(userId, type, workbookId, folderId));

        /// <summary>
        /// workbook codes EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="folderId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.NewRequest response from the API call.</returns>
        public async Task<Models.NewRequest> WorkbookCodesAsync(
                int userId,
                string type,
                string workbookId,
                int folderId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.NewRequest>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/workbooks/codes")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("type", type))
                      .Query(_query => _query.Setup("workbook_id", workbookId))
                      .Query(_query => _query.Setup("folder_id", folderId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// user chats EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <returns>Returns the Models.UserChats response from the API call.</returns>
        public Models.UserChats UserChats(
                int userId,
                string type)
            => CoreHelper.RunTask(UserChatsAsync(userId, type));

        /// <summary>
        /// user chats EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserChats response from the API call.</returns>
        public async Task<Models.UserChats> UserChatsAsync(
                int userId,
                string type,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserChats>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/workbooks/chats")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("type", type))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// permanent Delete document EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <returns>Returns the Models.PermanentDeleteDocument response from the API call.</returns>
        public Models.PermanentDeleteDocument PermanentDeleteDocument(
                int userId,
                int id,
                string type)
            => CoreHelper.RunTask(PermanentDeleteDocumentAsync(userId, id, type));

        /// <summary>
        /// permanent Delete document EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PermanentDeleteDocument response from the API call.</returns>
        public async Task<Models.PermanentDeleteDocument> PermanentDeleteDocumentAsync(
                int userId,
                int id,
                string type,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PermanentDeleteDocument>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/documents/permanent-delete")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("id", id))
                      .Query(_query => _query.Setup("type", type))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Restore Docuemnt of all type  (content.voiceover,images,transcript,code) EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <returns>Returns the Models.RestoreDocuemntOfAllTypeContentVoiceoverImagesTranscriptCode response from the API call.</returns>
        public Models.RestoreDocuemntOfAllTypeContentVoiceoverImagesTranscriptCode RestoreDocuemntOfAllTypeContentVoiceoverImagesTranscriptCode(
                int id,
                int userId,
                string type)
            => CoreHelper.RunTask(RestoreDocuemntOfAllTypeContentVoiceoverImagesTranscriptCodeAsync(id, userId, type));

        /// <summary>
        /// Restore Docuemnt of all type  (content.voiceover,images,transcript,code) EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RestoreDocuemntOfAllTypeContentVoiceoverImagesTranscriptCode response from the API call.</returns>
        public async Task<Models.RestoreDocuemntOfAllTypeContentVoiceoverImagesTranscriptCode> RestoreDocuemntOfAllTypeContentVoiceoverImagesTranscriptCodeAsync(
                int id,
                int userId,
                string type,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RestoreDocuemntOfAllTypeContentVoiceoverImagesTranscriptCode>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/documents/restore")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("id", id))
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("type", type))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Delete all kind of documents EndPoint.
        /// </summary>
        /// <returns>Returns the Models.DeleteAllKindOfDocuments response from the API call.</returns>
        public Models.DeleteAllKindOfDocuments DeleteAllKindOfDocuments()
            => CoreHelper.RunTask(DeleteAllKindOfDocumentsAsync());

        /// <summary>
        /// Delete all kind of documents EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DeleteAllKindOfDocuments response from the API call.</returns>
        public async Task<Models.DeleteAllKindOfDocuments> DeleteAllKindOfDocumentsAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeleteAllKindOfDocuments>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/documents/delete")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Add and remove from fav Document EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <returns>Returns the Models.AddAndRemoveFromFavDocument response from the API call.</returns>
        public Models.AddAndRemoveFromFavDocument AddAndRemoveFromFavDocument(
                int id,
                int userId,
                string type)
            => CoreHelper.RunTask(AddAndRemoveFromFavDocumentAsync(id, userId, type));

        /// <summary>
        /// Add and remove from fav Document EndPoint.
        /// </summary>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AddAndRemoveFromFavDocument response from the API call.</returns>
        public async Task<Models.AddAndRemoveFromFavDocument> AddAndRemoveFromFavDocumentAsync(
                int id,
                int userId,
                string type,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AddAndRemoveFromFavDocument>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/documents/add-to-fav")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("id", id))
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("type", type))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Join workbook requestr EndPoint.
        /// </summary>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="email">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JoinWorkbookRequestr response from the API call.</returns>
        public Models.JoinWorkbookRequestr JoinWorkbookRequestr(
                int workbookId,
                int userId,
                string email)
            => CoreHelper.RunTask(JoinWorkbookRequestrAsync(workbookId, userId, email));

        /// <summary>
        /// Join workbook requestr EndPoint.
        /// </summary>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="email">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JoinWorkbookRequestr response from the API call.</returns>
        public async Task<Models.JoinWorkbookRequestr> JoinWorkbookRequestrAsync(
                int workbookId,
                int userId,
                string email,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JoinWorkbookRequestr>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/worbooks/join-request")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("workbook_id", workbookId))
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("email", email))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Join workbook EndPoint.
        /// </summary>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JoinWorkbook response from the API call.</returns>
        public Models.JoinWorkbook JoinWorkbook(
                int workbookId,
                int userId)
            => CoreHelper.RunTask(JoinWorkbookAsync(workbookId, userId));

        /// <summary>
        /// Join workbook EndPoint.
        /// </summary>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JoinWorkbook response from the API call.</returns>
        public async Task<Models.JoinWorkbook> JoinWorkbookAsync(
                int workbookId,
                int userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JoinWorkbook>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/workbooks/join-workbook")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("workbook_id", workbookId))
                      .Query(_query => _query.Setup("user_id", userId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Reject Workbook EndPoint.
        /// </summary>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.RejectWorkbook response from the API call.</returns>
        public Models.RejectWorkbook RejectWorkbook(
                int workbookId,
                int userId)
            => CoreHelper.RunTask(RejectWorkbookAsync(workbookId, userId));

        /// <summary>
        /// Reject Workbook EndPoint.
        /// </summary>
        /// <param name="workbookId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RejectWorkbook response from the API call.</returns>
        public async Task<Models.RejectWorkbook> RejectWorkbookAsync(
                int workbookId,
                int userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RejectWorkbook>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/workbooks/reject-workbook")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("workbook_id", workbookId))
                      .Query(_query => _query.Setup("user_id", userId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// workbook policies EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <returns>Returns the Models.WorkbookPolicies response from the API call.</returns>
        public Models.WorkbookPolicies WorkbookPolicies(
                int userId,
                string type)
            => CoreHelper.RunTask(WorkbookPoliciesAsync(userId, type));

        /// <summary>
        /// workbook policies EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkbookPolicies response from the API call.</returns>
        public async Task<Models.WorkbookPolicies> WorkbookPoliciesAsync(
                int userId,
                string type,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkbookPolicies>()
              .Server(Server.Server1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/workbooks/policies")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("type", type))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Create link to access any document EndPoint.
        /// </summary>
        public void CreateLinkToAccessAnyDocument()
            => CoreHelper.RunVoidTask(CreateLinkToAccessAnyDocumentAsync());

        /// <summary>
        /// Create link to access any document EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task CreateLinkToAccessAnyDocumentAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken);
    }
}