![](https://img.shields.io/badge/api-v2.0-lightgrey) ![Nuget](https://img.shields.io/nuget/v/GroupDocs.Signature-Cloud) ![Nuget](https://img.shields.io/nuget/dt/GroupDocs.Signature-Cloud) [![GitHub license](https://img.shields.io/github/license/groupdocs-signature-cloud/groupdocs-signature-cloud-dotnet)](https://github.com/groupdocs-signature-cloud/groupdocs-signature-cloud-dotnet/blob/master/LICENSE) 

# .NET SDK to e-Sign Documents in the Cloud

[GroupDocs.Signature Cloud SDK for .NET](https://products.groupdocs.cloud/signature/net) wraps GroupDocs.Signature RESTful APIs so you may integrate Document Signing features in your own apps with zero initial cost.

GroupDocs.Signature Cloud API allows the developers to create, remove, verify and search different types of signature objects in a number of document formats including Word documents, Excel speradsheets, PowerPoint presentations, PDF, OpenDocument formats & images.

## Manipulate Digital Signatures

- Add stamp, text, barcode, QR-code, image & digital signatures.
- Verify signatures.
- Search signatures.
- Update & delete signatures by ID.
- Get a list of supported document formats.
- Get a list of supported barcode & QR-Code encode type names.
- Extract document properties like  size, creation and update dates, page count and so on.

Check out the [Developer's Guide](https://docs.groupdocs.cloud/signature/developer-guide/) to know more about GroupDocs.Signature REST API.

## Supported Signature Types

- Text Signature - adds text label with the ability to align the signature location on page area, set font and colors, and so on.
- Image Signature - adds image label with the ability to control opacity, gray scale filter, brightness, contracts etc.
- Barcode Signature - puts barcode on document pages with the ability to control appearance and alignment.
- QR-Code Signature - places QR-code on document pages with additional settings.
- Digital Signature - adds digital signatures via certificate files (PFX, CRT) on a document or separate pages (PDF only).
- Stamp Signature - stamps document pages.

## Microsoft Office Formats

**Microsoft Word:** DOC, DOCM, DOCX, DOT, DOTM, DOTX\
**Microsoft Excel:** XLS, XLSB, XLSB, XLSX, XLT, XLTM, XLTX\
**Microsoft PowerPoint:** POT, POTM, POTX, PPS, PPT, PPTM, PPTX

## Other Document Formats

**Portable:** PDF\
**OpenDocument:** ODT, OTT, ODP, OTP\
**Images:** BMP, PNG, JPG, JPEG, TIFF, GIF, CDR\
**Others:** TXT, RTF

## Get Started with GroupDocs.Signature Cloud SDK for .NET

First create an account at [GroupDocs for Cloud](https://dashboard.groupdocs.cloud/) and get your application information. Next,  execute `Install-Package GroupDocs.Signature-Cloud` from Package Manager Console in Visual Studio to fetch & reference the SDK in your project. If you already have the package and wish to upgrade it, please execute `Update-Package GroupDocs.Signature-Cloud` to get the latest version.

### Dependencies

- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json)

## Get List of Supported Formats for e-Signing

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

## GroupDocs.Signature Cloud SDKs in Popular Languages

| .NET | Java | PHP | Python | Ruby | Node.js |
|---|---|---|---|---|---|
| [GitHub](https://github.com/groupdocs-signature-cloud/groupdocs-signature-cloud-dotnet) | [GitHub](https://github.com/groupdocs-signature-cloud/groupdocs-signature-cloud-java) | [GitHub](https://github.com/groupdocs-signature-cloud/groupdocs-signature-cloud-php) | [GitHub](https://github.com/groupdocs-signature-cloud/groupdocs-signature-cloud-python) | [GitHub](https://github.com/groupdocs-signature-cloud/groupdocs-signature-cloud-ruby)  | [GitHub](https://github.com/groupdocs-signature-cloud/groupdocs-signature-cloud-node) |
| [NuGet](https://www.nuget.org/packages/GroupDocs.Signature-Cloud/) | [Maven](https://repository.groupdocs.cloud/webapp/#/artifacts/browse/tree/General/repo/com/groupdocs/groupdocs-signature-cloud) | [Composer](https://packagist.org/packages/groupdocscloud/groupdocs-signature-cloud) | [PIP](https://pypi.org/project/groupdocs-signature-cloud/) | [GEM](https://rubygems.org/gems/groupdocs_signature_cloud)  | [NPM](https://www.npmjs.com/package/groupdocs-signature-cloud) | 

[Home](https://www.groupdocs.cloud/) | [Product Page](https://products.groupdocs.cloud/signature/net) | [Documentation](https://docs.groupdocs.cloud/signature/) | [Live Demo](https://products.groupdocs.app/signature/total) | [API Reference](https://apireference.groupdocs.cloud/signature/) | [Code Samples](https://github.com/groupdocs-signature-cloud/groupdocs-signature-cloud-dotnet-samples) | [Blog](https://blog.groupdocs.cloud/category/signature/) | [Free Support](https://forum.groupdocs.cloud/c/signature) | [Free Trial](https://dashboard.groupdocs.cloud)
