using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using OpenAI.GPT3.DotNetStandard.Extensions;
using OpenAI.GPT3.DotNetStandard.Interfaces;
using OpenAI.GPT3.DotNetStandard.ObjectModels;
using OpenAI.GPT3.DotNetStandard.ObjectModels.ResponseModels.FileResponseModels;
using OpenAI.GPT3.DotNetStandard.ObjectModels.SharedModels;

namespace OpenAI.GPT3.DotNetStandard.Managers;

public partial class OpenAIService : IFileService
{
    public async Task<FileListResponse> ListFile()
    {
        return await _httpClient.GetFromJsonAsync<FileListResponse>(_endpointProvider.FilesList());
    }

    public async Task<FileUploadResponse> UploadFile(string purpose, byte[] file, string fileName)
    {
        var multipartContent = new MultipartFormDataContent();
        multipartContent.Add(new StringContent(purpose), "purpose");
        multipartContent.Add(new ByteArrayContent(file), "file", fileName);

        return await _httpClient.PostFileAndReadAsAsync<FileUploadResponse>(_endpointProvider.FilesUpload(), multipartContent);
    }

    public Task<FileUploadResponse> FileUpload(string purpose, Stream file, string fileName)
    {
        return UploadFile(purpose, file.ToByteArray(), fileName);
    }

    public Task<FileUploadResponse> FileUpload(UploadFilePurposes.UploadFilePurpose purpose, Stream file, string fileName)
    {
        return UploadFile(purpose.EnumToString(), file.ToByteArray(), fileName);
    }

    public Task<FileUploadResponse> FileUpload(UploadFilePurposes.UploadFilePurpose purpose, byte[] file, string fileName)
    {
        return UploadFile(purpose.EnumToString(), file, fileName);
    }

    public async Task<FileDeleteResponse> DeleteFile(string fileId)
    {
        return await _httpClient.DeleteAndReadAsAsync<FileDeleteResponse>(_endpointProvider.FileDelete(fileId));
    }

    public async Task<FileResponse> RetrieveFile(string fileId)
    {
        return await _httpClient.GetFromJsonAsync<FileResponse>(_endpointProvider.FileRetrieve(fileId));
    }

    //TODO Not tested yet
    //TODO check if there undocumented response object
    // I couldn't figure out how this endpoint works..
    public async Task RetrieveFileContent(string fileId)
    {
        throw new NotImplementedException();
        //await _httpClient.GetFromJsonAsync<RetrieveFileResponse>($"/{ApiVersion}/files/{fileId}/content");
    }
}