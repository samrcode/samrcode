# NoteReader
# by samrcode
using Pkg
Pkg.add("JSON")
using JSON # using JSON because XML isn't as easy to use in Julia
function parse()
    # Parse Note
    println("Type location of note:")
    location = readline()
    try
      tree = JSON.parsefile(location)
      println("== Note Reader")
      println(string("From: ", tree["from"]))
      println(string("To: ", tree["to"]))
    	println(string("=== ", tree["head"]))
      println(tree["body"])
      println(string("Timestamp: ", tree["time"]))
    catch e
      println("error: the possible reason for the error is that location is not valid.")
    end
end
function inst()
  # Instructions
  println("== Instructions ==")
  println("=== Reading Notes")
  println("After choosing the option to read a note, type in the path of the file that includes the note.")
  println("It should be a .json file.")
  println("It will parse the file and show the from, to, heading, body, and timestamp of the note.")
  println("=== Writing Notes")
  println("Open a .json file in your favourite text editor.")
  println("Type entries named 'from', 'to', 'head', 'body', and 'time'.")
  println("In the 'from' and 'to' entries, type the from and to information.")
  println("In the 'head' entry, type the heading of the note.")
  println("In the 'body' entry, type the body of the note.")
  println("In the 'time' entry, type the timestamp as HH:MM Month DD YYYY")
  println("Example: 04:30 PM December 29 2021")
end
println("== NoteReader ==")
println("Choose an option:")
println("[1] Read Note")
println("[2] Instructions")
input = readline()
if input == "1"
  # Read Note
  parse()
elseif input == "2"
  # Instructions
  inst()
else
  # Error
  println("Uh oh! '$input' is not an option.")
end
