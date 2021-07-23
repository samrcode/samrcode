Answer=MsgBox("Is is your birthday?", vbQuestion+vbYesNo, "Question")

If Answer vbYes Then MsgBox "Happy birthday!", vbOKOnly, "Program"
If Answer vbNo Then MsgBox "Sorry for the interruption.", vbOKOnly, "Program"