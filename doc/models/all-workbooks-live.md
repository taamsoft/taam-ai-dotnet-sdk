
# All Workbooks Live

## Structure

`AllWorkbooksLive`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `int` | Required | - |
| `Status` | `string` | Required | - |
| `Mesaage` | `string` | Required | - |
| `Data` | [`List<Datum1>`](../../doc/models/datum-1.md) | Required | - |

## Example (as JSON)

```json
{
  "code": 200,
  "status": "success",
  "mesaage": "Workbooks fetched SUccessfully",
  "data": [
    {
      "id": 1,
      "user_id": 1,
      "name": "saas",
      "default": 0,
      "created_at": "2023-06-20T07:24:51.000000Z",
      "updated_at": "2023-07-10T14:39:11.000000Z",
      "deleted_at": "deleted_at8",
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
    },
    {
      "id": 2,
      "user_id": 1,
      "name": "sales",
      "default": 0,
      "created_at": "2023-06-20T07:25:00.000000Z",
      "updated_at": "2023-06-20T07:25:00.000000Z",
      "deleted_at": "deleted_at8",
      "folders": []
    },
    {
      "id": 32,
      "user_id": 1,
      "name": "test",
      "default": 0,
      "created_at": "2023-09-13T11:50:03.000000Z",
      "updated_at": "2023-09-13T11:50:03.000000Z",
      "deleted_at": "deleted_at8",
      "folders": []
    },
    {
      "id": 7,
      "user_id": 2,
      "name": "member workspace",
      "default": 0,
      "created_at": "2023-07-19T04:51:54.000000Z",
      "updated_at": "2023-07-19T04:51:54.000000Z",
      "deleted_at": "deleted_at8",
      "folders": [
        {
          "id": 8,
          "name": "defaul1",
          "icon": "assets/folders/64ed715fc11cb_Artificial intelligence.gif",
          "description": "description4",
          "workbook_id": 7,
          "user_id": 2,
          "status": 1,
          "created_at": "2023-07-19T04:51:54.000000Z",
          "updated_at": "2023-08-29T04:17:35.000000Z",
          "deleted_at": null
        }
      ]
    }
  ]
}
```

