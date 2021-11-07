#include <stdio.h>

main()
{
	const int maxnumber = 1000;
	int isprime[maxnumber];
	int i,x,n,b = 1,cnt;
	for (i = 0 ;i < maxnumber;i++)
	{
		isprime[i] = 1;
	}
	for(n=1;n < maxnumber;n++)
	{
		if (isprime[n] == 1)
		{
			b = 2;
			for (x = (n+1)*b;x < maxnumber;b++)
			{
				x = (n+1)*b;
				isprime[x] = 0;
			}
		}
	}
	for (cnt = 0;cnt < maxnumber;cnt++)
	{
		if (isprime[cnt])
		{
			printf("%d\n",cnt);
		}
	}
	return 0;
 } 
