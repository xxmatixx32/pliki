# BlackThemeApp (Visual Studio)

Prosty projekt aplikacji Windows Forms w czarnym motywie z 4 przyciskami funkcyjnymi: **1, 2, 3, 4**.

## Chcę po prostu gotowy EXE do pobrania

Najprościej (bez instalowania niczego lokalnie):

1. Wrzuć to repo na GitHub.
2. Otwórz zakładkę **Actions**.
3. Wybierz workflow **Build Windows EXE**.
4. Kliknij **Run workflow** (domyślnie wersja `1.0.0`).
5. Po zakończeniu masz 2 opcje pobrania:
   - z **Artifacts**: `BlackThemeApp-win-x64-exe` (ZIP z `BlackThemeApp.exe`) i `BlackThemeApp-setup-exe` (instalator),
   - z zakładki **Releases**: gotowe pliki pod tagiem `v<wersja>`.

To jest dokładnie ścieżka dla osób „nie technicznych” — kilka kliknięć i masz plik `.exe`.

## Uruchomienie w Visual Studio

1. Otwórz plik `BlackThemeApp.sln` w Visual Studio 2022.
2. Ustaw projekt `BlackThemeApp` jako Startup Project (jeśli nie ustawi się automatycznie).
3. Uruchom aplikację (`F5`).

## Budowanie gotowego instalatora `.exe` lokalnie (Windows)

Jeśli chcesz budować lokalnie:

1. Zainstaluj **.NET SDK 8**.
2. Zainstaluj **Inno Setup 6** i dodaj `iscc` do `PATH`.
3. Otwórz PowerShell w katalogu repozytorium i uruchom:

```powershell
./scripts/Build-Installer.ps1 -Configuration Release -Runtime win-x64 -Version 1.0.0
```

Po wykonaniu:
- opublikowana aplikacja (pojedynczy EXE) trafi do: `artifacts/publish/BlackThemeApp.exe`,
- gotowy instalator trafi do: `artifacts/installer/BlackThemeApp-Setup-1.0.0.exe`.

## Co robi aplikacja

- Wyświetla 4 przyciski funkcyjne (`1`, `2`, `3`, `4`) w czarnym motywie.
- Po kliknięciu przycisku aktualizuje etykietę statusu informacją o uruchomionej funkcji.
