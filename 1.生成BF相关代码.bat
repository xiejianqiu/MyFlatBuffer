REM jsonPath,//cs表类结构存储路径
REM fbSavePath,//FlatBuffer表结构存储路径
REM csSavePath,//生成的CS代码存储陆建国
REM FBProviderTT,//provider模板存放陆建国
REM FBInitTT,//将Table导出文件二进制文件
REM hotfixPath,//将Tab代码替换为FB代码
REM GenFB,//是否生成table结构,
REM GenCls,//是否生成cs代码
REM RelCode,//是否替换代码
SET CUR_PATH=%~dp0
SET ToolDir=%CUR_PATH%Tools\JsonPaserTool
SET JsonPaserEXE=%ToolDir%\JsonPaser.exe

SET jsonPath=%CUR_PATH%FlatBuffer\TableStructure.txt
SET fbSavePath=%CUR_PATH%FlatBuffer\Tables

SET FBProviderTT=%ToolDir%\FBProvider.txt
SET FBInitTT=%ToolDir%\FBBinaryExport.txt
SET FlatBufferProj=%CUR_PATH%FlatBuffer\FlatBufferTable\FlatBufferTable
SET csSavePath=%FlatBufferProj%\FlatBuffer

SET hotfixPath=F:\dlc9_20220704_webgl\shengwang\hotfix\hotfix\iLScript

SET COMMON_PARMA=jsonPath %jsonPath%
SET GEN_FB_TABLE=fbSavePath %fbSavePath%
SET CODE_PARMA=FBProviderTT %FBProviderTT% FBInitTT %FBInitTT% csSavePath %csSavePath%
SET REPLACE_CDEE_PARMA=hotfixPath %hotfixPath%

SET GenFB=true
SET GenCls=true
SET RelCode=false
SET CONTROL_CMD=GenFB %GenFB% GenCls %GenCls% RelCode %RelCode%

if %GenCls% == false GOTO BAT_END
GEN_FB_TABLE_DLL:
CALL %JsonPaserEXE% %CONTROL_CMD% %COMMON_PARMA% %GEN_FB_TABLE% %CODE_PARMA% %REPLACE_CDEE_PARMA%

CD %FlatBufferProj%
SET DLL_PATH=%FlatBufferProj%\bin\Release\netcoreapp3.1
SET DLL_SAVEPATH=%CUR_PATH%shengwang\Assets\Plugins\FlatBuffer
dotnet clean
dotnet build -c Release
xcopy %DLL_PATH%\FlatBufferTable.dll %DLL_SAVEPATH% /y /q


BAT_END:
ECHO FINISH!!!!!!!
PAUSE
