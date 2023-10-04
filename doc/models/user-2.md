
# User 2

## Structure

`User2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `Email` | `string` | Required | - |
| `Country` | `string` | Required | - |
| `UpdatedAt` | `string` | Required | - |
| `CreatedAt` | `string` | Required | - |
| `Id` | `int` | Required | - |
| `EmailVerifiedAt` | `string` | Required | - |
| `Status` | `string` | Required | - |
| `Group` | `string` | Required | - |
| `AvailableWordsPrepaid` | `string` | Required | - |
| `AvailableImagesPrepaid` | `string` | Required | - |
| `AvailableCharsPrepaid` | `string` | Required | - |
| `AvailableMinutesPrepaid` | `string` | Required | - |
| `DefaultVoiceoverLanguage` | `string` | Required | - |
| `DefaultVoiceoverVoice` | `string` | Required | - |
| `JobRole` | `string` | Required | - |
| `ReferralId` | `string` | Required | - |
| `ReferredBy` | `string` | Required | - |
| `Workbook` | `string` | Required | - |
| `WorkbookId` | `int` | Required | - |
| `WorkbookFolderId` | `int` | Required | - |
| `PlanId` | `int` | Required | - |
| `TotalWords` | `int` | Required | - |
| `TotalImages` | `int` | Required | - |
| `TotalChars` | `int` | Required | - |
| `TotalMinutes` | `int` | Required | - |
| `AvailableWords` | `int` | Required | - |
| `AvailableImages` | `int` | Required | - |
| `AvailableChars` | `int` | Required | - |
| `AvailableMinutes` | `int` | Required | - |
| `Roles` | [`List<Role>`](../../doc/models/role.md) | Required | - |

## Example (as JSON)

```json
{
  "name": "soban",
  "email": "sobanshahid47@gmail.com",
  "country": "pakistan",
  "updated_at": "2023-09-19T12:22:43.000000Z",
  "created_at": "2023-09-19T12:22:43.000000Z",
  "id": 20,
  "email_verified_at": "2023-09-19T12:22:43.000000Z",
  "status": "active",
  "group": "subscriber",
  "available_words_prepaid": "1000",
  "available_images_prepaid": "1000",
  "available_chars_prepaid": "1000",
  "available_minutes_prepaid": "10",
  "default_voiceover_language": "en-US",
  "default_voiceover_voice": "en-US-Wavenet-J",
  "job_role": "Happy Person",
  "referral_id": "EGUYLK7WC4DNMQU",
  "referred_by": "",
  "workbook": "default workbook",
  "workbook_id": 21,
  "workbook_folder_id": 26,
  "plan_id": 3,
  "total_words": 11,
  "total_images": 11,
  "total_chars": 0,
  "total_minutes": 0,
  "available_words": 11,
  "available_images": 11,
  "available_chars": 0,
  "available_minutes": 0,
  "roles": [
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
  ]
}
```

