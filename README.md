# SongBatcher Project
![](https://img.shields.io/github/languages/code-size/k0vac/SongBatcher?style=plastic)
![](https://img.shields.io/github/license/k0vac/SongBatcher?style=plastic)
![](https://img.shields.io/github/v/release/k0vac/SongBatcher?style=plastic)

![](https://i.postimg.cc/L86ccQsr/songbatcherbanner.png)  
SongBatcher is a lightweight Windows Application built on .NET 5 to convert batches of MP4s in a folder into MP3s.

![Song Batcher GIF](https://i.postimg.cc/3x7Rm1WN/songbatcherdemo.gif)

[Releases](https://github.com/k0vac/SongBatcher/releases/tag/Stable)

## Libraries

- [FFmpeg.NET](https://github.com/cmxl/FFmpeg.NET) - .NET Wrapper for FFmpeg
- [FFmpeg](https://github.com/FFmpeg/FFmpeg) - Library of Multimedia Processors used to perform the conversion

## Pre-requisites
- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- [.NET 5 Runtimes](https://dotnet.microsoft.com/download/dotnet/5.0/runtime)

## Known Issues

⚠️ - MP4 files with no audio stream will not output an MP3 file  
⚠️ - After conversion files can not be deleted or modified until the program is exited or a random amount of time has passed.
⚠️ - Pressing the Convert button without selecting files will cause program to crash

DISCLAIMER: In addition to the terms provided by the LGPL v2.1 license, I do not condone the usage of this program, nor any of its derivates to be used to infringe on Intellectual Property of Rights Holders. I also do not condone the usage of this program under commercial use due to vague, complex and various patent laws regarding algorithms used to encode or decode media, as well as FFmpeg, the library used for conversion is not available under a proprietary/commercial license. Hence forth by agreeing to use this software you are solely responsible for any infrigements or legal action taken by owners of patented technology.





