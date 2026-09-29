prices = [7, 1, 5, 3, 6, 4]

buy = prices[0]
profit = 0

for p in prices[1:]:
    if buy > p:
        buy = p
    elif profit < p - buy:
        profit = p - buy

print(profit)