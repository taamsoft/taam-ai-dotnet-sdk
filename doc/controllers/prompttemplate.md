# Prompttemplate

```csharp
PrompttemplateController prompttemplateController = client.PrompttemplateController;
```

## Class Name

`PrompttemplateController`

## Methods

* [Prompt Templates](../../doc/controllers/prompttemplate.md#prompt-templates)
* [Add and Remove From Bookmark Prompt Template](../../doc/controllers/prompttemplate.md#add-and-remove-from-bookmark-prompt-template)
* [Prompt Template Like or Remove From Like](../../doc/controllers/prompttemplate.md#prompt-template-like-or-remove-from-like)
* [Create Prompt Template](../../doc/controllers/prompttemplate.md#create-prompt-template)
* [Trashed Prompt Templates](../../doc/controllers/prompttemplate.md#trashed-prompt-templates)
* [Delete Prmopt Template](../../doc/controllers/prompttemplate.md#delete-prmopt-template)
* [Restore Prompt Template](../../doc/controllers/prompttemplate.md#restore-prompt-template)
* [Parmanent Delete Prompt Template](../../doc/controllers/prompttemplate.md#parmanent-delete-prompt-template)
* [Generate Prompt Template](../../doc/controllers/prompttemplate.md#generate-prompt-template)


# Prompt Templates

```csharp
PromptTemplatesAsync(
    int userId,
    string cat,
    string subCat)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `int` | Query, Required | - |
| `cat` | `string` | Query, Required | - |
| `subCat` | `string` | Query, Required | - |

## Response Type

[`Task<Models.PromptTemplates>`](../../doc/models/prompt-templates.md)

## Example Usage

```csharp
int userId = 1;
string cat = "publc";
string subCat = "all";
try
{
    PromptTemplates result = await promptTemplateController.PromptTemplatesAsync(
        userId,
        cat,
        subCat
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
  "message": "Data Fateched Successfully",
  "data": [
    {
      "id": 3,
      "user_id": 1,
      "name": "Sobi Rajpoot",
      "icon": "<i class=\"fa-solid fa-search-minus blog-icon\"></i>",
      "image": null,
      "description": "tone of voice generator",
      "template_code": "DAQGY",
      "lang": "en-US",
      "status": 1,
      "professional": 0,
      "new": 0,
      "public": 0,
      "edit": 0,
      "group": "public",
      "slug": "custom-template",
      "type": "custom",
      "prompt": null,
      "tone": 0,
      "fields": [],
      "package": "all",
      "created_at": "2023-07-24T13:04:48.000000Z",
      "updated_at": "2023-07-24T13:04:48.000000Z",
      "deleted_at": null
    }
  ]
}
```


# Add and Remove From Bookmark Prompt Template

```csharp
AddAndRemoveFromBookmarkPromptTemplateAsync(
    int userId,
    int templateId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `int` | Query, Required | - |
| `templateId` | `int` | Query, Required | - |

## Response Type

[`Task<Models.NewRequest1>`](../../doc/models/new-request-1.md)

## Example Usage

```csharp
int userId = 1;
int templateId = 1;
try
{
    NewRequest1 result = await promptTemplateController.AddAndRemoveFromBookmarkPromptTemplateAsync(
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
  "message": "Added to bookmark Successfully"
}
```


# Prompt Template Like or Remove From Like

```csharp
PromptTemplateLikeOrRemoveFromLikeAsync(
    int userId,
    int templateId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `int` | Query, Required | - |
| `templateId` | `int` | Query, Required | - |

## Response Type

[`Task<Models.PromptTemplateLikeOrRemoveFromLike>`](../../doc/models/prompt-template-like-or-remove-from-like.md)

## Example Usage

```csharp
int userId = 1;
int templateId = 1;
try
{
    PromptTemplateLikeOrRemoveFromLike result = await promptTemplateController.PromptTemplateLikeOrRemoveFromLikeAsync(
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
  "message": "added to Liked list",
  "count": 1
}
```


# Create Prompt Template

```csharp
CreatePromptTemplateAsync(
    int userId,
    int mPublic,
    int edit,
    string name,
    int activate,
    int tone,
    string prompt,
    string language,
    string package,
    string category,
    string names0,
    string placeholders0,
    string code0,
    string inputField0)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `int` | Query, Required | - |
| `mPublic` | `int` | Query, Required | - |
| `edit` | `int` | Query, Required | - |
| `name` | `string` | Query, Required | - |
| `activate` | `int` | Query, Required | - |
| `tone` | `int` | Query, Required | - |
| `prompt` | `string` | Query, Required | - |
| `language` | `string` | Query, Required | - |
| `package` | `string` | Query, Required | - |
| `category` | `string` | Query, Required | - |
| `names0` | `string` | Query, Required | - |
| `placeholders0` | `string` | Query, Required | - |
| `code0` | `string` | Query, Required | - |
| `inputField0` | `string` | Query, Required | - |

## Response Type

[`Task<Models.CreatePromptTemplate>`](../../doc/models/create-prompt-template.md)

## Example Usage

```csharp
int userId = 1;
int mPublic = 1;
int edit = 1;
string name = "New checking";
int activate = 1;
int tone = 1;
string prompt = "Want to create vlog";
string language = "en-US";
string package = "all";
string category = "text";
Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')Liquid error: Value cannot be null. (Parameter 'key')try
{
    CreatePromptTemplate result = await promptTemplateController.CreatePromptTemplateAsync(
        userId,
        mPublic,
        edit,
        name,
        activate,
        tone,
        prompt,
        language,
        package,
        category,
        names0,
        placeholders0,
        code0,
        inputField0
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
  "message": "Prompt template creeated Successfully"
}
```


# Trashed Prompt Templates

```csharp
TrashedPromptTemplatesAsync(
    int userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `int` | Query, Required | - |

## Response Type

[`Task<Models.TrashedPromptTemplates>`](../../doc/models/trashed-prompt-templates.md)

## Example Usage

```csharp
int userId = 1;
try
{
    TrashedPromptTemplates result = await promptTemplateController.TrashedPromptTemplatesAsync(userId);
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
  "data": [
    {
      "id": 2,
      "user_id": 1,
      "name": "a",
      "icon": "<i class=\"fa-solid fa-power-off blog-icon\"></i>",
      "image": null,
      "description": "a",
      "template_code": "7AUBC",
      "lang": "en-US",
      "status": 1,
      "professional": 0,
      "new": 0,
      "public": 1,
      "edit": 0,
      "group": "public",
      "slug": "custom-template",
      "type": "custom",
      "prompt": null,
      "tone": 0,
      "fields": [],
      "package": "all",
      "created_at": "2023-07-21T11:48:04.000000Z",
      "updated_at": "2023-09-04T09:04:34.000000Z",
      "deleted_at": "2023-09-04T09:04:34.000000Z"
    }
  ]
}
```


# Delete Prmopt Template

```csharp
DeletePrmoptTemplateAsync(
    int userId,
    int templateId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `int` | Query, Required | - |
| `templateId` | `int` | Query, Required | - |

## Response Type

[`Task<Models.DeletePrmoptTemplate>`](../../doc/models/delete-prmopt-template.md)

## Example Usage

```csharp
int userId = 1;
int templateId = 3;
try
{
    DeletePrmoptTemplate result = await promptTemplateController.DeletePrmoptTemplateAsync(
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


# Restore Prompt Template

```csharp
RestorePromptTemplateAsync(
    int userId,
    int templateId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `int` | Query, Required | - |
| `templateId` | `int` | Query, Required | - |

## Response Type

[`Task<Models.RestorePromptTemplate>`](../../doc/models/restore-prompt-template.md)

## Example Usage

```csharp
int userId = 1;
int templateId = 3;
try
{
    RestorePromptTemplate result = await promptTemplateController.RestorePromptTemplateAsync(
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


# Parmanent Delete Prompt Template

```csharp
ParmanentDeletePromptTemplateAsync(
    int userId,
    int templateId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `int` | Query, Required | - |
| `templateId` | `int` | Query, Required | - |

## Response Type

[`Task<Models.ParmanentDeletePromptTemplate>`](../../doc/models/parmanent-delete-prompt-template.md)

## Example Usage

```csharp
int userId = 1;
int templateId = 3;
try
{
    ParmanentDeletePromptTemplate result = await promptTemplateController.ParmanentDeletePromptTemplateAsync(
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
  "status": "error",
  "message": "Not Found"
}
```


# Generate Prompt Template

```csharp
GeneratePromptTemplateAsync(
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
    string text1)
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
| `text1` | `string` | Query, Required | - |

## Response Type

[`Task<Models.GeneratePromptTemplate>`](../../doc/models/generate-prompt-template.md)

## Example Usage

```csharp
int userId = 1;
string templateCode = "SXHY9";
string language = "en-US";
int maxResults = 1;
int words = 10000;
double creativity = 0.5;
string title = "new";
string description = "something new";
int workbookId = 1;
int folderId = 1;
string text1 = "hello";
try
{
    GeneratePromptTemplate result = await promptTemplateController.GeneratePromptTemplateAsync(
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
        text1
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
  "max_words": "1000",
  "id": 379
}
```

