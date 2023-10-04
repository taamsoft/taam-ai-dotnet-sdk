// <copyright file="AuthControllerTest.cs" company="APIMatic">
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
    /// AuthControllerTest.
    /// </summary>
    [TestFixture]
    public class AuthControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private AuthController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.AuthController;
        }

        /// <summary>
        /// TestLogin.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestLogin()
        {
            // Parameters for the API call
            string email = "sobanshahid47@gmail.com";
            string password = "ali112233";

            // Perform API call
            Standard.Models.Login result = null;
            try
            {
                result = await this.controller.LoginAsync(email, password);
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
                    "{\r\n  \"status\": true,\r\n  \"message\": \"Successfully logged in\",\r\n  \"access_token\": \"6|b6WIe6smnjl2dP0Yulzu8TsQnr6UtAV2SmtiKj3V\",\r\n  \"token_type\": \"Bearer\",\r\n  \"expires_at\": null,\r\n  \"user\": {\r\n    \"id\": 20,\r\n    \"name\": \"soban\",\r\n    \"job_role\": \"Happy Person\",\r\n    \"email\": \"sobanshahid47@gmail.com\",\r\n    \"subdomain\": null,\r\n    \"email_verified_at\": \"2023-09-19T12:22:43.000000Z\",\r\n    \"status\": \"active\",\r\n    \"group\": \"subscriber\",\r\n    \"workbook\": \"default workbook\",\r\n    \"workbook_id\": 21,\r\n    \"workbook_folder_id\": 26,\r\n    \"product_id\": 0,\r\n    \"plan_id\": 3,\r\n    \"plan_type\": null,\r\n    \"company\": null,\r\n    \"website\": null,\r\n    \"phone_number\": null,\r\n    \"address\": null,\r\n    \"city\": null,\r\n    \"postal_code\": null,\r\n    \"country\": \"pakistan\",\r\n    \"available_words\": 11,\r\n    \"available_words_prepaid\": 1000,\r\n    \"total_words\": 11,\r\n    \"available_images\": 11,\r\n    \"available_images_prepaid\": 1000,\r\n    \"total_images\": 11,\r\n    \"balance\": 0,\r\n    \"total_chars\": 0,\r\n    \"available_chars\": 0,\r\n    \"available_chars_prepaid\": 1000,\r\n    \"total_minutes\": \"0.000\",\r\n    \"available_minutes\": \"0.000\",\r\n    \"available_minutes_prepaid\": \"10.000\",\r\n    \"profile_photo_path\": null,\r\n    \"oauth_id\": null,\r\n    \"oauth_type\": null,\r\n    \"last_seen\": null,\r\n    \"member_role\": 0,\r\n    \"parent_id\": 0,\r\n    \"ckbox\": null,\r\n    \"google2fa_secret\": null,\r\n    \"google2fa_enabled\": 0,\r\n    \"referral_id\": \"EGUYLK7WC4DNMQU\",\r\n    \"referred_by\": \"\",\r\n    \"referral_payment_method\": null,\r\n    \"referral_paypal\": null,\r\n    \"referral_bank_requisites\": null,\r\n    \"default_voiceover_language\": \"en-US\",\r\n    \"default_temp_language\": 0,\r\n    \"default_voiceover_voice\": \"en-US-Wavenet-J\",\r\n    \"default_tone\": null,\r\n    \"subdomain_token\": null,\r\n    \"created_at\": \"2023-09-19T12:22:43.000000Z\",\r\n    \"updated_at\": \"2023-09-19T12:22:43.000000Z\"\r\n  }\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestLogin1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestLogin1()
        {
            // Parameters for the API call
            string email = "sobanshahid47@gmail.com";
            string password = "ali112233";

            // Perform API call
            Standard.Models.Login result = null;
            try
            {
                result = await this.controller.LoginAsync(email, password);
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
            headers.Add("Transfer-Encoding", null);
            headers.Add("pragma", null);
            headers.Add("expires", null);
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
                    "{\r\n  \"status\": true,\r\n  \"message\": \"Successfully logged in\",\r\n  \"access_token\": \"3|5ek7yEVxDwqMgKRmJSBRhj1z0kNcSfC52EPpix04\",\r\n  \"token_type\": \"Bearer\",\r\n  \"expires_at\": null,\r\n  \"user\": {\r\n    \"id\": 40,\r\n    \"name\": \"soban\",\r\n    \"job_role\": \"Happy Person\",\r\n    \"email\": \"sobanshahid47@gmail.com\",\r\n    \"email_verified_at\": \"2023-09-22T07:21:12.000000Z\",\r\n    \"status\": \"active\",\r\n    \"subdomain\": null,\r\n    \"group\": \"subscriber\",\r\n    \"workbook\": \"default workbook\",\r\n    \"workbook_id\": 38,\r\n    \"workbook_folder_id\": 43,\r\n    \"product_id\": 0,\r\n    \"plan_id\": 1,\r\n    \"plan_type\": null,\r\n    \"company\": null,\r\n    \"website\": null,\r\n    \"phone_number\": null,\r\n    \"address\": null,\r\n    \"city\": null,\r\n    \"postal_code\": null,\r\n    \"country\": \"pakistan\",\r\n    \"available_words\": 20400,\r\n    \"available_words_prepaid\": 100000,\r\n    \"total_words\": 20400,\r\n    \"available_images\": 10000,\r\n    \"available_images_prepaid\": 100000,\r\n    \"total_images\": 10000,\r\n    \"balance\": 0,\r\n    \"total_chars\": 16600,\r\n    \"available_chars\": 16600,\r\n    \"available_chars_prepaid\": 1000,\r\n    \"total_minutes\": \"200.000\",\r\n    \"available_minutes\": \"200.000\",\r\n    \"available_minutes_prepaid\": \"10.000\",\r\n    \"profile_photo_path\": null,\r\n    \"oauth_id\": null,\r\n    \"oauth_type\": null,\r\n    \"last_seen\": null,\r\n    \"member_role\": 0,\r\n    \"parent_id\": 0,\r\n    \"ckbox\": null,\r\n    \"google2fa_secret\": null,\r\n    \"google2fa_enabled\": 0,\r\n    \"referral_id\": \"LCPFKIBCE7IEUGY\",\r\n    \"referred_by\": \"\",\r\n    \"referral_payment_method\": null,\r\n    \"referral_paypal\": null,\r\n    \"referral_bank_requisites\": null,\r\n    \"default_tone\": null,\r\n    \"default_voiceover_language\": \"en-US\",\r\n    \"default_temp_language\": 0,\r\n    \"default_voiceover_voice\": \"sk-SK-Wavenet-A\",\r\n    \"subdomain_token\": null,\r\n    \"created_at\": \"2023-09-22T07:21:12.000000Z\",\r\n    \"updated_at\": \"2023-09-22T07:21:13.000000Z\"\r\n  }\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestRegister.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestRegister()
        {
            // Parameters for the API call
            string name = "soban";
            string email = "sobanshahid47@gmail.com";
            string password = "ali112233";
            string country = "pakistan";
            string subdomain = "friend";

            // Perform API call
            Standard.Models.ExampleWithDefaultPlanSubdomainAndSubsctpion result = null;
            try
            {
                result = await this.controller.RegisterAsync(name, email, password, country, subdomain);
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
                    "{\r\n  \"result\": true,\r\n  \"message\": \"Registration Successful. Please verify and log in to your account.\",\r\n  \"access_token\": \"5|78sPFuxgmVpMEE7n9cbNfCsKHRkLOgWngwirWZh1\",\r\n  \"user\": {\r\n    \"name\": \"soban\",\r\n    \"email\": \"sobanshahid47@gmail.com\",\r\n    \"country\": \"pakistan\",\r\n    \"updated_at\": \"2023-09-19T12:22:43.000000Z\",\r\n    \"created_at\": \"2023-09-19T12:22:43.000000Z\",\r\n    \"id\": 20,\r\n    \"email_verified_at\": \"2023-09-19T12:22:43.000000Z\",\r\n    \"status\": \"active\",\r\n    \"group\": \"subscriber\",\r\n    \"available_words_prepaid\": \"1000\",\r\n    \"available_images_prepaid\": \"1000\",\r\n    \"available_chars_prepaid\": \"1000\",\r\n    \"available_minutes_prepaid\": \"10\",\r\n    \"default_voiceover_language\": \"en-US\",\r\n    \"default_voiceover_voice\": \"en-US-Wavenet-J\",\r\n    \"job_role\": \"Happy Person\",\r\n    \"referral_id\": \"EGUYLK7WC4DNMQU\",\r\n    \"referred_by\": \"\",\r\n    \"workbook\": \"default workbook\",\r\n    \"workbook_id\": 21,\r\n    \"workbook_folder_id\": 26,\r\n    \"plan_id\": 3,\r\n    \"total_words\": 11,\r\n    \"total_images\": 11,\r\n    \"total_chars\": 0,\r\n    \"total_minutes\": 0,\r\n    \"available_words\": 11,\r\n    \"available_images\": 11,\r\n    \"available_chars\": 0,\r\n    \"available_minutes\": 0,\r\n    \"roles\": [\r\n      {\r\n        \"id\": 2,\r\n        \"name\": \"subscriber\",\r\n        \"guard_name\": \"web\",\r\n        \"created_at\": \"2023-07-06T13:33:48.000000Z\",\r\n        \"updated_at\": \"2023-07-06T13:33:48.000000Z\",\r\n        \"pivot\": {\r\n          \"model_id\": 20,\r\n          \"role_id\": 2,\r\n          \"model_type\": \"App\\\\Models\\\\User\"\r\n        }\r\n      }\r\n    ]\r\n  }\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestRegister1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestRegister1()
        {
            // Parameters for the API call
            string name = "soban";
            string email = "sobanshahid47@gmail.com";
            string password = "ali112233";
            string country = "pakistan";
            string subdomain = "friend";

            // Perform API call
            Standard.Models.ExampleWithDefaultPlanSubdomainAndSubsctpion result = null;
            try
            {
                result = await this.controller.RegisterAsync(name, email, password, country, subdomain);
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
            headers.Add("Transfer-Encoding", null);
            headers.Add("pragma", null);
            headers.Add("expires", null);
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
                    "{\r\n  \"result\": true,\r\n  \"message\": \"Registration Successful. Please verify and log in to your account.\",\r\n  \"access_token\": \"2|QYrP7Acc8uWlie97NREzfG2gmueJf8nSXtAWtoMM\",\r\n  \"user\": {\r\n    \"name\": \"soban\",\r\n    \"email\": \"sobanshahid47@gmail.com\",\r\n    \"country\": \"pakistan\",\r\n    \"updated_at\": \"2023-09-22T07:21:13.000000Z\",\r\n    \"created_at\": \"2023-09-22T07:21:12.000000Z\",\r\n    \"id\": 40,\r\n    \"email_verified_at\": \"2023-09-22T07:21:12.000000Z\",\r\n    \"status\": \"active\",\r\n    \"group\": \"subscriber\",\r\n    \"available_words_prepaid\": \"100000\",\r\n    \"available_images_prepaid\": \"100000\",\r\n    \"available_chars_prepaid\": \"1000\",\r\n    \"available_minutes_prepaid\": \"10\",\r\n    \"default_voiceover_language\": \"en-US\",\r\n    \"default_voiceover_voice\": \"sk-SK-Wavenet-A\",\r\n    \"job_role\": \"Happy Person\",\r\n    \"referral_id\": \"LCPFKIBCE7IEUGY\",\r\n    \"referred_by\": \"\",\r\n    \"workbook\": \"default workbook\",\r\n    \"workbook_id\": 38,\r\n    \"workbook_folder_id\": 43,\r\n    \"plan_id\": 1,\r\n    \"total_words\": 20400,\r\n    \"total_images\": 10000,\r\n    \"total_chars\": 16600,\r\n    \"total_minutes\": 200,\r\n    \"available_words\": 20400,\r\n    \"available_images\": 10000,\r\n    \"available_chars\": 16600,\r\n    \"available_minutes\": 200,\r\n    \"roles\": [\r\n      {\r\n        \"id\": 2,\r\n        \"name\": \"subscriber\",\r\n        \"guard_name\": \"web\",\r\n        \"created_at\": \"2023-07-06T08:33:48.000000Z\",\r\n        \"updated_at\": \"2023-07-06T08:33:48.000000Z\",\r\n        \"pivot\": {\r\n          \"model_id\": 40,\r\n          \"role_id\": 2,\r\n          \"model_type\": \"App\\\\Models\\\\User\"\r\n        }\r\n      }\r\n    ]\r\n  }\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}