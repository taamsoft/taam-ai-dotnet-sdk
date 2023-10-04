// <copyright file="ChatWithPdfControllerTest.cs" company="APIMatic">
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
    /// ChatWithPdfControllerTest.
    /// </summary>
    [TestFixture]
    public class ChatWithPdfControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private ChatWithPdfController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.ChatWithPdfController;
        }

        /// <summary>
        /// TestSendAndGetMsgToChatPdf.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSendAndGetMsgToChatPdf()
        {
            // Parameters for the API call
            string question = "what is the education";

            // Perform API call
            try
            {
                await this.controller.SendAndGetMsgToChatPdfAsync(question);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestAnswerTheQuestion.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestAnswerTheQuestion()
        {
            // Perform API call
            try
            {
                await this.controller.AnswerTheQuestionAsync();
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
            // Parameters for the API call
            string question = "what data this file contains";
            string path = "assets/pdf/64ef458eabc4e_Soban-Shahid (Laravel).pdf";

            // Perform API call
            try
            {
                await this.controller.NewRequestAsync(question, path);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");
        }
    }
}