Greatest-Common-Divisor
Program is designed to find the greatest common divisor of two numbers by several slightly different ways:

By division or by finding mod of two numbers.
By recursion.
By substraction.
By recursion and ternary operator.
Given two non-negative integers a and b, we have to find their GCD (greatest common divisor), i.e. the largest number which is a divisor of both a and b. It's commonly denoted by gcd(a,b). When one of the numbers is zero, while the other is non-zero, their greatest common divisor, by definition, is the second number. When both numbers are zero, their greatest common divisor is undefined (it can be any arbitrarily large number), but we can define it to be zero. Which gives us a simple rule: if one of the numbers is zero, the greatest common divisor is the other number.

The Euclidean algorithm allows to find the greatest common divisor of two numbers a and b in O(logmin(a,b)).

The algorithm was first described in Euclid's "Elements" (circa 300 BC), but it is possible that the algorithm has even earlier origins.
