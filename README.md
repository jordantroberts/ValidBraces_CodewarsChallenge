# Valid Braces (Codewars Kata)

I attempted <a href="https://www.codewars.com/kata/valid-braces">this Codewars kata</a> to practice learning C#. 

## How to use this program 

1. Clone this repo
2. `cd` into the directory that you cloned the repo into 
3. Open in Visual Studio 
4. Build the program, which should open the terminal. 
5. The terminal will prompt you to enter a string of brackets. Brackets you can enter are `[`, `{` or `(` 
6. If you type in brackets that are in a valid order, i.e. they all match, such as `{[()]}` and hit the enter key, the program will return `true`. If the brackets are in an invalid order i.e. they do not  match, such as `{[[]]{(}}` then the program will return `false`

## How to test this program 

1. Follow steps 1 - 3 above 
2. In Visual Studio, click 'Run Unit Tests' 

## Specification 

The Codewars Specification for this challenge can be found <a href="https://www.codewars.com/kata/valid-braces">HERE/a> 

Example acceptance criteria: 

```
"(){}[]"   =>  True
"([{}])"   =>  True
"(}"       =>  False
"[(])"     =>  False
"[({})](]" =>  False
```

## My approach 

1. Break the string down into characters 
2. Iterate over each character 
3. If the character is an opening brace, push this into a fresh array (I ended up using a Stack in C#, which I had not come across before but seemed easier to use .Pop() and .Peek() methods). The purpose of the fresh Stack was to keep track of which braces had been matched. 
4. If the character is a closing brace, check whether the most recent pushed brace has been a matching opening brace. If so, delete the opening brace from the Stack and move on. 
5. At the end of the loop, check the Stack. If they all got matched, it will be empty. In which case return `true`. If not, return `false`, as there was a brace there that wasn't matched. 


