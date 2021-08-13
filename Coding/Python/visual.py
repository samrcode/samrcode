from tkinter import *
print("Program is starting.")
print("Wrriten by @samrcode on repl.it.")

root = Tk()

# Text Labels
empty = Label(root, text=" ")
myLabel1 = Label(root, text="Hello, World!")
myLabel2 = Label(root, text="This is some text.")
myLabel3 = Label(root, text="This is some text with a\nnew line.")
myLabel4 = Label(root, text="This is an unused text label.")
myLabel5 = Label(root, text="This is some text on the second column.")

# Button Functions
def myClick1():
    myClickLabel1 = Label(root, text="You clicked a button!")
    myClickLabel1.grid(row=5, column=0)
def myClick2():
    myLabel6 = Label(root, text="Enter your Name")
    myEntry1 = Entry(root)
    def myClick3():
        myLabel7 = Label(root, text="Hello, " + myEntry1.get() + "!")
        myLabel7.grid(row=3, column=2)
    myButton4 = Button(root, text="Submit", command=myClick3)
    myLabel6.grid(row=0, column=2)
    myEntry1.grid(row=1, column=2)
    myButton4.grid(row=2, column=2)
    

# Buttons
myButton1 = Button(root, text="Click Me!", command=myClick1)
myButton2 = Button(root, text="You can't click me :(", state=DISABLED)
myButton3 = Button(root, text="Click me for entry!", command=myClick2)

# Placement
myLabel1.grid(row=0, column=0)
myLabel2.grid(row=1, column=0)
myLabel3.grid(row=2 , column=0)
myLabel5.grid(row=0, column=1)
empty.grid(row=3, column=0)
empty.grid(row=1, column=1)
empty.grid(row=2, column=1)
empty.grid(row=3, column=1)
myButton1.grid(row=4, column=0)
myButton2.grid(row=4, column=1)
myButton3.grid(row=6, column=0)

root.mainloop()

print("Program has ended.")