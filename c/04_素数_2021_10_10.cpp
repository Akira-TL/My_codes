#include <stdio.h>

int main ()
{
	int x;
	printf("请输入欲求素数的值：");
	//printf("请输入查看是否为素数的数:");
	scanf("%d",&x);
	
	int i,b;
	int a = 1;
	for (a = 1,b = 1;a <= x;a++,b = 1){
		for (i = 2;i < a;i++){
			if(a%i == 0){
				//printf("%d",b);
				b = 0;
				break;
			}
		}
		if (b == 0){
			//printf("%d不是素数。\n",a);
		} else{
			printf("%d\n",a);
		} 
	}
	//if (a == 1){
	//	printf("%d是素数。\n",x); 
	//}else{
	//	printf("%d不是素数。\n",x);
	//}
	
	return 0;
 } 
