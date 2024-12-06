def is_safe_report(levels):
    #Check whether the list is increasing or decreasing
    is_increasing = all(levels[i] < levels[i+1] for i in range(len(levels)-1))
    is_decreasing = all(levels[i] > levels[i+1] for i in range(len(levels)-1))

    #Check if the adjusten levels differ by 1 to 3
    check_difference = all(1 <= abs(levels[i] - levels[i+1]) <= 3 for i in range(len(levels) - 1))

    return (is_increasing or is_decreasing) and check_difference

def count_safe_reports(filename):

    def problemer_dampener(levels):
        #Check if removing 1 level will make the report safe
        for i in range(len(levels)):
            modified_levels = levels[:i] + levels[i + 1:]
            if is_safe_report(modified_levels):
                return True

        return False


    count = 0
    with open(filename, 'r') as file:
        for line in file:
            if line.strip():
                levels = [int(num) for num in line.split()]
                if is_safe_report(levels) or problemer_dampener(levels):
                    count += 1
    return count


filename = "input.txt"
safe_reports = count_safe_reports(filename)
print("Number of safe reports: ", safe_reports)

