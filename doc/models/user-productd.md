
# User Productd

## Structure

`UserProductd`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`List<Data13>`](../../doc/models/data-13.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "success",
  "message": "Data fateched Successfully",
  "data": [
    {
      "id": 4,
      "user_id": 1,
      "name": "Programming new",
      "description": "Get your code",
      "feature_image": "assets/product_feature/64a71a7d35b1c_image.png",
      "bullet_points": "55",
      "target_audience": "55",
      "tags": "[\"sdffddf\",\"dfgfhjhk\",\"dfghjk\"]",
      "deleted_at": "deleted_at8"
    },
    {
      "id": 5,
      "user_id": 11,
      "name": "shahzaman",
      "description": "detail about shahzaman",
      "feature_image": "feature_image8",
      "bullet_points": "55",
      "target_audience": "55",
      "tags": "tags0",
      "deleted_at": "deleted_at8"
    },
    {
      "id": 6,
      "user_id": 0,
      "name": "MATGARLI SAAS",
      "description": "matgarli saas applcation help the vendors to  create online store in one click , the veondors can sell any kind of products",
      "feature_image": "https://www.taamfly.com/assets/empty.jpg",
      "bullet_points": "55",
      "target_audience": "vendors , sellers",
      "tags": "[\"vendors\",\"sellers\"]",
      "deleted_at": "deleted_at8"
    },
    {
      "id": 7,
      "user_id": 0,
      "name": "asdas",
      "description": "sdfsdfsd",
      "feature_image": "https://taamfly.com/assets/empty.jpg",
      "bullet_points": "1321",
      "target_audience": "dfdsgsd",
      "tags": "[\"asdas\"]",
      "deleted_at": "deleted_at8"
    },
    {
      "id": 8,
      "user_id": 0,
      "name": "new",
      "description": "new",
      "feature_image": "https://taamfly.com/assets/empty.jpg",
      "bullet_points": "32321",
      "target_audience": "dfdsgsd",
      "tags": "[\"asd\"]",
      "deleted_at": "deleted_at8"
    },
    {
      "id": 9,
      "user_id": 1,
      "name": "truth smokeshop and vape",
      "description": "The top smoke shop and vapes and the best customer support. Shop for bongs, dab rigs, hand pipes, vaporizers and other smoking accessories.",
      "feature_image": "assets/product_feature/64b89f965465f_Truth.png",
      "bullet_points": "asdas",
      "target_audience": "all",
      "tags": "[\"vapes\",\"tobacco\"]",
      "deleted_at": "deleted_at8"
    }
  ]
}
```

