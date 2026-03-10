#define MyAppName "BlackThemeApp"
#ifndef AppVersion
  #define AppVersion "1.0.0"
#endif
#ifndef PublishDir
  #define PublishDir "..\\artifacts\\publish"
#endif

[Setup]
AppId={{8D9D12B6-3CDA-4EEE-A2CA-3A1E10071D8A}
AppName={#MyAppName}
AppVersion={#AppVersion}
AppPublisher=BlackThemeApp
DefaultDirName={autopf}\\{#MyAppName}
DefaultGroupName={#MyAppName}
DisableProgramGroupPage=yes
OutputDir=..\\artifacts\\installer
OutputBaseFilename=BlackThemeApp-Setup-{#AppVersion}
Compression=lzma
SolidCompression=yes
WizardStyle=modern
ArchitecturesInstallIn64BitMode=x64compatible

[Languages]
Name: "polish"; MessagesFile: "compiler:Languages\\Polish.isl"
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "Utwórz skrót na pulpicie"; GroupDescription: "Dodatkowe skróty:"; Flags: unchecked

[Files]
Source: "{#PublishDir}\\BlackThemeApp.exe"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{autoprograms}\\{#MyAppName}"; Filename: "{app}\\BlackThemeApp.exe"
Name: "{autodesktop}\\{#MyAppName}"; Filename: "{app}\\BlackThemeApp.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\\BlackThemeApp.exe"; Description: "Uruchom {#MyAppName}"; Flags: nowait postinstall skipifsilent
