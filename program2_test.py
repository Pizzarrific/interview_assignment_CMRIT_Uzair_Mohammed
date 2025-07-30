def program2(a):
 for i in range(len(a)):
  for j in range(len(a)-1):
   if a[j]==0 and a[j+1]!=0:
    a[j],a[j+1] = a[j+1],a[j]
a=[
 [0,1,0,3,12],
 [1,2,3,4],
 [0,0,0,0]]
for i in a:
 program2(i)
 print(i)
