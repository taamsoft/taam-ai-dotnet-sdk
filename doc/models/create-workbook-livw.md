
# Create Workbook Livw

## Structure

`CreateWorkbookLivw`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`Data`](../../doc/models/data.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "success",
  "message": "Workbook has been successfully created",
  "data": {
    "user_id": "40",
    "name": "soban2",
    "updated_at": "2023-09-22T14:27:03.000000Z",
    "created_at": "2023-09-22T14:27:03.000000Z",
    "id": 39
  }
}
```

