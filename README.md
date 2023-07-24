# C#-conslole-calculator
Using the fundermental building blocks of C# to create a console based scientific calculator

PROJECT OVERALL LAYOUT

1. SECTION 1: 
    - Welcome message
    - Categories Section
    - Help Section

2. SECTION 2:
    - Sub category section
    - Help Section

3. SECTION 3:
    - User value input section
    - Error handling (syntax errors, logical errors & no input entered error)

4. SECTION 4:
    - Answer section
    - Your comment section
    - Exit or Continue option section
    - Thank you message section



ALGORITHM

1. Initialize the calculator:

    Create a data structure to store the calculator's state, including the current input, result, and other necessary variables.

2. Input processing:

    Continuously accept user input, which can be either from buttons or command-line interface.
    Validate the input to ensure it's a valid number or operation.
    Handle special commands (e.g., "clear," "delete," "equals").

3. Arithmetic operations:

    Implement functions for basic arithmetic operations: addition, subtraction, multiplication, and division.
    Keep track of the current result and update it with each operation.

4. Trigonometric operations:

    Implement functions for trigonometric operations like sine, cosine, tangent, arcsine, arccosine, and arctangent.
    Ensure input and output are in degrees or radians based on the calculator's settings.

5. Logarithmic operations:

    Implement functions for logarithmic operations like logarithm (base 10 and natural logarithm) and exponentiation.

6. Parentheses handling:

    Implement a method to handle parentheses in expressions, allowing users to perform complex calculations.
    Scientific constants (optional):

    Provide support for common scientific constants like π (pi) and e (Euler's number).

7. Display results:

    Update the calculator's display with the current result after each calculation.
    Ensure the display format is user-friendly and supports scientific notation for large or small numbers.

8. Error handling:

    Implement robust error handling to deal with various edge cases, such as division by zero or invalid input.
    Testing:
    Conduct thorough testing to verify the correctness of calculations and user interface.