#include<stdio.h>

main()
{
	//初始化
	int price,bill;
	
	//输入金额面值
	printf("请输入金额：");
	scanf("%d",&price);
	printf("请输入面值：");
	scanf("%d",&bill);
	//判断是否足够
	if(price>=bill)
	{
		printf("您的金额不足以支付。"); 	
	}
	else
	{
	// 输出找零
	printf("找您%d元。",bill-price); }
	
	
	return 0;
}
