# GiftBox

GiftBox is a Windows Forms desktop app for managing gifts and selecting a gift based on configurable priority rules.

## Features

- Maintain a list of gifts with name, period, priority, and type.
- Persist gift data to JSON in the user's AppData folder.
- Select gifts using weighted/period-based logic in `GiftManager`.

## Tech Stack

- .NET Windows Forms
- C#
- Newtonsoft.Json

## Project Structure

- `/home/runner/work/GiftBox/GiftBox/GiftBox/Program.cs` - app entry point
- `/home/runner/work/GiftBox/GiftBox/GiftBox/Form1.cs` - main UI
- `/home/runner/work/GiftBox/GiftBox/GiftBox/GiftManager.cs` - gift selection logic
- `/home/runner/work/GiftBox/GiftBox/GiftBox/GiftService.cs` - JSON persistence

## Run Locally

1. Open `/home/runner/work/GiftBox/GiftBox/GiftBox.sln` in Visual Studio.
2. Restore NuGet packages.
3. Build and run the `GiftBox` project.

## Data Storage

Gift data is saved to:

`%AppData%/GiftBox/gifts.json`