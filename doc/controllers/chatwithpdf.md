# Chatwithpdf

```csharp
ChatwithpdfController chatwithpdfController = client.ChatwithpdfController;
```

## Class Name

`ChatwithpdfController`

## Methods

* [Upload File for Chat Pdf](../../doc/controllers/chatwithpdf.md#upload-file-for-chat-pdf)
* [Send and Get Msg to Chat Pdf](../../doc/controllers/chatwithpdf.md#send-and-get-msg-to-chat-pdf)
* [Pdf to Text](../../doc/controllers/chatwithpdf.md#pdf-to-text)
* [File Upload](../../doc/controllers/chatwithpdf.md#file-upload)
* [Answer the Question](../../doc/controllers/chatwithpdf.md#answer-the-question)
* [New Request](../../doc/controllers/chatwithpdf.md#new-request)


# Upload File for Chat Pdf

```csharp
UploadFileForChatPdfAsync(
    FileStreamInfo file)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `file` | `FileStreamInfo` | Form, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
FileStreamInfo file = new FileStreamInfo(new FileStream("dummy_file", FileMode.Open));
try
{
    await chatWithPdfController.UploadFileForChatPdfAsync(file);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Send and Get Msg to Chat Pdf

```csharp
SendAndGetMsgToChatPdfAsync(
    string question)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `question` | `string` | Form, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
string question = "what is the education";
try
{
    await chatWithPdfController.SendAndGetMsgToChatPdfAsync(question);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Pdf to Text

```csharp
PdfToTextAsync(
    FileStreamInfo file)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `file` | `FileStreamInfo` | Form, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
FileStreamInfo file = new FileStreamInfo(new FileStream("dummy_file", FileMode.Open));
try
{
    await chatWithPdfController.PdfToTextAsync(file);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# File Upload

```csharp
FileUploadAsync(
    FileStreamInfo file)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `file` | `FileStreamInfo` | Form, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
FileStreamInfo file = new FileStreamInfo(new FileStream("dummy_file", FileMode.Open));
try
{
    await chatWithPdfController.FileUploadAsync(file);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Answer the Question

```csharp
AnswerTheQuestionAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await chatWithPdfController.AnswerTheQuestionAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# New Request

```csharp
NewRequestAsync(
    string question,
    string path)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `question` | `string` | Query, Required | - |
| `path` | `string` | Query, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
string question = "what data this file contains";
string path = "assets/pdf/64ef458eabc4e_Soban-Shahid (Laravel).pdf";
try
{
    await chatWithPdfController.NewRequestAsync(
        question,
        path
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

