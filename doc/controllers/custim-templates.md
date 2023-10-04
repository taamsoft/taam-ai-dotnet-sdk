# Custim Templates

```csharp
CustimTemplatesController custimTemplatesController = client.CustimTemplatesController;
```

## Class Name

`CustimTemplatesController`

## Methods

* [Custom Templates](../../doc/controllers/custim-templates.md#custom-templates)
* [Fav Custom Templates](../../doc/controllers/custim-templates.md#fav-custom-templates)
* [Custom Template Generate](../../doc/controllers/custim-templates.md#custom-template-generate)
* [Create Custom Template](../../doc/controllers/custim-templates.md#create-custom-template)
* [Trashed Custom Templates](../../doc/controllers/custim-templates.md#trashed-custom-templates)
* [Delete Custom Template](../../doc/controllers/custim-templates.md#delete-custom-template)
* [Restore Custom Template](../../doc/controllers/custim-templates.md#restore-custom-template)
* [Permanent Delete Custom Template](../../doc/controllers/custim-templates.md#permanent-delete-custom-template)


# Custom Templates

```csharp
CustomTemplatesAsync(
    int userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `int` | Query, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
int userId = 40;
try
{
    await custimTemplatesController.CustomTemplatesAsync(userId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Fav Custom Templates

```csharp
FavCustomTemplatesAsync(
    int userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `int` | Query, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
int userId = 40;
try
{
    await custimTemplatesController.FavCustomTemplatesAsync(userId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Custom Template Generate

```csharp
CustomTemplateGenerateAsync(
    int userId,
    string templateCode,
    string language,
    int maxResults,
    int words,
    double creativity,
    string title,
    string description,
    int workbookId,
    int folderId,
    string text,
    string text2)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `int` | Query, Required | - |
| `templateCode` | `string` | Query, Required | - |
| `language` | `string` | Query, Required | - |
| `maxResults` | `int` | Query, Required | - |
| `words` | `int` | Query, Required | - |
| `creativity` | `double` | Query, Required | - |
| `title` | `string` | Query, Required | - |
| `description` | `string` | Query, Required | - |
| `workbookId` | `int` | Query, Required | - |
| `folderId` | `int` | Query, Required | - |
| `text` | `string` | Query, Required | - |
| `text2` | `string` | Query, Required | - |

## Response Type

[`Task<Models.CustomTemplateGenerate>`](../../doc/models/custom-template-generate.md)

## Example Usage

```csharp
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
try
{
    CustomTemplateGenerate result = await custimTemplatesController.CustomTemplateGenerateAsync(
        userId,
        templateCode,
        language,
        maxResults,
        words,
        creativity,
        title,
        description,
        workbookId,
        folderId,
        text,
        text2
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
  "max_results": "1",
  "temperature": "0.5",
  "max_words": 100,
  "id": 289
}
```


# Create Custom Template

```csharp
CreateCustomTemplateAsync()
```

## Response Type

[`Task<Models.CreateCustomTemplate>`](../../doc/models/create-custom-template.md)

## Example Usage

```csharp
try
{
    CreateCustomTemplate result = await custimTemplatesController.CreateCustomTemplateAsync();
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
  "code": "200",
  "status": "success",
  "message": "template Created Successfully",
  "data": {
    "user_id": "1",
    "description": null,
    "status": true,
    "professional": false,
    "template_code": "KOWPI",
    "name": "new",
    "icon": "<i class=\"fa-solid  blog-icon\"></i>",
    "group": "text",
    "slug": "custom-template",
    "prompt": "Tone of voice generator",
    "tone": true,
    "fields": [
      {
        "name": "text1",
        "placeholder": "Enter the ralevent information",
        "input": "input",
        "code": "input-field-1"
      }
    ],
    "package": "all",
    "updated_at": "2023-09-30T13:35:17.000000Z",
    "created_at": "2023-09-30T13:35:17.000000Z",
    "id": 3
  }
}
```


# Trashed Custom Templates

```csharp
TrashedCustomTemplatesAsync(
    int userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `int` | Query, Required | - |

## Response Type

[`Task<Models.TrashedCustomTemplates>`](../../doc/models/trashed-custom-templates.md)

## Example Usage

```csharp
int userId = 1;
try
{
    TrashedCustomTemplates result = await custimTemplatesController.TrashedCustomTemplatesAsync(userId);
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
  "message": "Data Fatched Successfully",
  "data": []
}
```


# Delete Custom Template

```csharp
DeleteCustomTemplateAsync(
    int userId,
    int templateId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `int` | Query, Required | - |
| `templateId` | `int` | Query, Required | - |

## Response Type

[`Task<Models.DeleteCustomTemplate>`](../../doc/models/delete-custom-template.md)

## Example Usage

```csharp
int userId = 1;
int templateId = 3;
try
{
    DeleteCustomTemplate result = await custimTemplatesController.DeleteCustomTemplateAsync(
        userId,
        templateId
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
  "message": "Deleted Successfully"
}
```


# Restore Custom Template

```csharp
RestoreCustomTemplateAsync(
    int userId,
    int templateId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `int` | Query, Required | - |
| `templateId` | `int` | Query, Required | - |

## Response Type

[`Task<Models.RestoreCustomTemplate>`](../../doc/models/restore-custom-template.md)

## Example Usage

```csharp
int userId = 1;
int templateId = 3;
try
{
    RestoreCustomTemplate result = await custimTemplatesController.RestoreCustomTemplateAsync(
        userId,
        templateId
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
  "message": "Restored Successfully"
}
```


# Permanent Delete Custom Template

```csharp
PermanentDeleteCustomTemplateAsync()
```

## Response Type

[`Task<Models.PermanentDeleteCustomTemplate>`](../../doc/models/permanent-delete-custom-template.md)

## Example Usage

```csharp
try
{
    PermanentDeleteCustomTemplate result = await custimTemplatesController.PermanentDeleteCustomTemplateAsync();
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
  "message": "Delete Successfully"
}
```

