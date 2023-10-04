// <copyright file="CustimTemplatesControllerTest.cs" company="APIMatic">
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
    /// CustimTemplatesControllerTest.
    /// </summary>
    [TestFixture]
    public class CustimTemplatesControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private CustimTemplatesController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.CustimTemplatesController;
        }

        /// <summary>
        /// TestCustomTemplates.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestCustomTemplates()
        {
            // Parameters for the API call
            int userId = 40;

            // Perform API call
            try
            {
                await this.controller.CustomTemplatesAsync(userId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestFavCustomTemplates.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestFavCustomTemplates()
        {
            // Parameters for the API call
            int userId = 40;

            // Perform API call
            try
            {
                await this.controller.FavCustomTemplatesAsync(userId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestCustomTemplateGenerate.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestCustomTemplateGenerate()
        {
            // Parameters for the API call
            int userId = 40;
            string templateCode = "AZL78";
            string language = "en-US";
            int maxResults = 1;
            int words = 100;
            double creativity = 0.5;
            string title = "code";
            string description = "code";
            int workbookId = 1;
            int folderId = 1;
            string text = "hello";
            string text2 = "really";

            // Perform API call
            Standard.Models.CustomTemplateGenerate result = null;
            try
            {
                result = await this.controller.CustomTemplateGenerateAsync(userId, templateCode, language, maxResults, words, creativity, title, description, workbookId, folderId, text, text2);
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
                    "{\r\n  \"status\": \"success\",\r\n  \"max_results\": \"1\",\r\n  \"temperature\": \"0.5\",\r\n  \"max_words\": 100,\r\n  \"id\": 289\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestCreateCustomTemplate.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestCreateCustomTemplate()
        {
            // Perform API call
            Standard.Models.CreateCustomTemplate result = null;
            try
            {
                result = await this.controller.CreateCustomTemplateAsync();
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
                    "{\r\n  \"code\": \"200\",\r\n  \"status\": \"success\",\r\n  \"message\": \"template Created Successfully\",\r\n  \"data\": {\r\n    \"user_id\": \"1\",\r\n    \"description\": null,\r\n    \"status\": true,\r\n    \"professional\": false,\r\n    \"template_code\": \"KOWPI\",\r\n    \"name\": \"new\",\r\n    \"icon\": \"<i class=\\\"fa-solid  blog-icon\\\"></i>\",\r\n    \"group\": \"text\",\r\n    \"slug\": \"custom-template\",\r\n    \"prompt\": \"Tone of voice generator\",\r\n    \"tone\": true,\r\n    \"fields\": [\r\n      {\r\n        \"name\": \"text1\",\r\n        \"placeholder\": \"Enter the ralevent information\",\r\n        \"input\": \"input\",\r\n        \"code\": \"input-field-1\"\r\n      }\r\n    ],\r\n    \"package\": \"all\",\r\n    \"updated_at\": \"2023-09-30T13:35:17.000000Z\",\r\n    \"created_at\": \"2023-09-30T13:35:17.000000Z\",\r\n    \"id\": 3\r\n  }\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestTrashedCustomTemplates.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTrashedCustomTemplates()
        {
            // Parameters for the API call
            int userId = 1;

            // Perform API call
            Standard.Models.TrashedCustomTemplates result = null;
            try
            {
                result = await this.controller.TrashedCustomTemplatesAsync(userId);
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
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Data Fatched Successfully\",\r\n  \"data\": []\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestDeleteCustomTemplate.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestDeleteCustomTemplate()
        {
            // Parameters for the API call
            int userId = 1;
            int templateId = 3;

            // Perform API call
            Standard.Models.DeleteCustomTemplate result = null;
            try
            {
                result = await this.controller.DeleteCustomTemplateAsync(userId, templateId);
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
        /// TestRestoreCustomTemplate.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestRestoreCustomTemplate()
        {
            // Parameters for the API call
            int userId = 1;
            int templateId = 3;

            // Perform API call
            Standard.Models.RestoreCustomTemplate result = null;
            try
            {
                result = await this.controller.RestoreCustomTemplateAsync(userId, templateId);
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
        /// TestPermanentDeleteCustomTemplate.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestPermanentDeleteCustomTemplate()
        {
            // Perform API call
            Standard.Models.PermanentDeleteCustomTemplate result = null;
            try
            {
                result = await this.controller.PermanentDeleteCustomTemplateAsync();
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
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Delete Successfully\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}