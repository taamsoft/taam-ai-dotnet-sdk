
# Generate Code

## Structure

`GenerateCode`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Text` | `string` | Required | - |
| `Status` | `string` | Required | - |
| `Id` | `int` | Required | - |
| `Old` | `string` | Required | - |
| `Current` | `int` | Required | - |

## Example (as JSON)

```json
{
  "text": "Sure, Here's a basic PHP script to upload an image to a server. This code assumes that you have a form in HTML that allows users to choose the image they want to upload.\n\n```php\n<?php\n   if(isset($_POST['submit'])){\n      $errors= array();\n      $file_name = $_FILES['image']['name'];\n      $file_size = $_FILES['image']['size'];\n      $file_tmp = $_FILES['image']['tmp_name'];\n      $file_type = $_FILES['image']['type'];\n      $file_ext = strtolower(pathinfo($file_name, PATHINFO_EXTENSION));\n\n      $extensions= array(\"jpeg\",\"jpg\",\"png\");\n\n      if(in_array($file_ext,$extensions) === false){\n         $errors[]=\"extension not allowed, please choose a JPEG or PNG file.\";\n      }\n\n      if($file_size > 2097152){\n         $errors[]='File size must be less than 2 MB';\n      }\n\n      if(empty($errors) == true){\n         move_uploaded_file($file_tmp,\"images/\".$file_name);\n         echo \"Image Successfully Uploaded!\";\n      } else {\n         print_r($errors);\n      }\n   }\n?>\n```\n\nThis code checks if the image has the correct filetype and file size less than 2MB. If all conditions are correct, it uploads the image file to the \"images\" directory. Else, it prints out the corresponding errors.\n\nYou will also need a HTML form as below:\n\n```html\n<form action = \"\" method = \"POST\" enctype = \"multipart/form-data\">\n     <input type = \"file\" name = \"image\" />\n     <input type = \"submit\" name = \"submit\"/>\n</form>\n```\nThis form should be placed in the same PHP file above. \n\nPlease remember to create the directory where the image file will be saved if it doesn't exist yet. Make sure that its permissions allow the web server to write files.",
  "status": "success",
  "id": 31,
  "old": "10000000",
  "current": 9999572
}
```

