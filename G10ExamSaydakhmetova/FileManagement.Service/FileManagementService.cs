
namespace FileManagement.Service;

public class FileManagementService : IFileManagementService

{
    private readonly IFileManagementService _fileManagementService;

    public FileManagementService()
    {
        _fileManagementService = _fileManagementService;
    }


    public async Task CreateFolder(string folderPath)
    {
        folderPath = Path.Combine(folderPath);
        if (Directory.Exists(folderPath))
        {
            throw new Exception("this file already exist");
        }

    }

    public async Task DeleteFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new Exception("File not Found");
        }
        File.Delete(filePath);
    }

    public async Task DeleteFolder(string folderPath)
    {
        if (!Directory.Exists(folderPath))
        {
            throw new Exception("this file not found");
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
        using (var stream = File.OpenRead(folderPath + "Zip"))
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


