// <copyright file="ProductControllerTest.cs" company="APIMatic">
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
    /// ProductControllerTest.
    /// </summary>
    [TestFixture]
    public class ProductControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private ProductController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.ProductController;
        }

        /// <summary>
        /// TestUserProductd.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUserProductd()
        {
            // Parameters for the API call
            int userId = 1;

            // Perform API call
            Standard.Models.UserProductd result = null;
            try
            {
                result = await this.controller.UserProductdAsync(userId);
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
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Data fateched Successfully\",\r\n  \"data\": [\r\n    {\r\n      \"id\": 4,\r\n      \"user_id\": 1,\r\n      \"name\": \"Programming new\",\r\n      \"description\": \"Get your code\",\r\n      \"feature_image\": \"assets/product_feature/64a71a7d35b1c_image.png\",\r\n      \"bullet_points\": \"55\",\r\n      \"target_audience\": \"55\",\r\n      \"tags\": \"[\\\"sdffddf\\\",\\\"dfgfhjhk\\\",\\\"dfghjk\\\"]\",\r\n      \"deleted_at\": null\r\n    },\r\n    {\r\n      \"id\": 5,\r\n      \"user_id\": 11,\r\n      \"name\": \"shahzaman\",\r\n      \"description\": \"detail about shahzaman\",\r\n      \"feature_image\": null,\r\n      \"bullet_points\": \"55\",\r\n      \"target_audience\": \"55\",\r\n      \"tags\": null,\r\n      \"deleted_at\": null\r\n    },\r\n    {\r\n      \"id\": 6,\r\n      \"user_id\": 0,\r\n      \"name\": \"MATGARLI SAAS\",\r\n      \"description\": \"matgarli saas applcation help the vendors to  create online store in one click , the veondors can sell any kind of products\",\r\n      \"feature_image\": \"https://www.taamfly.com/assets/empty.jpg\",\r\n      \"bullet_points\": \"55\",\r\n      \"target_audience\": \"vendors , sellers\",\r\n      \"tags\": \"[\\\"vendors\\\",\\\"sellers\\\"]\",\r\n      \"deleted_at\": null\r\n    },\r\n    {\r\n      \"id\": 7,\r\n      \"user_id\": 0,\r\n      \"name\": \"asdas\",\r\n      \"description\": \"sdfsdfsd\",\r\n      \"feature_image\": \"https://taamfly.com/assets/empty.jpg\",\r\n      \"bullet_points\": \"1321\",\r\n      \"target_audience\": \"dfdsgsd\",\r\n      \"tags\": \"[\\\"asdas\\\"]\",\r\n      \"deleted_at\": null\r\n    },\r\n    {\r\n      \"id\": 8,\r\n      \"user_id\": 0,\r\n      \"name\": \"new\",\r\n      \"description\": \"new\",\r\n      \"feature_image\": \"https://taamfly.com/assets/empty.jpg\",\r\n      \"bullet_points\": \"32321\",\r\n      \"target_audience\": \"dfdsgsd\",\r\n      \"tags\": \"[\\\"asd\\\"]\",\r\n      \"deleted_at\": null\r\n    },\r\n    {\r\n      \"id\": 9,\r\n      \"user_id\": 1,\r\n      \"name\": \"truth smokeshop and vape\",\r\n      \"description\": \"The top smoke shop and vapes and the best customer support. Shop for bongs, dab rigs, hand pipes, vaporizers and other smoking accessories.\",\r\n      \"feature_image\": \"assets/product_feature/64b89f965465f_Truth.png\",\r\n      \"bullet_points\": \"asdas\",\r\n      \"target_audience\": \"all\",\r\n      \"tags\": \"[\\\"vapes\\\",\\\"tobacco\\\"]\",\r\n      \"deleted_at\": null\r\n    }\r\n  ]\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestTrashedProducts.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTrashedProducts()
        {
            // Parameters for the API call
            int userId = 1;

            // Perform API call
            Standard.Models.TrashedProducts result = null;
            try
            {
                result = await this.controller.TrashedProductsAsync(userId);
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
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Data fateched Successfully\",\r\n  \"data\": [\r\n    {\r\n      \"id\": 10,\r\n      \"user_id\": 1,\r\n      \"name\": \"New Product\",\r\n      \"description\": \"THis is testing\",\r\n      \"feature_image\": \"http://127.0.0.1:8000/assets/empty.jpg\",\r\n      \"bullet_points\": \"friend\",\r\n      \"target_audience\": \"males\",\r\n      \"tags\": \"null\",\r\n      \"deleted_at\": \"2023-09-30T08:18:41.000000Z\"\r\n    }\r\n  ]\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestCreateProduct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestCreateProduct()
        {
            // Parameters for the API call
            int userId = 1;
            string name = "New Product";
            string description = "THis is testing";
            string bulletPoints = "friend";
            string targetAudience = "males";
            string tags0 = "hello";
            string tags1 = "friend";

            // Perform API call
            Standard.Models.CreateProduct result = null;
            try
            {
                result = await this.controller.CreateProductAsync(userId, name, description, bulletPoints, targetAudience, tags0, tags1);
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
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Product Created Successfully\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestDeleteProduct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestDeleteProduct()
        {
            // Parameters for the API call
            int userId = 1;
            int productId = 10;

            // Perform API call
            Standard.Models.DeleteProduct result = null;
            try
            {
                result = await this.controller.DeleteProductAsync(userId, productId);
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
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Product Deleted Successfully\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestRestoreProduct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestRestoreProduct()
        {
            // Parameters for the API call
            int userId = 1;
            int productId = 10;

            // Perform API call
            Standard.Models.RestoreProduct result = null;
            try
            {
                result = await this.controller.RestoreProductAsync(userId, productId);
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
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Product Restored Successfully\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestParmenentDeleteProduct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestParmenentDeleteProduct()
        {
            // Parameters for the API call
            int userId = 1;
            int productId = 10;

            // Perform API call
            Standard.Models.NewRequest1 result = null;
            try
            {
                result = await this.controller.ParmenentDeleteProductAsync(userId, productId);
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
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Product Deleted Permanently\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TestUpdateProduct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestUpdateProduct()
        {
            // Parameters for the API call
            int userId = 1;
            int productId = 11;
            string name = "updated";
            string description = "updated";
            int bulletPoints = 11;
            string targetAudience = "females";
            string tags0 = "new";

            // Perform API call
            Standard.Models.UpdateProduct result = null;
            try
            {
                result = await this.controller.UpdateProductAsync(userId, productId, name, description, bulletPoints, targetAudience, tags0);
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
                    "{\r\n  \"status\": \"success\",\r\n  \"message\": \"Product Updated Successfully\"\r\n}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}