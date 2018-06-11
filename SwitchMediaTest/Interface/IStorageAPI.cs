using System;

namespace SwitchMediaTest.Interface
{
    public interface IStorageAPI
    {
        IHomeAPI HomeAPI { get; }
    }
}
