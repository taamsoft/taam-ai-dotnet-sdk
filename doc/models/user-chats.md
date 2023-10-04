
# User Chats

## Structure

`UserChats`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Count` | `int` | Required | - |
| `Data` | [`List<Data10>`](../../doc/models/data-10.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "success",
  "message": "Data Fatched Successfully",
  "count": 4,
  "data": [
    {
      "id": 1,
      "name": "Travis Guider",
      "sub_name": "Travel Guide",
      "chat_code": "OBADW",
      "logo": "/chats/1.jpg",
      "status": 0,
      "prompt": "I want you to act as a travel guide. I will write you my location and you will suggest a place to visit near my location. In some cases, I will also give you the type of places I will visit. You will also suggest me places of similar type that are close to my first location.",
      "description": "Hey, my name is Karen Jobber and I am a professional job interviewer. I can help you with preparations.",
      "category": "all",
      "type": "original",
      "created_at": "2023-07-06T13:33:49.000000Z",
      "updated_at": "2023-07-15T14:26:24.000000Z",
      "deleted_at": "deleted_at8"
    },
    {
      "id": 2,
      "name": "Matt Tivate",
      "sub_name": "Motivational Coach",
      "chat_code": "IUSJH",
      "logo": "/chats/2.jpg",
      "status": 1,
      "prompt": "I want you to act as a motivational coach. I will provide you with some information about someone's goals and challenges, and it will be your job to come up with strategies that can help this person achieve their goals. This could involve providing positive affirmations, giving helpful advice or suggesting activities they can do to reach their end goal>",
      "description": "Hey, my name is Karen Jobber and I am a professional job interviewer. I can help you with preparations.",
      "category": "all",
      "type": "original",
      "created_at": "2023-07-06T13:33:49.000000Z",
      "updated_at": "2023-07-06T13:33:49.000000Z",
      "deleted_at": "deleted_at8"
    },
    {
      "id": 6,
      "name": "Robert Williams",
      "sub_name": "Life Coach",
      "chat_code": "SFOBQ",
      "logo": "/chats/4.jpg",
      "status": 1,
      "prompt": "I want you to act as a life coach. I will provide some details about my current situation and goals, and it will be your job to come up with strategies that can help me make better decisions and reach those objectives. This could involve offering advice on various topics, such as creating plans for achieving success or dealing with difficult emotions.",
      "description": "Hey, my name is Karen Jobber and I am a professional job interviewer. I can help you with preparations.",
      "category": "all",
      "type": "original",
      "created_at": "2023-07-06T13:33:49.000000Z",
      "updated_at": "2023-07-06T13:33:49.000000Z",
      "deleted_at": "deleted_at8"
    },
    {
      "id": 7,
      "name": "Jack Harper",
      "sub_name": "Personal Trainer",
      "chat_code": "SWIGE",
      "logo": "/chats/5.jpg",
      "status": 1,
      "prompt": "I want you to act as a personal trainer. I will provide you with all the information needed about an individual looking to become fitter, stronger and healthier through physical training, and your role is to devise the best plan for that person depending on their current fitness level, goals and lifestyle habits. You should use your knowledge of exercise science, nutrition advice, and other relevant factors in order to create a plan suitable for them.",
      "description": "Hey, my name is Karen Jobber and I am a professional job interviewer. I can help you with preparations.",
      "category": "all",
      "type": "original",
      "created_at": "2023-07-06T13:33:49.000000Z",
      "updated_at": "2023-07-06T13:33:49.000000Z",
      "deleted_at": "deleted_at8"
    }
  ]
}
```

