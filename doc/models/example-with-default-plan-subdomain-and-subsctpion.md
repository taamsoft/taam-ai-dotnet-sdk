
# Example With Default Plan Subdomain and Subsctpion

## Structure

`ExampleWithDefaultPlanSubdomainAndSubsctpion`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Result` | `bool` | Required | - |
| `Message` | `string` | Required | - |
| `AccessToken` | `string` | Required | - |
| `User` | [`User2`](../../doc/models/user-2.md) | Required | - |

## Example (as JSON)

```json
{
  "result": true,
  "message": "Registration Successful. Please verify and log in to your account.",
  "access_token": "5|78sPFuxgmVpMEE7n9cbNfCsKHRkLOgWngwirWZh1",
  "user": {
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
}
```

