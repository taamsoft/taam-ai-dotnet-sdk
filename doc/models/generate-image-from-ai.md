
# Generate Image From AI

## Structure

`GenerateImageFromAI`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Old` | `string` | Required | - |
| `Current` | `int` | Required | - |
| `Data` | [`Data17`](../../doc/models/data-17.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "success",
  "old": "10000000",
  "current": 9999999,
  "data": {
    "user_id": 1,
    "name": "sample checking",
    "description": "need a eagle image",
    "resolution": "256x256",
    "image": "assets/images/65156efb84c6c_3",
    "plan_type": "paid",
    "storage": "local",
    "expires_at": "2073-09-15T12:18:03.545504Z",
    "image_name": "images/ix3Y9KswvE.png",
    "workbook_id": "1",
    "workbook_folder_id": "1",
    "updated_at": "2023-09-28T12:18:03.000000Z",
    "created_at": "2023-09-28T12:18:03.000000Z",
    "id": 92,
    "image_url": "http://127.0.0.1:8000/assets/images/65156efb84c6c_3"
  }
}
```

