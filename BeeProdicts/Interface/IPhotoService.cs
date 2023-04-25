﻿using CloudinaryDotNet.Actions;

namespace BeeProdicts.Interface
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> AddPhotoAsync(IFormFile file);
        //Task<DeletionResult> DeletePhotoAsync(string publicId);
    }
}
