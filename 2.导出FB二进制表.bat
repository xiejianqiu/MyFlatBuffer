SET CUR_PATH=%~dp0
SET FlatBufferProj=%CUR_PATH%\FlatBuffer\FlatBufferTable
SET DLL_PATH=%FlatBufferProj%\FlatBufferTable\bin\Release\netcoreapp3.1\
SET EXPORT_EXEPATH=%FlatBufferProj%\ExportFBData\DLL
SET EXPORT_EXE=%EXPORT_EXEPATH%\ExportFBData.exe
SET TxtRoot=%CUR_PATH%\Tables
REM SET BinaryRoot=%CUR_PATH%\TMP_Text
SET BinaryRoot=%CUR_PATH%\shengwang\Assets\BundleData\Tables
SET CMD_PARGMA=TxtRoot %TxtRoot% BinaryRoot %BinaryRoot%

xcopy %DLL_PATH%\*.dll %EXPORT_EXEPATH% /y /q
CALL %EXPORT_EXE% %CMD_PARGMA%
PAUSE
