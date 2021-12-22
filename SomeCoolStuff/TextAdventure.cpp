// SmallTextAdventure
// by samrcode
// also on repl.it
#include <iostream>

using namespace std;

int main() {
    char opt;
	int passcode;
	bool keyFoundChest = false;
	bool keyFoundDoor = false;
	bool chestFound = false;
	bool doorFound = false;
    cout << "SmallTextAdventure" << endl;
	cout << "a small text adventure" << endl;
	cout << "You are stuck in a room. You need to escape." << endl;
	while(true) {
		system("sleep 1");
		cout << "Which way will you look? North, east, south, west" << endl;
		cin >> opt;
		if (opt == 'n') {
			// north
			if (keyFoundDoor) {
				// Key found, door can be opened
				cout << "You slide in the door key... " << endl;
				cout << "And it works!" << endl;
				cout << "You step out the door, leaving behind the room that you were stuck in." << endl;
				return 0;
			} else {
				// Key not found yet, door can not be unlocked
				cout << "You see a door. It is locked." << endl;
				cout << "However, it looks like it can be unlocked with a key." << endl;
				doorFound = true; // Door found, chest key can now be found	
			}
		} else if (opt == 'e') {
			// east
			if (chestFound) {
				// Chest found, chest key enabled
				cout << "You find a key." << endl;
				cout << "It looks like a chest key... " << endl;
				keyFoundChest = true;
			} else {
				// Chest not found, chest key not enabled
				cout << "You find a key." << endl;
				cout << "You have no idea what it is for." << endl;
				cout << "So you leave it there." << endl;
			}
		} else if (opt == 's') {
			// south
			cout << "You find a small note." << endl;
			cout << "It says the numbers 3762 on it." << endl;
		} else if (opt == 'w') {
			// west
			if (keyFoundChest) {
				// Chest key found, chest (almost) unlocked
				cout << "You find a chest." << endl;
				cout << "You slide in the chest key... " << endl;
				cout << "It works!" << endl;
				cout << "It seems to require a passode." << endl;
				cout << "Type the passcode: " << endl;
				cin >> passcode;
				if (passcode == 3762) {
					// Correct passcode
					cout << "You did it!" << endl;
					cout << "You got a door key." << endl;
					keyFoundDoor = true;
				} else {
					// Wrong passcode
					cout << "Wrong passcode!" << endl;
					cout << "Maybe you need to find it somewhere." << endl;
				}
			} else {
				// Chest key not found, chest can't be unlocked
				cout << "You find a chest." << endl;
				cout << "It seems to require a key." << endl;
				chestFound = true;
			}
		} else {
			// error
			cout << "Uh oh! '" << opt << "' is not a valid option." << endl;
			cout << "Try again." << endl;
		}
	}
}
