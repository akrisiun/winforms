
dotnet msbuild src\HelloForms /v:m

dotnet msbuild src\System.Windows.Forms\tests\UnitTests /v:m

dotnet test src\System.Windows.Forms\tests\UnitTests `
	 --no-build -v n   | select-string -pattern Passed -NotMatch `
	 | select-string -pattern xUnit. -NotMatch

# $psVersiontable
dotnet --info | findstr : | select-string -pattern 2. -notmatch
