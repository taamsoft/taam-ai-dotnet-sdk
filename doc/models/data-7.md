
# Data 7

## Structure

`Data7`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int` | Required | - |
| `UserId` | `int` | Required | - |
| `Url` | `string` | Required | - |
| `Transcript` | `string` | Required | - |
| `WorkbookId` | `int` | Required | - |
| `WorkbookFolderId` | `int` | Required | - |
| `Title` | `string` | Required | - |
| `Workbook` | `string` | Required | - |
| `Task` | `string` | Required | - |
| `Words` | `int` | Required | - |
| `Format` | `string` | Required | - |
| `AudioType` | `string` | Required | - |
| `Description` | `string` | Required | - |
| `Storage` | `string` | Required | - |
| `Length` | `string` | Required | - |
| `PlanType` | `string` | Required | - |
| `Size` | `string` | Required | - |
| `FileName` | `string` | Required | - |
| `TempName` | `string` | Required | - |
| `ExpiresAt` | `string` | Required | - |
| `CreatedAt` | `string` | Required | - |
| `UpdatedAt` | `string` | Required | - |
| `DeletedAt` | `string` | Required | - |

## Example (as JSON)

```json
{
  "id": 41,
  "user_id": 1,
  "url": "transcribe/MF8nK7yAyNbUmmVG3zMAPFQcgkONpUdJvz3eUDGz.mp3",
  "transcript": "<p>Marhaban, ana al-mutahaddithi al-iftiradi min imza'i al-jawda. Da'ani ulqi al-tahiyyata ala jumhourik wa u'arrifahom ala muntajatik abra wasilatin min akthar al-wasaili al-taswiqiya, tashwiqan wa mut'a.</p>",
  "workbook_id": 1,
  "workbook_folder_id": 1,
  "title": "Audio File",
  "workbook": "all",
  "task": "transcribe",
  "words": 25,
  "format": "mp3",
  "audio_type": "audio/mpeg",
  "description": "description4",
  "storage": "local",
  "length": "13.767",
  "plan_type": "free",
  "size": "215.13 KB",
  "file_name": "AR_F_GadaB.mp3",
  "temp_name": "u9c4fizRqM.mp3",
  "expires_at": "2073-09-05 23:21:57",
  "created_at": "2023-09-19T10:21:57.000000Z",
  "updated_at": "2023-09-19T10:22:12.000000Z",
  "deleted_at": "deleted_at2"
}
```

