using System;
namespace SwitchMediaTest.Droid
{

    public class Photo  
    {  
        public int mPhotoID { get; set; }  
        public string mCaption { get; set; }  
    }  
    public class ImageAlbum
    {
        static Photo[] listPhoto1 =  
        {  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 1"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 2"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 3"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 4"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 5"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 6"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 7"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 8"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 9"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 10"},  
        };  
        static Photo[] listPhoto2 =  
        {  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 1"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 2"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 3"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 4"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 5"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 6"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 7"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 8"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 9"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 10"},  
        }; 
        static Photo[] listPhoto3 =  
        {  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 1"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 2"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 3"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 4"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 5"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 6"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 7"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 8"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 9"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 10"},  
        };  
        static Photo[] listPhoto4 =  
        {  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 1"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 2"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 3"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 4"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 5"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 6"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 7"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 8"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 9"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 10"},  
        };  
        static Photo[] listPhoto5 =  
        {  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 1"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 2"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 3"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 4"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 5"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 6"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 7"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 8"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 9"},  
            new Photo() {mPhotoID = Resource.Drawable.titanic, mCaption = "Image 10"},  
        };  

        static Photo[][] listPhoto = { listPhoto1,listPhoto2,listPhoto3,listPhoto4,listPhoto5};
        public Photo[][] photos;  
        Random random;  
        public ImageAlbum()  
        {  
            this.photos = listPhoto;  
            random = new Random();  
        }  
        public int numPhoto  
        {  
            get  
            {  
                return photos.Length;  
            }  
        }  
    }
}
