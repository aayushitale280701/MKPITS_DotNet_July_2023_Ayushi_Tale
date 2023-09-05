#include<iostream>
using namespace std;
class employee
{
	public:
		int empno;
		string empname;
		employee(int eno,string en)
		{
			empno=eno;
			empname=en;
			
		}
		int display()
		{
			cout<<"empno"<<"empno"<<endl;
			cout<<"empname"<<"empname"<<endl;
			
		}
};
int main()
{
	int eno;
	string en;
	employee emp1(16,"Ayushi");
	emp1.display();
	return 0;
}
