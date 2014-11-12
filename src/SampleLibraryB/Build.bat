"../nuget" restore SampleLibraryB.sln
msbuild SampleLibraryB.sln /p:Configuration=Release /t:rebuild
"../nuget" pack SampleLibraryB/SampleLibraryB.csproj -OutputDirectory "../Packages" -Prop Configuration=Release