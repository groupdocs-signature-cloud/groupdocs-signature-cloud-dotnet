# GroupDocs.Signature Cloud SDK for .NET
This repository contains GroupDocs.Signature Cloud SDK for .NET source code. This SDK allows you to work with GroupDocs.Signature Cloud REST APIs in your .NET applications.

## How to use the SDK?
The complete source code is available in this repository folder, you can either directly use it in your project via NuGet package manager. For more details, please visit our [documentation website](https://docs.groupdocs.cloud/signature/available-sdks/).

## Dependencies
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json)

## Getting Started

```csharp
using System;
using System.Diagnostics;
using GroupDocs.Signature.Cloud.Sdk.Api;
using GroupDocs.Signature.Cloud.Sdk.Client;

namespace Example
{
    public class Example
    {
        public void Main()
        {
            //TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).
            var appSid = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX";
            var appKey = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

            var config = new Configuration(appSid, appKey)
            {
                ApiBaseUrl = "https://api.groupdocs.cloud"
            };

            var api = new InfoApi(config);

            try
            {
                // Get supported file formats
                var response = api.GetSupportedFileFormats();

                foreach (var format in response.Formats)
                {
                    Debug.Print(format.ToString());
                }
            }
            catch (Exception e)
            {
                Debug.Print("Something went wrong: " + e.Message);
            }
        }
    }
}
```

## Licensing
All GroupDocs.Signature Cloud SDKs are licensed under [MIT License](LICENSE).

[Home](https://www.groupdocs.cloud/) | [Product Page](https://products.groupdocs.cloud/signature/net) | [Docs](https://docs.groupdocs.cloud/signature/) | [Demos](https://products.groupdocs.app/signature/family) | [API Reference](https://apireference.groupdocs.cloud/signature/) | [Examples](https://github.com/groupdocs-signature-cloud/groupdocs-signature-cloud-dotnet-samples) | [Blog](https://blog.groupdocs.cloud/category/signature/) | [Free Support](https://forum.groupdocs.cloud/c/signature) | [Free Trial](https://purchase.groupdocs.cloud/trial)
