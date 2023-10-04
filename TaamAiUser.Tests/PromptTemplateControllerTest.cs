// <copyright file="PromptTemplateControllerTest.cs" company="APIMatic">
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
    /// PromptTemplateControllerTest.
    /// </summary>
    [TestFixture]
    public class PromptTemplateControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private PromptTemplateController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.PromptTemplateController;
        }

        /// <summary>
        /// TestPromptTemplates.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestPromptTemplates()
        {
            // Parameters for the API call
            int userId = 1;
            string cat = "publc";
            string subCat = "all";

            // Perform API call
            Standard.Models.PromptTemplates result = null;
            try
            {
                result = await this.controller.PromptTemplatesAsync(userId, cat, subCat);
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
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Data Fateched Successfully\",\r\n  \"data\": [\r\n    {\r\n      \"id\": 3,\r\n      \"user_id\": 1,\r\n      \"name\": \"Sobi Rajpoot\",\r\n      \"icon\": \"<i class=\\\"fa-solid fa-search-minus blog-icon\\\"></i>\",\r\n      \"image\": null,\r\n      \"description\": \"tone of voice generator\",\r\n      \"template_code\": \"DAQGY\",\r\n      \"lang\": \"en-US\",\r\n      \"status\": 1,\r\n      \"professional\": 0,\r\n      \"new\": 0,\r\n      \"public\": 0,\r\n      \"edit\": 0,\r\n      \"group\": \"public\",\r\n      \"slug\": \"custom-template\",\r\n      \"type\": \"custom\",\r\n      \"prompt\": null,\r\n      \"tone\": 0,\r\n      \"fields\": [],\r\n      \"package\": \"all\",\r\n      \"created_at\": \"2023-07-24T13:04:48.000000Z\",\r\n      \"updated_at\": \"2023-07-24T13:04:48.000000Z\",\r\n      \"deleted_at\": null\r\n    }\r\n  ]\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestAddAndRemoveFromBookmarkPromptTemplate.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestAddAndRemoveFromBookmarkPromptTemplate()
        {
            // Parameters for the API call
            int userId = 1;
            int templateId = 1;

            // Perform API call
            Standard.Models.NewRequest1 result = null;
            try
            {
                result = await this.controller.AddAndRemoveFromBookmarkPromptTemplateAsync(userId, templateId);
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
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Added to bookmark Successfully\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestPromptTemplateLikeOrRemoveFromLike.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestPromptTemplateLikeOrRemoveFromLike()
        {
            // Parameters for the API call
            int userId = 1;
            int templateId = 1;

            // Perform API call
            Standard.Models.PromptTemplateLikeOrRemoveFromLike result = null;
            try
            {
                result = await this.controller.PromptTemplateLikeOrRemoveFromLikeAsync(userId, templateId);
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
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"added to Liked list\",\r\n  \"count\": 1\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestCreatePromptTemplate.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestCreatePromptTemplate()
        {
            // Parameters for the API call
            int userId = 1;
            int mPublic = 1;
            int edit = 1;
            string name = "New checking";
            int activate = 1;
            int tone = 1;
            string prompt = "Want to create vlog";
            string language = "en-US";
            string package = "all";
            string category = "text";
            string names0 = "new";
            string placeholders0 = "Enter relavent information";
            string code0 = "input-field-1";
            string inputField0 = "input";

            // Perform API call
            Standard.Models.CreatePromptTemplate result = null;
            try
            {
                result = await this.controller.CreatePromptTemplateAsync(userId, mPublic, edit, name, activate, tone, prompt, language, package, category, names0, placeholders0, code0, inputField0);
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
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Prompt template creeated Successfully\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestTrashedPromptTemplates.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTrashedPromptTemplates()
        {
            // Parameters for the API call
            int userId = 1;

            // Perform API call
            Standard.Models.TrashedPromptTemplates result = null;
            try
            {
                result = await this.controller.TrashedPromptTemplatesAsync(userId);
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
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Data Fatched Successfully\",\r\n  \"data\": [\r\n    {\r\n      \"id\": 2,\r\n      \"user_id\": 1,\r\n      \"name\": \"a\",\r\n      \"icon\": \"<i class=\\\"fa-solid fa-power-off blog-icon\\\"></i>\",\r\n      \"image\": null,\r\n      \"description\": \"a\",\r\n      \"template_code\": \"7AUBC\",\r\n      \"lang\": \"en-US\",\r\n      \"status\": 1,\r\n      \"professional\": 0,\r\n      \"new\": 0,\r\n      \"public\": 1,\r\n      \"edit\": 0,\r\n      \"group\": \"public\",\r\n      \"slug\": \"custom-template\",\r\n      \"type\": \"custom\",\r\n      \"prompt\": null,\r\n      \"tone\": 0,\r\n      \"fields\": [],\r\n      \"package\": \"all\",\r\n      \"created_at\": \"2023-07-21T11:48:04.000000Z\",\r\n      \"updated_at\": \"2023-09-04T09:04:34.000000Z\",\r\n      \"deleted_at\": \"2023-09-04T09:04:34.000000Z\"\r\n    }\r\n  ]\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestDeletePrmoptTemplate.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestDeletePrmoptTemplate()
        {
            // Parameters for the API call
            int userId = 1;
            int templateId = 3;

            // Perform API call
            Standard.Models.DeletePrmoptTemplate result = null;
            try
            {
                result = await this.controller.DeletePrmoptTemplateAsync(userId, templateId);
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
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Deleted Successfully\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestRestorePromptTemplate.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestRestorePromptTemplate()
        {
            // Parameters for the API call
            int userId = 1;
            int templateId = 3;

            // Perform API call
            Standard.Models.RestorePromptTemplate result = null;
            try
            {
                result = await this.controller.RestorePromptTemplateAsync(userId, templateId);
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
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Restored Successfully\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestParmanentDeletePromptTemplate.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestParmanentDeletePromptTemplate()
        {
            // Parameters for the API call
            int userId = 1;
            int templateId = 3;

            // Perform API call
            Standard.Models.ParmanentDeletePromptTemplate result = null;
            try
            {
                result = await this.controller.ParmanentDeletePromptTemplateAsync(userId, templateId);
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
                    "{\r\n  \"status\": \"error\",\r\n  \"message\": \"Not Found\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestGeneratePromptTemplate.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGeneratePromptTemplate()
        {
            // Parameters for the API call
            int userId = 1;
            string templateCode = "SXHY9";
            string language = "en-US";
            int maxResults = 1;
            int words = 10000;
            double creativity = 0.5;
            string title = "new";
            string description = "something new";
            int workbookId = 1;
            int folderId = 1;
            string text1 = "hello";

            // Perform API call
            Standard.Models.GeneratePromptTemplate result = null;
            try
            {
                result = await this.controller.GeneratePromptTemplateAsync(userId, templateCode, language, maxResults, words, creativity, title, description, workbookId, folderId, text1);
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
                    "{\r\n  \"status\": \"success\",\r\n  \"max_results\": \"1\",\r\n  \"temperature\": \"0.5\",\r\n  \"max_words\": \"1000\",\r\n  \"id\": 379\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}