/*
Written by samrcode on GitHub
Also avaiable on Replit at https://replit.com/@samrcode/Number-Guesser
*/

#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

int main() {
    srand(time(NULL));

    // Make Variables
    int secretNum = (rand() %10) + 1;
    int guess;
    int guessCount = 0;
    int guessLimit = 5;
    bool outOfGuesses = false;

    // Begin Main
    cout << "Number Guesser" << endl;
    cout << "---" << endl;
    cout << "In Number Guesser, you have 5 tries to guess a number that is 1 through 10. Good luck!" << endl;
    cout << "---" << endl;

    // Input
    while (secretNum != guess && !outOfGuesses) {
        if (guessCount < guessLimit) {
            cout << "Enter your guess: ";
            cin >> guess;
            guessCount++;
        } else {
            outOfGuesses = true;
        }
    }

    // Checks if out of guesses
    if (outOfGuesses) {
        cout << "---" << endl;
        cout << "You Lose!" << endl;
        cout << "The secret number was: " << secretNum;
    } else {
        cout << "---" << endl;
        cout << "You Win!";
    }

    return 0;
}
