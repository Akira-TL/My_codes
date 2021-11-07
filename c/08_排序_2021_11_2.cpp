#include <stdio.h>

int maxnum(int a[],int len)
{
	int maxid = 0;
	for (int i = 1;i <len;i++)
	{
		if (a[maxid] < a[i])
		{
			maxid = i;
		}
		
	}
	return maxid;
}

main()
{
	int b; 
	int a[] = {5,74,3,9,79,4,56,36,8,86,23,54,23};
	b = maxnum(a,(sizeof(a)-sizeof(a[0]))/4);
	printf("%d",b);
	return 0;
} 
