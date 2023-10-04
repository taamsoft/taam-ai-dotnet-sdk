
# Datum 1

## Structure

`Datum1`

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
| `Folders` | [`List<Datum1Folders>`](../../doc/models/containers/datum-1-folders.md) | Required | This is List of a container for one-of cases. |

## Example (as JSON)

```json
{
  "id": 1,
  "user_id": 1,
  "name": "saas",
  "default": 0,
  "created_at": "2023-06-20T07:24:51.000000Z",
  "updated_at": "2023-07-10T14:39:11.000000Z",
  "deleted_at": "deleted_at6",
  "folders": [
    {
      "id": 1,
      "name": "Taam soft folder",
      "icon": "assets/folders/64ed714d9dd0f_Innovation.gif",
      "description": "description4",
      "workbook_id": 1,
      "user_id": 1,
      "status": 1,
      "created_at": "2023-06-27T10:32:02.000000Z",
      "updated_at": "2023-08-29T04:17:17.000000Z",
      "deleted_at": null
    },
    {
      "id": 15,
      "name": "hello",
      "icon": "https://taamfly.com/assets/empty.jpg",
      "description": "description4",
      "workbook_id": 1,
      "user_id": 4,
      "status": 1,
      "created_at": "2023-08-03T06:34:27.000000Z",
      "updated_at": "2023-08-03T06:34:27.000000Z",
      "deleted_at": null
    },
    {
      "id": 16,
      "name": "test folders",
      "icon": "https://taamfly.com/assets/empty.jpg",
      "description": "description4",
      "workbook_id": 1,
      "user_id": 1,
      "status": 1,
      "created_at": "2023-08-03T14:31:02.000000Z",
      "updated_at": "2023-08-16T03:08:19.000000Z",
      "deleted_at": null
    },
    {
      "id": 31,
      "name": "taam ai",
      "icon": "https://taam.ai/assets/empty.jpg",
      "description": "description4",
      "workbook_id": 1,
      "user_id": 1,
      "status": 1,
      "created_at": "2023-08-23T01:57:28.000000Z",
      "updated_at": "2023-08-23T01:57:28.000000Z",
      "deleted_at": null
    }
  ]
}
```

