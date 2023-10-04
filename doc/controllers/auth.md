# Auth

```csharp
AuthController authController = client.AuthController;
```

## Class Name

`AuthController`

## Methods

* [Login](../../doc/controllers/auth.md#login)
* [Register](../../doc/controllers/auth.md#register)


# Login

```csharp
LoginAsync(
    string email,
    string password)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `email` | `string` | Form, Required | - |
| `password` | `string` | Form, Required | - |

## Response Type

[`Task<Models.Login>`](../../doc/models/login.md)

## Example Usage

```csharp
string email = "sobanshahid47@gmail.com";
string password = "ali112233";
try
{
    Login result = await authController.LoginAsync(
        email,
        password
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "status": true,
  "message": "Successfully logged in",
  "access_token": "6|b6WIe6smnjl2dP0Yulzu8TsQnr6UtAV2SmtiKj3V",
  "token_type": "Bearer",
  "expires_at": null,
  "user": {
    "id": 20,
    "name": "soban",
    "job_role": "Happy Person",
    "email": "sobanshahid47@gmail.com",
    "subdomain": null,
    "email_verified_at": "2023-09-19T12:22:43.000000Z",
    "status": "active",
    "group": "subscriber",
    "workbook": "default workbook",
    "workbook_id": 21,
    "workbook_folder_id": 26,
    "product_id": 0,
    "plan_id": 3,
    "plan_type": null,
    "company": null,
    "website": null,
    "phone_number": null,
    "address": null,
    "city": null,
    "postal_code": null,
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
    "profile_photo_path": null,
    "oauth_id": null,
    "oauth_type": null,
    "last_seen": null,
    "member_role": 0,
    "parent_id": 0,
    "ckbox": null,
    "google2fa_secret": null,
    "google2fa_enabled": 0,
    "referral_id": "EGUYLK7WC4DNMQU",
    "referred_by": "",
    "referral_payment_method": null,
    "referral_paypal": null,
    "referral_bank_requisites": null,
    "default_voiceover_language": "en-US",
    "default_temp_language": 0,
    "default_voiceover_voice": "en-US-Wavenet-J",
    "default_tone": null,
    "subdomain_token": null,
    "created_at": "2023-09-19T12:22:43.000000Z",
    "updated_at": "2023-09-19T12:22:43.000000Z"
  }
}
```


# Register

```csharp
RegisterAsync(
    string name,
    string email,
    string password,
    string country,
    string subdomain)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `string` | Query, Required | - |
| `email` | `string` | Query, Required | - |
| `password` | `string` | Query, Required | - |
| `country` | `string` | Query, Required | - |
| `subdomain` | `string` | Query, Required | - |

## Response Type

[`Task<Models.ExampleWithDefaultPlanSubdomainAndSubsctpion>`](../../doc/models/example-with-default-plan-subdomain-and-subsctpion.md)

## Example Usage

```csharp
string name = "soban";
string email = "sobanshahid47@gmail.com";
string password = "ali112233";
string country = "pakistan";
string subdomain = "friend";
try
{
    ExampleWithDefaultPlanSubdomainAndSubsctpion result = await authController.RegisterAsync(
        name,
        email,
        password,
        country,
        subdomain
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

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

