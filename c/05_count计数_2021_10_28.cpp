#include <stdio.h>

int main(void)
{
	int x,i;
	int count[10]; 
	for (i = 0;i < 10;i ++) 
	{
		count[i] = 0;
	}//初始化count 
	scanf("%d",&x) ;
	while( x != -1 )
	{
		if( x > 0 & x <10)
		{
			count[x] ++;
		}
		scanf("%d",&x);
	}
	for (x = 0;x <10;x ++)
	{
		printf("%d出现了%d次\n",x,count[x]);
	}
	return 0;
}
