#include <iostream>
#include <string>

using namespace std;

int main() {
	string op;
	int x;
	int y;
	cout << "Calculator" << endl;
	cout << "Type an operator: ";
	cin >> op;
	cout << "Type a number: ";
	cin >> x;
	cout << "Type another number: ";
	cin >> y;
	if (op == "+") {
		int z = x + y;
		cout << "The sum is: " << z;
	} else if (op == "-") {
		int z = x - y;
		cout << "The sum is: " << z;
	} else if (op == "*") {
		int z = x * y;
		cout << "The sum is: " << z;
	} else if (op == "/") {
		int z = x / y;
		cout << "The sum is: " << z;
	} else {
		cout << "Something went wrong. Try again later.";
	}
	return 0;
}