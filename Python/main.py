nums = [1,2,4,3,5,6,7,8]   
target = 9                  
for i in range(len(nums)):  
    for j in range(i+1, len(nums)):
        if nums[i] + nums[j] == target: 
            print(i, j)    #Here we print the indices of the two numbers that add up to the target value.