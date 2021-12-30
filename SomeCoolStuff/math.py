# Written by samrcode on GitHub
# a calculator

# math function: for making math happen in programs other than this one
def math(op, user_no, num1, num2, message1, message2, message3):
	# Checks if there is a user or not
	if int(user_no) == 1:
		# if there is no user
		if int(op) == 1:
			# addition
			z = int(num1) + int(num2)
			return int(z)
		elif int(op) == 2:
			# subtraction
			z = int(num1) - int(num2)
			return int(z)
		elif int(op) == 3:
			# multiplication
			z = int(num1) * int(num2)
			return int(z)
		elif int(op) == 4:
			# division
			z = int(num1) / int(num2)
			return int(z)
		else:
			# error
			print("Uh oh")
	elif int(user_no) == 0:
		# if there is a user
		if int(op) == 1:
			# addition
			print(str(message1))
			x = input()
			print(str(message2))
			y = input()
			z = int(x) + int(y)
			print(str(message3) + str(z))
		elif int(op) == 2:
			# subtraction
			print(str(message1))
			x = input()
			print(str(message2))
			y = input()
			z = int(x) - int(y)
			print(str(message3) + str(z))
		elif int(op) == 3:
			# multiplication
			print(str(message1))
			x = input()
			print(str(message2))
			y = input()
			z = int(x) * int(y)
			print(str(message3) + str(z))
		elif int(op) == 4:
			# division
			print(str(message1))
			x = input()
			print(str(message2))
			y = input()
			z = int(x) / int(y)
			print(str(message3) + str(z))
		else:
			# error
			print("Uh oh")
	else:
		# error
		print("Uh oh")

# Pause: Makes a pause in the code
def pause():
	print("Press Enter to continue... ")
	input()

# Main Calculator Code
print("Calculator")
print("Choose an option: ")
print("1. Addition")
print("2. Subtraction")
print("3. Multiplication")
print("4. Division")
print("5. Exit")
opt = input()
if int(opt) == 1:
	# if operation selected is addition
	math(1, 0, 0, 0, "Type a number: ", "Type a number: ", "The sum is: ")
	pause()
elif int(opt) == 2:
	# if operation selected is subtraction
	math(2, 0, 0, 0, "Type a number: ", "Type a number: ", "The sum is: ")
	pause()
elif int(opt) == 3:
	#  if operation selected is multiplication
	math(3, 0, 0, 0, "Type a number: ", "Type a number: ", "The sum is: ")
	pause()
elif int(opt) == 4:
	# if operation selected is division
	math(4, 0, 0, 0, "Type a number: ", "Type a number: ", "The sum is: ")
	pause()
elif int(opt) == 5:
	# if option selected to quit
	quit()
else:
	# error
	print("Something happened.")
	pause()
