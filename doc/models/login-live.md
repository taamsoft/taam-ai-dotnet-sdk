
# Login Live

## Structure

`LoginLive`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `bool` | Required | - |
| `Message` | `string` | Required | - |
| `AccessToken` | `string` | Required | - |
| `TokenType` | `string` | Required | - |
| `ExpiresAt` | `string` | Required | - |
| `User` | [`User`](../../doc/models/user.md) | Required | - |

## Example (as JSON)

```json
{
  "status": true,
  "message": "Successfully logged in",
  "access_token": "3|5ek7yEVxDwqMgKRmJSBRhj1z0kNcSfC52EPpix04",
  "token_type": "Bearer",
  "expires_at": "expires_at2",
  "user": {
    "id": 40,
    "name": "soban",
    "job_role": "Happy Person",
    "email": "sobanshahid47@gmail.com",
    "email_verified_at": "2023-09-22T07:21:12.000000Z",
    "status": "active",
    "subdomain": "subdomain4",
    "group": "subscriber",
    "workbook": "default workbook",
    "workbook_id": 38,
    "workbook_folder_id": 43,
    "product_id": 0,
    "plan_id": 1,
    "plan_type": "plan_type0",
    "company": "company0",
    "website": "website4",
    "phone_number": "phone_number2",
    "address": "address6",
    "city": "city0",
    "postal_code": "postal_code2",
    "country": "pakistan",
    "available_words": 20400,
    "available_words_prepaid": 100000,
    "total_words": 20400,
    "available_images": 10000,
    "available_images_prepaid": 100000,
    "total_images": 10000,
    "balance": 0,
    "total_chars": 16600,
    "available_chars": 16600,
    "available_chars_prepaid": 1000,
    "total_minutes": "200.000",
    "available_minutes": "200.000",
    "available_minutes_prepaid": "10.000",
    "profile_photo_path": "profile_photo_path2",
    "oauth_id": "oauth_id0",
    "oauth_type": "oauth_type4",
    "last_seen": "last_seen0",
    "member_role": 0,
    "parent_id": 0,
    "ckbox": "ckbox8",
    "google2fa_secret": "google2fa_secret8",
    "google2fa_enabled": 0,
    "referral_id": "LCPFKIBCE7IEUGY",
    "referred_by": "",
    "referral_payment_method": "referral_payment_method2",
    "referral_paypal": "referral_paypal8",
    "referral_bank_requisites": "referral_bank_requisites0",
    "default_tone": "default_tone8",
    "default_voiceover_language": "en-US",
    "default_temp_language": 0,
    "default_voiceover_voice": "sk-SK-Wavenet-A",
    "subdomain_token": "subdomain_token4",
    "created_at": "2023-09-22T07:21:12.000000Z",
    "updated_at": "2023-09-22T07:21:13.000000Z"
  }
}
```

