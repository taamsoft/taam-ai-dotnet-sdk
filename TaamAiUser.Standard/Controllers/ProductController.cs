// <copyright file="ProductController.cs" company="APIMatic">
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
    /// ProductController.
    /// </summary>
    public class ProductController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductController"/> class.
        /// </summary>
        internal ProductController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// User Productd EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.UserProductd response from the API call.</returns>
        public Models.UserProductd UserProductd(
                int userId)
            => CoreHelper.RunTask(UserProductdAsync(userId));

        /// <summary>
        /// User Productd EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserProductd response from the API call.</returns>
        public async Task<Models.UserProductd> UserProductdAsync(
                int userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserProductd>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/products")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Trashed Products EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.TrashedProducts response from the API call.</returns>
        public Models.TrashedProducts TrashedProducts(
                int userId)
            => CoreHelper.RunTask(TrashedProductsAsync(userId));

        /// <summary>
        /// Trashed Products EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TrashedProducts response from the API call.</returns>
        public async Task<Models.TrashedProducts> TrashedProductsAsync(
                int userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TrashedProducts>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/products/trashed")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Create Product EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="description">Required parameter: Example: .</param>
        /// <param name="bulletPoints">Required parameter: Example: .</param>
        /// <param name="targetAudience">Required parameter: Example: .</param>
        /// <param name="tags0">Required parameter: Example: .</param>
        /// <param name="tags1">Required parameter: Example: .</param>
        /// <returns>Returns the Models.CreateProduct response from the API call.</returns>
        public Models.CreateProduct CreateProduct(
                int userId,
                string name,
                string description,
                string bulletPoints,
                string targetAudience,
                string tags0,
                string tags1)
            => CoreHelper.RunTask(CreateProductAsync(userId, name, description, bulletPoints, targetAudience, tags0, tags1));

        /// <summary>
        /// Create Product EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="description">Required parameter: Example: .</param>
        /// <param name="bulletPoints">Required parameter: Example: .</param>
        /// <param name="targetAudience">Required parameter: Example: .</param>
        /// <param name="tags0">Required parameter: Example: .</param>
        /// <param name="tags1">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreateProduct response from the API call.</returns>
        public async Task<Models.CreateProduct> CreateProductAsync(
                int userId,
                string name,
                string description,
                string bulletPoints,
                string targetAudience,
                string tags0,
                string tags1,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreateProduct>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/products/create")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Form(_form => _form.Setup("user_id", userId))
                      .Form(_form => _form.Setup("name", name))
                      .Form(_form => _form.Setup("description", description))
                      .Form(_form => _form.Setup("bullet_points", bulletPoints))
                      .Form(_form => _form.Setup("target_audience", targetAudience))
                      .Form(_form => _form.Setup("tags[0]", tags0))
                      .Form(_form => _form.Setup("tags[1]", tags1))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Delete Product EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.DeleteProduct response from the API call.</returns>
        public Models.DeleteProduct DeleteProduct(
                int userId,
                int productId)
            => CoreHelper.RunTask(DeleteProductAsync(userId, productId));

        /// <summary>
        /// Delete Product EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DeleteProduct response from the API call.</returns>
        public async Task<Models.DeleteProduct> DeleteProductAsync(
                int userId,
                int productId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeleteProduct>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/products/delete")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("product_id", productId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Restore Product EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.RestoreProduct response from the API call.</returns>
        public Models.RestoreProduct RestoreProduct(
                int userId,
                int productId)
            => CoreHelper.RunTask(RestoreProductAsync(userId, productId));

        /// <summary>
        /// Restore Product EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RestoreProduct response from the API call.</returns>
        public async Task<Models.RestoreProduct> RestoreProductAsync(
                int userId,
                int productId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RestoreProduct>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/products/restore")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("product_id", productId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// parmenent delete Product EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.NewRequest1 response from the API call.</returns>
        public Models.NewRequest1 ParmenentDeleteProduct(
                int userId,
                int productId)
            => CoreHelper.RunTask(ParmenentDeleteProductAsync(userId, productId));

        /// <summary>
        /// parmenent delete Product EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.NewRequest1 response from the API call.</returns>
        public async Task<Models.NewRequest1> ParmenentDeleteProductAsync(
                int userId,
                int productId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.NewRequest1>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/products/permanent-delete")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("product_id", productId))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Update Product EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="description">Required parameter: Example: .</param>
        /// <param name="bulletPoints">Required parameter: Example: .</param>
        /// <param name="targetAudience">Required parameter: Example: .</param>
        /// <param name="tags0">Required parameter: Example: .</param>
        /// <returns>Returns the Models.UpdateProduct response from the API call.</returns>
        public Models.UpdateProduct UpdateProduct(
                int userId,
                int productId,
                string name,
                string description,
                int bulletPoints,
                string targetAudience,
                string tags0)
            => CoreHelper.RunTask(UpdateProductAsync(userId, productId, name, description, bulletPoints, targetAudience, tags0));

        /// <summary>
        /// Update Product EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="description">Required parameter: Example: .</param>
        /// <param name="bulletPoints">Required parameter: Example: .</param>
        /// <param name="targetAudience">Required parameter: Example: .</param>
        /// <param name="tags0">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UpdateProduct response from the API call.</returns>
        public async Task<Models.UpdateProduct> UpdateProductAsync(
                int userId,
                int productId,
                string name,
                string description,
                int bulletPoints,
                string targetAudience,
                string tags0,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UpdateProduct>()
              .Server(Server.Server2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/products/update")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("user_id", userId))
                      .Query(_query => _query.Setup("product_id", productId))
                      .Query(_query => _query.Setup("name", name))
                      .Query(_query => _query.Setup("description", description))
                      .Query(_query => _query.Setup("bullet_points", bulletPoints))
                      .Query(_query => _query.Setup("target_audience", targetAudience))
                      .Query(_query => _query.Setup("tags[0]", tags0))))
              .ExecuteAsync(cancellationToken);
    }
}