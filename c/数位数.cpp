#include<stdio.h>
main()
{
	int n = 0;
	int x = 0; 
	
	printf("��������Ҫ��λ��������"); 
	scanf("%d",&x);
	
	while(x>0){
		x/=10;
		n++;
	}
	
	printf("λ��Ϊ��%d",n); 
	
	return 0;
 } 
