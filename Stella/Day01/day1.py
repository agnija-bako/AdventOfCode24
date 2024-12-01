from collections import Counter

left = []
right = []

with open("input.txt") as f:
    for line in f.readlines():
        x, y = (int(i) for i in line.split())
        left.append(x)
        right.append(y)

left.sort()
right.sort()

distance = sum(abs(l - r) for l, r in zip(left, right))
counts = Counter(right)
similarity_score = sum(num * counts[num] for num in left)

print(similarity_score)
