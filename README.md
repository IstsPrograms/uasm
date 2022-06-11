mw (hexadecimal number 1) (hexadecimal number 2) - create new variable with address hexadicimal number 1 and with value - hexadicimal number 2.
mr (hexadicimal number 1) (number 1-4) - read a variable with address hexadicimal number 1, as:

1 - output as a number, without moving to the next line.
2 - output as a number, with moving to the next line.
3 - output as a character, without moving to the next line.
4 - output as a character, with moving to the next line.

ADD (hexadecimal number 1) (hexadicimal number 2) - adds a hexadicimal number 2 to variable with address hexadicimal number 1.
SUB (hexadecimal number 1) (hexadicimal number 2) - subtracts from the variable with the address of hex number 1 the hex number 2ю
DIV (hexadecimal number 1) (hexadicimal number 2) - divides the variable with the address of hexadecimal number 1 by hexadecimal number 2.
MUL (hexadecimal number 1) (hexadicimal number 2) - multiplies the variable with the address of hexadecimal number 1 by hexadecimal number 2.
IN (hexadecimal number 1) - input of a hexadecimal number by the user into a variable with the address of hexadecimal number 1.
MOV (hexadecimal number 1) (hexadicimal number 2) - copies the value to the variable with the address of hex 1 from the variable with the address of hex 2.

sbw (hexadicimal number 1) (hexadicimal numbers) - creates a sequence of "bytes" with the address of the hexadecimal number 1. Example of creation:
sbw FF2 FF3,FF3,FF3.
You can also use previously declared variables. This can be done like this:
mw FF3 FF3
mw FF5 FF4
sbw FF4 QFF3,QFF5.

sbr (hexadicimal number 1) (number 1-4) - reads information from a previously declared sequence of "bytes" under the address of the hexadecimal number 1 in the mode indicated by the numbers from 1 to 4. I have already said how these numbers are used.


To run the code, you need to rename the file with the code to main.uasm so that the interpreter can run your code.
