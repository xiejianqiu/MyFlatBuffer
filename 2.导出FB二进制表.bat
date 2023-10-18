SET CUR_PATH=%~dp0
SET FlatBufferProj=%CUR_PATH%FlatBuffer\FlatBufferTable
SET DLL_PATH=
SET EXPORT_EXE=%FlatBufferProj%\FlatBufferTable\bin\Release\netcoreapp3.1\FlatBufferTable.exe
SET TxtRoot=%CUR_PATH%\Tables
SET BinaryRoot=%CUR_PATH%\shengwang\Assets\BundleData\Tables
SET csSavePath=%CUR_PATH%\shengwang\hotfix\hotfix\iLScript\flatbuffers
SET CMD_PARGMA=TxtRoot %TxtRoot% BinaryRoot %BinaryRoot% csSavePath %csSavePath%
CALL %EXPORT_EXE% %CMD_PARGMA%

SET hotfixPath=%CUR_PATH%\shengwang\hotfix\
CD /D %hotfixPath%
dotnet clean
dotnet build -c Release
PAUSE
