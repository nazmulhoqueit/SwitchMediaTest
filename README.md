# Switch Media Test
Release notes 1.0
Date: 12 June 2018

Summary
This a Xamarin based application exhibiting MVVM pattern which runs on most of the Android devices. Specially design for tablet but it also run on mobile as well. Users are able to scroll a vertical list of images, which each image capable of being independently scrolled horizontally. This app has three tabs on top and user can swipe and click each tab. When user clicks each image a full screen semi-transparent overlay of the title/image will show. This app also uses caching so that user can smoothly use the app

All features for this release
•	Single page app. 
•	Mainly targeted for Tables.  
•	Three tabs on top.
•	Initially this app loaded 24 images from remote.
•	Second time it uses local cache to improve performance.
•	Image titles are randomly generated.
•	Images are randomly loaded from remote.
•	A full screen semi-transparent overlay of the title/image on element click.  
•	Splash screen which disappears to reveal all initial elements loaded.  


Technologies used
•	Visual studio for Mac
•	Xamarin.Android
•	MVVM architecture
•	Realm database
•	Multithreading/Asynchronicity  
•	C#

Supported Device and APIs
•	Minimum API 15 (Android 4.0.3)
•	Maximum API 27 (Android 8.0)
•	All type of Android devices running on KitKat to Oreo

Improvement
As running out of time there are few areas need to improve for next release. 
•	UI design
•	Theme/Style
•	Fixed number of images showing at this moment, it should be dynamic.
•	MVVM design improvement. Can be used MVVMCross library to get better output.
•	Unit test
•	UI test
•	Logs implementation
•	Analytics for monitoring
•	Xamarin insights
•	Use string resources more rather than use hardcoded value in layout file and other places.
•	Use meaningful name of the variable, property, method and class.
•	Error handling properly rather than just use try catch.

