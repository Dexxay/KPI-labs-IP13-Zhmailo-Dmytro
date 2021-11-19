last_n = 100
for i in range(1, last_n + 1):
    number = i
    palindrome = ((number//10) == number % 10 ) or (number < 10)
    if (palindrome):
        sqrd_number = number ** 2
        reversed_number = 0
        result = number
        while (sqrd_number > 0):
            current = sqrd_number % 10
            reversed_number = (reversed_number * 10) + current
            sqrd_number = sqrd_number // 10
        sqrd_number = number ** 2
        palindrome = sqrd_number == reversed_number
        if (palindrome):
            print(number, end = ' ')






