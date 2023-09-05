#include<iostream>
using namespace std;
class employee
{
	public:
		int empno;
		string empname;
		employee()
		{
			empno=123;
			empname="ayushi";
		}
		void display()
		{
			cout<<"empno"<<"empname"<<endl;
			cout<<"empname"<<"empname";
		}
};
int main ()
{
	employee emp1;
	emp1.display();
	return 0;
	
}
