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
	printf("���Ѿ������һ��100���ڵ�������\n");
	printf("���ڿ�ʼ�°ɣ�\n");
	
	do{
		scanf("%d",&a);
		count ++;
		if (a < number){
			printf("С��Ŷ~\n");
		}else{
		if (a > number){
			printf("����Ŷ~\n");
			}
		}
	}while(number != a);
	
	if (count == 1){
		printf ("�ҿ�����ò����Ҷ�����Ļ׳�ɣ�\n");
	}else{
		if(count < 8){
			printf ("��ϲ��³����ˣ�\n");
		}else{printf ("����ɲ���ɣ���Ȼ������˲���ô�ã�\n");
		} 
	}
	
	
	return 0;
 } 
