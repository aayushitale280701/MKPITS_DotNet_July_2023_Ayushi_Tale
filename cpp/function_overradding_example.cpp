#include <iostream>
using namespace std;
class account
{
	public:
		int act_no;
		int bal;
		void deposit (int  amt)
		{
			cout<<"hello from account deposite"<<endl;
		}
};
class saving:public account
{
	public:
		void deposit(int amt)
		{
			int interest=500;
			bal=bal+amt+interest;
	        cout<<"bal with intrest is"<<bal<<endl;
		}
};
class current:public account
{
	public:
		void deposit(int amt)
		{
			bal=bal+amt;
			cout<<"bal without intrest"<<bal<<endl;
		}
};
int main()
{
	saving s;
	s.act_no=123;
	s.bal=2000;
	s.deposit(100);
	current c;
	c.act_no=333;
	c.bal=1000;
	c.deposit(500);
	return 0;
}
