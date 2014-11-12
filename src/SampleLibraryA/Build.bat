"../nuget" restore SampleLibraryA.sln
msbuild SampleLibraryA.sln /p:Configuration=Release /t:rebuild
"../nuget" pack SampleLibraryA/SampleLibraryA.csproj -OutputDirectory "../Packages" -Prop Configuration=Release