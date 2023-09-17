@echo OFF
if exist list.txt del list.txt /q
SET input=../dt_tables
if not exist "%input%" goto input
for %%i in ("%input%") do if /i "%%~di"==%%i goto input
pushd %cd%
cd /d "%input%">nul 2>nul || exit
set cur_dir=%cd%
popd
for /f "delims=" %%i in ('dir /b /a-d /s "%input%"') do (
	call flatc.exe -n %%i --gen-onefile
)
pause