
# Trashed Prompt Templates

## Structure

`TrashedPromptTemplates`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`List<Data16>`](../../doc/models/data-16.md) | Required | - |

## Example (as JSON)

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
      "image": "image6",
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
      "prompt": "prompt0",
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

