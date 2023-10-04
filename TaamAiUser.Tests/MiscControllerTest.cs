// <copyright file="MiscControllerTest.cs" company="APIMatic">
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
    /// MiscControllerTest.
    /// </summary>
    [TestFixture]
    public class MiscControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private MiscController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.MiscController;
        }

        /// <summary>
        /// TestAllCategories.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestAllCategories()
        {
            // Parameters for the API call
            int userId = 40;

            // Perform API call
            try
            {
                await this.controller.AllCategoriesAsync(userId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestNewRequest.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestNewRequest()
        {
            // Perform API call
            try
            {
                await this.controller.NewRequestAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }
    }
}