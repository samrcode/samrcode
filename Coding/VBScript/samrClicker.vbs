Start=MsgBox("Are you sure you want to start samrClicker? Press Cancel anytime during playing to end the game.", vbYesNo+vbQuestion, "samrClicker")
If Start=vbNo Then wscript.quit
Count=1
FirstMain=MsgBox("You clicked 1 time!", vbOKCancel+vbInformation, "samrClicker")
If FirstMain=vbCancel Then wscript.quit

Do

Count=Count+1
Main=MsgBox("You clicked " & Count & " times!", vbOKCancel+vbInformation, "samrClicker")
If Main=vbCancel Then exit Do

Loop