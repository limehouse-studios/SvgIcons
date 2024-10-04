# usage:
#   powershell .\publish_nuget.ps1
#   powershell .\publish_nuget.ps1 -Push:1

param (
    [string]$Folder = "X:\\NugetLocal",
    [string]$BuildConfig = "Release"
)

[xml]$xmlElem = Get-Content -Path LHS.SvgIcons.Blazor.csproj
$version = ($xmlElem.Project.PropertyGroup.Version).Trim()

Write-Host -ForegroundColor Green "Building LHS.SvgIcons.Blazor version $version"
&dotnet "pack" "-p:PackageVersion=$version" "LHS.SvgIcons.Blazor.csproj" "-c:$BuildConfig"

Write-Host -ForegroundColor Green "Pushing LHS.SvgIcons.Blazor version $version to $Folder"
&nuget "add" "bin/$BuildConfig/LHS.SvgIcons.Blazor.$version.nupkg" "-Source" "$Folder"