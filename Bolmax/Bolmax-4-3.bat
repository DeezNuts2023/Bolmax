@echo off

START Qres.exe /x 1024 /y 768

tasklist /FI "IMAGENAME eq cs2.exe" 2>NUL | find /I /N "cs2.exe">NUL
if "%ERRORLEVEL%"=="1" START steam://rungameid/730
timeout 10
:whilecsgo
timeout 7
tasklist /FI "IMAGENAME eq cs2.exe" 2>NUL | find /I /N "cs2.exe">NUL
if "%ERRORLEVEL%"=="0" goto :whilecsgo

START Qres.exe /x 1920 /y 1080

exit