param(
    [string]$Configuration = "Release",
    [string]$Runtime = "win-x64",
    [string]$Version = "1.0.0"
)

$ErrorActionPreference = "Stop"

$projectPath = Join-Path $PSScriptRoot "..\BlackThemeApp\BlackThemeApp.csproj"
$publishDir = Join-Path $PSScriptRoot "..\artifacts\publish"
$installerScript = Join-Path $PSScriptRoot "..\installer\BlackThemeApp.iss"

Write-Host "[1/3] Publikowanie aplikacji do pojedynczego EXE..."
dotnet publish $projectPath `
    -c $Configuration `
    -r $Runtime `
    --self-contained true `
    /p:PublishSingleFile=true `
    /p:IncludeNativeLibrariesForSelfExtract=true `
    /p:DebugType=None `
    /p:DebugSymbols=false `
    -o $publishDir

if (-not (Get-Command iscc -ErrorAction SilentlyContinue)) {
    throw "Nie znaleziono Inno Setup Compiler (iscc). Zainstaluj Inno Setup i dodaj iscc do PATH."
}

Write-Host "[2/3] Budowanie instalatora EXE (Inno Setup)..."
iscc "/DAppVersion=$Version" "/DPublishDir=$publishDir" $installerScript

Write-Host "[3/3] Gotowe. Instalator znajdziesz w katalogu artifacts\\installer"
