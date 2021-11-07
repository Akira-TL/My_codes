# include<stdio.h>

int main()
{
	const int NUMBER = 5;
	int price;
	
	printf("接下来请输入数量和价格。\n数量：");
	scanf("%d",&NUMBER);
	printf("价格：");
	scanf("%d",&price);
	
	printf("总价：%d",NUMBER*price);
	
	return 0;
}
