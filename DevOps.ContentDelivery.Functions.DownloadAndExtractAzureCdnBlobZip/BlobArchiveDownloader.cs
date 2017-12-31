using DevOps.ContentDelivery.Structures.AzureBlob;
using static Common.Functions.DownloadAndExtractZip.ZipDownloaderAndExtractor;
using static DevOps.ContentDelivery.Functions.ResolveAzureCdnBlobUrl.UrlResolver;

namespace DevOps.ContentDelivery.Functions.DownloadAndExtractAzureCdnBlobZip
{
    public static class BlobArchiveDownloader
    {
        public static void Extract(string endpointName, Blob blob, string destinationPath)
            => DownloadAndExtract(
                Uri(endpointName, blob),
                destinationPath);
    }
}
