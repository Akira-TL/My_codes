#include <stdio.h>

int main ()
{
	int x;
	printf("����������������ֵ��");
	//printf("������鿴�Ƿ�Ϊ��������:");
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
			//printf("%d����������\n",a);
		} else{
			printf("%d\n",a);
		} 
	}
	//if (a == 1){
	//	printf("%d��������\n",x); 
	//}else{
	//	printf("%d����������\n",x);
	//}
	
	return 0;
 } 
