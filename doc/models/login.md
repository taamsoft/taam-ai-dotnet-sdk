
# Login

## Structure

`Login`

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
  "access_token": "6|b6WIe6smnjl2dP0Yulzu8TsQnr6UtAV2SmtiKj3V",
  "token_type": "Bearer",
  "expires_at": "expires_at4",
  "user": {
    "id": 20,
    "name": "soban",
    "job_role": "Happy Person",
    "email": "sobanshahid47@gmail.com",
    "subdomain": "subdomain4",
    "email_verified_at": "2023-09-19T12:22:43.000000Z",
    "status": "active",
    "group": "subscriber",
    "workbook": "default workbook",
    "workbook_id": 21,
    "workbook_folder_id": 26,
    "product_id": 0,
    "plan_id": 3,
    "plan_type": "plan_type0",
    "company": "company0",
    "website": "website4",
    "phone_number": "phone_number2",
    "address": "address6",
    "city": "city0",
    "postal_code": "postal_code2",
    "country": "pakistan",
    "available_words": 11,
    "available_words_prepaid": 1000,
    "total_words": 11,
    "available_images": 11,
    "available_images_prepaid": 1000,
    "total_images": 11,
    "balance": 0,
    "total_chars": 0,
    "available_chars": 0,
    "available_chars_prepaid": 1000,
    "total_minutes": "0.000",
    "available_minutes": "0.000",
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
    "referral_id": "EGUYLK7WC4DNMQU",
    "referred_by": "",
    "referral_payment_method": "referral_payment_method2",
    "referral_paypal": "referral_paypal8",
    "referral_bank_requisites": "referral_bank_requisites0",
    "default_voiceover_language": "en-US",
    "default_temp_language": 0,
    "default_voiceover_voice": "en-US-Wavenet-J",
    "default_tone": "default_tone8",
    "subdomain_token": "subdomain_token4",
    "created_at": "2023-09-19T12:22:43.000000Z",
    "updated_at": "2023-09-19T12:22:43.000000Z"
  }
}
```

