FizzBuzz Kata
============
Source: [https://github.com/ardalis/kata-catalog](https://github.com/ardalis/kata-catalog)

# Instructions #

FizzBuzz is a simple number game in which you count, but replace certain numbers with the words "Fizz" and/or "Buzz", adhering to certain rules.

1. Create a FizzBuzz() method that prints out the numbers 1 through 100, separated by newlines.
2. Instead of numbers divisible by 3, the method should output "Fizz".
3. Instead of numbers divisible by 5, the method should output "Buzz".
4. Instead of numbers divisible by 3 and 5, the method should output "FizzBuzz".

## Sample Output ##
    1
    2
    Fizz
    4
    Buzz
    Fizz
    7
    8
    Fizz
    Buzz
    11
    Fizz
    13
    14
    FizzBuzz
    16

## Extra Credit ##
- Instead of numbers with a three in them, print "Fizz".
- Instead of numbers with a five in them, print "Buzz".
- Instead of numbers with a three and a five in them, print "FizzBuzz".

Here are the steps I took before starting to work on this kata 

I created a new Github repository called FizzBuzz 
https://github.com/rickhodder/FizzBuzz
- No template
- Include Readme.md
- MIT License
- gitignore VisualStudio

I opened VS Code

I cloned the repository (ctrl+shift+p, then chose Clone Repository)

I opened the terminal in VS Code (ctrl+~)

And executed the following commands

```
dotnet new sln 

dotnet new xunit

dotnet sln add .\FizzBuzz.csproj

dotnet new class --name FizzBuzzer

rename unittest1.cs FizzBuzzTests.cs
```

Finally, open FizzBuzzTests.cs, and change the name of the 
class from "UnitTest1" to "FizzBuzzTests"