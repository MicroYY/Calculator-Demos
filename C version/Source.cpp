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
	t = fun2(); //�ȿ����޳˳������˳���������ټ���Ӽ�
	while ((calc[n] == '+') || (calc[n] == '-'))
	{
		switch (calc[n]) //����Ӽ�ʱ���ٿ�����������޳˳������˳���������ټ���Ӽ�
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
	t = fun3(); //�ȿ����޳˷������˷���������ټ���˳�
	while ((calc[n] == '*') || (calc[n] == '/'))
	{
		switch (calc[n]) //����˳�ʱ���ٿ�����������޳˷������˷���������ټ���˳�
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
	t = fun4(); //�ȿ��������ţ���������ļ�������ټ���˷�
	while (calc[n] == '^')
	{
		n++, t = pow(t, fun4());  //����˷�ʱ���ٿ�������������������㣬��������ļ�������ټ���˷�
	}
	return(t);
}

double fun4()  //��ˣ���fun4()��ֵ����ʱ�������ŵ�����������ģ��ٽ�����ֵ���أ���ȥ���ŵ�Ŀ�ģ����𼶰��˷����ˡ������ӡ����Ĵ�����м��㣬�������ȷ���
{
	char num[16];
	int i = 0;
	double t;
	if (calc[n] == '(')
	{
		n++, t = fun1(), n++; //������ʱ���Ƚ��������ֵ������ٷ���t����һ��
	}
	else if (fun5())
	{
		while (fun5()) //����������صķ��Ÿ���num[]
		{
			num[i++] = calc[n++];
		}
		num[i] = '\0';
		t = atof(num); //��num[]ת��������
	}
	return(t); //����t����һ��
}

double fun5()
{
	if (((calc[n] >= '0'&&calc[n] <= '9') || (calc[n] == '.')) || (n > 0 && (calc[n - 1] == '+' || calc[n - 1] == '-' || calc[n - 1] == '*' || calc[n - 1] == '/' || calc[n - 1] == '^' || calc[n - 1] == '(')))
		return(1); //����������صģ��������ַ���С���㡢�����ţ�����1
	else
		return(0); //�ӡ������ˡ������˷�ʱ������0
}

int main(void)
{
	int ds1, ds2;
loop:
	n = 0;
	printf("Input a calculation method like 1+2^(3-4)*5/10=�L\nPlease:");
	gets_s(calc); //������ʽ
	for (ds1 = 0; calc[ds1] != '\0'; ds1++) //ȥ�������������ո�
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
	printf("Result=%g\n", fun1()); //������ʽ��ֵ�����
	printf("Continue(y/n)?"); //������һ��ʽ����ʾ
	switch (_getch())
	{
	case 'y':{system("cls"); goto loop; } //��������ͷ��ʼ
	case 'n':
	default:exit(0); //�˳�����
	}
	_getch(); //ͣ������ʾ���
	return(0);
}