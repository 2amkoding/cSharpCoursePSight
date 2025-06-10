# Adding Decision and Iteration Statements in C #

- Working w Bool values
- Making decision with if Statements
- Using the switch statement
- Adding iterations

## Boolean values

- T or F
- bool type
- Boolean operators

### Relational Operators

==
!=
<>
etc

### Boolean Logical Operators

&&
||

## if Statements

- just use {} even if single Statements

## Switch Statements

switch(expression) {
case constant expression 1:
// other statements
break;

case constant expression 2:
// other statements
break;

default:
do this
break;

}

- !works with float and double
- each case must be unique
- first "true" will get executed (top to bottom)
- Default gets evaluated last, regardless of line placement

> [!QUESTION]
> Case labels use a pattern: constant or relational.

> [!EXAMPLE]
>
> ```c#
>   Console.WriteLine("Set Pomodoro Timer");
>   int selectedTimer = int.Parse(Console.ReadLine());
> ```

```

```
