
# Data 6

## Structure

`Data6`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int` | Required | - |
| `UserId` | `int` | Required | - |
| `Language` | `string` | Required | - |
| `LanguageFlag` | `string` | Required | - |
| `Voice` | `string` | Required | - |
| `VoiceId` | `string` | Required | - |
| `Gender` | `string` | Required | - |
| `Text` | `string` | Required | - |
| `WorkbookId` | `int` | Required | - |
| `WorkbookFolderId` | `int` | Required | - |
| `TextRaw` | `string` | Required | - |
| `FileName` | `string` | Required | - |
| `ResultUrl` | `string` | Required | - |
| `ResultExt` | `string` | Required | - |
| `Storage` | `string` | Required | - |
| `Title` | `string` | Required | - |
| `Vendor` | `string` | Required | - |
| `VendorId` | `string` | Required | - |
| `Characters` | `int` | Required | - |
| `VoiceType` | `string` | Required | - |
| `PlanType` | `string` | Required | - |
| `AudioType` | `string` | Required | - |
| `Mode` | `string` | Required | - |
| `Project` | `string` | Required | - |
| `ExpiresAt` | `string` | Required | - |
| `CreatedAt` | `string` | Required | - |
| `UpdatedAt` | `string` | Required | - |
| `DeletedAt` | `string` | Required | - |

## Example (as JSON)

```json
{
  "id": 38,
  "user_id": 1,
  "language": "Afrikaans (South Africa)",
  "language_flag": "/img/flags/za.svg",
  "voice": "Willem",
  "voice_id": "af-ZA-WillemNeural",
  "gender": "Male",
  "text": "hello. ",
  "workbook_id": 1,
  "workbook_folder_id": 1,
  "text_raw": "hello. ",
  "file_name": "rob5qkLDTS.mp3",
  "result_url": "/storage/rob5qkLDTS.mp3",
  "result_ext": "mp3",
  "storage": "local",
  "title": "New Audio",
  "vendor": "azure",
  "vendor_id": "azure_nrl",
  "characters": 5,
  "voice_type": "neural",
  "plan_type": "free",
  "audio_type": "audio/mpeg",
  "mode": "file",
  "project": "project8",
  "expires_at": "expires_at2",
  "created_at": "2023-09-05T07:12:12.000000Z",
  "updated_at": "2023-09-05T07:12:12.000000Z",
  "deleted_at": "deleted_at2"
}
```

