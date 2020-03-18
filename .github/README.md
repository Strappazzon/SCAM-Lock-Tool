<h1 align="center">
  <br>
  <img src="./images/syskey.png" alt="SCAM Lock Tool Screenshot"></a>
  <br>
  SCAM Lock Tool
  <br>
</h1>

<h4 align="center">A fake syskey. Scammers won't be able to encrypt account credentials.</h4>

<p align="center">
  <a href="#about">About</a> •
  <a href="#how-to-replace-syskey">How to Replace syskey</a> •
  <a href="#settings">Settings</a> •
  <a href="#preview">Preview</a> •
  <a href="#download">Download</a>
</p>

## About

**SCAM Lock Tool** is a replacement for SAM Lock Tool (better known as syskey), which is used to encrypt the account credentials stored inside the SAM file. Tech support scammers use syskey to lock their victims out of their computer, but with SCAM Lock Tool they won't be able to do it.

## How to replace syskey

* Open an elevated Command Prompt and run the following commands:

```batch
takeown /F syskey.exe
icacls syskey.exe /T /C /GRANT Everyone:F
```

![Command Prompt](./images/syskey_takeown.png)

* Rename the original **syskey.exe** or move it somewhere else to make a backup.
* Copy **my version of syskey.exe** inside `C:\Windows\System32`, **including** `INIFileParser.dll`.
* If you want to customize SCAM Lock Tool behavior copy `syskey.ini` as well or create it. See the [Settings](#settings) section for more information.

## Settings

SCAM Lock Tool behavior can be configured by using a `syskey.ini` file. For example, you can decide to display an error or open the [Tech Support Scam Wikipedia page](https://www.wikipedia.org/wiki/Tech_support_scam) when attempting to change the Startup Key.

The settings file is optional.

The `syskey.ini` file **must** be placed alongside `syskey.exe`.

### Elements of syskey.ini

#### [syskey]

The `syskey` section can include the following properties:

<table>
  <tr>
    <th align="left">Property</th>
    <th align="left">Type</th>
    <th align="left">Default</th>
    <th align="left">Description</th>
  </tr>
  <tr>
    <td><code>behavior</code></td>
    <td>Integer</td>
    <td>0</td>
    <td>
      If set to <code>0</code>, it will show an error when attempting to change the Startup Key.
      <br>
      If set to <code>1</code>, it will show an error message and will open the <a href="https://www.wikipedia.org/wiki/Tech_support_scam">Tech Support Scam Wikipedia page</a> when attempting to change the Startup Key..
      <br>
      If set to <code>2</code>, it will show a message saying that the Startup Key was changed successfully.
    </td>
  </tr>
  <tr>
    <td><code>message</code></td>
    <td>String</td>
    <td>An error occurred while attempting to scam this user.</td>
    <td>
      If <code>behavior</code> is set to <code>1</code> shows a custom error message. Include <code>$PASSWORD</code> to display the typed password in the error message.
      <br>
      <b>Don't surround the custom message with quotation marks</b> otherwise they will appear in the error message.
    </td>
  </tr>
</table>

### Example syskey.ini file

```ini
[syskey]
behavior=1
message=Your custom error message.
```

## Preview

| Error | Error + Wikipedia page |
|-------|------------------------|
| ![SCAM Lock Tool Preview](./images/syskey_demo.gif?raw=true) | ![SCAM Lock Tool Preview](./images/syskey_demo_wikipedia.gif?raw=true) |

<p align="center"><i>Click on a preview to enlarge it</i></p>

## Download

You can [download](https://github.com/Strappazzon/SCAM-Lock-Tool/releases/latest) the latest version of SCAM Lock Tool from the Releases page.
