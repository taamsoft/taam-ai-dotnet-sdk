
# Contents in Work Book

## Structure

`ContentsInWorkBook`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Count` | `int` | Required | - |
| `Data` | [`List<Data4>`](../../doc/models/data-4.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "status6",
  "message": "message8",
  "count": 188,
  "data": [
    {
      "id": 138,
      "user_id": 234,
      "title": "title6",
      "input_text": "input_text8",
      "result_text": "result_text6",
      "model": "model8",
      "language": "language2",
      "template_code": "template_code0",
      "template_name": "template_name8",
      "workbook": "workbook2",
      "workbook_id": 184,
      "workbook_folder_id": 22,
      "icon": "icon2",
      "group": "group8",
      "tags": "tags0",
      "draft": 12,
      "language_name": "language_name8",
      "language_flag": "language_flag0",
      "tokens": 100,
      "words": "String9",
      "plan_type": "plan_type0",
      "created_at": "created_at8",
      "updated_at": "updated_at6",
      "deleted_at": "deleted_at8"
    }
  ]
}
```

