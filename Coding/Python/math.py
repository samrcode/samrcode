def math(op, userNo, num1, num2, message1, message2, message3):
	if int(userNo) == 1:
		if int(op) == 1:
			z = int(num1) + int(num2)
			return int(z)
		elif int(op) == 2:
			z = int(num1) - int(num2)
			return int(z)
		elif int(op) == 3:
			z = int(num1) * int(num2)
			return int(z)
		elif int(op) == 4:
			z = int(num1) / int(num2)
			return int(z)
		else:
			print("Uh oh")
	elif int(userNo) == 0:
		if int(op) == 1:
			print(str(message1))
			x = input()
			print(str(message2))
			y = input()
			z = int(x) + int(y)
			print(str(message3) + str(z))
		elif int(op) == 2:
			print(str(message1))
			x = input()
			print(str(message2))
			y = input()
			z = int(x) - int(y)
			print(str(message3) + str(z))
		elif int(op) == 3:
			print(str(message1))
			x = input()
			print(str(message2))
			y = input()
			z = int(x) * int(y)
			print(str(message3) + str(z))
		elif int(op) == 4:
			print(str(message1))
			x = input()
			print(str(message2))
			y = input()
			z = int(x) / int(y)
			print(str(message3) + str(z))
		else:
			print("Uh oh")
	else:
		print("Uh oh")

def qpr(message):
	if int(message) == 1:
		return "Type a number: "
	elif int(message) == 2:
		return "The sum is: "

def pause():
	print("Press Enter to continue... ")
	input()

print("Calculator")
print("Choose an option: ")
print("1. Addition")
print("2. Subtraction")
print("3. Multiplication")
print("4. Division")
print("5. Exit")
opt = input()
if int(opt) == 1:
	math(1, 0, 0, 0, qpr(1), qpr(1), qpr(2))
	pause()
elif int(opt) == 2:
	math(2, 0, 0, 0, qpr(1), qpr(1), qpr(2))
	pause()
elif int(opt) == 3:
	math(3, 0, 0, 0, qpr(1), qpr(1), qpr(2))
	pause()
elif int(opt) == 4:
	math(4, 0, 0, 0, qpr(1), qpr(1), qpr(2))
	pause()
elif int(opt) == 5:
	quit()
else:
	print("Something happened.")
	pause()