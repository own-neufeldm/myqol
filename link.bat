@echo off
setlocal enabledelayedexpansion

:: Define base paths
set "SOURCE_BASE=C:\Users\Martin\repos\own-neufeldm\terraria-mods"
set "TARGET_BASE=C:\Users\Martin\Documents\My Games\Terraria\tModLoader\ModSources"

:: Check for at least one argument
if "%~1"=="" goto usage

:: Route commands
if /i "%~1"=="add" goto check_add
if /i "%~1"=="list" goto do_list
if /i "%~1"=="remove" goto check_remove

:: Fallthrough for invalid commands
goto usage

:check_add
if "%~2"=="" goto usage
goto do_add

:check_remove
if "%~2"=="" goto usage
goto do_remove

:do_add
set "FOLDER_NAME=%~2"
set "SRC_PATH=%SOURCE_BASE%\%FOLDER_NAME%"
set "TGT_PATH=%TARGET_BASE%\%FOLDER_NAME%"

if not exist "%SRC_PATH%" (
    echo [ERROR] Mod does not exist: %SRC_PATH%
    exit /b 1
)

mklink /d "%TGT_PATH%" "%SRC_PATH%"
goto :eof

:do_list
if not exist "%TARGET_BASE%" (
    echo [ERROR] Mod sources directory does not exist: %TARGET_BASE%
    exit /b 1
)

dir "%TARGET_BASE%" /b /ad
goto :eof

:do_remove
set "FOLDER_NAME=%~2"
set "TGT_PATH=%TARGET_BASE%\%FOLDER_NAME%"

if not exist "%TGT_PATH%" (
    echo [ERROR] Mod does not exist: %TGT_PATH%
    exit /b 1
)

rmdir "%TGT_PATH%"
goto :eof

:usage
echo Usage: link.bat COMMAND [ARGUMENT]
echo.
echo Manage soft-links for tModLoader mod sources.
echo.
echo Commands:
echo   add MOD     Add MOD to ModSources.
echo   list        List all mods in ModSources.
echo   remove MOD  Remove MOD from ModSources.
exit /b 1
