# Маємо графік рівняння, що складається з кола, заданого рівнянням (x-1)^2 + y^2 = 4
# обмеженого на проміжку по осі абсцис так, що -1 ≤ x ≤ 1 і прямих y1 = x-3, y2 = -x+3,
# обмежених на проміжку по осі абсцис так, що 1 ≤ x ≤ 3.
# Необхідно визначити чи належить точка з координатами (x, y) області, обмеженою двома відрізками і півколом.
x = float(input("Введіть значення X: "))
y = float(input("Введіть значення Y: "))
if (-1 <= x <= 3):
    if (-1 <= x <= 1):
        if ((x-1)**2 + y**2 <= 4):
            print("Точка знаходиться в зафарбованiй областi")
        else:
            print("Точка не знаходиться в зафарбованiй областi")
    else:
        if (x-3 <= x <= -x+3):
            print("Точка знаходиться в зафарбованiй областi")
        else:
            print("Точка не знаходиться в зафарбованiй областi")
else:
    print("Точка не знаходиться в зафарбованiй областi")
input()






