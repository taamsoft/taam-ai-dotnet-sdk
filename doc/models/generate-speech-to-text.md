
# Generate Speech to Text

## Structure

`GenerateSpeechToText`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Text` | `string` | Required | - |
| `Status` | `string` | Required | - |
| `Url` | `string` | Required | - |
| `Id` | `int` | Required | - |
| `Old` | `string` | Required | - |
| `Current` | `int` | Required | - |

## Example (as JSON)

```json
{
  "text": "Marhaban, ana al-mutahaddithi al-iftiradi min imza'i al-jawda. Da'ani ulqi al-tahiyyata ala jumhourik wa u'arrifahom ala muntajatik abra wasilatin min akthar al-wasaili al-taswiqiya, tashwiqan wa mut'a.",
  "status": "success",
  "url": "http://127.0.0.1:8000/transcribe/0p8DmYbj2WkiONOe1xsSf6nVIZERRJgE8RJELnvG.mp3",
  "id": 43,
  "old": "10000000",
  "current": 10000000
}
```

