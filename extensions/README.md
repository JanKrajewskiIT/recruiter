## To build nuget package, in solution folder run 

```sh
> dotnet pack
```

## To be able to publish nuget fill PERSONAL TOKEN in nuget.config file

## To publish nuget run command for each projekt

```sh
> dotnet nuget push "Extensions.Domain/bin/Release/Extensions.Domain.1.0.0.nupkg" --source "github"
```