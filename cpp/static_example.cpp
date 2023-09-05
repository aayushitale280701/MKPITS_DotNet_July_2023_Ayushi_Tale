#include <iostream>
using namespace std;
class account
{
	public:
		int act_no;
		int bal;
		static float roi;
		account (int act_no, int bal)
		{
			this->act_no=act_no;
			this->bal=bal;
		}
		void display()
		{
			cout<<"act_no"<<act_no<<endl;
			cout<<"bal"<<bal<<endl;
			cout<<"rat_of_Int"<<roi<<endl;
		}
};
float account::roi=9.5f;
int main ()
{
	account a1=account(123,2000);
	account a2=account(212,3000);
	a1.display();
	a2.display();
	return 0;
}
