// <copyright file="ExampleWithDefaultPlanSubdomainAndSubsctpion.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace TaamAiUser.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using TaamAiUser.Standard;
    using TaamAiUser.Standard.Utilities;

    /// <summary>
    /// ExampleWithDefaultPlanSubdomainAndSubsctpion.
    /// </summary>
    public class ExampleWithDefaultPlanSubdomainAndSubsctpion
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleWithDefaultPlanSubdomainAndSubsctpion"/> class.
        /// </summary>
        public ExampleWithDefaultPlanSubdomainAndSubsctpion()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleWithDefaultPlanSubdomainAndSubsctpion"/> class.
        /// </summary>
        /// <param name="result">result.</param>
        /// <param name="message">message.</param>
        /// <param name="accessToken">access_token.</param>
        /// <param name="user">user.</param>
        public ExampleWithDefaultPlanSubdomainAndSubsctpion(
            bool result,
            string message,
            string accessToken,
            Models.User2 user)
        {
            this.Result = result;
            this.Message = message;
            this.AccessToken = accessToken;
            this.User = user;
        }

        /// <summary>
        /// Gets or sets Result.
        /// </summary>
        [JsonProperty("result")]
        public bool Result { get; set; }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets AccessToken.
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets User.
        /// </summary>
        [JsonProperty("user")]
        public Models.User2 User { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ExampleWithDefaultPlanSubdomainAndSubsctpion : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is ExampleWithDefaultPlanSubdomainAndSubsctpion other &&                this.Result.Equals(other.Result) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                ((this.AccessToken == null && other.AccessToken == null) || (this.AccessToken?.Equals(other.AccessToken) == true)) &&
                ((this.User == null && other.User == null) || (this.User?.Equals(other.User) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Result = {this.Result}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message)}");
            toStringOutput.Add($"this.AccessToken = {(this.AccessToken == null ? "null" : this.AccessToken)}");
            toStringOutput.Add($"this.User = {(this.User == null ? "null" : this.User.ToString())}");
        }
    }
}