
# Trashed Products

## Structure

`TrashedProducts`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`List<Data14>`](../../doc/models/data-14.md) | Required | - |

## Example (as JSON)

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

