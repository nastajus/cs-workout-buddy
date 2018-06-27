//todo, automate below and eliminate with some kind of build system

i need a build system. for the moment, i manually generate the updated grpc code by 
- opening a powershell at the `\cs-workout-buddy` level.
- running this command
  - ` .\WobuServices\protos\ --csharp_out WobuServices --grpc_out WobuServices .\WobuServices\protos\Everythi
ng.proto --plugin=protoc-gen-grpc=.\packages\Grpc.Tools.1.12.0\tools\windows_x64\grpc_csharp_plugin.exe
PS C:\Users\GMunion\Documents\Visual Studio 2017\Projects\cs-workout-buddy>`