
# Workbook Voiceovers

## Structure

`WorkbookVoiceovers`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Count` | `int` | Required | - |
| `Data` | [`List<Data6>`](../../doc/models/data-6.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "success",
  "message": "Data Fatched Successfully",
  "count": 1,
  "data": [
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
      "project": "project4",
      "expires_at": "expires_at4",
      "created_at": "2023-09-05T07:12:12.000000Z",
      "updated_at": "2023-09-05T07:12:12.000000Z",
      "deleted_at": "deleted_at8"
    }
  ]
}
```

