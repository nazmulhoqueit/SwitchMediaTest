using System;
using System.Threading.Tasks;
using SwitchMediaTest.Model;

namespace SwitchMediaTest.Interface
{
    public interface IHomeAPI
    {
        Task<Image> GetImageAsync();
        Task<byte[]> GetImageBytesAsync(string imageUrl);
    }
}
