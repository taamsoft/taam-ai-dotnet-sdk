
# Role

## Structure

`Role`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int` | Required | - |
| `Name` | `string` | Required | - |
| `GuardName` | `string` | Required | - |
| `CreatedAt` | `string` | Required | - |
| `UpdatedAt` | `string` | Required | - |
| `Pivot` | [`Pivot`](../../doc/models/pivot.md) | Required | - |

## Example (as JSON)

```json
{
  "id": 2,
  "name": "subscriber",
  "guard_name": "web",
  "created_at": "2023-07-06T13:33:48.000000Z",
  "updated_at": "2023-07-06T13:33:48.000000Z",
  "pivot": {
    "model_id": 20,
    "role_id": 2,
    "model_type": "App\\Models\\User"
  }
}
```

