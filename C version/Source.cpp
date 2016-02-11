#include<stdio.h>
#include<conio.h>
#include<math.h>
#include<string.h>
#include<stdlib.h>
#include<stdarg.h>

double fun1();
double fun2();
double fun3();
double fun4();
double fun5();
char calc[64];
int n;

double fun1()
{
	double t;
	t = fun2(); //先看有无乘除，将乘除计算完后再计算加减
	while ((calc[n] == '+') || (calc[n] == '-'))
	{
		switch (calc[n]) //计算加减时，再看后面的数有无乘除，将乘除计算完后再计算加减
		{
		case '+':n++, t = t + fun2(); break;
		case '-':n++, t = t - fun2(); break;
		}
	}
	return(t);
}

double fun2()
{
	double t;
	t = fun3(); //先看有无乘方，将乘方计算完后再计算乘除
	while ((calc[n] == '*') || (calc[n] == '/'))
	{
		switch (calc[n]) //计算乘除时，再看后面的数有无乘方，将乘方计算完后再计算乘除
		{
		case '*':n++, t = t*fun3(); break;
		case '/':n++, t = t / fun3(); break;
		}
	}
	return(t);
}

double fun3()
{
	double t;
	t = fun4(); //先看有无括号，将括号里的计算完后再计算乘方
	while (calc[n] == '^')
	{
		n++, t = pow(t, fun4());  //计算乘方时，再看后面的数有无括号运算，将括号里的计算完后再计算乘方
	}
	return(t);
}

double fun4()  //如此，将fun4()的值返回时（有括号的先算括号里的，再将计算值返回，起到去括号的目的），逐级按乘方、乘、除、加、减的次序进行计算，满足优先法则
{
	char num[16];
	int i = 0;
	double t;
	if (calc[n] == '(')
	{
		n++, t = fun1(), n++; //遇括号时，先将括号里的值算出，再返回t给上一级
	}
	else if (fun5())
	{
		while (fun5()) //将与数字相关的符号赋予num[]
		{
			num[i++] = calc[n++];
		}
		num[i] = '\0';
		t = atof(num); //净num[]转换成数字
	}
	return(t); //返回t给上一级
}

double fun5()
{
	if (((calc[n] >= '0'&&calc[n] <= '9') || (calc[n] == '.')) || (n > 0 && (calc[n - 1] == '+' || calc[n - 1] == '-' || calc[n - 1] == '*' || calc[n - 1] == '/' || calc[n - 1] == '^' || calc[n - 1] == '(')))
		return(1); //是与数字相关的，如数字字符、小数点、正负号，返回1
	else
		return(0); //加、减、乘、除、乘方时，返回0
}

int main(void)
{
	int ds1, ds2;
loop:
	n = 0;
	printf("Input a calculation method like 1+2^(3-4)*5/10=↙\nPlease:");
	gets_s(calc); //输入表达式
	for (ds1 = 0; calc[ds1] != '\0'; ds1++) //去掉非运算符，如空格
		if (!((calc[ds1] >= '0'&&calc[ds1] <= '9') || (calc[ds1] == '+' || calc[ds1] == '-' || calc[ds1] == '*' || calc[ds1] == '/' || calc[ds1] == '^' || calc[ds1] == '.' || calc[ds1]
			== '(' || calc[ds1] == ')')))
		{
			ds2 = ds1;
			for (ds2 = ds2; calc[ds2] != 0; ds2++)
			{
				calc[ds2] = calc[ds2 + 1];
			}
			calc[ds2] = '\0';
			ds1--;
		}
	//printf("%d", sizeof(calc));
	printf("Result=%g\n", fun1()); //计算表达式的值并输出
	printf("Continue(y/n)?"); //计算下一算式的提示
	switch (_getch())
	{
	case 'y':{system("cls"); goto loop; } //清屏并重头开始
	case 'n':
	default:exit(0); //退出程序
	}
	_getch(); //停留以显示结果
	return(0);
}