Start=MsgBox("Are you sure you want to start samrClicker? To exit during playing, just click Cancel.",vbYesNo+vbQuestion,"samrClicker")
Set StartExitCode=CreateObject("wscript.shell")
If Start=vbNo then StartExitCode.run "taskkill /f /im wscript.exe"
FirstMain=MsgBox("1",vbOKCancel+vbInformation,"samrClicker")
If FirstMain=vbCancel then StartExitCode.run "taskkill /f /im wscript.exe"
Count=1

Do

Count=Count+1
Main=MsgBox(Count,vbOKCancel+vbInformation,"samrClicker")
If Main=vbCancel then exit Do

Loop