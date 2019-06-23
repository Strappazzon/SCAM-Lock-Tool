# SCAM Lock Tool

![SCAM Lock Tool](images/syskey.png)

This is a fake SAM Lock Tool (also known as syskey). Scammers use it to lock their victims out of their computer, encrypting the credentials stored inside the SAM file with a password. This version is virtually identical to the original syskey, the only difference is that scammers won't be able to encrypt SAM.

## How to replace syskey

Replacing a system file is not as easy as a copy and paste, you need to take ownership over the file. To do so:
 - Go to `C:\Windows\System32\` and right click `syskey.exe`
 - Click **Properties**, open the **Security** tab, click the **Advanced** button, then open the **Owner** tab
 - As you can see the owner of the file is **TrustedInstaller** and not your current account
 - Click on the **Edit** button (in Windows 10, it’s **Change**) and select the *Administrators* group
 - Click **OK**. The current owner is now the **Administrators** group (which includes your account assuming you are an administrator)
 - Click **OK** until you have closed all properties windows and are back to the Explorer screen
 - Right-click on **syskey.exe** and click **Properties > Security tab > Advanced button** again
 - Click the **Change permissions...** button, select **Administrators** from the list and then click the **Edit...** button
 - Now tick the box next to **Full Control** and click **OK** until you close all the dialogs
 - Windows will ask you: "*You are about to change the permission settings on system folders* [...] *Do you want to continue?*", confirm with **Yes**

![File Permissions](.github/images/file_permissions.png)

Now you can rename **syskey.exe** in **syskey.exe.bak** to make a backup. At this point all you have to do is paste my syskey.exe inside system32.

## Preview

You can see this fake syskey in action below.

![SCAM Lock Tool Preview](.github/images/syskey_demo.gif)
