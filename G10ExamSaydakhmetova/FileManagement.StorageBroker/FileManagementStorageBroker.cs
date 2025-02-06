
using FileManagement.Service;

namespace FileManagement.StorageBroker;

public class FileManagementStorageBroker : IFileManagementStorageBroker

{
    private readonly FileManagementService _fileManagementService;

    public FileManagementStorageBroker()
    {
        FileManagementStorageBroker _fileManagementStorageBroker;
    }


    public async Task CreatFolder(string folderPath)
    {
        folderPath = Path.Combine(folderPath);
        if (!Directory.Exists(folderPath))
        {
            throw new Exception("There is no folder");
        }
    }

    public async Task DeleteFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new Exception("File not found");
        }
        File.Delete(filePath);
    }

    public async Task DeleteFolder(string folderPath)
    {
        if (!Directory.Exists(folderPath))
        {
            throw new Exception("Folder not found");
        }
        Directory.Delete(folderPath);
    }

    public async Task DownloadFile(string filePath)
    {
        using (var stream = File.OpenRead(filePath)) 
        {
            await stream.CopyToAsync(stream);
        }

    }

    public async Task DownloadFolderAsZip(string folderPath)
    {
       using (var stream = File.OpenRead(folderPath))
        {
            await stream.CopyToAsync(stream);
        }
    }

    public async Task GetAllInFolderPath(string? folderPath)
    {
        

    }

    public async Task GetContentOfTxtFile()
    {
        throw new NotImplementedException();
    }

    public async Task UpdateContentOfTxtFile(string filePath, string newContent)
    {
        throw new NotImplementedException();
    }

    public async Task UploadFile(IFormFile file, string? folderPath)
    {
        throw new NotImplementedException();
    }

    public async Task UploadFiles(List<IFormFile> files, string? folderPath)
    {
        throw new NotImplementedException();
    }

    public async Task UploadFileWithChunks(IFormFile file, string? folderPath)
    {
        throw new NotImplementedException();
    }
}
