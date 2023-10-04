
# Trashed Workspaces Live

## Structure

`TrashedWorkspacesLive`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`List<Data2>`](../../doc/models/data-2.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "success",
  "message": "Data Fatched Successfully",
  "data": [
    {
      "id": 39,
      "user_id": 40,
      "name": "soban2",
      "default": 0,
      "created_at": "2023-09-22T14:27:03.000000Z",
      "updated_at": "2023-09-22T14:28:21.000000Z",
      "deleted_at": "2023-09-22T14:28:21.000000Z"
    }
  ]
}
```

