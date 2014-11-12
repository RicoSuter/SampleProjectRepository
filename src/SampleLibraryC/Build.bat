"../nuget" restore SampleLibraryC.sln
msbuild SampleLibraryC.sln /p:Configuration=Release /t:rebuild
"../nuget" pack SampleLibraryC/SampleLibraryC.csproj -OutputDirectory "../Packages" -Prop Configuration=Release