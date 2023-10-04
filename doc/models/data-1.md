
# Data 1

## Structure

`Data1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int` | Required | - |
| `UserId` | `int` | Required | - |
| `Name` | `string` | Required | - |
| `Default` | `int` | Required | - |
| `CreatedAt` | `string` | Required | - |
| `UpdatedAt` | `string` | Required | - |
| `DeletedAt` | `string` | Required | - |
| `Folders` | [`List<Folder2>`](../../doc/models/folder-2.md) | Required | - |

## Example (as JSON)

```json
{
  "id": 7,
  "user_id": 2,
  "name": "member workspace",
  "default": 0,
  "created_at": "2023-07-19T04:51:54.000000Z",
  "updated_at": "2023-07-19T04:51:54.000000Z",
  "deleted_at": "deleted_at6",
  "folders": [
    {
      "id": 8,
      "name": "defaul1",
      "icon": "assets/folders/64ed715fc11cb_Artificial intelligence.gif",
      "description": "description6",
      "workbook_id": 7,
      "user_id": 2,
      "status": 1,
      "created_at": "2023-07-19T04:51:54.000000Z",
      "updated_at": "2023-08-29T04:17:35.000000Z",
      "deleted_at": "deleted_at4"
    }
  ]
}
```

