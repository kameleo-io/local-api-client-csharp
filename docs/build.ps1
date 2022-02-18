autorest --verbose --input-file=./docs/swagger.json --csharp --output-folder=./output --namespace=Kameleo.LocalApiClient --override-client-name=KameleoLocalApiClient --legacy
Copy-Item -Force -Recurse  -Path .\\output\* -Destination .\\src
Remove-Item -Force -Recurse -Path .\\output
