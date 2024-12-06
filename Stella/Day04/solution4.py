#Parse the file into a 2D list
def count_words(filename, word='XMAS'):
    with open(filename, 'r') as file:
        grid = [list(line.strip()) for line in file.readlines()]
    
    #Finds the words in all possible directions
    rows, cols = len(grid), len(grid[0])
    word_len = len(word)
    directions = [
        (0, 1),  #horizontal right
        (0, -1),  #horizontal left
        (1, 0),  #vertical down
        (-1, 0),  #vertical up
        (1, 1),  #diagonal down-right
        (1, -1),  #diagonal down-left
        (-1, 1),  #diagonal up-right
        (-1, -1)  #diagonal up-left
    ]

    def is_in_bounds(x, y):
        #Checks if (x, y) is within grid bounds
        return 0 <= x < rows and 0 <= y < cols

    def find_word(x, y, dx, dy):
        for i in range(word_len):
            nx, ny = x + i * dx, y + i * dy
            if not is_in_bounds(nx, ny) or grid[nx][ny] != word[i]:
                return False
        return True

    count = 0
    for r in range(rows):
        for c in range(cols):
            for dx, dy in directions:
                if find_word(r, c, dx, dy):
                    count += 1
    return count

filename = "input.txt"
result = count_words(filename)
print(f"XMAS appears {result} times")
