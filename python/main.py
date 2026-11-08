def calculator():
    a = float(input("First number: "))
    b = float(input("Second number: "))
    op = input("Operation (+, -, *, /): ").strip()
    if op == "+":
        result = a + b
    elif op == "-":
        result = a - b
    elif op == "*":
        result = a * b
    elif op == "/":
        if b == 0:
            print("Error: division by zero.")
            return
        result = a / b
    else:
        print("Unknown operation.")
        return
    print(f"Result: {result:g}")


def temperature_converter():
    direction = input("Convert from (C = Celsius -> Fahrenheit, F = Fahrenheit -> Celsius): ").strip().upper()
    value = float(input("Temperature: "))
    if direction == "C":
        print(f"{value:g}°C = {value * 1.8 + 32:g}°F")
    elif direction == "F":
        print(f"{value:g}°F = {(value - 32) / 1.8:g}°C")
    else:
        print("Unknown direction, choose C or F.")


def grade_average():
    count = int(input("How many grades? "))
    if count <= 0:
        print("Number of grades must be positive.")
        return
    total = 0
    for i in range(count):
        grade = int(input(f"Grade {i + 1} (1-6): "))
        while grade < 1 or grade > 6:
            grade = int(input("Grade must be 1-6, try again: "))
        total += grade
    average = total / count
    print(f"Average: {average:.2f}")
    print("Student passed." if average >= 3.0 else "Student failed.")


def main():
    while True:
        print("\n1 - Calculator\n2 - Temperature converter\n3 - Grade average\n0 - Exit")
        choice = input("Choose: ").strip()
        try:
            if choice == "1":
                calculator()
            elif choice == "2":
                temperature_converter()
            elif choice == "3":
                grade_average()
            elif choice == "0":
                break
            else:
                print("Unknown option.")
        except ValueError:
            print("Invalid number.")


if __name__ == "__main__":
    main()
