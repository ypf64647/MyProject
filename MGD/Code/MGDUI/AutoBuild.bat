
echo reset IIS
echo iisreset

echo beging copy UI dll to portal

copy .\bin\Debug\UFIDA.U9.Cust.MGDUI.WebPart.dll  D:\yonyou\U9V60\Portal\UILib
copy .\bin\Debug\UFIDA.U9.Cust.MGDUI.WebPart.pdb  D:\yonyou\U9V60\Portal\UILib

echo begin run build UI Script
echo 目录：.\..\..\..\..\..\yonyou\UBFV60\U9.VOB.Product.Other\\u_ui\UIScript\

echo .\..\..\..\..\..\yonyou\UBF-双环\U9.VOB.Product.UBF\UBFStudio\Runtime\\..\DBScriptExecutor.exe -connStr "User Id=sa;Password=Bcfood45000@;Data Source=U9TEST;Initial Catalog=BC;packet size=4096;Max Pool size=500;Connection Timeout=5;persist security info=True;MultipleActiveResultSets=true;" -NotDropDB -NotWriteLog -ExecuteDelete .\..\..\..\UBFV60\U9.VOB.Product.Other\\u_ui\UIScript\

echo ui buid end
pause

