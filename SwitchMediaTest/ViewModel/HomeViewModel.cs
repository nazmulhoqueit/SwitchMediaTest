using System.Threading.Tasks;
using Realms;
using SwitchMediaTest.Interface;
using SwitchMediaTest.Model;
using SwitchMediaTest.Storage;
using SwitchMediaTest.Common;
using System;

namespace SwitchMediaTest.ViewModels
{
    public class HomeViewModel
    {
        private IStorageAPI apiStorage;
        const int ROW_SIZE = 4;
        const int COLUMN_SIZE = 6;

        public HomeViewModel()
        {
            apiStorage = new StorageAPI();
        }

        async public Task<Image[][]> GetImages()
        {
            Image[][] listImage = new Image[ROW_SIZE][];
            try
            {
                var config = new RealmConfiguration() { SchemaVersion = 1 };
                config.ShouldDeleteIfMigrationNeeded = true;

                var vRealmDb = Realm.GetInstance(config);
                var allImages = vRealmDb.All<Image>();

                if (allImages.AsRealmCollection<Image>().Count == 0)
                {
                    vRealmDb.Write(() =>
                    {
                        vRealmDb.RemoveAll<Image>();
                    });
                    listImage = await GetImagesFromRemote(vRealmDb);

                }
                else
                {
                    listImage = GetImagesFromCache(allImages.AsRealmCollection<Image>());
                }

                return listImage;
            }
            catch(Exception e)
            {
                //error handle and record log

                return listImage;
            }
        }

        async private Task<Image[][]> GetImagesFromRemote(Realm vRealmDb)
        {
            Image[][] listImage = new Image[ROW_SIZE][];

            try
            {
                for (int i = 0; i < ROW_SIZE; i++)
                {
                    Image[] imgRow = new Image[COLUMN_SIZE];

                    for (int j = 0; j < COLUMN_SIZE; j++)
                    {
                        var imgeObject = await apiStorage.HomeAPI.GetImageAsync();
                        var imageBytesObject = await apiStorage.HomeAPI.GetImageBytesAsync(imgeObject.imageUrl);
                        var obj = new Image() { imageUrl = imgeObject.imageUrl, imageBytes = imageBytesObject, sTitle = Utils.GenerateName(10) };
                        imgRow[j] = obj;
                        vRealmDb.Write(() =>
                        {
                            vRealmDb.Add(obj);
                        });
                    }
                    listImage[i] = imgRow;
                }

                return listImage;
            }
            catch(Exception e)
            {
                //error handle and record log

                return listImage;
            }
        }

        private Image[][] GetImagesFromCache(IRealmCollection<Image> images)
        {
            Image[][] listImage = new Image[ROW_SIZE][];

            try
            {
                int m = 0;
                for (int i = 0; i < ROW_SIZE; i++)
                {
                    Image[] imgRow = new Image[COLUMN_SIZE];

                    for (int j = 0; j < COLUMN_SIZE; j++)
                    {
                        var imgeObject = images[m];
                        var obj = new Image() { imageUrl = imgeObject.imageUrl, imageBytes = imgeObject.imageBytes, sTitle = imgeObject.sTitle };
                        imgRow[j] = obj;
                        m++;

                    }
                    listImage[i] = imgRow;
                }
                return listImage;
            }
            catch(Exception e)
            {
                //error handle and record log

                return listImage;
            }
        }
    }
}
