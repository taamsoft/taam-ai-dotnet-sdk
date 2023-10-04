
# Prompt Templates

## Structure

`PromptTemplates`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`List<Data15>`](../../doc/models/data-15.md) | Required | - |

## Example (as JSON)

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
      "image": "image6",
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
      "prompt": "prompt0",
      "tone": 0,
      "fields": [],
      "package": "all",
      "created_at": "2023-07-24T13:04:48.000000Z",
      "updated_at": "2023-07-24T13:04:48.000000Z",
      "deleted_at": "deleted_at8"
    }
  ]
}
```

