import re

def find_mul(filename):

    with open(filename, 'r') as file:
        data = file.read()

    #Regex to match instructions
    pattern = r"(mul\((\d+),(\d+)\)|don't\(\)|do\(\))"
    matches = re.findall(pattern, data)

    sum = 0
    enabled = True

    for match in matches:
        instruction, a ,b = match
        if instruction == "don't()":
            enabled = False  # disable multiplications
        elif instruction == "do()":
            enabled = True  # enable multipl
        elif instruction.startswith("mul") and enabled:
            sum += int(a) * int(b)
    return sum

filename = "input.txt"
result = find_mul(filename)
print("The sum of enabled multiplications is: ", result)


