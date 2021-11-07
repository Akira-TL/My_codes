#include<stdio.h>
#include<stdlib.h>
#include<time.h>
main()
{
	srand(time(0));
	int number;
	int count = 0;
	int a; 
	
	number = rand() %  100 + 1;
	//printf("%d",number);
	printf("我已经想好了一个100以内的整数。\n");
	printf("现在开始猜吧！\n");
	
	do{
		scanf("%d",&a);
		count ++;
		if (a < number){
			printf("小了哦~\n");
		}else{
		if (a > number){
			printf("大了哦~\n");
			}
		}
	}while(number != a);
	
	if (count == 1){
		printf ("我靠，你该不是我肚子里的蛔虫吧？\n");
	}else{
		if(count < 8){
			printf ("恭喜你猜出来了！\n");
		}else{printf ("不会吧不会吧，居然真的有人猜这么久？\n");
		} 
	}
	
	
	return 0;
 } 
