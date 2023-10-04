// <copyright file="WorkbookAndFoldersControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace TaamAiUser.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities;
    using Newtonsoft.Json.Converters;
    using NUnit.Framework;
    using TaamAiUser.Standard;
    using TaamAiUser.Standard.Controllers;
    using TaamAiUser.Standard.Exceptions;
    using TaamAiUser.Standard.Http.Client;
    using TaamAiUser.Standard.Http.Response;
    using TaamAiUser.Standard.Models.Containers;
    using TaamAiUser.Standard.Utilities;

    /// <summary>
    /// WorkbookAndFoldersControllerTest.
    /// </summary>
    [TestFixture]
    public class WorkbookAndFoldersControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private WorkbookAndFoldersController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.WorkbookAndFoldersController;
        }

        /// <summary>
        /// TestAllWorkbooks.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestAllWorkbooks()
        {
            // Parameters for the API call
            int userId = 1;

            // Perform API call
            Standard.Models.AllWorkbooksLive result = null;
            try
            {
                result = await this.controller.AllWorkbooksAsync(userId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);
            headers.Add("Server", null);
            headers.Add("Date", null);
            headers.Add("Transfer-Encoding", null);
            headers.Add("Connection", null);
            headers.Add("X-Powered-By", null);
            headers.Add("Cache-Control", null);
            headers.Add("pragma", null);
            headers.Add("expires", null);
            headers.Add("X-RateLimit-Limit", null);
            headers.Add("X-RateLimit-Remaining", null);
            headers.Add("Access-Control-Allow-Origin", null);
            headers.Add("Vary", null);
            headers.Add("Content-Encoding", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\r\n  \"code\": 200,\r\n  \"status\": \"success\",\r\n  \"mesaage\": \"Workbooks fetched SUccessfully\",\r\n  \"data\": [\r\n    {\r\n      \"id\": 1,\r\n      \"user_id\": 1,\r\n      \"name\": \"saas\",\r\n      \"default\": 0,\r\n      \"created_at\": \"2023-06-20T07:24:51.000000Z\",\r\n      \"updated_at\": \"2023-07-10T14:39:11.000000Z\",\r\n      \"deleted_at\": null,\r\n      \"folders\": [\r\n        {\r\n          \"id\": 1,\r\n          \"name\": \"Taam soft folder\",\r\n          \"icon\": \"assets/folders/64ed714d9dd0f_Innovation.gif\",\r\n          \"description\": null,\r\n          \"workbook_id\": 1,\r\n          \"user_id\": 1,\r\n          \"status\": 1,\r\n          \"created_at\": \"2023-06-27T10:32:02.000000Z\",\r\n          \"updated_at\": \"2023-08-29T04:17:17.000000Z\",\r\n          \"deleted_at\": null\r\n        },\r\n        {\r\n          \"id\": 15,\r\n          \"name\": \"hello\",\r\n          \"icon\": \"https://taamfly.com/assets/empty.jpg\",\r\n          \"description\": null,\r\n          \"workbook_id\": 1,\r\n          \"user_id\": 4,\r\n          \"status\": 1,\r\n          \"created_at\": \"2023-08-03T06:34:27.000000Z\",\r\n          \"updated_at\": \"2023-08-03T06:34:27.000000Z\",\r\n          \"deleted_at\": null\r\n        },\r\n        {\r\n          \"id\": 16,\r\n          \"name\": \"test folders\",\r\n          \"icon\": \"https://taamfly.com/assets/empty.jpg\",\r\n          \"description\": null,\r\n          \"workbook_id\": 1,\r\n          \"user_id\": 1,\r\n          \"status\": 1,\r\n          \"created_at\": \"2023-08-03T14:31:02.000000Z\",\r\n          \"updated_at\": \"2023-08-16T03:08:19.000000Z\",\r\n          \"deleted_at\": null\r\n        },\r\n        {\r\n          \"id\": 31,\r\n          \"name\": \"taam ai\",\r\n          \"icon\": \"https://taam.ai/assets/empty.jpg\",\r\n          \"description\": null,\r\n          \"workbook_id\": 1,\r\n          \"user_id\": 1,\r\n          \"status\": 1,\r\n          \"created_at\": \"2023-08-23T01:57:28.000000Z\",\r\n          \"updated_at\": \"2023-08-23T01:57:28.000000Z\",\r\n          \"deleted_at\": null\r\n        }\r\n      ]\r\n    },\r\n    {\r\n      \"id\": 2,\r\n      \"user_id\": 1,\r\n      \"name\": \"sales\",\r\n      \"default\": 0,\r\n      \"created_at\": \"2023-06-20T07:25:00.000000Z\",\r\n      \"updated_at\": \"2023-06-20T07:25:00.000000Z\",\r\n      \"deleted_at\": null,\r\n      \"folders\": []\r\n    },\r\n    {\r\n      \"id\": 32,\r\n      \"user_id\": 1,\r\n      \"name\": \"test\",\r\n      \"default\": 0,\r\n      \"created_at\": \"2023-09-13T11:50:03.000000Z\",\r\n      \"updated_at\": \"2023-09-13T11:50:03.000000Z\",\r\n      \"deleted_at\": null,\r\n      \"folders\": []\r\n    },\r\n    {\r\n      \"id\": 7,\r\n      \"user_id\": 2,\r\n      \"name\": \"member workspace\",\r\n      \"default\": 0,\r\n      \"created_at\": \"2023-07-19T04:51:54.000000Z\",\r\n      \"updated_at\": \"2023-07-19T04:51:54.000000Z\",\r\n      \"deleted_at\": null,\r\n      \"folders\": [\r\n        {\r\n          \"id\": 8,\r\n          \"name\": \"defaul1\",\r\n          \"icon\": \"assets/folders/64ed715fc11cb_Artificial intelligence.gif\",\r\n          \"description\": null,\r\n          \"workbook_id\": 7,\r\n          \"user_id\": 2,\r\n          \"status\": 1,\r\n          \"created_at\": \"2023-07-19T04:51:54.000000Z\",\r\n          \"updated_at\": \"2023-08-29T04:17:35.000000Z\",\r\n          \"deleted_at\": null\r\n        }\r\n      ]\r\n    }\r\n  ]\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestCreateWorkbook.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestCreateWorkbook()
        {
            // Parameters for the API call
            int userId = 1;
            string workbookName = "soban2";

            // Perform API call
            Standard.Models.CreateWorkbookLivw result = null;
            try
            {
                result = await this.controller.CreateWorkbookAsync(userId, workbookName);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);
            headers.Add("Server", null);
            headers.Add("Date", null);
            headers.Add("Transfer-Encoding", null);
            headers.Add("Connection", null);
            headers.Add("X-Powered-By", null);
            headers.Add("Cache-Control", null);
            headers.Add("pragma", null);
            headers.Add("expires", null);
            headers.Add("X-RateLimit-Limit", null);
            headers.Add("X-RateLimit-Remaining", null);
            headers.Add("Access-Control-Allow-Origin", null);
            headers.Add("Vary", null);
            headers.Add("Content-Encoding", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Workbook has been successfully created\",\r\n  \"data\": {\r\n    \"user_id\": \"40\",\r\n    \"name\": \"soban2\",\r\n    \"updated_at\": \"2023-09-22T14:27:03.000000Z\",\r\n    \"created_at\": \"2023-09-22T14:27:03.000000Z\",\r\n    \"id\": 39\r\n  }\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestWorkbookDetail.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestWorkbookDetail()
        {
            // Parameters for the API call
            int userId = 1;
            int workbookId = 12;

            // Perform API call
            Standard.Models.WorkbookDetailLive result = null;
            try
            {
                result = await this.controller.WorkbookDetailAsync(userId, workbookId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);
            headers.Add("Server", null);
            headers.Add("Date", null);
            headers.Add("Transfer-Encoding", null);
            headers.Add("Connection", null);
            headers.Add("X-Powered-By", null);
            headers.Add("Cache-Control", null);
            headers.Add("pragma", null);
            headers.Add("expires", null);
            headers.Add("X-RateLimit-Limit", null);
            headers.Add("X-RateLimit-Remaining", null);
            headers.Add("Access-Control-Allow-Origin", null);
            headers.Add("Vary", null);
            headers.Add("Content-Encoding", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Data Fetch Successfully\",\r\n  \"data\": {\r\n    \"id\": 7,\r\n    \"user_id\": 2,\r\n    \"name\": \"member workspace\",\r\n    \"default\": 0,\r\n    \"created_at\": \"2023-07-19T04:51:54.000000Z\",\r\n    \"updated_at\": \"2023-07-19T04:51:54.000000Z\",\r\n    \"deleted_at\": null,\r\n    \"folders\": [\r\n      {\r\n        \"id\": 8,\r\n        \"name\": \"defaul1\",\r\n        \"icon\": \"assets/folders/64ed715fc11cb_Artificial intelligence.gif\",\r\n        \"description\": null,\r\n        \"workbook_id\": 7,\r\n        \"user_id\": 2,\r\n        \"status\": 1,\r\n        \"created_at\": \"2023-07-19T04:51:54.000000Z\",\r\n        \"updated_at\": \"2023-08-29T04:17:35.000000Z\",\r\n        \"deleted_at\": null\r\n      }\r\n    ]\r\n  }\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestDeleteWorkspace.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestDeleteWorkspace()
        {
            // Parameters for the API call
            int userId = 1;
            int workbookId = 39;

            // Perform API call
            Standard.Models.DeleteWorkspaceLive result = null;
            try
            {
                result = await this.controller.DeleteWorkspaceAsync(userId, workbookId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);
            headers.Add("Server", null);
            headers.Add("Date", null);
            headers.Add("Transfer-Encoding", null);
            headers.Add("Connection", null);
            headers.Add("X-Powered-By", null);
            headers.Add("Cache-Control", null);
            headers.Add("pragma", null);
            headers.Add("expires", null);
            headers.Add("X-RateLimit-Limit", null);
            headers.Add("X-RateLimit-Remaining", null);
            headers.Add("Access-Control-Allow-Origin", null);
            headers.Add("Vary", null);
            headers.Add("Content-Encoding", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Workspace deleted Successfully\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestTrashedWorkspaces.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTrashedWorkspaces()
        {
            // Parameters for the API call
            int userId = 1;

            // Perform API call
            Standard.Models.TrashedWorkspacesLive result = null;
            try
            {
                result = await this.controller.TrashedWorkspacesAsync(userId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);
            headers.Add("Server", null);
            headers.Add("Date", null);
            headers.Add("Transfer-Encoding", null);
            headers.Add("Connection", null);
            headers.Add("X-Powered-By", null);
            headers.Add("Cache-Control", null);
            headers.Add("pragma", null);
            headers.Add("expires", null);
            headers.Add("X-RateLimit-Limit", null);
            headers.Add("X-RateLimit-Remaining", null);
            headers.Add("Access-Control-Allow-Origin", null);
            headers.Add("Vary", null);
            headers.Add("Content-Encoding", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Data Fatched Successfully\",\r\n  \"data\": [\r\n    {\r\n      \"id\": 39,\r\n      \"user_id\": 40,\r\n      \"name\": \"soban2\",\r\n      \"default\": 0,\r\n      \"created_at\": \"2023-09-22T14:27:03.000000Z\",\r\n      \"updated_at\": \"2023-09-22T14:28:21.000000Z\",\r\n      \"deleted_at\": \"2023-09-22T14:28:21.000000Z\"\r\n    }\r\n  ]\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestRestoreWorkspace.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestRestoreWorkspace()
        {
            // Parameters for the API call
            int userId = 40;
            int workbookId = 39;

            // Perform API call
            Standard.Models.RestoreWorkspaceLive result = null;
            try
            {
                result = await this.controller.RestoreWorkspaceAsync(userId, workbookId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);
            headers.Add("Server", null);
            headers.Add("Date", null);
            headers.Add("Transfer-Encoding", null);
            headers.Add("Connection", null);
            headers.Add("X-Powered-By", null);
            headers.Add("Cache-Control", null);
            headers.Add("pragma", null);
            headers.Add("expires", null);
            headers.Add("X-RateLimit-Limit", null);
            headers.Add("X-RateLimit-Remaining", null);
            headers.Add("Access-Control-Allow-Origin", null);
            headers.Add("Vary", null);
            headers.Add("Content-Encoding", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"workspace restored successfully\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestCreateFolder.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestCreateFolder()
        {
            // Parameters for the API call
            string folderName = "default new";
            int workbookId = 23;
            int userId = 1;

            // Perform API call
            Standard.Models.CreateFolderLive result = null;
            try
            {
                result = await this.controller.CreateFolderAsync(folderName, workbookId, userId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);
            headers.Add("Server", null);
            headers.Add("Date", null);
            headers.Add("Transfer-Encoding", null);
            headers.Add("Connection", null);
            headers.Add("X-Powered-By", null);
            headers.Add("Cache-Control", null);
            headers.Add("pragma", null);
            headers.Add("expires", null);
            headers.Add("X-RateLimit-Limit", null);
            headers.Add("X-RateLimit-Remaining", null);
            headers.Add("Access-Control-Allow-Origin", null);
            headers.Add("Vary", null);
            headers.Add("Content-Encoding", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Folder Created Successfully\",\r\n  \"data\": {\r\n    \"name\": \"default new\",\r\n    \"workbook_id\": \"39\",\r\n    \"user_id\": \"40\",\r\n    \"icon\": \"https://taam.ai/assets/empty.jpg\",\r\n    \"description\": null,\r\n    \"updated_at\": \"2023-09-22T14:27:35.000000Z\",\r\n    \"created_at\": \"2023-09-22T14:27:35.000000Z\",\r\n    \"id\": 45\r\n  }\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestDeleteFolder.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestDeleteFolder()
        {
            // Parameters for the API call
            int userId = 1;
            int folderId = 27;

            // Perform API call
            Standard.Models.DeleteFolder result = null;
            try
            {
                result = await this.controller.DeleteFolderAsync(userId, folderId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);
            headers.Add("Server", null);
            headers.Add("Date", null);
            headers.Add("Transfer-Encoding", null);
            headers.Add("Connection", null);
            headers.Add("X-Powered-By", null);
            headers.Add("Cache-Control", null);
            headers.Add("pragma", null);
            headers.Add("expires", null);
            headers.Add("X-RateLimit-Limit", null);
            headers.Add("X-RateLimit-Remaining", null);
            headers.Add("Access-Control-Allow-Origin", null);
            headers.Add("Vary", null);
            headers.Add("Content-Encoding", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\r\n  \"status\": \"error\",\r\n  \"message\": \"You are not able to delete this folder\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestRestoreFolder.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestRestoreFolder()
        {
            // Parameters for the API call
            int userId = 1;
            int folderId = 27;

            // Perform API call
            try
            {
                await this.controller.RestoreFolderAsync(userId, folderId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestSetDefualtWorkspace.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSetDefualtWorkspace()
        {
            // Parameters for the API call
            int userId = 1;
            int workbookId = 1;

            // Perform API call
            try
            {
                await this.controller.SetDefualtWorkspaceAsync(userId, workbookId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestPermanentDeleteFolder.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestPermanentDeleteFolder()
        {
            // Parameters for the API call
            int userId = 1;
            int folderId = 27;

            // Perform API call
            try
            {
                await this.controller.PermanentDeleteFolderAsync(userId, folderId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestTrashedFolders.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTrashedFolders()
        {
            // Parameters for the API call
            int userId = 1;
            int workbookId = 22;

            // Perform API call
            Standard.Models.TrashedFoldersLive result = null;
            try
            {
                result = await this.controller.TrashedFoldersAsync(userId, workbookId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);
            headers.Add("Server", null);
            headers.Add("Date", null);
            headers.Add("Transfer-Encoding", null);
            headers.Add("Connection", null);
            headers.Add("X-Powered-By", null);
            headers.Add("Cache-Control", null);
            headers.Add("pragma", null);
            headers.Add("expires", null);
            headers.Add("X-RateLimit-Limit", null);
            headers.Add("X-RateLimit-Remaining", null);
            headers.Add("Access-Control-Allow-Origin", null);
            headers.Add("Vary", null);
            headers.Add("Content-Encoding", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Data Fatched Successfully\",\r\n  \"data\": [\r\n    {\r\n      \"id\": 14,\r\n      \"name\": \"haristaamsoft\",\r\n      \"icon\": \"https://taamfly.com/assets/empty.jpg\",\r\n      \"description\": null,\r\n      \"workbook_id\": 1,\r\n      \"user_id\": 1,\r\n      \"status\": 1,\r\n      \"created_at\": \"2023-07-20T14:06:31.000000Z\",\r\n      \"updated_at\": \"2023-08-09T07:48:43.000000Z\",\r\n      \"deleted_at\": \"2023-08-09T07:48:43.000000Z\"\r\n    }\r\n  ]\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestWorkbookVoiceovers.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestWorkbookVoiceovers()
        {
            // Parameters for the API call
            int userId = 1;
            string type = "general";
            int workbookId = 1;
            int folderId = 1;

            // Perform API call
            Standard.Models.WorkbookVoiceovers result = null;
            try
            {
                result = await this.controller.WorkbookVoiceoversAsync(userId, type, workbookId, folderId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);
            headers.Add("Host", null);
            headers.Add("Date", null);
            headers.Add("Connection", null);
            headers.Add("X-Powered-By", null);
            headers.Add("Cache-Control", null);
            headers.Add("X-RateLimit-Limit", null);
            headers.Add("X-RateLimit-Remaining", null);
            headers.Add("Access-Control-Allow-Origin", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Data Fatched Successfully\",\r\n  \"count\": 1,\r\n  \"data\": [\r\n    {\r\n      \"id\": 38,\r\n      \"user_id\": 1,\r\n      \"language\": \"Afrikaans (South Africa)\",\r\n      \"language_flag\": \"/img/flags/za.svg\",\r\n      \"voice\": \"Willem\",\r\n      \"voice_id\": \"af-ZA-WillemNeural\",\r\n      \"gender\": \"Male\",\r\n      \"text\": \"hello. \",\r\n      \"workbook_id\": 1,\r\n      \"workbook_folder_id\": 1,\r\n      \"text_raw\": \"hello. \",\r\n      \"file_name\": \"rob5qkLDTS.mp3\",\r\n      \"result_url\": \"/storage/rob5qkLDTS.mp3\",\r\n      \"result_ext\": \"mp3\",\r\n      \"storage\": \"local\",\r\n      \"title\": \"New Audio\",\r\n      \"vendor\": \"azure\",\r\n      \"vendor_id\": \"azure_nrl\",\r\n      \"characters\": 5,\r\n      \"voice_type\": \"neural\",\r\n      \"plan_type\": \"free\",\r\n      \"audio_type\": \"audio/mpeg\",\r\n      \"mode\": \"file\",\r\n      \"project\": null,\r\n      \"expires_at\": null,\r\n      \"created_at\": \"2023-09-05T07:12:12.000000Z\",\r\n      \"updated_at\": \"2023-09-05T07:12:12.000000Z\",\r\n      \"deleted_at\": null\r\n    }\r\n  ]\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestWorkbookTranscripts.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestWorkbookTranscripts()
        {
            // Parameters for the API call
            int userId = 1;
            string type = "general";
            string workbookId = "all";
            int folderId = 1;

            // Perform API call
            Standard.Models.WorkbookTranscripts result = null;
            try
            {
                result = await this.controller.WorkbookTranscriptsAsync(userId, type, workbookId, folderId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);
            headers.Add("Host", null);
            headers.Add("Date", null);
            headers.Add("Connection", null);
            headers.Add("X-Powered-By", null);
            headers.Add("Cache-Control", null);
            headers.Add("X-RateLimit-Limit", null);
            headers.Add("X-RateLimit-Remaining", null);
            headers.Add("Access-Control-Allow-Origin", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Data Fatched Successfully\",\r\n  \"count\": 1,\r\n  \"data\": [\r\n    {\r\n      \"id\": 41,\r\n      \"user_id\": 1,\r\n      \"url\": \"transcribe/MF8nK7yAyNbUmmVG3zMAPFQcgkONpUdJvz3eUDGz.mp3\",\r\n      \"transcript\": \"<p>Marhaban, ana al-mutahaddithi al-iftiradi min imza'i al-jawda. Da'ani ulqi al-tahiyyata ala jumhourik wa u'arrifahom ala muntajatik abra wasilatin min akthar al-wasaili al-taswiqiya, tashwiqan wa mut'a.</p>\",\r\n      \"workbook_id\": 1,\r\n      \"workbook_folder_id\": 1,\r\n      \"title\": \"Audio File\",\r\n      \"workbook\": \"all\",\r\n      \"task\": \"transcribe\",\r\n      \"words\": 25,\r\n      \"format\": \"mp3\",\r\n      \"audio_type\": \"audio/mpeg\",\r\n      \"description\": null,\r\n      \"storage\": \"local\",\r\n      \"length\": \"13.767\",\r\n      \"plan_type\": \"free\",\r\n      \"size\": \"215.13 KB\",\r\n      \"file_name\": \"AR_F_GadaB.mp3\",\r\n      \"temp_name\": \"u9c4fizRqM.mp3\",\r\n      \"expires_at\": \"2073-09-05 23:21:57\",\r\n      \"created_at\": \"2023-09-19T10:21:57.000000Z\",\r\n      \"updated_at\": \"2023-09-19T10:22:12.000000Z\",\r\n      \"deleted_at\": null\r\n    }\r\n  ]\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestPermanentDeleteWorkspace.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestPermanentDeleteWorkspace()
        {
            // Perform API call
            Standard.Models.PermanentDeleteWorkspaceLive result = null;
            try
            {
                result = await this.controller.PermanentDeleteWorkspaceAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);
            headers.Add("Server", null);
            headers.Add("Date", null);
            headers.Add("Transfer-Encoding", null);
            headers.Add("Connection", null);
            headers.Add("X-Powered-By", null);
            headers.Add("Cache-Control", null);
            headers.Add("pragma", null);
            headers.Add("expires", null);
            headers.Add("X-RateLimit-Limit", null);
            headers.Add("X-RateLimit-Remaining", null);
            headers.Add("Access-Control-Allow-Origin", null);
            headers.Add("Vary", null);
            headers.Add("Content-Encoding", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\r\n  \"status\": \"errpr\",\r\n  \"message\": \"You are not able to Delete this workspace\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestWorkbookImages.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestWorkbookImages()
        {
            // Parameters for the API call
            int userId = 1;
            string type = "general";
            string workbookId = "all";
            int folderId = 1;

            // Perform API call
            Standard.Models.WorkbookImages result = null;
            try
            {
                result = await this.controller.WorkbookImagesAsync(userId, type, workbookId, folderId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);
            headers.Add("Host", null);
            headers.Add("Date", null);
            headers.Add("Connection", null);
            headers.Add("X-Powered-By", null);
            headers.Add("Cache-Control", null);
            headers.Add("X-RateLimit-Limit", null);
            headers.Add("X-RateLimit-Remaining", null);
            headers.Add("Access-Control-Allow-Origin", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Data Fatched Successfully\",\r\n  \"count\": 9,\r\n  \"data\": [\r\n    {\r\n      \"id\": 90,\r\n      \"user_id\": 1,\r\n      \"name\": \"New Image\",\r\n      \"description\": \"car\",\r\n      \"image\": \"assets/images/6507ed288bb37_7\",\r\n      \"workbook_id\": 1,\r\n      \"workbook_folder_id\": 1,\r\n      \"storage\": \"local\",\r\n      \"image_name\": \"images/jWE80sgd7U.png\",\r\n      \"resolution\": \"256x256\",\r\n      \"plan_type\": \"paid\",\r\n      \"expires_at\": \"2073-09-04 19:24:40\",\r\n      \"created_at\": \"2023-09-18T06:24:40.000000Z\",\r\n      \"updated_at\": \"2023-09-18T06:24:40.000000Z\",\r\n      \"deleted_at\": null\r\n    },\r\n    {\r\n      \"id\": 89,\r\n      \"user_id\": 1,\r\n      \"name\": \"New Image\",\r\n      \"description\": \"boy\",\r\n      \"image\": \"assets/images/6507eccfbd842_5\",\r\n      \"workbook_id\": 1,\r\n      \"workbook_folder_id\": 1,\r\n      \"storage\": \"local\",\r\n      \"image_name\": \"images/oE4JFGV9YI.png\",\r\n      \"resolution\": \"256x256\",\r\n      \"plan_type\": \"paid\",\r\n      \"expires_at\": \"2073-09-04 19:23:11\",\r\n      \"created_at\": \"2023-09-18T06:23:11.000000Z\",\r\n      \"updated_at\": \"2023-09-18T06:23:11.000000Z\",\r\n      \"deleted_at\": null\r\n    },\r\n    {\r\n      \"id\": 88,\r\n      \"user_id\": 1,\r\n      \"name\": \"New Image\",\r\n      \"description\": \"boy\",\r\n      \"image\": \"assets/images/6507ec965410e_5\",\r\n      \"workbook_id\": 1,\r\n      \"workbook_folder_id\": 1,\r\n      \"storage\": \"local\",\r\n      \"image_name\": \"images/4Asp9kVwDS.png\",\r\n      \"resolution\": \"256x256\",\r\n      \"plan_type\": \"paid\",\r\n      \"expires_at\": \"2073-09-04 19:22:14\",\r\n      \"created_at\": \"2023-09-18T06:22:14.000000Z\",\r\n      \"updated_at\": \"2023-09-18T06:22:14.000000Z\",\r\n      \"deleted_at\": null\r\n    },\r\n    {\r\n      \"id\": 87,\r\n      \"user_id\": 1,\r\n      \"name\": \"New Image\",\r\n      \"description\": \"girl\",\r\n      \"image\": \"assets/images/6507ec016cedd_8\",\r\n      \"workbook_id\": 1,\r\n      \"workbook_folder_id\": 1,\r\n      \"storage\": \"local\",\r\n      \"image_name\": \"images/Sp6UuQsHlR.png\",\r\n      \"resolution\": \"256x256\",\r\n      \"plan_type\": \"paid\",\r\n      \"expires_at\": \"2073-09-04 19:19:45\",\r\n      \"created_at\": \"2023-09-18T06:19:45.000000Z\",\r\n      \"updated_at\": \"2023-09-18T06:19:45.000000Z\",\r\n      \"deleted_at\": null\r\n    },\r\n    {\r\n      \"id\": 86,\r\n      \"user_id\": 1,\r\n      \"name\": \"New Image\",\r\n      \"description\": \"car\",\r\n      \"image\": \"assets/images/6507ebc7221c5_9\",\r\n      \"workbook_id\": 1,\r\n      \"workbook_folder_id\": 1,\r\n      \"storage\": \"local\",\r\n      \"image_name\": \"images/GtMdnzT5kF.png\",\r\n      \"resolution\": \"256x256\",\r\n      \"plan_type\": \"paid\",\r\n      \"expires_at\": \"2073-09-04 19:18:47\",\r\n      \"created_at\": \"2023-09-18T06:18:47.000000Z\",\r\n      \"updated_at\": \"2023-09-18T06:18:47.000000Z\",\r\n      \"deleted_at\": null\r\n    },\r\n    {\r\n      \"id\": 85,\r\n      \"user_id\": 1,\r\n      \"name\": \"New Image\",\r\n      \"description\": \"larka\",\r\n      \"image\": \"assets/images/6507eb71d397b_5\",\r\n      \"workbook_id\": 1,\r\n      \"workbook_folder_id\": 1,\r\n      \"storage\": \"local\",\r\n      \"image_name\": \"images/sTO1u0m5rU.png\",\r\n      \"resolution\": \"256x256\",\r\n      \"plan_type\": \"paid\",\r\n      \"expires_at\": \"2073-09-04 19:17:21\",\r\n      \"created_at\": \"2023-09-18T06:17:21.000000Z\",\r\n      \"updated_at\": \"2023-09-18T06:17:21.000000Z\",\r\n      \"deleted_at\": null\r\n    },\r\n    {\r\n      \"id\": 84,\r\n      \"user_id\": 1,\r\n      \"name\": \"New Image\",\r\n      \"description\": \"larka\",\r\n      \"image\": \"assets/images/6507eaedd57fc_7\",\r\n      \"workbook_id\": 1,\r\n      \"workbook_folder_id\": 1,\r\n      \"storage\": \"local\",\r\n      \"image_name\": \"images/qewKzBPTLW.png\",\r\n      \"resolution\": \"256x256\",\r\n      \"plan_type\": \"paid\",\r\n      \"expires_at\": \"2073-09-04 19:15:09\",\r\n      \"created_at\": \"2023-09-18T06:15:09.000000Z\",\r\n      \"updated_at\": \"2023-09-18T06:15:09.000000Z\",\r\n      \"deleted_at\": null\r\n    },\r\n    {\r\n      \"id\": 83,\r\n      \"user_id\": 1,\r\n      \"name\": \"New Image\",\r\n      \"description\": \"car\",\r\n      \"image\": \"assets/images/6507ea71637a2_2\",\r\n      \"workbook_id\": 1,\r\n      \"workbook_folder_id\": 1,\r\n      \"storage\": \"local\",\r\n      \"image_name\": \"images/8uMUJn8ESH.png\",\r\n      \"resolution\": \"256x256\",\r\n      \"plan_type\": \"paid\",\r\n      \"expires_at\": \"2073-09-04 19:13:05\",\r\n      \"created_at\": \"2023-09-18T06:13:05.000000Z\",\r\n      \"updated_at\": \"2023-09-18T06:13:05.000000Z\",\r\n      \"deleted_at\": null\r\n    },\r\n    {\r\n      \"id\": 82,\r\n      \"user_id\": 1,\r\n      \"name\": \"New Image\",\r\n      \"description\": \"car\",\r\n      \"image\": \"assets/images/64fabfd095f76_7\",\r\n      \"workbook_id\": 1,\r\n      \"workbook_folder_id\": 1,\r\n      \"storage\": \"local\",\r\n      \"image_name\": \"images/YjnEnLD7WJ.png\",\r\n      \"resolution\": \"256x256\",\r\n      \"plan_type\": \"paid\",\r\n      \"expires_at\": \"2073-08-25 19:31:44\",\r\n      \"created_at\": \"2023-09-08T06:31:44.000000Z\",\r\n      \"updated_at\": \"2023-09-08T06:31:44.000000Z\",\r\n      \"deleted_at\": null\r\n    }\r\n  ]\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestWorkbookCodes.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestWorkbookCodes()
        {
            // Parameters for the API call
            int userId = 1;
            string type = "general";
            string workbookId = "all";
            int folderId = 1;

            // Perform API call
            Standard.Models.NewRequest result = null;
            try
            {
                result = await this.controller.WorkbookCodesAsync(userId, type, workbookId, folderId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);
            headers.Add("Host", null);
            headers.Add("Date", null);
            headers.Add("Connection", null);
            headers.Add("X-Powered-By", null);
            headers.Add("Cache-Control", null);
            headers.Add("X-RateLimit-Limit", null);
            headers.Add("X-RateLimit-Remaining", null);
            headers.Add("Access-Control-Allow-Origin", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Data Fatched Successfully\",\r\n  \"count\": 1,\r\n  \"data\": [\r\n    {\r\n      \"id\": 29,\r\n      \"user_id\": 1,\r\n      \"model\": \"python\",\r\n      \"title\": \"New Code\",\r\n      \"instructions\": \"hello print\",\r\n      \"code\": \"<p>Sure, here’s a simple code in Python to print “Hello, World!”</p>\\n<pre class=\\\"hljs\\\"><code><a class=\\\"copy-code\\\" onclick=\\\"copyCode(this)\\\" href=\\\"#\\\">Copy</a><span class=\\\"hljs-built_in\\\">print</span>(<span class=\\\"hljs-string\\\">\\\"Hello, World!\\\"</span>)\\n</code></pre>\",\r\n      \"workbook_id\": 1,\r\n      \"workbook_folder_id\": 1,\r\n      \"created_at\": \"2023-09-18T08:18:58.000000Z\",\r\n      \"updated_at\": \"2023-09-18T08:19:03.000000Z\",\r\n      \"deleted_at\": null\r\n    }\r\n  ]\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestUserChats.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUserChats()
        {
            // Parameters for the API call
            int userId = 1;
            string type = "general";

            // Perform API call
            Standard.Models.UserChats result = null;
            try
            {
                result = await this.controller.UserChatsAsync(userId, type);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);
            headers.Add("Host", null);
            headers.Add("Date", null);
            headers.Add("Connection", null);
            headers.Add("X-Powered-By", null);
            headers.Add("Cache-Control", null);
            headers.Add("X-RateLimit-Limit", null);
            headers.Add("X-RateLimit-Remaining", null);
            headers.Add("Access-Control-Allow-Origin", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Data Fatched Successfully\",\r\n  \"count\": 4,\r\n  \"data\": [\r\n    {\r\n      \"id\": 1,\r\n      \"name\": \"Travis Guider\",\r\n      \"sub_name\": \"Travel Guide\",\r\n      \"chat_code\": \"OBADW\",\r\n      \"logo\": \"/chats/1.jpg\",\r\n      \"status\": 0,\r\n      \"prompt\": \"I want you to act as a travel guide. I will write you my location and you will suggest a place to visit near my location. In some cases, I will also give you the type of places I will visit. You will also suggest me places of similar type that are close to my first location.\",\r\n      \"description\": \"Hey, my name is Karen Jobber and I am a professional job interviewer. I can help you with preparations.\",\r\n      \"category\": \"all\",\r\n      \"type\": \"original\",\r\n      \"created_at\": \"2023-07-06T13:33:49.000000Z\",\r\n      \"updated_at\": \"2023-07-15T14:26:24.000000Z\",\r\n      \"deleted_at\": null\r\n    },\r\n    {\r\n      \"id\": 2,\r\n      \"name\": \"Matt Tivate\",\r\n      \"sub_name\": \"Motivational Coach\",\r\n      \"chat_code\": \"IUSJH\",\r\n      \"logo\": \"/chats/2.jpg\",\r\n      \"status\": 1,\r\n      \"prompt\": \"I want you to act as a motivational coach. I will provide you with some information about someone's goals and challenges, and it will be your job to come up with strategies that can help this person achieve their goals. This could involve providing positive affirmations, giving helpful advice or suggesting activities they can do to reach their end goal>\",\r\n      \"description\": \"Hey, my name is Karen Jobber and I am a professional job interviewer. I can help you with preparations.\",\r\n      \"category\": \"all\",\r\n      \"type\": \"original\",\r\n      \"created_at\": \"2023-07-06T13:33:49.000000Z\",\r\n      \"updated_at\": \"2023-07-06T13:33:49.000000Z\",\r\n      \"deleted_at\": null\r\n    },\r\n    {\r\n      \"id\": 6,\r\n      \"name\": \"Robert Williams\",\r\n      \"sub_name\": \"Life Coach\",\r\n      \"chat_code\": \"SFOBQ\",\r\n      \"logo\": \"/chats/4.jpg\",\r\n      \"status\": 1,\r\n      \"prompt\": \"I want you to act as a life coach. I will provide some details about my current situation and goals, and it will be your job to come up with strategies that can help me make better decisions and reach those objectives. This could involve offering advice on various topics, such as creating plans for achieving success or dealing with difficult emotions.\",\r\n      \"description\": \"Hey, my name is Karen Jobber and I am a professional job interviewer. I can help you with preparations.\",\r\n      \"category\": \"all\",\r\n      \"type\": \"original\",\r\n      \"created_at\": \"2023-07-06T13:33:49.000000Z\",\r\n      \"updated_at\": \"2023-07-06T13:33:49.000000Z\",\r\n      \"deleted_at\": null\r\n    },\r\n    {\r\n      \"id\": 7,\r\n      \"name\": \"Jack Harper\",\r\n      \"sub_name\": \"Personal Trainer\",\r\n      \"chat_code\": \"SWIGE\",\r\n      \"logo\": \"/chats/5.jpg\",\r\n      \"status\": 1,\r\n      \"prompt\": \"I want you to act as a personal trainer. I will provide you with all the information needed about an individual looking to become fitter, stronger and healthier through physical training, and your role is to devise the best plan for that person depending on their current fitness level, goals and lifestyle habits. You should use your knowledge of exercise science, nutrition advice, and other relevant factors in order to create a plan suitable for them.\",\r\n      \"description\": \"Hey, my name is Karen Jobber and I am a professional job interviewer. I can help you with preparations.\",\r\n      \"category\": \"all\",\r\n      \"type\": \"original\",\r\n      \"created_at\": \"2023-07-06T13:33:49.000000Z\",\r\n      \"updated_at\": \"2023-07-06T13:33:49.000000Z\",\r\n      \"deleted_at\": null\r\n    }\r\n  ]\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestPermanentDeleteDocument.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestPermanentDeleteDocument()
        {
            // Parameters for the API call
            int userId = 1;
            int id = 4;
            string type = "document";

            // Perform API call
            Standard.Models.PermanentDeleteDocument result = null;
            try
            {
                result = await this.controller.PermanentDeleteDocumentAsync(userId, id, type);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);
            headers.Add("Host", null);
            headers.Add("Date", null);
            headers.Add("Connection", null);
            headers.Add("X-Powered-By", null);
            headers.Add("Cache-Control", null);
            headers.Add("X-RateLimit-Limit", null);
            headers.Add("X-RateLimit-Remaining", null);
            headers.Add("Access-Control-Allow-Origin", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"document Deleted Successfully\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestRestoreDocuemntOfAllTypeContentVoiceoverImagesTranscriptCode.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestRestoreDocuemntOfAllTypeContentVoiceoverImagesTranscriptCode()
        {
            // Parameters for the API call
            int id = 1;
            int userId = 1;
            string type = "document";

            // Perform API call
            Standard.Models.RestoreDocuemntOfAllTypeContentVoiceoverImagesTranscriptCode result = null;
            try
            {
                result = await this.controller.RestoreDocuemntOfAllTypeContentVoiceoverImagesTranscriptCodeAsync(id, userId, type);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);
            headers.Add("Host", null);
            headers.Add("Date", null);
            headers.Add("Connection", null);
            headers.Add("X-Powered-By", null);
            headers.Add("Cache-Control", null);
            headers.Add("X-RateLimit-Limit", null);
            headers.Add("X-RateLimit-Remaining", null);
            headers.Add("Access-Control-Allow-Origin", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"document Restored Successfully\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestDeleteAllKindOfDocuments.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestDeleteAllKindOfDocuments()
        {
            // Perform API call
            Standard.Models.DeleteAllKindOfDocuments result = null;
            try
            {
                result = await this.controller.DeleteAllKindOfDocumentsAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);
            headers.Add("Host", null);
            headers.Add("Date", null);
            headers.Add("Connection", null);
            headers.Add("X-Powered-By", null);
            headers.Add("Cache-Control", null);
            headers.Add("X-RateLimit-Limit", null);
            headers.Add("X-RateLimit-Remaining", null);
            headers.Add("Access-Control-Allow-Origin", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"document Deleted Successfully\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestAddAndRemoveFromFavDocument.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestAddAndRemoveFromFavDocument()
        {
            // Parameters for the API call
            int id = 6;
            int userId = 1;
            string type = "document";

            // Perform API call
            Standard.Models.AddAndRemoveFromFavDocument result = null;
            try
            {
                result = await this.controller.AddAndRemoveFromFavDocumentAsync(id, userId, type);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);
            headers.Add("Host", null);
            headers.Add("Date", null);
            headers.Add("Connection", null);
            headers.Add("X-Powered-By", null);
            headers.Add("Cache-Control", null);
            headers.Add("X-RateLimit-Limit", null);
            headers.Add("X-RateLimit-Remaining", null);
            headers.Add("Access-Control-Allow-Origin", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Remove from Favourite Successfully\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestJoinWorkbookRequestr.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestJoinWorkbookRequestr()
        {
            // Parameters for the API call
            int workbookId = 1;
            int userId = 1;
            string email = "sobanshahid38@gmail.com";

            // Perform API call
            Standard.Models.JoinWorkbookRequestr result = null;
            try
            {
                result = await this.controller.JoinWorkbookRequestrAsync(workbookId, userId, email);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);
            headers.Add("Host", null);
            headers.Add("Date", null);
            headers.Add("Connection", null);
            headers.Add("X-Powered-By", null);
            headers.Add("Cache-Control", null);
            headers.Add("X-RateLimit-Limit", null);
            headers.Add("X-RateLimit-Remaining", null);
            headers.Add("Access-Control-Allow-Origin", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Invitation sended to user successfully\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestJoinWorkbook.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestJoinWorkbook()
        {
            // Parameters for the API call
            int workbookId = 1;
            int userId = 12;

            // Perform API call
            Standard.Models.JoinWorkbook result = null;
            try
            {
                result = await this.controller.JoinWorkbookAsync(workbookId, userId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);
            headers.Add("Host", null);
            headers.Add("Date", null);
            headers.Add("Connection", null);
            headers.Add("X-Powered-By", null);
            headers.Add("Cache-Control", null);
            headers.Add("X-RateLimit-Limit", null);
            headers.Add("X-RateLimit-Remaining", null);
            headers.Add("Access-Control-Allow-Origin", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Joined workspace Successfully\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestRejectWorkbook.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestRejectWorkbook()
        {
            // Parameters for the API call
            int workbookId = 1;
            int userId = 12;

            // Perform API call
            Standard.Models.RejectWorkbook result = null;
            try
            {
                result = await this.controller.RejectWorkbookAsync(workbookId, userId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);
            headers.Add("Host", null);
            headers.Add("Date", null);
            headers.Add("Connection", null);
            headers.Add("X-Powered-By", null);
            headers.Add("Cache-Control", null);
            headers.Add("X-RateLimit-Limit", null);
            headers.Add("X-RateLimit-Remaining", null);
            headers.Add("Access-Control-Allow-Origin", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\r\n  \"status\": \"error\",\r\n  \"message\": \"Worbook invite no more exist\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestWorkbookPolicies.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestWorkbookPolicies()
        {
            // Parameters for the API call
            int userId = 1;
            string type = "general";

            // Perform API call
            Standard.Models.WorkbookPolicies result = null;
            try
            {
                result = await this.controller.WorkbookPoliciesAsync(userId, type);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);
            headers.Add("Host", null);
            headers.Add("Date", null);
            headers.Add("Connection", null);
            headers.Add("X-Powered-By", null);
            headers.Add("Cache-Control", null);
            headers.Add("X-RateLimit-Limit", null);
            headers.Add("X-RateLimit-Remaining", null);
            headers.Add("Access-Control-Allow-Origin", null);

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Data Fatched Successfully\",\r\n  \"count\": 8,\r\n  \"data\": [\r\n    {\r\n      \"id\": 20,\r\n      \"created_at\": \"2023-07-17T10:44:54.000000Z\",\r\n      \"updated_at\": \"2023-07-17T10:44:54.000000Z\",\r\n      \"deleted_at\": null,\r\n      \"alias\": \"taamfly\",\r\n      \"name\": \"taamfly\",\r\n      \"type\": \"ppgen.Terms\",\r\n      \"lang\": \"en\",\r\n      \"content\": \"<h1>Welcome to taamfly's Terms And Conditions!</h1>\\n<p>These terms and conditions outline the rules and regulations for the use of taamfly ( <a href=\\\"https://taamfly.com\\\">https://taamfly.com )  </a>.</p>\\n<p>By accessing this  website , we assume you accept these terms and conditions. Do not continue to use taamfly if you do not agree to take all of the terms and conditions stated on this page.</p>\\n<p>The following terminology applies to these Terms and Conditions, Privacy Statement, and Disclaimer Notice and all Agreements: \\\"Client,\\\" \\\"You,\\\" and \\\"Your\\\" refers to you, the person log on this website/app and compliant to the Company's terms and conditions. \\\"The Company,\\\" \\\"Ourselves,\\\" \\\"We,\\\" \\\"Our,\\\" and \\\"Us,\\\" refers to our Company. \\\"Party,\\\" \\\"Parties,\\\" or \\\"Us,\\\" refers to both the Client and ourselves. All terms refer to the offer, acceptance, and consideration of payment necessary to undertake the process of our assistance to the Client in the most appropriate manner for the express purpose of meeting the Client's needs in respect of the provision of the Company's stated services, in accordance with and subject to, prevailing law of Netherlands. Any use of the above terminology or other words in the singular, plural, capitalization and/or he/she or they, are taken as interchangeable and therefore as referring to the same.</p>\\n\\n \\n<h2>License</h2>\\n<p>Unless otherwise stated, taamfly and/or its&nbsp;licensors own the intellectual property rights in the website/app and material on the website/app. Subject to the license below, all these intellectual property rights are reserved.</p>\\n<p>You may view, download for caching purposes only, and print pages from the website/app for your own personal use, subject to the restrictions set out below and elsewhere in these terms and conditions.</p>\\n<p>You must not:</p>\\n<p>Republish material from taamfly&nbsp;<br>Sell, rent or sub-license material from taamfly <br>Reproduce, duplicate or copy material from taamfly <br>Redistribute content from taamfly (unless the content is specifically made for redistribution).</p>\\n<h2>User Content</h2>\\n<p>In these terms and conditions, \\\"your user content\\\" means material (including without limitation text, images, audio material, video material, and audio-visual material) that you submit to this website/app, for whatever purpose.</p>\\n<p>You grant to taamfly a worldwide, irrevocable, non-exclusive, royalty-free license to use, reproduce, adapt, publish, translate, and distribute your user content in any existing or future media. You also grant to taamfly the right to sub-license these rights, and the right to bring an action for infringement of these rights.</p>\\n<p>Your user content must not be defamatory, indecent, obscene, harassing, or hateful, and must not infringe any third party's rights. taamfly reserves the right to remove any of your user content from this website/app at any time, and for any reason, without notice.</p>\\n<h2>Variation of Terms</h2>\\n<p>taamfly is permitted to revise these terms and conditions at any time as it sees fit, and by using this website/app you are expected to review these terms regularly.</p>\\n<p>Assignment taamfly is allowed to assign, transfer, and subcontract its rights and/or obligations under these terms and conditions without any notification. However, you are not allowed to assign, transfer, or subcontract any of your rights and/or obligations under these terms and conditions.</p>\\n<h2>Entire Agreement</h2>\\n<p>These terms and conditions constitute the entire agreement between taamfly and you concerning your use of this</p>\",\r\n      \"response\": \"{\\\"_token\\\":\\\"eWdti7UpjaXPTIxF5LJ56hbsS8M3Qj6TAzUdvGDv\\\",\\\"doctype\\\":\\\"Terms\\\",\\\"fortype\\\":\\\"website\\\",\\\"use_openai_yes_subquestion\\\":null,\\\"use_openai_yes_secondsubquestion\\\":null,\\\"use_openai\\\":\\\"use_openai_no\\\",\\\"business_name\\\":\\\"Taam soft\\\",\\\"project_name\\\":\\\"taamfly\\\",\\\"website_url\\\":\\\"https:\\\\/\\\\/taamfly.com\\\",\\\"use_cookies\\\":\\\"use_cookies_no\\\"}\",\r\n      \"user_id\": 4,\r\n      \"paid\": 1,\r\n      \"ai\": 0,\r\n      \"ai_done\": 0,\r\n      \"ai_used_tokens\": 0,\r\n      \"active\": 1,\r\n      \"price\": 0,\r\n      \"md\": \"taamfly\"\r\n    },\r\n    {\r\n      \"id\": 19,\r\n      \"created_at\": \"2023-07-14T11:29:20.000000Z\",\r\n      \"updated_at\": \"2023-07-14T11:29:20.000000Z\",\r\n      \"deleted_at\": null,\r\n      \"alias\": \"matgarli-3\",\r\n      \"name\": \"MATGARLI\",\r\n      \"type\": \"ppgen.Ccpa\",\r\n      \"lang\": \"en\",\r\n      \"content\": \"<h1><strong>California Privacy&nbsp;Rights - MATGARLI</strong></h1>\\nLast updated:2023-07-13<br />\\n<p>To the extent provided for by law and subject to applicable exceptions, California residents have the following privacy rights in relation to the Personal Information we&nbsp;collect:</p>\\n<p>The right to know what Personal Information we have collected and how we have used and disclosed that Personal&nbsp;Information;</p>\\n<p>The right to request the deletion of your Personal Information;&nbsp;and</p>\\n<p>The right to be free from discrimination relating to the exercise of any of your privacy&nbsp;rights.</p>\\n<p>We do not and will not sell your Personal&nbsp;Information.</p>\\n<p>This Privacy Policy document&nbsp;describes the personal information that we collect, the sources from which we collect it, the purposes for which we use it, the limited circumstances under which we share personal information, and with whom we share it. These additional disclosures are required by the California Consumer Privacy Act:</p>\\n<ol>\\n<li><strong>Categories of personal information collected</strong>. The personal information that  taam soft. collects, or has collected from consumers in the twelve months prior to the effective date of this Disclosure, fall into the following categories established by the California Consumer Privacy Act:\\n<ol>\\n    <li>identifiers such as your name, alias, address, phone number, or IP address;</li>    <li>personal information, such as a credit card number;</li>        <li>commercial information, such as purchase and content consumed activity;</li>                            </ol>\\n</li>\\n<li><strong>Categories of personal information disclosed for a business purpose</strong>. The personal information that taam soft disclosed to the third parties identified in the previous sections&nbsp;about consumers for a business purpose in the twelve months prior to the effective date of this Disclosure fall into the following categories established by the California Consumer Privacy Act:\\n<ol>\\n    <li>identifiers such as your name, alias, address, phone number, or IP address;</li>            <li>commercial information, such as purchase and content consumed activity;</li>                            </ol>\\n</li>\\n<li><strong>Right to Request Access to or Deletion of Personal Information:</strong>&nbsp;You may have the right under the California Consumer Privacy Act to request information about the collection of your personal information by taam soft, or access to or deletion of your personal information. If you wish to do any of these things, please contact us <a href=\\\"mailto:tamem20142016@gmail.com\\\" />tamem20142016@gmail.com</a>.</li>\\n<li><strong>No sale of personal information</strong>. In the twelve months prior to the effective date of this Disclosure, taam soft has not sold any personal information of consumers, as those terms are defined under the California Consumer Privacy Act.</li>\\n<li><strong>No Discrimination</strong>. taam soft will not discriminate against any consumer for exercising their rights under the California Consumer Privacy Act.</li>\\n</ol>\",\r\n      \"response\": \"{\\\"_token\\\":\\\"xJYzw4KC1qidibEfAzRIDLvXbM2vHhzLwrJqxnzT\\\",\\\"doctype\\\":\\\"Ccpa\\\",\\\"fortype\\\":\\\"website\\\",\\\"use_openai_yes_subquestion\\\":null,\\\"use_openai_yes_secondsubquestion\\\":null,\\\"business_name\\\":\\\"taam soft\\\",\\\"project_name\\\":\\\"MATGARLI\\\",\\\"website_url\\\":\\\"https:\\\\/\\\\/taamsoft.com\\\\/\\\",\\\"ccpa_collected_id\\\":\\\"ccpa_collected_id\\\",\\\"ccpa_collected_ccnumbers\\\":\\\"ccpa_collected_ccnumbers\\\",\\\"ccpa_collected_comm_info\\\":\\\"ccpa_collected_comm_info\\\",\\\"ccpa_disclosed_id\\\":\\\"ccpa_disclosed_id\\\",\\\"ccpa_disclosed_comm_info\\\":\\\"ccpa_disclosed_comm_info\\\",\\\"change_email\\\":\\\"tamem20142016@gmail.com\\\"}\",\r\n      \"user_id\": 1,\r\n      \"paid\": 1,\r\n      \"ai\": 0,\r\n      \"ai_done\": 0,\r\n      \"ai_used_tokens\": 0,\r\n      \"active\": 1,\r\n      \"price\": 0,\r\n      \"md\": \"matgarli-3\"\r\n    },\r\n    {\r\n      \"id\": 18,\r\n      \"created_at\": \"2023-07-14T11:14:20.000000Z\",\r\n      \"updated_at\": \"2023-07-14T11:14:20.000000Z\",\r\n      \"deleted_at\": null,\r\n      \"alias\": \"matgarli-2\",\r\n      \"name\": \"MATGARLI\",\r\n      \"type\": \"ppgen.Terms\",\r\n      \"lang\": \"en\",\r\n      \"content\": \"<h1>Welcome to MATGARLI's Terms And Conditions!</h1>\\n<p>These terms and conditions outline the rules and regulations for the use of MATGARLI ( <a href=\\\"https://taamsoft.com/\\\">https://taamsoft.com/ )  </a>.</p>\\n<p>By accessing this  website , we assume you accept these terms and conditions. Do not continue to use MATGARLI if you do not agree to take all of the terms and conditions stated on this page.</p>\\n<p>The following terminology applies to these Terms and Conditions, Privacy Statement, and Disclaimer Notice and all Agreements: \\\"Client,\\\" \\\"You,\\\" and \\\"Your\\\" refers to you, the person log on this website/app and compliant to the Company's terms and conditions. \\\"The Company,\\\" \\\"Ourselves,\\\" \\\"We,\\\" \\\"Our,\\\" and \\\"Us,\\\" refers to our Company. \\\"Party,\\\" \\\"Parties,\\\" or \\\"Us,\\\" refers to both the Client and ourselves. All terms refer to the offer, acceptance, and consideration of payment necessary to undertake the process of our assistance to the Client in the most appropriate manner for the express purpose of meeting the Client's needs in respect of the provision of the Company's stated services, in accordance with and subject to, prevailing law of Netherlands. Any use of the above terminology or other words in the singular, plural, capitalization and/or he/she or they, are taken as interchangeable and therefore as referring to the same.</p>\\n\\n<h2>Cookies</h2>\\n<p>We employ the use of cookies. By accessing MATGARLI, you agreed to use cookies in agreement with the MATGARLI's Privacy Policy.</p>\\n \\n<h2>License</h2>\\n<p>Unless otherwise stated, MATGARLI and/or its&nbsp;licensors own the intellectual property rights in the website/app and material on the website/app. Subject to the license below, all these intellectual property rights are reserved.</p>\\n<p>You may view, download for caching purposes only, and print pages from the website/app for your own personal use, subject to the restrictions set out below and elsewhere in these terms and conditions.</p>\\n<p>You must not:</p>\\n<p>Republish material from MATGARLI&nbsp;<br>Sell, rent or sub-license material from MATGARLI <br>Reproduce, duplicate or copy material from MATGARLI <br>Redistribute content from MATGARLI (unless the content is specifically made for redistribution).</p>\\n<h2>User Content</h2>\\n<p>In these terms and conditions, \\\"your user content\\\" means material (including without limitation text, images, audio material, video material, and audio-visual material) that you submit to this website/app, for whatever purpose.</p>\\n<p>You grant to MATGARLI a worldwide, irrevocable, non-exclusive, royalty-free license to use, reproduce, adapt, publish, translate, and distribute your user content in any existing or future media. You also grant to MATGARLI the right to sub-license these rights, and the right to bring an action for infringement of these rights.</p>\\n<p>Your user content must not be defamatory, indecent, obscene, harassing, or hateful, and must not infringe any third party's rights. MATGARLI reserves the right to remove any of your user content from this website/app at any time, and for any reason, without notice.</p>\\n<h2>Variation of Terms</h2>\\n<p>MATGARLI is permitted to revise these terms and conditions at any time as it sees fit, and by using this website/app you are expected to review these terms regularly.</p>\\n<p>Assignment MATGARLI is allowed to assign, transfer, and subcontract its rights and/or obligations under these terms and conditions without any notification. However, you are not allowed to assign, transfer, or subcontract any of your rights and/or obligations under these terms and conditions.</p>\\n<h2>Entire Agreement</h2>\\n<p>These terms and conditions constitute the entire agreement between MATGARLI and you concerning your use of this</p>\",\r\n      \"response\": \"{\\\"_token\\\":\\\"xJYzw4KC1qidibEfAzRIDLvXbM2vHhzLwrJqxnzT\\\",\\\"doctype\\\":\\\"Terms\\\",\\\"fortype\\\":\\\"website\\\",\\\"use_openai_yes_subquestion\\\":null,\\\"use_openai_yes_secondsubquestion\\\":null,\\\"use_openai\\\":\\\"use_openai_no\\\",\\\"business_name\\\":\\\"taam soft\\\",\\\"project_name\\\":\\\"MATGARLI\\\",\\\"website_url\\\":\\\"https:\\\\/\\\\/taamsoft.com\\\\/\\\",\\\"use_cookies\\\":\\\"use_cookies_yes\\\"}\",\r\n      \"user_id\": 1,\r\n      \"paid\": 1,\r\n      \"ai\": 0,\r\n      \"ai_done\": 0,\r\n      \"ai_used_tokens\": 0,\r\n      \"active\": 1,\r\n      \"price\": 0,\r\n      \"md\": \"matgarli-2\"\r\n    },\r\n    {\r\n      \"id\": 17,\r\n      \"created_at\": \"2023-07-07T21:43:46.000000Z\",\r\n      \"updated_at\": \"2023-07-07T21:43:56.000000Z\",\r\n      \"deleted_at\": null,\r\n      \"alias\": \"matgarli-1\",\r\n      \"name\": \"MATGARLI\",\r\n      \"type\": \"ppgen.Refundtemplate\",\r\n      \"lang\": \"en\",\r\n      \"content\": \"business days after the returned product is received and inspected by MATGARLI.<br />\\n<br />\\nSection: Late or Missing Refunds<br />\\nIf you haven't received a refund within the specified time period, please check your bank account again. Then contact your credit card company, as it may take some time before your refund is officially posted. Next, contact your bank. There is often some processing time before a refund is posted. If you've completed all of these steps and still haven't received your refund, please contact MATGARLI's customer support team for further assistance.<br />\\n<br />\\nSection: Exchanges<br />\\nMATGARLI does not offer exchanges for returned items. If you wish to exchange a product, you will need to return the original item for a refund and place a new order for the desired product.<br />\\n<br />\\nSection: Damaged or Defective Products<br />\\nIf you receive a damaged or defective product, please contact MATGARLI's customer support team within 48 hours of receiving the product. We will provide instructions on how to return the item and arrange for a replacement or refund, depending on your preference.<br />\\n<br />\\nSection: Cancellations<br />\\nCancellations are only accepted for orders that have not been shipped yet. If you wish to cancel your order, please contact MATGARLI's customer support team as soon as possible. If your order has already been shipped, you will need to follow the return process outlined in this policy.<br />\\n<br />\\nSection: Changes to the Refund Policy<br />\\nMATGARLI reserves the right to modify or update this refund policy at any time. Any changes will be effective immediately upon posting the revised policy on the MATGARLI website. It is your responsibility to review this policy periodically for any updates or changes.<br />\\n<br />\\nBy making a purchase from MATGARLI, you acknowledge that you have read, understood, and agree to this refund policy.\",\r\n      \"response\": \"{\\\"_token\\\":\\\"IR6OfNy4GYkb1LJjdqBVgcr4nsNJGjahNkTccPC7\\\",\\\"doctype\\\":\\\"Refundtemplate\\\",\\\"fortype\\\":\\\"shop\\\",\\\"use_openai\\\":\\\"use_openai_yes\\\",\\\"use_openai_yes_subquestion\\\":\\\"SAAS APPLICATION HELP THE VENDORS TO CREATE ONLINE STORE IN CLICK\\\",\\\"use_openai_yes_secondsubquestion\\\":\\\"ENGLISH\\\",\\\"project_name\\\":\\\"MATGARLI\\\",\\\"how_long_for_refund\\\":\\\"how_long_for_refund_value\\\",\\\"how_long_for_refund_value_subquestion\\\":null,\\\"num_days_credit\\\":\\\"10\\\",\\\"conditions_for_refund_op\\\":\\\"conditions_for_refund_op\\\",\\\"conditions_for_refund_nd\\\":\\\"conditions_for_refund_nd\\\",\\\"conditions_for_refund_receipt\\\":\\\"conditions_for_refund_receipt\\\",\\\"refund_discount\\\":\\\"refund_discount_yes\\\",\\\"refund_pay\\\":\\\"refund_pay_yes\\\",\\\"how_return_address_subquestion\\\":null}\",\r\n      \"user_id\": 1,\r\n      \"paid\": 1,\r\n      \"ai\": 1,\r\n      \"ai_done\": 1,\r\n      \"ai_used_tokens\": 0,\r\n      \"active\": 1,\r\n      \"price\": 1000,\r\n      \"md\": \"matgarli-1\"\r\n    },\r\n    {\r\n      \"id\": 16,\r\n      \"created_at\": \"2023-07-07T21:43:31.000000Z\",\r\n      \"updated_at\": \"2023-07-07T21:43:31.000000Z\",\r\n      \"deleted_at\": null,\r\n      \"alias\": \"matgarli\",\r\n      \"name\": \"MATGARLI\",\r\n      \"type\": \"ppgen.Refundtemplate\",\r\n      \"lang\": \"en\",\r\n      \"content\": \"Create new Refund Policy for MATGARLI   in ENGLISH  .\\n\\nSAAS APPLICATION HELP THE VENDORS TO CREATE ONLINE STORE IN CLICK\\n\\nWe need the following section to be preent in thes Policy:\\n\\nSection: Return Eligibility\\n            The return must be initiated within  days of the purchase date.\\n                    \\n            The product must be returned in its original packaging, including all accessories, labels, and documentation.\\n    \\n            The product must be returned together with the purchase receipt.\\n    \\n            The product must not have been used or damaged in any way. Products that are returned in a damaged or used condition will not be eligible for a refund.\\n        \\n\\nSection: Non-refundable Items\\nDiscounted or sale items are not eligible for refunds.\\n\\n\\nSection: Return cost\\nThe customer is responsible for covering the cost of return shipping. MATGARLI will not reimburse or provide a prepaid shipping label for returned items.\\n \\n \\n\\nSection: Return Process\\n\\nSection: Refund Process\\nA credit will automatically be applied to your original method of payment within 10\",\r\n      \"response\": \"{\\\"_token\\\":\\\"IR6OfNy4GYkb1LJjdqBVgcr4nsNJGjahNkTccPC7\\\",\\\"doctype\\\":\\\"Refundtemplate\\\",\\\"fortype\\\":\\\"shop\\\",\\\"use_openai\\\":\\\"use_openai_yes\\\",\\\"use_openai_yes_subquestion\\\":\\\"SAAS APPLICATION HELP THE VENDORS TO CREATE ONLINE STORE IN CLICK\\\",\\\"use_openai_yes_secondsubquestion\\\":\\\"ENGLISH\\\",\\\"project_name\\\":\\\"MATGARLI\\\",\\\"how_long_for_refund\\\":\\\"how_long_for_refund_value\\\",\\\"how_long_for_refund_value_subquestion\\\":null,\\\"num_days_credit\\\":\\\"10\\\",\\\"conditions_for_refund_op\\\":\\\"conditions_for_refund_op\\\",\\\"conditions_for_refund_nd\\\":\\\"conditions_for_refund_nd\\\",\\\"conditions_for_refund_receipt\\\":\\\"conditions_for_refund_receipt\\\",\\\"refund_discount\\\":\\\"refund_discount_yes\\\",\\\"refund_pay\\\":\\\"refund_pay_yes\\\",\\\"how_return_address_subquestion\\\":null}\",\r\n      \"user_id\": 1,\r\n      \"paid\": 0,\r\n      \"ai\": 1,\r\n      \"ai_done\": 0,\r\n      \"ai_used_tokens\": 0,\r\n      \"active\": 0,\r\n      \"price\": 1000,\r\n      \"md\": \"matgarli\"\r\n    },\r\n    {\r\n      \"id\": 15,\r\n      \"created_at\": \"2023-07-07T21:36:53.000000Z\",\r\n      \"updated_at\": \"2023-07-07T21:36:53.000000Z\",\r\n      \"deleted_at\": null,\r\n      \"alias\": \"taam-soft\",\r\n      \"name\": \"taam soft\",\r\n      \"type\": \"ppgen.Privacypolicytemplate\",\r\n      \"lang\": \"en\",\r\n      \"content\": \"<h1><b>Privacy Policy for taam soft</b></h1>\\nLast updated:2023-07-07\\n\\n<p>\\nWe at taam soft. (together with our affiliates,  taam soft, “we”, “our” or “us”) respect your privacy and are strongly committed to keeping secure any information we obtain from you or about you. This Privacy Policy describes our practices with respect to Personal Information we collect from or about you when you access  taam soft ( <a href=\\\"https://taamsoft.com/\\\">https://taamsoft.com/</a> ) and its affiliates’ websites (collectively, the “Site”), or use  taam soft and its affiliates’ products and services, including application programming interfaces, associated software, tools, developer services, data and documentation (collectively, the “Services”).\\n<br/>Visiting the website, creating an account with a view to using the application, subscribing to the newsletter, and/or applying for a live or video demo implies your explicit approval (by means of providing your personal data or opt-in) of the Privacy Statement and therefore your approval of the way we collect, use and process your personal data.\\n<br/>Please read this Privacy Statement in conjunction with taam soft’s cookie policy. </p><br /><br />\\n<h1><b>PERSONAL INFORMATION WE COLLECT</b></h1>\\n\\ntaam soft may collect and process the following personal data:\\n- First and last name <br />\\n<p>\\nWe collect information that alone or in combination with other information in our possession could be used to identify you (“Personal Information”) as follows:\\n</p>\\n<p>\\n<b>Personal Information You Provide</b>: We may collect Personal Information if you create an account to use our Services or communicate with us as follows.\\n<br />\\n<b>Communication Information</b>: If you communicate with us, we may collect your name, contact information, and the contents of any messages you send (“Communication Information”).\\n<br />\\n<b>Personal Information We Receive Automatically From Your Use of the Services</b>: When you visit, use, and interact with the Services, we may receive certain information about your visit, use, or interactions (“Technical Information”), including the following:\\n<br />\\n<b>Log data</b>: Information that your browser automatically sends whenever you visit the Site (“log data”). Log data includes your Internet Protocol address, browser type and settings, the date and time of your request, and how you interacted with the Site.\\n<br />\\n<b>Usage data</b>: We may automatically collect information about your use of the Services, such as the types of content that you view or engage with, the features you use, and the actions you take, as well as your time zone, country, the dates and times of access, user agent and version, type of computer or mobile device, computer connection, IP address, and the like.\\n<br />\\n<b>Device information</b>: Includes name of the device, operating system, and browser you are using. Information collected may depend on the type of device you use and its settings.\\n</p>\\n<b>Cookies</b><br /> We use cookies to operate and administer our Site and Services, and improve your experience on it. A “cookie” is a piece of information sent to your browser by a website you visit. You can set your browser to accept all cookies, reject all cookies, or notify you whenever a cookie is offered so that you can decide each time whether to accept it. However, refusing a cookie may in some cases preclude you from using, or negatively affect the display or function of, a website or certain areas or features of a website. For more details on cookies please visit <a href=\\\"https://allaboutcookies.org/\\\" target=\\\"_blank\\\">All About Cookies</a>.\\n    <br /><br />\\n<h1><b>HOW WE USE PERSONAL INFORMATION</b></h1>\\nWe may use your Personal Information as follows:\\n<ul>\\n<li><b>Provide Our Products and Services: </b>We use Personal Information\\nto furnish our Services, including to process and fulfill your selection or purchase of our Services and to\\nimprove the quality, safety and security of our Site and the Services.</li>\\n<li><b>Communicate with You:</b> We use Personal Information to respond\\nto communications, contact you about your transactions, promote our Services, provide other relevant\\ninformation, and request information or feedback.</li>\\n<li><b>Personalize Your Experience</b>: We utilize Personal Information\\nregarding your use of our Site, including to personalize and enhance your experiences.</li>\\n<li><b>Internal Research</b>: We use Personal Information to conduct\\ninternal research to develop, improve or repair our products, services or technology.</li>\\n<li><b>Security or Fraud Prevention</b>: We use Personal Information to:\\n(1) prevent, detect, protect against, or respond to security incidents, and (2) preserve the integrity or\\nsecurity of systems.</li>\\n<li><b>Legal Compliance</b>: We may use Personal Information to comply\\nwith applicable law or to comply with a lawful governmental request.</li>\\n\\n</ul>\\n<p>We strive to retain your Personal Information only for as long\\nas reasonably necessary to fulfill the purpose(s) for which we obtained the information or as otherwise required\\nby law.</p>\\n<h1><b>SHARING AND DISCLOSURE OF PERSONAL INFORMATION</b></h1>\\nIn certain circumstances we may share your Personal Information with third parties without further notice to you, unless required by the law, including without limitation in the situations below:\\n<ul>\\n\\t<li><strong>Vendors and Service Providers</strong>: To assist us in meeting business operations needs and to perform certain services and functions, we may share Personal Information with vendors and service providers, including providers of hosting services, cloud services, and other information technology services providers, event management services, email communication software and email newsletter services, advertising and marketing services, and web analytics services. Pursuant to our instructions, these parties will access, process, or store Personal Information in the course of performing their duties to&nbsp;us.</li>\\n\\t<li><strong>Business Transfers</strong>: If we are involved in strategic transactions, reorganization, bankruptcy, receivership, or transition of service to another provider (collectively a &ldquo;Transaction&rdquo;), your Personal Information and other information may be shared in the diligence process with counterparties and others assisting with the Transaction and transferred to a successor or affiliate as part of that Transaction along with other&nbsp;assets.</li>\\n\\t<li><strong>Legal Requirements</strong>: If required to do so by law or in the good faith belief that such action is necessary to (i) comply with a legal obligation, including to meet national security or law enforcement requirements, (ii) protect and defend our rights or property, (iii) prevent fraud, (iv) act in urgent circumstances to protect the personal safety of users of the Services, or the public, or (v) protect against legal&nbsp;liability.</li>\\n\\t<li><strong>Affiliates</strong>: We may share Personal Information with our affiliates, meaning an entity that controls, is controlled by, or is under common control with OpenAI. Our affiliates may use the Personal Information we share in a manner consistent with this Privacy&nbsp;Policy.</li>\\n\\t<li><strong>Other Users</strong>: certain actions you take may be visible to other users of the&nbsp;Service.</li>\\n</ul>\\n<h1><strong>PROCESSING OF YOUR PERSONAL DATA</strong></h1>\\n    \\n    \\n     \\n<p><strong>Payments</strong></p>\\n<p>We do provide paid products and/or services within the Service. </p>\\n<p>We do not store or collect Your payment card details. That information is provided directly to Our third-party payment processors whose use of Your personal information is governed by their Privacy Policy.</p>\\n<p>The tools/s we use for payment processing</p>\\n<table>\\n    <thead>\\n        <tr>\\n            <th><strong>Tool name</strong></th>\\n            <th><strong>Privacy policy URL</strong></th>\\n        </tr>\\n    </thead>\\n    <tbody>\\n                <tr>\\n            <td><strong>PayPal</strong></td>\\n            <td><a href=\\\"https://www.paypal.com/en/webapps/mpp/ua/privacy-full\\\">Privacy Policy</a></td>\\n        </tr>\\n        \\n                <tr>\\n            <td><strong>Stripe</strong></td>\\n            <td><a href=\\\"https://stripe.com/en-gb-us/privacy\\\">Privacy Policy</a></td>\\n        </tr>\\n        \\n        \\n        \\n            </tbody>\\n\\n    \\n</table>\\n\\n     \\n<p><strong>ADS</strong></p>\\n<p>We do generate revenue by showing advertising placement.  </p>\\n<p>The tools/s we use for the ads</p>\\n<table>\\n    <thead>\\n        <tr>\\n            <th><strong>Tool name</strong></th>\\n            <th><strong>Privacy policy URL</strong></th>\\n        </tr>\\n    </thead>\\n    <tbody>\\n                <tr>\\n            <td><strong>Google AdSense</strong></td>\\n            <td><a href=\\\"https://policies.google.com/privacy\\\">Privacy Policy</a></td>\\n        </tr>\\n        \\n                <tr>\\n            <td><strong>Meta (Facebook) ADS</strong></td>\\n            <td><a href=\\\"https://www.facebook.com/privacy/policy/?entry_point=data_policy_redirect&entry=0\\\">Privacy Policy</a></td>\\n        </tr>\\n        \\n\\n            </tbody>\\n\\n    \\n</table>\\n    <h1><strong>UPDATING YOUR NFORMATION</strong></h1>\\n<p>Please contact us at <a href=\\\"mailto:tamem20142016@gmail.com\\\" />tamem20142016@gmail.com</a> if you need to change or correct your Personal Information, or if you have any questions or concerns not already addressed in this Privacy Policy.</p>            <h1>CHILDREN</h1>\\n<p>Our Service is not directed to children who are under the age of 13. taam soft does not knowingly collect Personal Information from children under the age of 13. If you have reason to believe that a child under the age of 13 has provided Personal Information to taam soft through the Service please email us at <a href=\\\"mailto:tamem20142016@gmail.com\\\" >tamem20142016@gmail.com</a> &nbsp;and we will endeavor to delete that information from our databases.</p>   \\n \\n\\n<h1><strong>SECURITY</strong></h1>\\n<p>We use commercial reasonably physical, technical, and administrative security measures to reduce the risk of loss, misuse, unauthorized access, and disclosure of data. Please note, however, that no security measures are perfectly secure, and we are unable to guarantee the security of your Personal Information.</p>\\n<p>No Internet or e-mail transmission is ever fully secure or error-free. In particular, e-mail sent to or from us may not be secure. Therefore, you should take special care in deciding what information you send to us via the Service or e-mail. In addition, we are not responsible for the circumvention of any privacy settings or security measures contained on the Service, or third-party websites.</p>\\n\\n<h1><strong>INTERNATIONAL&nbsp;USERS</strong></h1>\\n<p>By using our Service, you understand and acknowledge that your Personal Information will be transferred from your location to our facilities and servers in the New York.</p>\\n\\n<h1><strong>CHANGES TO THE PRIVACY&nbsp;POLICY</strong></h1>\\n<p>We may update this Policy periodically as we offer new products and services, and as our business, technology, and applicable laws change. You can determine when this Policy was last revised by referring to the &ldquo;Last updated&rdquo; referenced below. Any changes will become effective upon posting of the revised Policy.</p>\\n<h1>CONTACT US</h1>\\n<p>taam soft<br>\\n<a href=\\\"tel:19172441980\\\" />19172441980</a><br>Last Updated: 2023-07-07</p>\",\r\n      \"response\": \"{\\\"_token\\\":\\\"oVTRrR7m8wA3gO32mIZBVydEuyI4Z3gQu85RN9w6\\\",\\\"doctype\\\":\\\"Privacypolicytemplate\\\",\\\"fortype\\\":\\\"website\\\",\\\"use_openai_yes_subquestion\\\":null,\\\"use_openai_yes_secondsubquestion\\\":null,\\\"use_openai\\\":\\\"use_openai_no\\\",\\\"business_name\\\":\\\"taam soft\\\",\\\"project_name\\\":\\\"taam soft\\\",\\\"website_url\\\":\\\"https:\\\\/\\\\/taamsoft.com\\\\/\\\",\\\"personal_data_collected_fln\\\":\\\"personal_data_collected_fln\\\",\\\"use_cookies\\\":\\\"use_cookies_yes\\\",\\\"analytics\\\":\\\"use_analytics_no\\\",\\\"emailmarketing\\\":\\\"emailmarketing_no\\\",\\\"payments\\\":\\\"payments_yes\\\",\\\"payments_yes_subquestion_paypal\\\":\\\"payments_yes_subquestion_paypal\\\",\\\"payments_yes_subquestion_stripe\\\":\\\"payments_yes_subquestion_stripe\\\",\\\"ads\\\":\\\"ads_yes\\\",\\\"ads_yes_subquestion_google_ads\\\":\\\"ads_yes_subquestion_google_ads\\\",\\\"ads_yes_subquestion_meta\\\":\\\"ads_yes_subquestion_meta\\\",\\\"otherserviceproviders\\\":\\\"otherserviceproviders_no\\\",\\\"change_email\\\":\\\"tamem20142016@gmail.com\\\",\\\"eu_gdrp\\\":\\\"eu_gdrp__no\\\",\\\"ccpa\\\":\\\"ccpa_no\\\",\\\"caloppa\\\":\\\"caloppa_no\\\",\\\"children_yes_subquestion\\\":null,\\\"children\\\":\\\"children_no\\\",\\\"servers_location\\\":\\\"New York\\\",\\\"how_to_contact_email_subquestion\\\":null,\\\"how_to_contact_phoone\\\":\\\"how_to_contact_phoone\\\",\\\"how_to_contact_phoone_subquestion\\\":\\\"19172441980\\\"}\",\r\n      \"user_id\": 2,\r\n      \"paid\": 1,\r\n      \"ai\": 0,\r\n      \"ai_done\": 0,\r\n      \"ai_used_tokens\": 0,\r\n      \"active\": 1,\r\n      \"price\": 0,\r\n      \"md\": \"taam-soft\"\r\n    },\r\n    {\r\n      \"id\": 14,\r\n      \"created_at\": \"2023-07-07T12:29:44.000000Z\",\r\n      \"updated_at\": \"2023-07-07T12:29:44.000000Z\",\r\n      \"deleted_at\": null,\r\n      \"alias\": \"shahzamaaaaaa-1\",\r\n      \"name\": \"shahzamaaaaaa\",\r\n      \"type\": \"ppgen.Privacypolicytemplate\",\r\n      \"lang\": \"en\",\r\n      \"content\": \"<h1><b>Privacy Policy for shahzamaaaaaa</b></h1>\\nLast updated:2023-07-07\\n\\n<p>\\nWe at Jazmyne Krajcik. (together with our affiliates,  shahzamaaaaaa, “we”, “our” or “us”) respect your privacy and are strongly committed to keeping secure any information we obtain from you or about you. This Privacy Policy describes our practices with respect to Personal Information we collect from or about you when you access  shahzamaaaaaa ( <a href=\\\"Aperiam tenetur quasi expedita.\\\">Aperiam tenetur quasi expedita.</a> ) and its affiliates’ websites (collectively, the “Site”), or use  shahzamaaaaaa and its affiliates’ products and services, including application programming interfaces, associated software, tools, developer services, data and documentation (collectively, the “Services”).\\n<br/>Visiting the website, creating an account with a view to using the application, subscribing to the newsletter, and/or applying for a live or video demo implies your explicit approval (by means of providing your personal data or opt-in) of the Privacy Statement and therefore your approval of the way we collect, use and process your personal data.\\n<br/>Please read this Privacy Statement in conjunction with shahzamaaaaaa’s cookie policy. </p><br /><br />\\n<h1><b>PERSONAL INFORMATION WE COLLECT</b></h1>\\n\\nshahzamaaaaaa may collect and process the following personal data:\\n- Function <br />\\n<p>\\nWe collect information that alone or in combination with other information in our possession could be used to identify you (“Personal Information”) as follows:\\n</p>\\n<p>\\n<b>Personal Information You Provide</b>: We may collect Personal Information if you create an account to use our Services or communicate with us as follows.\\n<br />\\n<b>Communication Information</b>: If you communicate with us, we may collect your name, contact information, and the contents of any messages you send (“Communication Information”).\\n<br />\\n<b>Personal Information We Receive Automatically From Your Use of the Services</b>: When you visit, use, and interact with the Services, we may receive certain information about your visit, use, or interactions (“Technical Information”), including the following:\\n<br />\\n<b>Log data</b>: Information that your browser automatically sends whenever you visit the Site (“log data”). Log data includes your Internet Protocol address, browser type and settings, the date and time of your request, and how you interacted with the Site.\\n<br />\\n<b>Usage data</b>: We may automatically collect information about your use of the Services, such as the types of content that you view or engage with, the features you use, and the actions you take, as well as your time zone, country, the dates and times of access, user agent and version, type of computer or mobile device, computer connection, IP address, and the like.\\n<br />\\n<b>Device information</b>: Includes name of the device, operating system, and browser you are using. Information collected may depend on the type of device you use and its settings.\\n</p>\\n<b>Cookies</b><br /> We use cookies to operate and administer our Site and Services, and improve your experience on it. A “cookie” is a piece of information sent to your browser by a website you visit. You can set your browser to accept all cookies, reject all cookies, or notify you whenever a cookie is offered so that you can decide each time whether to accept it. However, refusing a cookie may in some cases preclude you from using, or negatively affect the display or function of, a website or certain areas or features of a website. For more details on cookies please visit <a href=\\\"https://allaboutcookies.org/\\\" target=\\\"_blank\\\">All About Cookies</a>.\\n    <br /><br />\\n<h1><b>HOW WE USE PERSONAL INFORMATION</b></h1>\\nWe may use your Personal Information as follows:\\n<ul>\\n<li><b>Provide Our Products and Services: </b>We use Personal Information\\nto furnish our Services, including to process and fulfill your selection or purchase of our Services and to\\nimprove the quality, safety and security of our Site and the Services.</li>\\n<li><b>Communicate with You:</b> We use Personal Information to respond\\nto communications, contact you about your transactions, promote our Services, provide other relevant\\ninformation, and request information or feedback.</li>\\n<li><b>Personalize Your Experience</b>: We utilize Personal Information\\nregarding your use of our Site, including to personalize and enhance your experiences.</li>\\n<li><b>Internal Research</b>: We use Personal Information to conduct\\ninternal research to develop, improve or repair our products, services or technology.</li>\\n<li><b>Security or Fraud Prevention</b>: We use Personal Information to:\\n(1) prevent, detect, protect against, or respond to security incidents, and (2) preserve the integrity or\\nsecurity of systems.</li>\\n<li><b>Legal Compliance</b>: We may use Personal Information to comply\\nwith applicable law or to comply with a lawful governmental request.</li>\\n\\n</ul>\\n<p>We strive to retain your Personal Information only for as long\\nas reasonably necessary to fulfill the purpose(s) for which we obtained the information or as otherwise required\\nby law.</p>\\n<h1><b>SHARING AND DISCLOSURE OF PERSONAL INFORMATION</b></h1>\\nIn certain circumstances we may share your Personal Information with third parties without further notice to you, unless required by the law, including without limitation in the situations below:\\n<ul>\\n\\t<li><strong>Vendors and Service Providers</strong>: To assist us in meeting business operations needs and to perform certain services and functions, we may share Personal Information with vendors and service providers, including providers of hosting services, cloud services, and other information technology services providers, event management services, email communication software and email newsletter services, advertising and marketing services, and web analytics services. Pursuant to our instructions, these parties will access, process, or store Personal Information in the course of performing their duties to&nbsp;us.</li>\\n\\t<li><strong>Business Transfers</strong>: If we are involved in strategic transactions, reorganization, bankruptcy, receivership, or transition of service to another provider (collectively a &ldquo;Transaction&rdquo;), your Personal Information and other information may be shared in the diligence process with counterparties and others assisting with the Transaction and transferred to a successor or affiliate as part of that Transaction along with other&nbsp;assets.</li>\\n\\t<li><strong>Legal Requirements</strong>: If required to do so by law or in the good faith belief that such action is necessary to (i) comply with a legal obligation, including to meet national security or law enforcement requirements, (ii) protect and defend our rights or property, (iii) prevent fraud, (iv) act in urgent circumstances to protect the personal safety of users of the Services, or the public, or (v) protect against legal&nbsp;liability.</li>\\n\\t<li><strong>Affiliates</strong>: We may share Personal Information with our affiliates, meaning an entity that controls, is controlled by, or is under common control with OpenAI. Our affiliates may use the Personal Information we share in a manner consistent with this Privacy&nbsp;Policy.</li>\\n\\t<li><strong>Other Users</strong>: certain actions you take may be visible to other users of the&nbsp;Service.</li>\\n</ul>\\n<h1><strong>PROCESSING OF YOUR PERSONAL DATA</strong></h1>\\n    \\n    \\n    \\n    <h1><strong>UPDATING YOUR NFORMATION</strong></h1>\\n<p>Please contact us at <a href=\\\"mailto:\\\" /></a> if you need to change or correct your Personal Information, or if you have any questions or concerns not already addressed in this Privacy Policy.</p><h1>CHILDREN</h1>\\n \\n\\n<h1><strong>SECURITY</strong></h1>\\n<p>We use commercial reasonably physical, technical, and administrative security measures to reduce the risk of loss, misuse, unauthorized access, and disclosure of data. Please note, however, that no security measures are perfectly secure, and we are unable to guarantee the security of your Personal Information.</p>\\n<p>No Internet or e-mail transmission is ever fully secure or error-free. In particular, e-mail sent to or from us may not be secure. Therefore, you should take special care in deciding what information you send to us via the Service or e-mail. In addition, we are not responsible for the circumvention of any privacy settings or security measures contained on the Service, or third-party websites.</p>\\n\\n<h1><strong>INTERNATIONAL&nbsp;USERS</strong></h1>\\n<p>By using our Service, you understand and acknowledge that your Personal Information will be transferred from your location to our facilities and servers in the .</p>\\n\\n<h1><strong>CHANGES TO THE PRIVACY&nbsp;POLICY</strong></h1>\\n<p>We may update this Policy periodically as we offer new products and services, and as our business, technology, and applicable laws change. You can determine when this Policy was last revised by referring to the &ldquo;Last updated&rdquo; referenced below. Any changes will become effective upon posting of the revised Policy.</p>\\n<h1>CONTACT US</h1>\\n<p>Jazmyne Krajcik<br>\\n<a href=\\\"mailto:shahzaman@gmail.com\\\" />shahzaman@gmail.com</a><br>Last Updated: 2023-07-07</p>\",\r\n      \"response\": \"{\\\"_token\\\":\\\"cXRpUeIxiWcghIz8vxj5rZ6Mvhmd89OKB33GlZtz\\\",\\\"doctype\\\":\\\"Privacypolicytemplate\\\",\\\"fortype\\\":\\\"website\\\",\\\"use_openai_yes_subquestion\\\":null,\\\"use_openai_yes_secondsubquestion\\\":null,\\\"use_openai\\\":\\\"use_openai_no\\\",\\\"business_name\\\":\\\"Jazmyne Krajcik\\\",\\\"project_name\\\":\\\"shahzamaaaaaa\\\",\\\"website_url\\\":\\\"Aperiam tenetur quasi expedita.\\\",\\\"personal_data_collected_function\\\":\\\"personal_data_collected_function\\\",\\\"use_cookies\\\":\\\"use_cookies_yes\\\",\\\"analytics\\\":\\\"use_analytics_no\\\",\\\"emailmarketing\\\":\\\"emailmarketing_no\\\",\\\"payments\\\":\\\"payments_no\\\",\\\"ads\\\":\\\"ads_no\\\",\\\"change_email\\\":null,\\\"children_yes_subquestion\\\":null,\\\"servers_location\\\":null,\\\"how_to_contact_email\\\":\\\"how_to_contact_email\\\",\\\"how_to_contact_email_subquestion\\\":\\\"shahzaman@gmail.com\\\",\\\"how_to_contact_phoone_subquestion\\\":null}\",\r\n      \"user_id\": 1,\r\n      \"paid\": 1,\r\n      \"ai\": 0,\r\n      \"ai_done\": 0,\r\n      \"ai_used_tokens\": 0,\r\n      \"active\": 1,\r\n      \"price\": 0,\r\n      \"md\": \"shahzamaaaaaa-1\"\r\n    },\r\n    {\r\n      \"id\": 13,\r\n      \"created_at\": \"2023-07-07T12:26:06.000000Z\",\r\n      \"updated_at\": \"2023-07-07T12:48:30.000000Z\",\r\n      \"deleted_at\": null,\r\n      \"alias\": \"shahzamaaaaaa\",\r\n      \"name\": \"shahzamaaaaaa\",\r\n      \"type\": \"ppgen.Privacypolicytemplate\",\r\n      \"lang\": \"en\",\r\n      \"content\": \"1. Personal Information We Collect<br />\\r\\n<br />\\r\\nWe may collect and process the following personal data from you:<br />\\r\\n<br />\\r\\n- First and last name<br />\\r\\n<br />\\r\\n2. How We Use Personal Information<br />\\r\\n<br />\\r\\nWe may use the personal information collected from you for the following purposes:<br />\\r\\n<br />\\r\\n3. Sharing and Disclosure of Personal Information<br />\\r\\n<br />\\r\\nWe may share or disclose your personal information in the following circumstances:<br />\\r\\n<br />\\r\\n4. Processing of Your Personal Data<br />\\r\\n<br />\\r\\n5. Updating Your Information<br />\\r\\n<br />\\r\\nIf you need to update or correct any personal information you have provided to us, please contact us at shahzaman@gmail.com.<br />\\r\\n<br />\\r\\n6. GDPR - EU Data Subjects<br />\\r\\n<br />\\r\\nIf you are an EU data subject, additional rights and obligations may apply to the collection and processing of your personal data. Please refer to our separate GDPR Privacy Notice for more information.<br />\\r\\n<br />\\r\\n7. CalOPPA<br />\\r\\n<br />\\r\\nWe use cookies on our Site. By using the Site, you consent to the use of cookies in accordance with our Cookie Policy. Our Site currently does not respond to Do Not Track signals.<br />\\r\\n<br />\\r\\n8. Children<br />\\r\\n<br />\\r\\nOur Service is not directed to children under the age of 13. We do not knowingly collect personal information from children under 13. If you are a parent or guardian and believe that your child has provided us with personal information, please contact us immediately at shahzaman@gmail.com.<br />\\r\\n<br />\\r\\n9. Security<br />\\r\\n<br />\\r\\nWe implement appropriate technical and organizational measures to protect the security of your personal information. However, please note that no method of transmission over the internet or electronic storage is completely secure.<br />\\r\\n<br />\\r\\n10. International Users<br />\\r\\n<br />\\r\\nBy accessing or using our Site, you agree that your personal information may be transferred from your location to our facilities and servers located in the Beatae voluptatum adipisci.<br />\\r\\n<br />\\r\\n11. Changes to the Privacy Policy<br />\\r\\n<br />\\r\\nWe reserve the right to update or change our Privacy Policy at any time. Any changes will be effective immediately upon posting the updated Privacy Policy on the Site. It is your responsibility to review this Privacy Policy periodically for any updates or changes. Your continued use of the Site after any changes will constitute your acceptance of such changes.<br />\\r\\n<br />\\r\\n12. Contact Us<br />\\r\\n<br />\\r\\nIf you have any questions or concerns about this Privacy Policy, please contact us at shahzaman@gmail.com.<br />\\r\\n<br />\\r\\nBy using this Site, you signify your acceptance of this Privacy Policy. If you do not agree to this Privacy Policy, please do not use our Site.\",\r\n      \"response\": \"{\\\"_token\\\":\\\"cXRpUeIxiWcghIz8vxj5rZ6Mvhmd89OKB33GlZtz\\\",\\\"doctype\\\":\\\"Privacypolicytemplate\\\",\\\"fortype\\\":\\\"website\\\",\\\"use_openai\\\":\\\"use_openai_yes\\\",\\\"use_openai_yes_subquestion\\\":\\\"Julia_Schinner13\\\",\\\"use_openai_yes_secondsubquestion\\\":\\\"Bessie_Ondricka49\\\",\\\"business_name\\\":\\\"Jazmyne Krajcik\\\",\\\"project_name\\\":\\\"shahzamaaaaaa\\\",\\\"website_url\\\":\\\"Aperiam tenetur quasi expedita.\\\",\\\"personal_data_collected_fln\\\":\\\"personal_data_collected_fln\\\",\\\"use_cookies\\\":\\\"use_cookies_yes\\\",\\\"analytics\\\":\\\"use_analytics_no\\\",\\\"emailmarketing\\\":\\\"emailmarketing_no\\\",\\\"payments\\\":\\\"payments_no\\\",\\\"ads\\\":\\\"ads_no\\\",\\\"otherserviceproviders\\\":\\\"otherserviceproviders_no\\\",\\\"change_email\\\":\\\"shahzaman@gmail.com\\\",\\\"eu_gdrp\\\":\\\"eu_gdrp_yes\\\",\\\"ccpa\\\":\\\"ccpa_no\\\",\\\"caloppa\\\":\\\"caloppa_yes\\\",\\\"caloppa_yes_subquestion\\\":\\\"caloppa_yes_subquestion_no\\\",\\\"children_yes_subquestion\\\":null,\\\"children\\\":\\\"children_no\\\",\\\"servers_location\\\":\\\"Beatae voluptatum adipisci.\\\",\\\"how_to_contact_email\\\":\\\"how_to_contact_email\\\",\\\"how_to_contact_email_subquestion\\\":\\\"shahzaman@gmail.com\\\",\\\"how_to_contact_phoone_subquestion\\\":null}\",\r\n      \"user_id\": 1,\r\n      \"paid\": 1,\r\n      \"ai\": 1,\r\n      \"ai_done\": 1,\r\n      \"ai_used_tokens\": 0,\r\n      \"active\": 1,\r\n      \"price\": 1000,\r\n      \"md\": \"shahzamaaaaaa\"\r\n    }\r\n  ]\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestCreateLinkToAccessAnyDocument.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestCreateLinkToAccessAnyDocument()
        {
            // Perform API call
            try
            {
                await this.controller.CreateLinkToAccessAnyDocumentAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }
    }
}