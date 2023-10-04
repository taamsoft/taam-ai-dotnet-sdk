# Misc

```csharp
MiscController miscController = client.MiscController;
```

## Class Name

`MiscController`

## Methods

* [All Categories](../../doc/controllers/misc.md#all-categories)
* [New Request](../../doc/controllers/misc.md#new-request)


# All Categories

```csharp
AllCategoriesAsync(
    int userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `int` | Query, Required | - |

## Response Type

`Task`

## Example Usage

```csharp
int userId = 40;
try
{
    await miscController.AllCategoriesAsync(userId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# New Request

```csharp
NewRequestAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await miscController.NewRequestAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

