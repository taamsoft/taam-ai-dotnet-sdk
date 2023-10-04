
# Data 12

## Structure

`Data12`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UserId` | `string` | Required | - |
| `Description` | `string` | Required | - |
| `Status` | `bool` | Required | - |
| `Professional` | `bool` | Required | - |
| `TemplateCode` | `string` | Required | - |
| `Name` | `string` | Required | - |
| `Icon` | `string` | Required | - |
| `Group` | `string` | Required | - |
| `Slug` | `string` | Required | - |
| `Prompt` | `string` | Required | - |
| `Tone` | `bool` | Required | - |
| `Fields` | [`List<Field>`](../../doc/models/field.md) | Required | - |
| `Package` | `string` | Required | - |
| `UpdatedAt` | `string` | Required | - |
| `CreatedAt` | `string` | Required | - |
| `Id` | `int` | Required | - |

## Example (as JSON)

```json
{
  "user_id": "1",
  "description": "description2",
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
```

