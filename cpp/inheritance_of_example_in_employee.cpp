#include<iostream>
using namespace std;
class employee
{
	public:
		string name;
		string city;
		string designatio;
};
class details: public employee
{
	public:
		int salary;
		int empno;
};
int main()
{
	details e1;
	e1.name="ayushi\n";
	e1.city="MZR\n";
	e1.designatio="HR\n";
	e1.salary=30000 ;
	e1.empno=123;
	cout<<e1.name<<e1.city<<e1.designatio<<e1.salary<<e1.empno<<endl;
	return 0;
}
