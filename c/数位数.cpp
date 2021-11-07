#include<stdio.h>
main()
{
	int n = 0;
	int x = 0; 
	
	printf("请输入想要数位数的数；"); 
	scanf("%d",&x);
	
	while(x>0){
		x/=10;
		n++;
	}
	
	printf("位数为：%d",n); 
	
	return 0;
 } 
