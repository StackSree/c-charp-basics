/\*
README: C# Iteration Statements Demo

---

This C# console application demonstrates different types of iteration statements including:

- for loop
- while loop
- do...while loop
- Usage of break and continue

🔁 What It Does:

✅ FOR LOOP:
A for loop is used to repeat a block of code a known number of times. It’s perfect when you know in advance how many times to run something — like printing numbers 1 to 5
Prints numbers from 1 to 5.

🔄 WHILE LOOP:
A while loop repeatedly executes a block of code as long as a specified condition is true. It checks the condition before running the loop body — so if the condition is false at the start, the loop won’t run at all.
Prints numbers from 1 to 5.

🔃 DO...WHILE LOOP:
A do...while loop is a type of loop that will always run the code block at least once, then check the condition to decide whether to repeat.
👉 It differs from a regular while loop because the condition is evaluated after the loop body runs.
Prints numbers from 1 to 5.

⚡ LOOP WITH BREAK & CONTINUE:
Prints only odd numbers below 9 by:

- Skipping even numbers with 'continue'
- Stopping the loop when 9 is reached with 'break'

⚙️ How the Loops Work:

for loop:
for (int i = 1; i <= 5; i++) { ... }

while loop:
int i = 1;
while (i <= 5) { ... }

do...while loop:
int i = 1;
do { ... } while (i <= 5);

continue: skips the current loop iteration.
break: exits the loop entirely.

🧪 Sample Output:

=== FOR LOOP ===
For loop: 1
For loop: 2
For loop: 3
For loop: 4
For loop: 5

=== WHILE LOOP ===
While loop: 1
While loop: 2
While loop: 3
While loop: 4
While loop: 5

=== DO...WHILE LOOP ===
Do...While loop: 1
Do...While loop: 2
Do...While loop: 3
Do...While loop: 4
Do...While loop: 5

=== LOOP WITH BREAK AND CONTINUE ===
Filtered loop: 1
Filtered loop: 3
Filtered loop: 5
Filtered loop: 7

All loops complete.
