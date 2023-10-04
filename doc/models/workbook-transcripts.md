
# Workbook Transcripts

## Structure

`WorkbookTranscripts`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Count` | `int` | Required | - |
| `Data` | [`List<Data7>`](../../doc/models/data-7.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "success",
  "message": "Data Fatched Successfully",
  "count": 1,
  "data": [
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
      "description": "description0",
      "storage": "local",
      "length": "13.767",
      "plan_type": "free",
      "size": "215.13 KB",
      "file_name": "AR_F_GadaB.mp3",
      "temp_name": "u9c4fizRqM.mp3",
      "expires_at": "2073-09-05 23:21:57",
      "created_at": "2023-09-19T10:21:57.000000Z",
      "updated_at": "2023-09-19T10:22:12.000000Z",
      "deleted_at": "deleted_at8"
    }
  ]
}
```

