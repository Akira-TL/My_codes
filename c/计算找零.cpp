#include<stdio.h>

main()
{
	//��ʼ��
	int price,bill;
	
	//��������ֵ
	printf("�������");
	scanf("%d",&price);
	printf("��������ֵ��");
	scanf("%d",&bill);
	//�ж��Ƿ��㹻
	if(price>=bill)
	{
		printf("���Ľ�����֧����"); 	
	}
	else
	{
	// �������
	printf("����%dԪ��",bill-price); }
	
	
	return 0;
}
