// <copyright file="AddonFeaturesControllerTest.cs" company="APIMatic">
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
    /// AddonFeaturesControllerTest.
    /// </summary>
    [TestFixture]
    public class AddonFeaturesControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private AddonFeaturesController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.AddonFeaturesController;
        }

        /// <summary>
        /// TestGenerateCode.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGenerateCode()
        {
            // Parameters for the API call
            string language = "php";
            string instructions = "generate a code to store image";
            string document = "new checking";
            int userId = 1;

            // Perform API call
            Standard.Models.GenerateCode result = null;
            try
            {
                result = await this.controller.GenerateCodeAsync(language, instructions, document, userId);
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
                    "{\r\n  \"text\": \"Sure, Here's a basic PHP script to upload an image to a server. This code assumes that you have a form in HTML that allows users to choose the image they want to upload.\\n\\n```php\\n<?php\\n   if(isset($_POST['submit'])){\\n      $errors= array();\\n      $file_name = $_FILES['image']['name'];\\n      $file_size = $_FILES['image']['size'];\\n      $file_tmp = $_FILES['image']['tmp_name'];\\n      $file_type = $_FILES['image']['type'];\\n      $file_ext = strtolower(pathinfo($file_name, PATHINFO_EXTENSION));\\n\\n      $extensions= array(\\\"jpeg\\\",\\\"jpg\\\",\\\"png\\\");\\n\\n      if(in_array($file_ext,$extensions) === false){\\n         $errors[]=\\\"extension not allowed, please choose a JPEG or PNG file.\\\";\\n      }\\n\\n      if($file_size > 2097152){\\n         $errors[]='File size must be less than 2 MB';\\n      }\\n\\n      if(empty($errors) == true){\\n         move_uploaded_file($file_tmp,\\\"images/\\\".$file_name);\\n         echo \\\"Image Successfully Uploaded!\\\";\\n      } else {\\n         print_r($errors);\\n      }\\n   }\\n?>\\n```\\n\\nThis code checks if the image has the correct filetype and file size less than 2MB. If all conditions are correct, it uploads the image file to the \\\"images\\\" directory. Else, it prints out the corresponding errors.\\n\\nYou will also need a HTML form as below:\\n\\n```html\\n<form action = \\\"\\\" method = \\\"POST\\\" enctype = \\\"multipart/form-data\\\">\\n     <input type = \\\"file\\\" name = \\\"image\\\" />\\n     <input type = \\\"submit\\\" name = \\\"submit\\\"/>\\n</form>\\n```\\nThis form should be placed in the same PHP file above. \\n\\nPlease remember to create the directory where the image file will be saved if it doesn't exist yet. Make sure that its permissions allow the web server to write files.\",\r\n  \"status\": \"success\",\r\n  \"id\": 31,\r\n  \"old\": \"10000000\",\r\n  \"current\": 9999572\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestSaveCodeInWorkspace.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSaveCodeInWorkspace()
        {
            // Parameters for the API call
            int workbookId = 1;
            int userId = 1;
            int folderId = 1;
            int codeId = 32;

            // Perform API call
            Standard.Models.SaveCodeInWorkspace result = null;
            try
            {
                result = await this.controller.SaveCodeInWorkspaceAsync(workbookId, userId, folderId, codeId);
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
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Code Saved Successfully\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestGenerateImageFromAI.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestGenerateImageFromAI()
        {
            // Parameters for the API call
            int userId = 1;
            string name = "sample checking";
            string title = "need a eagle image";
            int workbookId = 1;
            int workbookFolderId = 1;
            int maxResults = 1;
            string resolution = "256x256";

            // Perform API call
            Standard.Models.GenerateImageFromAI result = null;
            try
            {
                result = await this.controller.GenerateImageFromAIAsync(userId, name, title, workbookId, workbookFolderId, maxResults, resolution);
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
                    "{\r\n  \"status\": \"success\",\r\n  \"old\": \"10000000\",\r\n  \"current\": 9999999,\r\n  \"data\": {\r\n    \"user_id\": 1,\r\n    \"name\": \"sample checking\",\r\n    \"description\": \"need a eagle image\",\r\n    \"resolution\": \"256x256\",\r\n    \"image\": \"assets/images/65156efb84c6c_3\",\r\n    \"plan_type\": \"paid\",\r\n    \"storage\": \"local\",\r\n    \"expires_at\": \"2073-09-15T12:18:03.545504Z\",\r\n    \"image_name\": \"images/ix3Y9KswvE.png\",\r\n    \"workbook_id\": \"1\",\r\n    \"workbook_folder_id\": \"1\",\r\n    \"updated_at\": \"2023-09-28T12:18:03.000000Z\",\r\n    \"created_at\": \"2023-09-28T12:18:03.000000Z\",\r\n    \"id\": 92,\r\n    \"image_url\": \"http://127.0.0.1:8000/assets/images/65156efb84c6c_3\"\r\n  }\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestSaveTranscript.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSaveTranscript()
        {
            // Parameters for the API call
            int userId = 1;
            string title = "New task";
            int transcriptId = 43;
            string text = "Marhaban, ana al-mutahaddithi al-iftiradi min imza'i al-jawda. Da'ani ulqi al-tahiyyata ala jumhourik wa u'arrifahom ala muntajatik abra wasilatin min akthar al-wasaili al-taswiqiya, tashwiqan wa mut'a.\",\n    \"status\": \"success";
            int workbookId = 1;
            int workbookFolderId = 1;

            // Perform API call
            Standard.Models.SaveTranscript result = null;
            try
            {
                result = await this.controller.SaveTranscriptAsync(userId, title, transcriptId, text, workbookId, workbookFolderId);
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
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Transcript saved successfully\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}