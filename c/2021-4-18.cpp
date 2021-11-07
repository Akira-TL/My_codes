#include<stdio.h>
main()
{
    int num1,num2;
    int cal1,cal2,cal3,c;
    int n=100000,x;
    double cal4,z,num1n,num2n;
    
    scanf("%d %d",&num1,&num2);
    num1n=num1;
    num2n=num2;
    cal1 = num1+num2;
    cal2 = num1-num2;
    cal3 = num1*num2;
    cal4 = num1n/num2n;
    
    printf("%d + %d = %d\n",num1,num2,cal1);
    printf("%d - %d = %d\n",num1,num2,cal2);
    printf("%d * %d = %d\n",num1,num2,cal3);
    
    printf("≤‚ ‘%f\n",cal4);
    x=cal4;
    printf("≤‚ ‘%d\n",x);
    z=x;
    printf("≤‚ ‘%f\n",z);
    z=cal4-z;
    printf("≤‚ ‘%f\n",z);
    
    if(z!=0){
    	printf("%d / %d = %0.2f\n",num1,num2,cal4);
    	z=0;
	}else{
		x=cal4;
		printf("%d / %d = %d\n",num1,num2,x);
	}
    
    return 0;
}
