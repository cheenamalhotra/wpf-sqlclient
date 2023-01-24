# Sample WPF App with Microsoft.Data.SqlClient

This app is a minimum WPF app to demonstrate working with `Microsoft.Data.SqlClient` in WPF package applications. Targets are added to WPF.Package.wapproj file to make this workflow work. They can be proposed to be included by default in the Microsoft.Data.SqlClient.SNI.targets file for future reference.

## Steps to run the application

1. Clone this repo.
2. Update the [connection string](./WPF/MainWindow.xaml.cs#L23) with a valid one.
3. Build the solution to restore all nuget packages.
4. Start the project "WPF.Package".
