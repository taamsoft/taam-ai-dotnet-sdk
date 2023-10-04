
# Datum

## Structure

`Datum`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int` | Required | - |
| `Name` | `string` | Required | - |
| `Icon` | `string` | Required | - |
| `Image` | `string` | Required | - |
| `Popular` | `int` | Required | - |
| `Description` | `string` | Required | - |
| `TemplateCode` | `string` | Required | - |
| `Status` | `int` | Required | - |
| `Professional` | `int` | Required | - |
| `New` | `int` | Required | - |
| `Type` | `string` | Required | - |
| `Group` | `string` | Required | - |
| `Slug` | `string` | Required | - |
| `Package` | `string` | Required | - |
| `Fields` | `string` | Required | - |
| `CreatedAt` | `string` | Required | - |
| `UpdatedAt` | `string` | Required | - |

## Example (as JSON)

```json
{
  "id": 1,
  "name": "Article Generator",
  "icon": "<i class=\"fa-solid fa-file-lines main-icon\"></i>",
  "image": "image4",
  "popular": 0,
  "description": "Turn a title and outline text into a fully complete high quality article within seconds",
  "template_code": "KPAQQ",
  "status": 1,
  "professional": 0,
  "new": 0,
  "type": "original",
  "group": "text",
  "slug": "article-generator",
  "package": "all",
  "fields": "[{\"name\":\"Article Title\",\"placeholder\":\"e.g. Amazing cuisine culture of Mexico\", \"required\":1, \"input\":\"input\",\"code\":\"title\", \"length\":200}, {\"name\":\"Focus Keywords\",\"placeholder\":\"e.g. taco, sangria, paella\", \"required\":0, \"input\":\"textarea\",\"code\":\"keywords\", \"length\":600}]",
  "created_at": "2023-07-06T08:33:48.000000Z",
  "updated_at": "2023-09-20T05:57:13.000000Z"
}
```

