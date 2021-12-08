# Рекурентна формула Ньютона для знаходження кореня k-ого степеня
# дійсного числа a (a>0) з точністю n, представлена у вигляді функції
def newton_formula(k, x, n): 
    curr_x = x
    for i in range(n):
        curr_x = (1 / k) * ((x / (curr_x ** (k - 1))) + curr_x * (k - 1))
    return curr_x

a = float(input('Input a(a > 0):  '))
while a <= 0:
    a = float(input('Wrong a. Input correct a(a > 0): '))

number = int(input('Input n(n > 0):  '))
while number <= 0:
    number = int(input('Wrong n. Input correct n(n > 0): '))

numerator = (newton_formula(3, a, number) - (newton_formula(6, ((a ** 2) + 1), number)))
denominator = (1 + (newton_formula(7, (3 + a), number)))
result = numerator/denominator
print('Result = ', result)

