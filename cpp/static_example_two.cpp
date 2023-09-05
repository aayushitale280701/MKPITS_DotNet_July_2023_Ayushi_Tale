#include<iostream>
using namespace std;
class employee
{
	public:
		int empno;
		string  empname;
	static string companyname;
		employee(int empno, string empname)
		{
			this->empno=empno;
			this->empname=empname;
		}
		void display()
		{
			cout<<"empno: "<<empno<<endl;
			cout<<"empname: "<<empname<<endl;
			cout<<"companyname: "<<companyname<<endl;
		}
};
string employee::companyname="MKPTIT";
int main()
{
	employee e1=employee(123,"ayushi");
	employee e2=employee(235,"om");
	employee e3=employee(145,"avinash");
	e1.display();
	e2.display();
	e3.display();
	return 0;
}
