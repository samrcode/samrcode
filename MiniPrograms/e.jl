println("E!")
# main code is at the end of the file

# Test Functions
# >- Compund Expressions -<
function compound()
    z = begin
        x = 1
        y = 2
        x + y
    end
    println("the final sum is ", z) # -> 3

    second = begin
        x = 23
        y = 49
        x - y
    end
    println("the final sum is ", second) # -> -26
end

# >- Functions && Conditional Evaulation -<
function ceval()
    function checkforequality(x, y)
        if x < y
            println("x is less than y")
        elseif x > y
            println("x is greater than y")
        else
            println("x is equal to y")
        end
    end
    checkforequality(12, 28) # -> "x is less than y"

    somefunction(a, b) = a * b
    println(somefunction(78, 35)) # -> 2730
end

# >- Repeated Evaluation: Loops -<
function reval()
    i = 1
    while i <= 5
        println(i)
        global i += 1
    end
    # -> 1
    # -> 2
    # -> 3
    # -> 4
    # -> 5

    for s ∈ ["foo", "bar", "baz"]
        println(s)
    end
    # -> "foo"
    # -> "bar"
    # -> "baz"

    n = [2, 4, 6, 8, 10]
    for a ∈ n
        println(a)
    end
    # -> 2
    # -> 4
    # -> 6
    # -> 8
    # -> 10
end

# main
println("Choose an option: ")
println("[1] Compound Expressions")
println("[2] Functions && Conditional Evaluation")
println("[3] Repeated Evaluation: Loops")
println("(Try looking through the code while running to see how it works!)")
input = readline()
if input == "1"
    compound()
elseif input == "2"
    ceval()
elseif input == "3"
    reval()
else
    println("Uh oh! $input isn't a correct value.")
end
