using SwitchMediaTest.Interface;

namespace SwitchMediaTest.Storage
{
    internal class StorageAPI : IStorageAPI
    {
        public StorageAPI()
        {

        }

        private IHomeAPI homeAPI;
        public IHomeAPI HomeAPI
        {
            get
            {
                if (homeAPI == null)
                {
                    homeAPI = new HomeAPI(this);
                }
                return homeAPI;
            }
        }
    }
}
