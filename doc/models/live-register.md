
# Live Register

## Structure

`LiveRegister`

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
  "access_token": "2|QYrP7Acc8uWlie97NREzfG2gmueJf8nSXtAWtoMM",
  "user": {
    "name": "soban",
    "email": "sobanshahid47@gmail.com",
    "country": "pakistan",
    "updated_at": "2023-09-22T07:21:13.000000Z",
    "created_at": "2023-09-22T07:21:12.000000Z",
    "id": 40,
    "email_verified_at": "2023-09-22T07:21:12.000000Z",
    "status": "active",
    "group": "subscriber",
    "available_words_prepaid": "100000",
    "available_images_prepaid": "100000",
    "available_chars_prepaid": "1000",
    "available_minutes_prepaid": "10",
    "default_voiceover_language": "en-US",
    "default_voiceover_voice": "sk-SK-Wavenet-A",
    "job_role": "Happy Person",
    "referral_id": "LCPFKIBCE7IEUGY",
    "referred_by": "",
    "workbook": "default workbook",
    "workbook_id": 38,
    "workbook_folder_id": 43,
    "plan_id": 1,
    "total_words": 20400,
    "total_images": 10000,
    "total_chars": 16600,
    "total_minutes": 200,
    "available_words": 20400,
    "available_images": 10000,
    "available_chars": 16600,
    "available_minutes": 200,
    "roles": [
      {
        "id": 2,
        "name": "subscriber",
        "guard_name": "web",
        "created_at": "2023-07-06T08:33:48.000000Z",
        "updated_at": "2023-07-06T08:33:48.000000Z",
        "pivot": {
          "model_id": 40,
          "role_id": 2,
          "model_type": "App\\Models\\User"
        }
      }
    ]
  }
}
```

