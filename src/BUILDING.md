# Building SCAM Lock Tool from its source code

This file should assist you in compiling and running SCAM Lock Tool.

## Building requirements

* [.NET Framework 4.6.1 or newer](https://dotnet.microsoft.com/download/dotnet-framework).
* Visual Studio. You can [download the community edition](https://visualstudio.microsoft.com/vs/community/) for free.
  * The ".NET desktop development" Workload is required.

## Getting the source code

Clone the repository via Git:

```cmd
git clone https://github.com/Strappazzon/SCAM-Lock-Tool.git SCAM-Lock-Tool
cd SCAM-Lock-Tool
```

Alternatively, you can clone the repository via any Git client, or download a zip archive of the repository [from here](https://github.com/Strappazzon/SCAM-Lock-Tool/archive/master.zip).

## Building with Visual Studio

1. Start Visual Studio.
2. Select **Open a project or solution** and open the `SCAM Lock Tool.sln` solution file located in your cloned repository (In this case: `.\SCAM-Lock-Tool\src\SCAM Lock Tool.sln`).
3. Select **Project** -> **Manage NuGet Packages...**.
4. Visual Studio will ask you to restore NuGet packages, click **Restore** in the top-right corner of the screen.
5. Compile using **Build** -> **Build Solution**.

The compiled binary will be inside the `.\SCAM Lock Tool\bin\Debug` folder.

## Building with build script

1. Run `build.bat` located in your cloned repository (In this case: `.\SCAM Lock Tool\script\build.bat`).

The compiled binary will be inside the `.\SCAM Lock Tool\bin\Release` folder.
