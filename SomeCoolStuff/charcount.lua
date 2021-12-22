-- Character counter
print("Use this tool to count the amount of characters in a word or sentence.")
print("Type your sequence: ")
userInput = io.read()
charcount = string.len(userInput)
print("The amount of characters in " .. userInput .. " is: " .. charcount .. ".")
