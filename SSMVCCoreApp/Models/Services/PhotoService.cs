using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using SSMVCCoreApp.Models.Abstract;

namespace SSMVCCoreApp.Models.Services
{
  public class PhotoService : IPhotoService
  {
    private CloudStorageAccount _storageAccount;
    private readonly ILogger<PhotoService> _logger;

    public PhotoService(IOptions<StorageUtility> storageUtility, ILogger<PhotoService> logger)
    {
      _storageAccount = storageUtility.Value.StorageAccount;
      _logger = logger;
    }

    public Task<string> UploadPhotoAsync(string category, IFormFile photoToUpload)
    {
      throw new NotImplementedException();
    }

    public Task<bool> DeletePhotoAsync(string category, string photoUrl)
    {
      throw new NotImplementedException();
    }
  }
}
