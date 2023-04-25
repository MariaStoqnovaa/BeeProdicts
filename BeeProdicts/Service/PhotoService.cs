using BeeProdicts.Helpers;
using BeeProdicts.Interface;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Options;

namespace BeeProdicts.Service
{
    public class PhotoService : IPhotoService
    {
        private readonly Cloudinary _cloudinary;

        public PhotoService(IOptions<CloudinarySettings> config)
        {
            var account = new Account(
                config.Value.CloudName,
                config.Value.ApiKey,
                config.Value.ApiSecret);

            _cloudinary = new Cloudinary(account);
        }

        public async Task<ImageUploadResult> AddPhotoAsync(IFormFile file)
        {
            using (var stream = file.OpenReadStream())
            {
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(file.FileName, stream),
                    Transformation = new Transformation().Height(500).Width(500).Crop("fill").Gravity("face")
                };

                var uploadResult = await _cloudinary.UploadAsync(uploadParams);

                return uploadResult;
            }
        }
    }
}

