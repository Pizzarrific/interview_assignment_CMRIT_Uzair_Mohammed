def program2(a):
 for i in range(len(a)):
  for j in range(len(a)-1):
   if a[j]==0 and a[j+1]!=0:
    a[j],a[j+1] = a[j+1],a[j]


