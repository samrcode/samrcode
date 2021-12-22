// IO
package main

import "fmt"

func main() {
	fmt.Println("Type something: ")
	var userinput string
	fmt.Scanln(&userinput)
	fmt.Println("The user typed: " + userinput)
}
