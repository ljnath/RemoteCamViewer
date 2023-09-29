# RemoteCamViewer
### Version 1.1.0

Author : Lakhya Jyoti Nath (ljnath)<br>
Date : May 2023 - September 2023<br>
Email : ljnath@ljnath.com<br>
Website : https://ljnath.com

[![Download Remote Cam Viewer](https://img.shields.io/sourceforge/dm/remotecamviewer.svg)](https://sourceforge.net/projects/remotecamviewer/files/latest/download)

[![Download Remote Cam Viewer](https://a.fsdn.com/con/app/sf-download-button)](https://sourceforge.net/projects/remotecamviewer/files/latest/download)

## Introduction

The **RamoteCamViewer** is a desktop application developed using the .NET framework. It provides users with the ability to view remote unauthenticated cameras over the internet. The primary functionality of the application is to download images from the camera at regular intervals and display them within the desktop application. Additionally, the application offers the following features:

1. **Image Download and Display**: The application periodically fetches images from the remote cameras at a specified interval. It ensures a reliable network connection to ensure that the latest images are always available for viewing. The downloaded images are displayed within the desktop application, providing users with real-time access to the camera feed.

2. **Automatic Image Saving**: The application allows users to automatically save the downloaded images to their local storage. This feature ensures that users have a backup of the camera feed and can review the images even when the camera is offline or unreachable.

3. **Export Images as Video**: The application provides the capability to export the downloaded images as a video file. This feature enhances the usability of the application by providing a convenient way to create video recordings from the camera feed.

4. **Camera Management**: Users can easily add, remove, or modify camera configurations within the application. Each camera can be assigned a unique name for easy identification, and specific camera settings such as the refresh interval, channel count can be customized.

5. **User-Friendly Interface**: The desktop application features a user-friendly interface with intuitive controls and menus. Users can easily navigate between cameras, adjust settings, and view the camera feed without any technical expertise.

The RamoteCamViewer Application offers a simple yet powerful solution for remotely accessing and viewing unauthenticated cameras over the internet. With its image download and display functionality, automatic image saving, and the ability to export images as video files, the application provides users with a comprehensive tool for monitoring camera feeds and securely storing important footage.
<br>

## Supported Camera Type

| Camera Type |                                    Image URL                                     |
| ----------- | :------------------------------------------------------------------------------: |
| Hi3516      | http://{**ip-address**}/webcapture.jpg?command=snap&channel={**channel-number**} |
| Defeway     | http://{**ip-address**}/cgi-bin/snapshot.cgi?chn={**channel-number**}&u=admin&p= |
<br>

## Open Camera
* [insecam.org](http://www.insecam.org/)  - check the image address to find the camera Type and network address
<br>

## Video Tutorial
* [Remote Cam Viewer - How to use ?](https://youtu.be/cmlOWdk5dD0)  - watch tutorial video on youtube


## Give a Star! ⭐️

If you find this repository useful, please give it a star.
Thanks in advance !
<br>

## License

Copyright © 2023 [Lakhya's Innovation Inc.](https://github.com/ljnath/) under the [Apache-2.0 license License](https://github.com/ljnath/RemoteCamViewer/blob/master/LICENSE).
