import re

def find_mul(filename):

    with open(filename, 'r') as file:
        data = file.read()

    pattern = r"mul\((\d+)\s*,\s*(\d+)\)"
    matches = re.findall(pattern, data)

    #Calculate the sum of multiplications
    sum = 0
    for match in matches:
        a, b = int(match[0]), int(match[1])
        sum += a * b
    return sum

filename = "input.txt"
result = find_mul(filename)
print("The sum of all multiplications is: ", result)


