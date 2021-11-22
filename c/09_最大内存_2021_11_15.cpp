#include<stdio.h>
#include<stdlib.h> 

main()
{
	void *p;
	int cnt; 
	while( p = (int*)malloc(1024*1024*10) )
	{
		cnt++;
	}
	printf("%d",cnt);
	
	return 0;
}
