#include <stdio.h>
int fenleinum(double num,char danwei)
{
	if(danwei == 'T')
	{
		num = num * 1024 * 1024 * 1024;
	}
	else if(danwei == 'G')
	{
		num = num * 1024 * 1024;
	}
	else if(danwei == 'M')
	{
		num = num * 1024;
	}
	else if(danwei == 'K')
	{
		num = num;
	}
}
main()
{
	double num,speed;
	char danweinum,danweispeed;
	
	printf("���������ֺ͵�λ(�ÿո�ֿ��Ҳ���b/B)��");
	scanf("%d %d",&num,&danweinum);
	fenleinum(num,danweinum);
	printf("%f",num);
	return 0;
	 
 } 
