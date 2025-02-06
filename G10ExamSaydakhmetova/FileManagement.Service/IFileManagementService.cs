using System.Net;

namespace FileManagement.Service
{
    public interface IFileManagementService
    {
        Task CreateFolder(string folderPath);

        Task UploadFile(IFormFile file, string? folderPath);

        Task UploadFileWithChunks(IFormFile file, string? folderPath);

        Task UploadFiles(List<IFormFile> files, string? folderPath);

        Task DeleteFile(string filepath);

        Task DeleteFolder(string folderPath);

        Task DownloadFile(string filePath);

        Task DownloadFolderAsZip(string folderPath);

        Task GetContentOfTxtFile();

        Task UpdateContentOfTxtFile(string filePath, string newContent);

        Task GetAllInFolderPath(string? folderPath);
    }
}