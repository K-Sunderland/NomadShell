# NomadShell
A launch shell for ETC Nomad when running in a kiosk mode. 
<h2> **Installation** </h2> <br>
Download the zip file from the releases and extract, copy all the files in it to C:\Program Files\ETC\EosFamily <br>
Change the registry key HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon <br>
The value you need to change is called Shell, and you will change it to C:\Program Files\ETC\EosFamily\NomadShell.exe
Log off, and log back on and it should boot into the Nomad Shell




<h2> **Tips** </h2> <br>
For the unlock functions to work correctly, you need to ensure that the files are located in C:\Program Files\ETC\EosFamily\
They can't be in a folder. You will also need to be in an administrator account. UAC for whatever reason won't let the registry changes be made in a non-admin account, even if you put in the admin passwords


 
