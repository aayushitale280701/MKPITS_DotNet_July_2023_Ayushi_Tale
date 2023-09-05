#include<iostream>
using namespace std;
class account
{
	public:
		int act_no;
		int bal;
		void deposit(int amt)
		{
			cout<<"hello from account deposit"<<endl;
		}
};
class saving:public account
{
	public:
		void deposit(int amt)
		{
			int intrest=500;
			bal=bal+amt+intrest;
			cout<<"bal with int is"<<bal<<endl;
		}
};
class current:public account 
{
	public:
		void dopsite(int amt)
		{
			bal=bal+amt;
			cout<<"bal without int is"<<bal<<endl;
		}
};
int main()
{
	account *a;
	saving s;
	current c;
	a=&s;
	a->act_no=123;
	a->bal=2000;
	a->deposit(100);
	a=&c;
	a->act_no=223;
	a->bal=1000;
	a->deposit(500);
	return 0;	
}
