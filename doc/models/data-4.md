
# Data 4

## Structure

`Data4`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int` | Required | - |
| `UserId` | `int` | Required | - |
| `Title` | `string` | Required | - |
| `InputText` | `string` | Required | - |
| `ResultText` | `string` | Required | - |
| `Model` | `string` | Required | - |
| `Language` | `string` | Required | - |
| `TemplateCode` | `string` | Required | - |
| `TemplateName` | `string` | Required | - |
| `Workbook` | `string` | Required | - |
| `WorkbookId` | `int` | Required | - |
| `WorkbookFolderId` | `int` | Required | - |
| `Icon` | `string` | Required | - |
| `Group` | `string` | Required | - |
| `Tags` | `string` | Required | - |
| `Draft` | `int` | Required | - |
| `LanguageName` | `string` | Required | - |
| `LanguageFlag` | `string` | Required | - |
| `Tokens` | `int` | Required | - |
| `Words` | [`Data4Words`](../../doc/models/containers/data-4-words.md) | Required | This is a container for one-of cases. |
| `PlanType` | `string` | Required | - |
| `CreatedAt` | `string` | Required | - |
| `UpdatedAt` | `string` | Required | - |
| `DeletedAt` | `string` | Required | - |

## Example (as JSON)

```json
{
  "id": 254,
  "user_id": 94,
  "title": "title4",
  "input_text": "input_text8",
  "result_text": "result_text4",
  "model": "model8",
  "language": "language2",
  "template_code": "template_code0",
  "template_name": "template_name2",
  "workbook": "workbook8",
  "workbook_id": 212,
  "workbook_folder_id": 138,
  "icon": "icon2",
  "group": "group8",
  "tags": "tags0",
  "draft": 128,
  "language_name": "language_name8",
  "language_flag": "language_flag0",
  "tokens": 40,
  "words": "String9",
  "plan_type": "plan_type0",
  "created_at": "created_at2",
  "updated_at": "updated_at4",
  "deleted_at": "deleted_at8"
}
```

