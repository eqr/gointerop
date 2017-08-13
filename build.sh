rm -rf bin
rm -rf output
rm libcgo.*
dotnet publish -o output
go build -buildmode=c-shared -o libgo.so main.go
cp libgo.so /output/libgo.so
dotnet run /output/interop.dll
