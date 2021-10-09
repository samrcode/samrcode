-- Calculator
print("Calculator")
print("Choose an operator: ")
print("")
print("[1] Addition")
print("[2] Subtraction")
print("[3] Multiplication")
print("[4] Division")
print("")
op = io.read("*n")
print("Type a number: ")
x = io.read("*n")
print("Type another number: ")
y = io.read("*n")
if (op == "1") then
	-- addition
	z = x + y
	print("The sum is " .. z .. ".")
elseif (op == "2") then
	-- subtraction
	z = x - y
	print("The sum is " .. z .. ".")
elseif (op == "3") then
	-- multiplication
	z = x * y
	print("The sum is " .. z .. ".")
elseif (op == "4") then
	-- division
	z = x / y
	print("The sum is " .. z .. ".")	
else
	-- error
	print("Something went wrong. Try again later.")
end
