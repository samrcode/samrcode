print("Calculator")
print("Type an operator.")
print("+, -, *, /")
op = io.read(1)
print("Type a number: ")
x = io.read("*n")
print("Type another number: ")
y = io.read("*n")
if(op == "+")
then
	z = x + y
elseif(op == "-")
then
	z = x - y
elseif(op == "*")
then
	z = x * y
elseif(op == "/")
then
	z = x / y
else
	print("Something went wrong. Try again later.")
end
print("The sum is ", z)
