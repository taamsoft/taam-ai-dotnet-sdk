# Product

```csharp
ProductController productController = client.ProductController;
```

## Class Name

`ProductController`

## Methods

* [User Productd](../../doc/controllers/product.md#user-productd)
* [Trashed Products](../../doc/controllers/product.md#trashed-products)
* [Create Product](../../doc/controllers/product.md#create-product)
* [Delete Product](../../doc/controllers/product.md#delete-product)
* [Restore Product](../../doc/controllers/product.md#restore-product)
* [Parmenent Delete Product](../../doc/controllers/product.md#parmenent-delete-product)
* [Update Product](../../doc/controllers/product.md#update-product)


# User Productd

```csharp
UserProductdAsync(
    int userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `int` | Query, Required | - |

## Response Type

[`Task<Models.UserProductd>`](../../doc/models/user-productd.md)

## Example Usage

```csharp
int userId = 1;
try
{
    UserProductd result = await productController.UserProductdAsync(userId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "status": "success",
  "message": "Data fateched Successfully",
  "data": [
    {
      "id": 4,
      "user_id": 1,
      "name": "Programming new",
      "description": "Get your code",
      "feature_image": "assets/product_feature/64a71a7d35b1c_image.png",
      "bullet_points": "55",
      "target_audience": "55",
      "tags": "[\"sdffddf\",\"dfgfhjhk\",\"dfghjk\"]",
      "deleted_at": null
    },
    {
      "id": 5,
      "user_id": 11,
      "name": "shahzaman",
      "description": "detail about shahzaman",
      "feature_image": null,
      "bullet_points": "55",
      "target_audience": "55",
      "tags": null,
      "deleted_at": null
    },
    {
      "id": 6,
      "user_id": 0,
      "name": "MATGARLI SAAS",
      "description": "matgarli saas applcation help the vendors to  create online store in one click , the veondors can sell any kind of products",
      "feature_image": "https://www.taamfly.com/assets/empty.jpg",
      "bullet_points": "55",
      "target_audience": "vendors , sellers",
      "tags": "[\"vendors\",\"sellers\"]",
      "deleted_at": null
    },
    {
      "id": 7,
      "user_id": 0,
      "name": "asdas",
      "description": "sdfsdfsd",
      "feature_image": "https://taamfly.com/assets/empty.jpg",
      "bullet_points": "1321",
      "target_audience": "dfdsgsd",
      "tags": "[\"asdas\"]",
      "deleted_at": null
    },
    {
      "id": 8,
      "user_id": 0,
      "name": "new",
      "description": "new",
      "feature_image": "https://taamfly.com/assets/empty.jpg",
      "bullet_points": "32321",
      "target_audience": "dfdsgsd",
      "tags": "[\"asd\"]",
      "deleted_at": null
    },
    {
      "id": 9,
      "user_id": 1,
      "name": "truth smokeshop and vape",
      "description": "The top smoke shop and vapes and the best customer support. Shop for bongs, dab rigs, hand pipes, vaporizers and other smoking accessories.",
      "feature_image": "assets/product_feature/64b89f965465f_Truth.png",
      "bullet_points": "asdas",
      "target_audience": "all",
      "tags": "[\"vapes\",\"tobacco\"]",
      "deleted_at": null
    }
  ]
}
```


# Trashed Products

```csharp
TrashedProductsAsync(
    int userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `int` | Query, Required | - |

## Response Type

[`Task<Models.TrashedProducts>`](../../doc/models/trashed-products.md)

## Example Usage

```csharp
int userId = 1;
try
{
    TrashedProducts result = await productController.TrashedProductsAsync(userId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "status": "success",
  "message": "Data fateched Successfully",
  "data": [
    {
      "id": 10,
      "user_id": 1,
      "name": "New Product",
      "description": "THis is testing",
      "feature_image": "http://127.0.0.1:8000/assets/empty.jpg",
      "bullet_points": "friend",
      "target_audience": "males",
      "tags": "null",
      "deleted_at": "2023-09-30T08:18:41.000000Z"
    }
  ]
}
```


# Create Product

```csharp
CreateProductAsync(
    int userId,
    string name,
    string description,
    string bulletPoints,
    string targetAudience,
    string tags0,
    string tags1)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `int` | Form, Required | - |
| `name` | `string` | Form, Required | - |
| `description` | `string` | Form, Required | - |
| `bulletPoints` | `string` | Form, Required | - |
| `targetAudience` | `string` | Form, Required | - |
| `tags0` | `string` | Form, Required | - |
| `tags1` | `string` | Form, Required | - |

## Response Type

[`Task<Models.CreateProduct>`](../../doc/models/create-product.md)

## Example Usage

```csharp
int userId = 1;
string name = "New Product";
string description = "THis is testing";
string bulletPoints = "friend";
string targetAudience = "males";
Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')try
{
    CreateProduct result = await productController.CreateProductAsync(
        userId,
        name,
        description,
        bulletPoints,
        targetAudience,
        tags0,
        tags1
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "status": "success",
  "message": "Product Created Successfully"
}
```


# Delete Product

```csharp
DeleteProductAsync(
    int userId,
    int productId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `int` | Query, Required | - |
| `productId` | `int` | Query, Required | - |

## Response Type

[`Task<Models.DeleteProduct>`](../../doc/models/delete-product.md)

## Example Usage

```csharp
int userId = 1;
int productId = 10;
try
{
    DeleteProduct result = await productController.DeleteProductAsync(
        userId,
        productId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "status": "success",
  "message": "Product Deleted Successfully"
}
```


# Restore Product

```csharp
RestoreProductAsync(
    int userId,
    int productId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `int` | Query, Required | - |
| `productId` | `int` | Query, Required | - |

## Response Type

[`Task<Models.RestoreProduct>`](../../doc/models/restore-product.md)

## Example Usage

```csharp
int userId = 1;
int productId = 10;
try
{
    RestoreProduct result = await productController.RestoreProductAsync(
        userId,
        productId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "status": "success",
  "message": "Product Restored Successfully"
}
```


# Parmenent Delete Product

```csharp
ParmenentDeleteProductAsync(
    int userId,
    int productId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `int` | Query, Required | - |
| `productId` | `int` | Query, Required | - |

## Response Type

[`Task<Models.NewRequest1>`](../../doc/models/new-request-1.md)

## Example Usage

```csharp
int userId = 1;
int productId = 10;
try
{
    NewRequest1 result = await productController.ParmenentDeleteProductAsync(
        userId,
        productId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "status": "success",
  "message": "Product Deleted Permanently"
}
```


# Update Product

```csharp
UpdateProductAsync(
    int userId,
    int productId,
    string name,
    string description,
    int bulletPoints,
    string targetAudience,
    string tags0)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `int` | Query, Required | - |
| `productId` | `int` | Query, Required | - |
| `name` | `string` | Query, Required | - |
| `description` | `string` | Query, Required | - |
| `bulletPoints` | `int` | Query, Required | - |
| `targetAudience` | `string` | Query, Required | - |
| `tags0` | `string` | Query, Required | - |

## Response Type

[`Task<Models.UpdateProduct>`](../../doc/models/update-product.md)

## Example Usage

```csharp
int userId = 1;
int productId = 11;
string name = "updated";
string description = "updated";
int bulletPoints = 11;
string targetAudience = "females";
Liquid error: Value cannot be null. (Parameter 'key')try
{
    UpdateProduct result = await productController.UpdateProductAsync(
        userId,
        productId,
        name,
        description,
        bulletPoints,
        targetAudience,
        tags0
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "status": "success",
  "message": "Product Updated Successfully"
}
```

