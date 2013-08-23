nuget pack src/thedelegate.BlogDotNet/thedelegate.BlogDotNet/thedelegate.BlogDotNet.csproj -Build -Symbols -Properties Configuration=Release -OutputDirectory published_packages -Version %1
nuget pack src/thedelegate.BlogDotNet/thedelegate.BlogDotNet.ContentProvider.Markdown/thedelegate.BlogDotNet.ContentProvider.Markdown.csproj -Build -Symbols -Properties Configuration=Release  -OutputDirectory published_packages -Version %1
nuget pack src/thedelegate.BlogDotNet/thedelegate.BlogDotNet.ContentProvider.Textile/thedelegate.BlogDotNet.ContentProvider.Textile.csproj -Build -Symbols -Properties Configuration=Release  -OutputDirectory published_packages -Version %1


nuget push published_packages\blog-dot-net-content-provider-markdown.%1.nupkg
nuget push published_packages\blog-dot-net-content-provider-markdown.%1.symbols.nupkg

nuget push published_packages\blog-dot-net-content-provider-textile.%1.nupkg
nuget push published_packages\blog-dot-net-content-provider-textile.%1.symbols.nupkg

nuget push published_packages\blog-dot-net-core.%1.nupkg
nuget push published_packages\blog-dot-net-core.%1.symbols.nupkg